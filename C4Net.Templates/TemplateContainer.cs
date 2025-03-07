using System;
using System.Collections.Generic;
using C4Net.Core.Utils;

namespace C4Net.Templates
{
    /// <summary>
    /// Class for a tree structure containing variables for the template, and iterators.
    /// One container contains attributes (values), sons (instances of other objects) and array values (indicates
    /// that the container is an array and can be iterated).
    /// </summary>
    public class TemplateContainer
    {
        #region - Properties -

        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <value>
        /// The parent.
        /// </value>
        public TemplateContainer Parent { get; private set; }

        /// <summary>
        /// Gets the attributes.
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        public Dictionary<String, object> Attributes { get; private set; }

        /// <summary>
        /// Gets the sons.
        /// </summary>
        /// <value>
        /// The sons.
        /// </value>
        public Dictionary<string, TemplateContainer> Sons { get; private set; }

        /// <summary>
        /// Gets the array values.
        /// </summary>
        /// <value>
        /// The array values.
        /// </value>
        public List<TemplateContainer> ArrayValues { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance is an array.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is an array; otherwise, <c>false</c>.
        /// </value>
        public bool IsArray
        {
            get { return this.ArrayValues.Count > 0; }
        }

        /// <summary>
        /// Gets the root.
        /// </summary>
        /// <value>
        /// The root.
        /// </value>
        public TemplateContainer Root
        {
            get
            {
                TemplateContainer container = this;
                while (container.Parent != null)
                {
                    container = container.Parent;
                }
                return container;
            }
        }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateContainer"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public TemplateContainer(TemplateContainer parent)
        {
            this.Parent = parent;
            this.Attributes = new Dictionary<String, object>();
            this.Sons = new Dictionary<string, TemplateContainer>();
            this.ArrayValues = new List<TemplateContainer>();
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Adds one attribute.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public void AddAttribute(string name, string value) 
        {
            if (this.Attributes.ContainsKey(name))
            {
                this.Attributes[name] = value;
            }
            else
            {
                this.Attributes.Add(name, value);
            }
        }

        /// <summary>
        /// Removes one attribute.
        /// </summary>
        /// <param name="name">The name.</param>
        public void RemoveAttribute(string name)
        {
            this.Attributes.Remove(name);
        }

        /// <summary>
        /// Gets the value of one attribute.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public object GetAttribute(string name)
        {
            if (this.Attributes.ContainsKey(name))
            {
                return this.Attributes[name];
            }
            return string.Empty;
        }

        /// <summary>
        /// Adds a new son and returns its instance. If the son already exists, then returns the instance.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public TemplateContainer AddSon(string name)
        {
            if (this.Sons.ContainsKey(name))
            {
                return this.Sons[name];
            }
            TemplateContainer result = new TemplateContainer(this);
            this.Sons.Add(name, result);
            return result;
        }

        /// <summary>
        /// Removes one son.
        /// </summary>
        /// <param name="name">The name.</param>
        public void RemoveSon(string name)
        {
            this.Sons.Remove(name);
        }

        /// <summary>
        /// Adds one array value.
        /// </summary>
        /// <returns></returns>
        public TemplateContainer AddArrayValue()
        {
            TemplateContainer result = new TemplateContainer(this);
            this.ArrayValues.Add(result);
            return result;
        }

        /// <summary>
        /// Returns one object from the container, by its path. The object can be a value, another container or
        /// null if not found.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public Object GetByPath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return this;
            }
            if (path.StartsWith("/"))
            {
                return this.Root.GetByPath(path.Remove(0, 1));
            }
            if (path.StartsWith("../"))
            {
                if (this.Parent == null)
                {
                    return null;
                }
                else
                {
                    return this.Parent.GetByPath(path.Remove(0, 3));
                }
            }
            string[] paths = path.Split('.');
            string actualPath = paths[0];
            string arrayPos = StringUtil.PopBetween(ref actualPath, "[", "]");
            if (this.Attributes.ContainsKey(actualPath))
            {
                return this.Attributes[actualPath];
            }
            if (this.Sons.ContainsKey(actualPath))
            {
                TemplateContainer son = this.Sons[actualPath];
                if (string.IsNullOrEmpty(arrayPos))
                {
                    if (paths.Length == 1)
                    {
                        return son;
                    }
                    else
                    {
                        return son.GetByPath(path.Remove(0,actualPath.Length+1));
                        
                    }
                }
                else
                {
                    return son.ArrayValues[int.Parse(arrayPos)];
                }
            }
            else
            {
                switch (actualPath)
                {
                    case "NewGUID": return Guid.NewGuid().ToString();
                    case "Year": return DateTime.Now.Year.ToString();
                }
            }
            if (this.Parent != null)
            {
                return this.Root.GetByPath(path);
            }
            return null;
        }

        public void Clear()
        {
            this.Attributes.Clear();
            this.ArrayValues.Clear();
            this.Sons.Clear();
        }

        #endregion
    }
}
