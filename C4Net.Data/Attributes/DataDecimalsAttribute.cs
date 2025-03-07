using System;

namespace C4Net.Data.Attributes
{
    public class DataDecimalsAttribute : Attribute
    {
        #region - Properties -

        public int Value { get; private set; }

        #endregion

        #region - Constructors -

        public DataDecimalsAttribute(int value)
        {
            this.Value = value;
        }

        #endregion
    }
}
