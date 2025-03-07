using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the relative priority that a specific capability that is an OPERATIONAL-CAPABILITY has.
    /// </summary>
    [DomId(100000327)]
    [DataContract]
    public enum MissionPrimacyEnum
    {
		
        /// <summary>
        /// Denotes the primary mission.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("PRIME")]
        [EnumMember]
        Primary,
		
        /// <summary>
        /// Denotes the secondary mission.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("SCNDRY")]
        [EnumMember]
        Secondary,
		
        /// <summary>
        /// Denotes the tertiary mission.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("THIRD")]
        [EnumMember]
        Tertiary,
		
    }
}
