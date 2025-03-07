using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of a DOMAIN-VALUE.
    /// </summary>
    [DomId(100006014)]
    [DataContract]
    public enum DomainValueTypeEnum
    {
		
        /// <summary>
        /// Enumerated domains are associated with a complete set of domain values.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ELEM")]
        [EnumMember]
        Element,
		
        /// <summary>
        /// The maximum value excluded from the range.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("MAX-EX")]
        [EnumMember]
        MaximumExclusive,
		
        /// <summary>
        /// The maximum value included in the range.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("MAX-IN")]
        [EnumMember]
        MaximumInclusive,
		
        /// <summary>
        /// The minimum value excluded from the range.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("MIN-EX")]
        [EnumMember]
        MinimumExclusive,
		
        /// <summary>
        /// The minimum value included in the range.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("MIN-IN")]
        [EnumMember]
        MinimumInclusive,
		
    }
}
