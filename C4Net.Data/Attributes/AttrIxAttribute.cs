using System;

namespace C4Net.Data.Attributes
{
    public class AttrIxAttribute : Attribute
    {
        #region - Properties -

        public int Value { get; private set; }

        #endregion

        #region - Constructors -

        public AttrIxAttribute(int value)
        {
            this.Value = value;
        }

        #endregion
    }

}
