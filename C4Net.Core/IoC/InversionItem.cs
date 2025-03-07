using System;
using System.Collections.Generic;

namespace C4Net.Core.IoC
{
    /// <summary>
    /// Class for an inversion item.
    /// </summary>
    public class InversionItem
    {
        #region - Constants -

        /// <summary>
        /// The default instance name.
        /// </summary>
        public const string DefaultInstanceName = "default";

        #endregion

        #region - Fields -

        /// <summary>
        /// The instances of this item. If Per Call then is null. If Singleton then contains only one object.
        /// In the case of Per Token, contains one item for each token.
        /// </summary>
        private Dictionary<string, InversionInstance> instances = null;

        #endregion

        #region - Properties -

        /// <summary>
        /// Gets the type of the interface.
        /// </summary>
        /// <value>
        /// The type of the interface.
        /// </value>
        public Type InterfaceType { get; private set; }

        /// <summary>
        /// Gets the type of the object.
        /// </summary>
        /// <value>
        /// The type of the object.
        /// </value>
        public Type ObjectType { get; private set; }

        /// <summary>
        /// Gets the lifetime.
        /// </summary>
        /// <value>
        /// The lifetime.
        /// </value>
        public InversionLifetime Lifetime { get; private set; }

        /// <summary>
        /// Gets or sets the expire mode.
        /// </summary>
        /// <value>
        /// The expire mode.
        /// </value>
        public InversionExpiration Expiration { get; set; }

        /// <summary>
        /// Gets or sets the expire time.
        /// </summary>
        /// <value>
        /// The expire time.
        /// </value>
        public DateTime ExpireTime { get; set; }

        /// <summary>
        /// Gets or sets the expire span.
        /// </summary>
        /// <value>
        /// The expire span.
        /// </value>
        public TimeSpan ExpireSpan { get; set; }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="InversionItem"/> class.
        /// </summary>
        /// <param name="interfaceType">Type of the interface.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="lifetime">The lifetime.</param>
        public InversionItem(Type interfaceType, Type objectType, InversionLifetime lifetime)
        {
            this.InterfaceType = interfaceType;
            this.ObjectType = objectType;
            this.Lifetime = lifetime;
            this.Expiration = InversionExpiration.Never;
            this.ExpireTime = DateTime.UtcNow;
            this.ExpireSpan = TimeSpan.FromDays(1);
            if (this.Lifetime != InversionLifetime.PerCall)
            {
                this.instances = new Dictionary<string, InversionInstance>();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InversionItem"/> class.
        /// </summary>
        /// <param name="interfaceType">Type of the interface.</param>
        /// <param name="instance">The instance.</param>
        public InversionItem(Type interfaceType, object instance)
        {
            this.InterfaceType = interfaceType;
            this.ObjectType = instance.GetType();
            this.Lifetime = InversionLifetime.Singleton;
            this.Expiration = InversionExpiration.Never;
            this.ExpireTime = DateTime.UtcNow;
            this.ExpireSpan = TimeSpan.FromDays(1);
            this.instances = new Dictionary<string, InversionInstance>();
            this.instances.Add(DefaultInstanceName, new InversionInstance(instance));
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Gets a new instance of the object type.
        /// </summary>
        /// <returns></returns>
        protected object GetNewInstance()
        {
            return Activator.CreateInstance(ObjectType);
        }

        /// <summary>
        /// Gets the instance for a token from the dictionary, create a new one if not exists.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        private object GetInstance(string token)
        {
            InversionInstance item;
            if (this.instances.ContainsKey(token))
            {
                item = this.instances[token];
            }
            else
            {
                item = new InversionInstance(this.GetNewInstance());
                this.instances.Add(token, item);
            }
            return item.Value;
        }

        /// <summary>
        /// Gets the object.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.ApplicationException">IoC GetObject() called with invalid lifetime.</exception>
        public object GetObject()
        {
            switch (this.Lifetime)
            {
                case InversionLifetime.PerCall:
                    return this.GetNewInstance();
                case InversionLifetime.Singleton:
                    return this.GetInstance(DefaultInstanceName);
                default:
                    throw new ApplicationException("IoC GetObject() called with invalid lifetime.");
            }
        }

        /// <summary>
        /// Gets the object.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        public object GetObject(string token)
        {
            if (this.Lifetime == InversionLifetime.PerToken)
            {
                return this.GetInstance(token);
            }
            else
            {
                return this.GetObject();
            }
        }

        /// <summary>
        /// Indicates if the token exists.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        public bool ExistsToken(string token)
        {
            return this.instances.ContainsKey(token);
        }

        /// <summary>
        /// Expire the instance of the given token.
        /// </summary>
        /// <param name="token">The token.</param>
        public void ExpireToken(string token)
        {
            if (this.instances.ContainsKey(token))
            {
                this.instances.Remove(token);
            }
        }

        /// <summary>
        /// Checks the expiration.
        /// </summary>
        public void CheckExpiration()
        {
            if (this.Expiration == InversionExpiration.DateTime)
            {
                if (DateTime.UtcNow > this.ExpireTime.Add(this.ExpireSpan))
                {
                    this.instances.Clear();
                }
            }
            else if (this.Expiration == InversionExpiration.Idle)
            {
                List<string> toRemove = new List<string>();
                foreach (KeyValuePair<string, InversionInstance> kvp in this.instances)
                {
                    if (kvp.Value.IsIdle(this.ExpireSpan))
                    {
                        toRemove.Add(kvp.Key);
                    }
                }
                foreach (string key in toRemove)
                {
                    this.instances.Remove(key);
                }
            }
        }

        #endregion
    }
}
