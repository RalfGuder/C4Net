using System;

namespace C4Net.Data.Attributes
{
    public class AttrColumnNameAttribute : Attribute
    {
        #region - Properties -

        public string Value { get; private set; }

        #endregion

        #region - Constructors -

        public AttrColumnNameAttribute(string value)
        {
            this.Value = value;
        }

        #endregion
    }
}
