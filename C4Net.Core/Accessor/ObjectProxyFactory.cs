using System;
using System.Collections.Generic;

namespace C4Net.Core.Accessor
{
    /// <summary>
    /// Factory for the Object Proxy accessor to objects.
    /// </summary>
    public static class ObjectProxyFactory
    {
        #region - Fields -

        /// <summary>
        /// Dictionary of proxies, relationship between the type and the proxy.
        /// </summary>
        private static Dictionary<Type, IObjectProxyAlias> proxies = new Dictionary<Type, IObjectProxyAlias>();

        #endregion

        #region - Methods -

        /// <summary>
        /// Return the ObjectProxy for a type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public static IObjectProxyAlias GetByType(Type type)
        {
            if (proxies.ContainsKey(type))
            {
                return proxies[type];
            }
            else
            {
                ObjectProxyAlias result = new ObjectProxyAlias(type);
                proxies.Add(type, result);
                return result;
            }
        }

        /// <summary>
        /// Adds an object proxy given the type, instance type and collection type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="collectionType">Type of the collection.</param>
        public static void Add(Type type, Type objectType, Type collectionType)
        {
            if (!proxies.ContainsKey(type))
            {
                ObjectProxyAlias proxy = new ObjectProxyAlias(type, objectType, collectionType);
                proxies.Add(type, proxy);
                if (type != objectType)
                {
                    proxies.Add(objectType, proxy);
                }
            }
        }

        /// <summary>
        /// Adds an object proxy given the type and instance type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="objectType">Type of the object.</param>
        public static void Add(Type type, Type objectType)
        {
            if (!proxies.ContainsKey(type))
            {
                ObjectProxyAlias proxy = new ObjectProxyAlias(type, objectType);
                proxies.Add(type, proxy);
                if (type != objectType)
                {
                    proxies.Add(objectType, proxy);
                }
            }
        }

        /// <summary>
        /// Adds an object proxy given the type.
        /// </summary>
        /// <param name="type">The type.</param>
        public static void Add(Type type)
        {
            if (!proxies.ContainsKey(type))
            {
                proxies.Add(type, new ObjectProxyAlias(type));
            }
        }

        /// <summary>
        /// Gets the object proxy for the type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IObjectProxyAlias Get<T>()
        {
            return GetByType(typeof(T));
        }

        /// <summary>
        /// Gets the object proxy for the instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        public static IObjectProxyAlias Get(object instance)
        {
            return GetByType(instance.GetType());
        }

        /// <summary>
        /// Creates a new object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T CreateObject<T>()
        {
            return (T)Get<T>().CreateObject();
        }

        /// <summary>
        /// Creates a new collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IList<T> CreateList<T>()
        {
            return (IList<T>)Get<T>().CreateList();
        }

        /// <summary>
        /// Gets the type of the property.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static Type GetPropertyType<T>(string name)
        {
            return Get<T>().GetPropertyType(name);
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance">The instance.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static object GetValue<T>(object instance, string name)
        {
            return Get<T>().GetValue(instance, name);
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static object GetValue(object instance, string name)
        {
            return Get(instance).GetValue(instance, name);
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance">The instance.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public static void SetValue<T>(object instance, string name, object value)
        {
            Get<T>().SetValue(instance, name, value);
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public static void SetValue(object instance, string name, object value)
        {
            Get(instance).SetValue(instance, name, value);
        }

        /// <summary>
        /// Gets the property type alias.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static Type GetPropertyTypeAlias<T>(string name)
        {
            return Get<T>().GetPropertyTypeAlias(name);
        }

        /// <summary>
        /// Gets the value alias.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance">The instance.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static object GetValueAlias<T>(object instance, string name)
        {
            return Get<T>().GetValueAlias(instance, name);
        }

        /// <summary>
        /// Gets the value alias.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static object GetValueAlias(object instance, string name)
        {
            return Get(instance).GetValueAlias(instance, name);
        }

        /// <summary>
        /// Sets the value alias.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance">The instance.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public static void SetValueAlias<T>(object instance, string name, object value)
        {
            Get<T>().SetValueAlias(instance, name, value);
        }

        /// <summary>
        /// Sets the value alias.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public static void SetValueAlias(object instance, string name, object value)
        {
            Get(instance).SetValueAlias(instance, name, value);
        }

        /// <summary>
        /// Adds the alias.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="alias">The alias.</param>
        /// <param name="propName">Name of the prop.</param>
        public static void AddAlias<T>(string alias, string propName)
        {
            Get<T>().AddAlias(alias, propName);
        }

        /// <summary>
        /// Removes the alias.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="alias">The alias.</param>
        public static void RemoveAlias<T>(string alias)
        {
            Get<T>().RemoveAlias(alias);
        }

        #endregion
    }
}
