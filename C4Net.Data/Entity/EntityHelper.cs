using System;
using System.Collections.Generic;
using System.Text;
using C4Net.Core.Accessor;
using C4Net.Data.Attributes;
using C4Net.Data.Definitions;

namespace C4Net.Data.Entity
{
    /// <summary>
    /// Entity Helper Class.
    /// </summary>
    public class EntityHelper : IEntityHelper
    {
        #region - Fields -

        /// <summary>
        /// The depth.
        /// </summary>
        private int depth = 0;

        /// <summary>
        /// The interface type
        /// </summary>
        private Type interfaceType = null;

        /// <summary>
        /// The class type
        /// </summary>
        private Type classType = null;

        /// <summary>
        /// The definition
        /// </summary>
        private TableDefinition definition = null;

        /// <summary>
        /// The object proxy
        /// </summary>
        private IObjectProxy objectProxy = null;

        #endregion

        #region - Properties -

        /// <summary>
        /// Gets or sets the depth.
        /// </summary>
        /// <value>
        /// The depth.
        /// </value>
        public int Depth
        {
            get { return this.depth; }
            set { this.depth = value; }
        }

        /// <summary>
        /// Gets the definition.
        /// </summary>
        /// <value>
        /// The definition.
        /// </value>
        public TableDefinition Definition
        {
            get
            {
                if (this.definition == null)
                {
                    this.definition = DefinitionManager.GetDefinition(classType);
                }
                return this.definition;
            }
        }

        /// <summary>
        /// Gets the object proxy.
        /// </summary>
        /// <value>
        /// The object proxy.
        /// </value>
        public IObjectProxy ObjectProxy
        {
            get
            {
                if (this.objectProxy == null)
                {
                    this.objectProxy = ObjectProxyFactory.GetByType(classType);
                }
                return this.objectProxy;
            }
        }

        /// <summary>
        /// Gets the get primary key properties.
        /// </summary>
        /// <value>
        /// The get primary key properties.
        /// </value>
        public List<string> GetPrimaryKeyProperties
        {
            get
            {
                return this.Definition.PrimaryKeys;
            }
        }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityHelper"/> class.
        /// </summary>
        /// <param name="interfaceType">Type of the interface.</param>
        /// <param name="classType">Type of the class.</param>
        public EntityHelper(Type interfaceType, Type classType) 
        {
            this.interfaceType = interfaceType;
            this.classType = classType;
            EntDepthAttribute[] attributes = (EntDepthAttribute[])this.interfaceType.GetCustomAttributes(typeof(EntDepthAttribute), false);
            if ((attributes != null) && (attributes.Length > 0))
            {
                this.depth = attributes[0].Value;
            }
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Gets the primary key values.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        public object[] GetPrimaryKeyValues(object instance)
        {
            List<string> pkFields = this.GetPrimaryKeyProperties;
            object[] result = new object[pkFields.Count];
            for (int i = 0; i < pkFields.Count; i++)
            {
                result[i] = this.ObjectProxy.GetValue(instance, pkFields[i]);
            }
            return result;
        }

        /// <summary>
        /// Gets the primary key STR.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        public string GetPrimaryKeyStr(object instance)
        {
            object[] primaryKey = this.GetPrimaryKeyValues(instance);
            StringBuilder builder = new StringBuilder();
            foreach (object item in primaryKey)
            {
                builder.Append(item.ToString());
                builder.Append("|");
            }
            return builder.ToString();
        }

        #endregion
    }
}
