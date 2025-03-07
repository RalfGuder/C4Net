using System;

namespace C4Net.Data.Attributes
{
    public class MandatoryAttribute : Attribute
    {
        #region - Properties -

        public bool Value { get; private set; }

        #endregion

        #region - Constructors -

        public MandatoryAttribute(bool value = true)
        {
            this.Value = value;
        }

        #endregion
    }
}
