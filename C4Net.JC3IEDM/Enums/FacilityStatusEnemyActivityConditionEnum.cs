using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the status of enemy activity around or at the FACILITY.
    /// </summary>
    [DomId(100004240)]
    [DataContract]
    public enum FacilityStatusEnemyActivityConditionEnum
    {
		
        /// <summary>
        /// No enemy action evident.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("COLD")]
        [EnumMember]
        Cold,
		
        /// <summary>
        /// Enemy action in proximity.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("HOT")]
        [EnumMember]
        Hot,
		
    }
}
