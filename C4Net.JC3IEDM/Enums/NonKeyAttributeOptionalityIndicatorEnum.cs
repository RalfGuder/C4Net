using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether non-null domain value is required for a NON-KEY-ATTRIBUTE.
    /// </summary>
    [DomId(100006024)]
    [DataContract]
    public enum NonKeyAttributeOptionalityIndicatorEnum
    {
		
        /// <summary>
        /// The non-key attribute is mandatory.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("MA")]
        [EnumMember]
        Mandatory,
		
        /// <summary>
        /// The non-key attribute is optional.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("OP")]
        [EnumMember]
        Optional,
		
    }
}
