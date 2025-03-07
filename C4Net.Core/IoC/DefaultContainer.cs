using System;

namespace C4Net.Core.IoC
{
    /// <summary>
    /// Singleton for the default IoC container.
    /// </summary>
    public static class DefaultContainer
    {
        #region - Fields -

        /// <summary>
        /// The inner container instance.
        /// </summary>
        private static InversionContainer container = new InversionContainer();

        #endregion

        #region - Methods -

        /// <summary>
        /// Registers the type.
        /// </summary>
        /// <param name="interfaceType">Type of the interface.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="expireMode">The expire mode.</param>
        /// <param name="span">The span.</param>
        /// <param name="lifetime">The lifetime.</param>
        public static void RegisterType(Type interfaceType, Type objectType, InversionExpiration expireMode, TimeSpan span, InversionLifetime lifetime = InversionLifetime.PerCall)
        {
            container.RegisterType(interfaceType, objectType, expireMode, span, lifetime);
        }

        /// <summary>
        /// Registers the type.
        /// </summary>
        /// <param name="interfaceType">Type of the interface.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="lifetime">The lifetime.</param>
        public static void RegisterType(Type interfaceType, Type objectType, InversionLifetime lifetime = InversionLifetime.PerCall)
        {
            container.RegisterType(interfaceType, objectType, lifetime);
        }

        /// <summary>
        /// Registers the type.
        /// </summary>
        /// <typeparam name="TInterface">The type of the interface.</typeparam>
        /// <typeparam name="TObject">The type of the object.</typeparam>
        /// <param name="lifetime">The lifetime.</param>
        public static void RegisterType<TInterface, TObject>(InversionLifetime lifetime = InversionLifetime.PerCall)
        {
            container.RegisterType<TInterface, TObject>(lifetime);
        }

        /// <summary>
        /// Registers the type.
        /// </summary>
        /// <typeparam name="TInterface">The type of the interface.</typeparam>
        /// <typeparam name="TObject">The type of the object.</typeparam>
        /// <param name="span">The span.</param>
        public static void RegisterType<TInterface, TObject>(TimeSpan span)
        {
            container.RegisterType<TInterface, TObject>(span);
        }

        /// <summary>
        /// Registers the singleton.
        /// </summary>
        /// <typeparam name="TInterface">The type of the interface.</typeparam>
        /// <param name="instance">The instance.</param>
        public static void RegisterSingleton<TInterface>(TInterface instance)
        {
            container.RegisterSingleton<TInterface>(instance);
        }

        /// <summary>
        /// Gets the inversion item.
        /// </summary>
        /// <typeparam name="TInterface">The type of the interface.</typeparam>
        /// <returns></returns>
        public static InversionItem GetInversionItem<TInterface>()
        {
            return container.GetInversionItem<TInterface>();
        }

        /// <summary>
        /// Gets the specified token.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        public static T Get<T>(string token = InversionItem.DefaultInstanceName)
        {
            return container.Get<T>(token);
        }

        /// <summary>
        /// Existses the token.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        public static bool ExistsToken<T>(string token)
        {
            return container.ExistsToken<T>(token);
        }

        #endregion
    }
}
