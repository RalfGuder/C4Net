using System;

namespace C4Net.Data.Attributes
{
    public class EntTableNameAttribute : Attribute
    {
        #region - Properties -

        public string Value { get; private set; }

        #endregion

        #region - Constructors -

        public EntTableNameAttribute(string value)
        {
            this.Value = value;
        }

        #endregion
    }
}
