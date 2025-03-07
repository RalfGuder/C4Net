using System;
using System.Collections.Generic;
using System.Reflection;

namespace C4Net.Core.Accessor
{
    /// <summary>
    /// Class for an ObjectProxy that can handle aliases for property names.
    /// </summary>
    public class ObjectProxyAlias : ObjectProxy, IObjectProxyAlias
    {
        #region - Fields -

        /// <summary>
        /// The aliases dictionary that relates aliases to target property names.
        /// </summary>
        private Dictionary<string, string> aliases = new Dictionary<string, string>();

        /// <summary>
        /// Dictionary to access the PropertyInfo of the type by the alias of the property.
        /// </summary>
        private Dictionary<string, PropertyInfo> propByAlias = new Dictionary<string, PropertyInfo>();

        #endregion

        #region - Properties -

        /// <summary>
        /// Gets the aliases dictionary that relates aliases with property names.
        /// </summary>
        /// <value>
        /// The aliases.
        /// </value>
        public Dictionary<string, string> Aliases
        {
            get { return this.aliases; }
        }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectProxyAlias"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="collectionType">Type of the collection.</param>
        public ObjectProxyAlias(Type type, Type objectType, Type collectionType)
            : base(type, objectType, collectionType)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectProxyAlias"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="objectType">Type of the object.</param>
        public ObjectProxyAlias(Type type, Type objectType)
            : base(type, objectType)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectProxyAlias"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        public ObjectProxyAlias(Type type)
            : base(type)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectProxyAlias"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public ObjectProxyAlias(object instance)
            : base(instance)
        {
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Adds an alias.
        /// </summary>
        /// <param name="alias">The alias.</param>
        /// <param name="propName">Name of the property.</param>
        public void AddAlias(string alias, string propName)
        {
            if (!aliases.ContainsKey(alias))
            {
                if (propInfo.ContainsKey(propName))
                {
                    aliases.Add(alias, propName);
                    propByAlias.Add(alias, propInfo[propName]);
                }
            }
        }

        /// <summary>
        /// Removes an alias.
        /// </summary>
        /// <param name="alias">The alias.</param>
        public void RemoveAlias(string alias)
        {
            if (aliases.ContainsKey(alias))
            {
                aliases.Remove(alias);
                propByAlias.Remove(alias);
            }
        }

        /// <summary>
        /// Gets the name of the property associated to the alias.
        /// </summary>
        /// <param name="alias">The alias.</param>
        /// <returns></returns>
        public string GetAliasPropertyName(string alias)
        {
            if (aliases.ContainsKey(alias))
            {
                return aliases[alias];
            }
            return string.Empty;
        }

        /// <summary>
        /// Gets the value of the property associated to the alias in the instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="alias">The alias.</param>
        /// <returns></returns>
        public object GetValueAlias(object instance, string alias)
        {
            if (propByAlias.ContainsKey(alias))
            {
                return propByAlias[alias].GetValue(instance);
            }
            return propInfo[alias].GetValue(instance);
        }

        /// <summary>
        /// Sets the value of the property associated to the alias in the instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="alias">The alias.</param>
        /// <param name="value">The value.</param>
        public void SetValueAlias(object instance, string alias, object value)
        {
            if (propByAlias.ContainsKey(alias))
            {
                propByAlias[alias].SetValue(instance, value);
            }
            else
            {
                propInfo[alias].SetValue(instance, value);
            }
        }

        /// <summary>
        /// Gets the property type of the property associated to the alias.
        /// </summary>
        /// <param name="alias">The alias.</param>
        /// <returns></returns>
        public Type GetPropertyTypeAlias(string alias)
        {
            if (propByAlias.ContainsKey(alias))
            {
                return propByAlias[alias].PropertyType;
            }
            return propInfo[alias].PropertyType;
        }

        #endregion
    }
}
