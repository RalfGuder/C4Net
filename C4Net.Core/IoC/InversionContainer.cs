﻿using System;
using System.Collections.Generic;

namespace C4Net.Core.IoC
{
    /// <summary>
    /// Inversion container.
    /// </summary>
    public class InversionContainer
    {
        #region - Fields -

        /// <summary>
        /// The items contained by the container.
        /// </summary>
        private Dictionary<Type, InversionItem> items = new Dictionary<Type, InversionItem>();

        #endregion

        #region - Methods -

        /// <summary>
        /// Registers the type.
        /// </summary>d:\work\C4Net\C4Net.Core\Log\
        /// <param name="interfaceType">Type of the interface.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="expireMode">The expire mode.</param>
        /// <param name="span">The span.</param>
        /// <param name="lifetime">The lifetime.</param>
        public void RegisterType(Type interfaceType, Type objectType, InversionExpiration expireMode, TimeSpan span, InversionLifetime lifetime = InversionLifetime.PerCall)
        {
            if (items.ContainsKey(interfaceType))
            {
                items.Remove(interfaceType);
            }
            InversionItem item = new InversionItem(interfaceType, objectType, lifetime);
            item.Expiration = expireMode;
            item.ExpireSpan = span;
            items.Add(interfaceType, item);
        }

        /// <summary>
        /// Registers the type.
        /// </summary>
        /// <param name="interfaceType">Type of the interface.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="lifetime">The lifetime.</param>
        public void RegisterType(Type interfaceType, Type objectType, InversionLifetime lifetime = InversionLifetime.PerCall)
        {
            this.RegisterType(interfaceType, objectType, InversionExpiration.Never, TimeSpan.FromMinutes(5), lifetime);
        }

        /// <summary>
        /// Registers the type.
        /// </summary>
        /// <typeparam name="TInterface">The type of the interface.</typeparam>
        /// <typeparam name="TObject">The type of the object.</typeparam>
        /// <param name="lifetime">The lifetime.</param>
        public void RegisterType<TInterface, TObject>(InversionLifetime lifetime = InversionLifetime.PerCall)
        {
            RegisterType(typeof(TInterface), typeof(TObject), lifetime);
        }

        /// <summary>
        /// Registers the type.
        /// </summary>
        /// <typeparam name="TInterface">The type of the interface.</typeparam>
        /// <typeparam name="TObject">The type of the object.</typeparam>
        /// <param name="span">The span.</param>
        public void RegisterType<TInterface, TObject>(TimeSpan span)
        {
            RegisterType(typeof(TInterface), typeof(TObject), InversionExpiration.Idle, span, InversionLifetime.PerToken);
        }

        /// <summary>
        /// Registers the singleton.
        /// </summary>
        /// <typeparam name="TInterface">The type of the interface.</typeparam>
        /// <param name="instance">The instance.</param>
        public void RegisterSingleton<TInterface>(TInterface instance)
        {
            if (items.ContainsKey(typeof(TInterface)))
            {
                items.Remove(typeof(TInterface));
            }
            InversionItem item = new InversionItem(typeof(TInterface), instance);
            items.Add(typeof(TInterface), item);
        }

        /// <summary>
        /// Gets the inversion item.
        /// </summary>
        /// <typeparam name="TInterface">The type of the interface.</typeparam>
        /// <returns></returns>
        public InversionItem GetInversionItem<TInterface>()
        {
            if (this.items.ContainsKey(typeof(TInterface)))
            {
                return this.items[typeof(TInterface)];
            }
            return null;
        }

        /// <summary>
        /// Gets the specified token.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        public T Get<T>(string token = InversionItem.DefaultInstanceName)
        {
            this.CheckExpiration();
            if (items.ContainsKey(typeof(T)))
            {
                return (T)items[typeof(T)].GetObject(token);
            }
            return default(T);
        }

        /// <summary>
        /// Existses the token.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        public bool ExistsToken<T>(string token)
        {
            this.CheckExpiration();
            if (items.ContainsKey(typeof(T)))
            {
                return items[typeof(T)].ExistsToken(token);
            }
            return false;
        }

        /// <summary>
        /// Checks the expiration.
        /// </summary>
        public void CheckExpiration()
        {
            foreach (KeyValuePair<Type, InversionItem> kvp in this.items)
            {
                kvp.Value.CheckExpiration();
            }
        }

        #endregion
    }
}
