using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the force level at which the specific OPERATIONAL-CAPABILITY is intended to be performed.
    /// </summary>
    [DomId(100004363)]
    [DataContract]
    public enum OperationalCapabilityLevelEnum
    {
		
        /// <summary>
        /// The specific mission can be performed at Corps level of command.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CORPS")]
        [EnumMember]
        Corps,
		
        /// <summary>
        /// The specific mission can be performed at Division level of command.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("DIV")]
        [EnumMember]
        Division,
		
        /// <summary>
        /// The specific mission can be performed at Force level of command.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("FORCE")]
        [EnumMember]
        Force,
		
        /// <summary>
        /// The specific mission can be performed at Operational level of command.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("OPR")]
        [EnumMember]
        Operational,
		
        /// <summary>
        /// The specific mission can be performed at Strategic level of command.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("STRTGC")]
        [EnumMember]
        Strategic,
		
        /// <summary>
        /// The specific mission can be performed at Tactical level of command.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("TACTCL")]
        [EnumMember]
        Tactical,
		
        /// <summary>
        /// The specific mission can be performed at Theatre level of command.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("THTRE")]
        [EnumMember]
        Theatre,
		
    }
}
