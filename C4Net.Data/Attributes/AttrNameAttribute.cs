using System;

namespace C4Net.Data.Attributes
{
    public class AttrNameAttribute : Attribute
    {
        #region - Properties -

        public string Value { get; private set; }

        #endregion

        #region - Constructors -

        public AttrNameAttribute(string value)
        {
            this.Value = value;
        }

        #endregion
    }
}
