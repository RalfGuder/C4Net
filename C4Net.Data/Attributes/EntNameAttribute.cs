using System;

namespace C4Net.Data.Attributes
{
    public class EntNameAttribute : Attribute
    {
        #region - Properties -

        public string Value { get; private set; }

        #endregion

        #region - Constructors -

        public EntNameAttribute(string value)
        {
            this.Value = value;
        }

        #endregion
    }
}
