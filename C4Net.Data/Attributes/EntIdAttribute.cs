using System;

namespace C4Net.Data.Attributes
{
    public class EntIdAttribute : Attribute
    {
        #region - Properties -

        public int Value { get; private set; }

        #endregion

        #region - Constructors -

        public EntIdAttribute(int value)
        {
            this.Value = value;
        }

        #endregion
    }
}
