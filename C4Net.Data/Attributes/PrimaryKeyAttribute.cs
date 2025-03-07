using System;

namespace C4Net.Data.Attributes
{
    public class PrimaryKeyAttribute : Attribute
    {
        #region - Properties -

        public bool Value { get; private set; }

        #endregion

        #region - Constructors -

        public PrimaryKeyAttribute(bool value = true)
        {
            this.Value = value;
        }

        #endregion
    }
}
