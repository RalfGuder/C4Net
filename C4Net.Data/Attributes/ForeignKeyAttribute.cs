using System;

namespace C4Net.Data.Attributes
{
    public class ForeignKeyAttribute : Attribute
    {
        #region - Properties -

        public bool Value { get; private set; }

        #endregion

        #region - Constructors -

        public ForeignKeyAttribute(bool value = true)
        {
            this.Value = value;
        }

        #endregion
    }
}
