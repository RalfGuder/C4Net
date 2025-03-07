using System;
using System.Collections.Generic;

namespace C4Net.Data.Entity
{
    /// <summary>
    /// Manager for Entity Helpers.
    /// </summary>
    public static class EntityHelperManager
    {
        #region - Fields -

        /// <summary>
        /// The helpers dictionary.
        /// </summary>
        private static Dictionary<Type, IEntityHelper> helpers = new Dictionary<Type, IEntityHelper>();

        #endregion

        #region - Methods -

        public static IEntityHelper Get(Type type)
        {
            if (helpers.ContainsKey(type))
            {
                return helpers[type];
            }
            Type classType = type;
            Type interfaceType = classType.GetInterface("I" + classType.Name);
            if (helpers.ContainsKey(interfaceType))
            {
                return helpers[interfaceType];
            }
            IEntityHelper helper = new EntityHelper(interfaceType, classType);
            helpers.Add(interfaceType, helper);
            return helper;
        }

        /// <summary>
        /// Gets the entity helper of a given type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEntityHelper Get<T>()
        {
            return EntityHelperManager.Get(typeof(T));
        }

        /// <summary>
        /// Registers the specified helper.
        /// </summary>
        /// <param name="interfaceType">Type of the interface.</param>
        /// <param name="classType">Type of the class.</param>
        public static void Register(Type interfaceType, Type classType) 
        {
            if (!helpers.ContainsKey(interfaceType))
            {
                helpers.Add(interfaceType, new EntityHelper(interfaceType, classType));
            }
        }

        #endregion
    }
}
