using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of employment authorised for a specific TARGET.
    /// </summary>
    [DomId(100000220)]
    [DataContract]
    public enum TargetEngagementAuthorityEnum
    {
		
        /// <summary>
        /// Engagement of the target is not permitted.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("EXCL")]
        [EnumMember]
        Excluded,
		
        /// <summary>
        /// Engagement of the target is available and is accorded the highest priority.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("HPOTGT")]
        [EnumMember]
        HighPayoffTarget,
		
        /// <summary>
        /// Authority for engagement of the target and is not a high payoff target.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("AVLB")]
        [EnumMember]
        Available,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
