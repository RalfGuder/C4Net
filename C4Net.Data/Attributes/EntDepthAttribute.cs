using System;

namespace C4Net.Data.Attributes
{
    public class EntDepthAttribute : Attribute
    {
        #region - Properties -

        public int Value { get; private set; }

        #endregion

        #region - Constructors -

        public EntDepthAttribute(int value)
        {
            this.Value = value;
        }

        #endregion
    }
}
