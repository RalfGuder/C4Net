using System;

namespace C4Net.Core.IoC
{
    /// <summary>
    /// Instance of an inversion item. Saves the object and the time of the last access.
    /// </summary>
    internal class InversionInstance
    {
        #region - Fields -

        /// <summary>
        /// Field for the object stored by this instance.
        /// </summary>
        private object value;

        #endregion

        #region - Properties -

        /// <summary>
        /// Gets or sets the last access.
        /// </summary>
        /// <value>
        /// The last access.
        /// </value>
        public DateTime LastAccess { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public object Value 
        {
            get
            {
                this.Use();
                return this.value;
            }

            set
            {
                this.value = value;
                this.Use();
            }
        }

        #endregion

        #region - Constructor -

        /// <summary>
        /// Initializes a new instance of the <see cref="InversionInstance"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public InversionInstance(object value)
        {
            this.Value = value;
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Uses this instance.
        /// </summary>
        private void Use()
        {
            this.LastAccess = DateTime.UtcNow;
        }

        /// <summary>
        /// Determines whether the specified span is idle.
        /// </summary>
        /// <param name="span">The span.</param>
        /// <returns>
        ///   <c>true</c> if the specified span is idle; otherwise, <c>false</c>.
        /// </returns>
        public bool IsIdle(TimeSpan span)
        {
            return this.LastAccess.Add(span) < DateTime.UtcNow;
        }

        #endregion

    }
}
