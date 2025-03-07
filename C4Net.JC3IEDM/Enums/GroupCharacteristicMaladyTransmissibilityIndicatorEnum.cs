using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that identifies whether the type of ill health, ailment or disease in a specific GROUP-CHARACTERISTIC is communicable.
    /// </summary>
    [DomId(100004155)]
    [DataContract]
    public enum GroupCharacteristicMaladyTransmissibilityIndicatorEnum
    {
		
        /// <summary>
        /// The ill health, ailment or disease is not communicable.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The ill health, ailment or disease is communicable.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
