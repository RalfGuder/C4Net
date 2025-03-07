using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the extent of repairs or servicing that can be accomplished.
    /// </summary>
    [DomId(100004349)]
    [DataContract]
    public enum MaintenanceCapabilityLevelEnum
    {
		
        /// <summary>
        /// The level of repair provided by the specific MAINTENANCE-CAPABILITY is only for emergencies.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("D")]
        [EnumMember]
        EmergencyOnly,
		
        /// <summary>
        /// The level of repair provided by the specific MAINTENANCE-CAPABILITY is limited.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("C")]
        [EnumMember]
        Limited,
		
        /// <summary>
        /// The level of repair provided by the specific MAINTENANCE-CAPABILITY is major.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("A")]
        [EnumMember]
        Major,
		
        /// <summary>
        /// The level of repair provided by the specific MAINTENANCE-CAPABILITY is moderate.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("B")]
        [EnumMember]
        Moderate,
		
    }
}
