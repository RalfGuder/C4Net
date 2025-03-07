using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates the suitability of a specific ROUTE or ROUTE-SEGMENT for movement.
    /// </summary>
    [DomId(100000202)]
    [DataContract]
    public enum MobilityEnum
    {
		
        /// <summary>
        /// Suitable only for pedestrians and animals.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("FOOT")]
        [EnumMember]
        Foot,
		
        /// <summary>
        /// Suitable for wheeled vehicles without need for any additional capability.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("WHEEL")]
        [EnumMember]
        WheeledGeneral,
		
        /// <summary>
        /// Suitable for tracked vehicles.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("TRACK")]
        [EnumMember]
        Tracked,
		
        /// <summary>
        /// Suitable for wheeled and tracked vehicles.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("WHTR")]
        [EnumMember]
        WheeledAndTracked,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// Suitable for wheeled vehicles with improved capabilities.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("WHLAWD")]
        [EnumMember]
        WheeledAllRoad,
		
    }
}
