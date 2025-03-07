using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents a tract of land.
    /// </summary>
    [DomId(100004207)]
    [DataContract]
    public enum GeographicFeatureTerrainEnum
    {
		
        /// <summary>
        /// The terrain of the GEOGRAPHIC-FEATURE is characterised as broadly level.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("FLAT")]
        [EnumMember]
        Flat,
		
        /// <summary>
        /// The terrain of the GEOGRAPHIC-FEATURE is characterised as having multiple hills.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("HILLY")]
        [EnumMember]
        Hilly,
		
        /// <summary>
        /// The terrain of the GEOGRAPHIC-FEATURE is characterised as having many large natural elevations of the earth's surface rising abruptly from the surrounding level.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MOUNTS")]
        [EnumMember]
        Mountainous,
		
        /// <summary>
        /// The terrain of the GEOGRAPHIC-FEATURE is characterised as rolling or wavy.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("UNDULT")]
        [EnumMember]
        Undulating,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A topographical complex where man-made construction or high population density is the dominant feature.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("URBAN")]
        [EnumMember]
        Urban,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
