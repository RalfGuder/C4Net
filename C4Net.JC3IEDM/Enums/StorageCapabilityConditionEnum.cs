using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of storage condition.
    /// </summary>
    [DomId(100004360)]
    [DataContract]
    public enum StorageCapabilityConditionEnum
    {
		
        /// <summary>
        /// The specific STORAGE-CAPABILITY provides climate controlled conditions.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CC")]
        [EnumMember]
        ClimateControlled,
		
        /// <summary>
        /// The specific STORAGE-CAPABILITY provides covered conditions.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CS")]
        [EnumMember]
        Covered,
		
        /// <summary>
        /// The specific STORAGE-CAPABILITY provides hardened conditions.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("HS")]
        [EnumMember]
        Hardened,
		
        /// <summary>
        /// The specific STORAGE-CAPABILITY provides open conditions.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("OS")]
        [EnumMember]
        Open,
		
    }
}
