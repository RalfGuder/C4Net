using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of AIRCRAFT-TYPE.
    /// </summary>
    [DomId(100000336)]
    [DataContract]
    public enum AircraftTypeCategoryEnum
    {
		
        /// <summary>
        /// A machine or device capable of atmospheric flight and dependent on wings for lift.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("FIXWNG")]
        [EnumMember]
        FixedWing,
		
        /// <summary>
        /// A machine or device capable of atmospheric flight and dependent on rotating blades for lift.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AIRRW")]
        [EnumMember]
        RotaryWing,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A machine or device capable of atmospheric flight weighing less than the air it displaces.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("LGTAIR")]
        [EnumMember]
        LighterThanAir,
		
        /// <summary>
        /// An aircraft capable of operating in the region beyond the earth’s atmosphere.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("SPACEM")]
        [EnumMember]
        SpaceVehicle,
		
    }
}
