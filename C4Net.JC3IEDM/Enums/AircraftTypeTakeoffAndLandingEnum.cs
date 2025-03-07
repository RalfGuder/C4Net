using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the takeoff and landing designation of an AIRCRAFT-TYPE.
    /// </summary>
    [DomId(100004204)]
    [DataContract]
    public enum AircraftTypeTakeoffAndLandingEnum
    {
		
        /// <summary>
        /// An aircraft whose designation indicates it is capable of short takeoff and landing.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("STOL")]
        [EnumMember]
        ShortTakeoffLanding,
		
        /// <summary>
        /// An aircraft whose designation indicates it is capable of vertical/short takeoff and landing.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("VSTOL")]
        [EnumMember]
        VerticalShortTakeoffLanding,
		
        /// <summary>
        /// An aircraft whose designation indicates it is capable of vertical takeoff and landing.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("VTOL")]
        [EnumMember]
        VerticalTakeoffLanding,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
