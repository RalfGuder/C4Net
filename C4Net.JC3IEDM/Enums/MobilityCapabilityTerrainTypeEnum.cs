using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of terrain to which a particular MOBILITY-CAPABILITY pertains.
    /// </summary>
    [DomId(100000330)]
    [DataContract]
    public enum MobilityCapabilityTerrainTypeEnum
    {
		
        /// <summary>
        /// The capability is valid for movement in open country.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CRSCTY")]
        [EnumMember]
        CrossCountry,
		
        /// <summary>
        /// The capability is valid for terrain specifically prepared for vehicle movement.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ROAD")]
        [EnumMember]
        Road,
		
        /// <summary>
        /// The capability is valid for terrain covered by snow.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SNOW")]
        [EnumMember]
        Snow,
		
        /// <summary>
        /// The capability is independent of the class of terrain.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("TERIND")]
        [EnumMember]
        TerrainIndependent,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
