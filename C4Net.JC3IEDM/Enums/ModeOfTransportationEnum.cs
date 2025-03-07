using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates the mode of transportation of a specific ROUTE-SEGMENT.
    /// </summary>
    [DomId(100004259)]
    [DataContract]
    public enum ModeOfTransportationEnum
    {
		
        /// <summary>
        /// Represents the general mode of transportation used in movement by air.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AIR")]
        [EnumMember]
        Air,
		
        /// <summary>
        /// Represents the general mode of transportation used in movement by inland waterways.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("IWT")]
        [EnumMember]
        InlandWaterway,
		
        /// <summary>
        /// Represents transportation utilizing more than one mode of transportation.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MULTI")]
        [EnumMember]
        MultiMode,
		
        /// <summary>
        /// Represents the mode of transportation of materiel by pipeline.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("PIPE")]
        [EnumMember]
        Pipeline,
		
        /// <summary>
        /// Represents the general mode of transportation used in surface movement by rail.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("RAIL")]
        [EnumMember]
        Rail,
		
        /// <summary>
        /// Represents the general mode of transportation used in surface movement by road.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ROAD")]
        [EnumMember]
        Road,
		
        /// <summary>
        /// Represents the general mode of transportation used in movement by sea.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("SEA")]
        [EnumMember]
        Sea,
		
        /// <summary>
        /// Represents the general mode of transportation used in surface movement other than road and rail.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("TERR")]
        [EnumMember]
        Terrain,
		
    }
}
