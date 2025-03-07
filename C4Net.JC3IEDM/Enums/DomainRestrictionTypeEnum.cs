using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of constraint imposed upon values for the DOMAIN.
    /// </summary>
    [DomId(100006010)]
    [DataContract]
    public enum DomainRestrictionTypeEnum
    {
		
        /// <summary>
        /// The constraint imposed on this domain is an enumerated domain.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("EN")]
        [EnumMember]
        EnumeratedDomain,
		
        /// <summary>
        /// The constraint imposed on this domain is a range.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("RA")]
        [EnumMember]
        Range,
		
    }
}
