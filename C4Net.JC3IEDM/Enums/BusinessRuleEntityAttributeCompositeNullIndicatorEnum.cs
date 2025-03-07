using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates whether the attribute cited in BUSINESS-RULE-ENTITY-ATTRIBUTE-COMPOSITE is permitted to be unspecified within the specific BUSINESS-RULE.
    /// </summary>
    [DomId(100006036)]
    [DataContract]
    public enum BusinessRuleEntityAttributeCompositeNullIndicatorEnum
    {
		
        /// <summary>
        /// The attribute can take any of the values listed in its associated BUSINESS-RULE-ENTITY-ATTRIBUTE-COMPOSITEs but it cannot be left unspecified.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The attribute can take any of the values listed in its associated BUSINESS-RULE-ENTITY-ATTRIBUTE-COMPOSITEs and can also be left unspecified.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
