using System;

namespace C4Net.Data.Attributes
{
    public class AttrSeqnrAttribute : Attribute
    {
        #region - Properties -

        public int Value { get; private set; }

        #endregion

        #region - Constructors -

        public AttrSeqnrAttribute(int value)
        {
            this.Value = value;
        }

        #endregion
    }
}
