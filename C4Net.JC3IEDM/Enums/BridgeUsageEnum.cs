using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the usage of a specific BRIDGE.
    /// </summary>
    [DomId(100004120)]
    [DataContract]
    public enum BridgeUsageEnum
    {
		
        /// <summary>
        /// The BRIDGE is intended to be used by foot traffic.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("FOOT")]
        [EnumMember]
        Foot,
		
        /// <summary>
        /// The BRIDGE is intended to be used for foot, vehicle and rail traffic.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MLTUSE")]
        [EnumMember]
        MultipleUse,
		
        /// <summary>
        /// The BRIDGE is intended to be used for rail traffic.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("RAILWY")]
        [EnumMember]
        Railway,
		
        /// <summary>
        /// The BRIDGE is intended to be used both for rail and vehicle traffic.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("RLWYVH")]
        [EnumMember]
        RailwayVehicle,
		
        /// <summary>
        /// The BRIDGE is intended to be used by vehicle traffic.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("VEHCLE")]
        [EnumMember]
        Vehicle,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
