using System;

namespace C4Net.Data.Attributes
{
    public class DomIdAttribute : Attribute
    {
        #region - Properties -

        public int Value { get; private set; }

        #endregion

        #region - Constructors -

        public DomIdAttribute(int value)
        {
            this.Value = value;
        }

        #endregion
    }
}
