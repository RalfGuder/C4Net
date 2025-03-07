using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of trajectory to be used in firing of a specific ACTION-RESOURCE in support of a specific ACTION.
    /// </summary>
    [DomId(100004313)]
    [DataContract]
    public enum ActionResourceEmploymentTrajectoryFireEnum
    {
		
        /// <summary>
        /// The ACTION-RESOURCE uses an elevation of more than 45 degrees (800 mils) when firing.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("HIGH")]
        [EnumMember]
        High,
		
        /// <summary>
        /// The ACTION-RESOURCE uses an elevation up to 45 degrees (800 mils) when firing.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("LOW")]
        [EnumMember]
        Low,
		
    }
}
