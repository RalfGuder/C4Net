using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of GEOGRAPHIC-FEATURE-TYPE.
    /// </summary>
    [DomId(100000137)]
    [DataContract]
    public enum GeographicFeatureTypeCategoryEnum
    {
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// Natural features representing different aspects of interchange between water and land.
        /// </summary>
        [DomValIx(1000077)]
        [StringValue("CSTLHY")]
        [EnumMember]
        CoastalHydrography,
		
        /// <summary>
        /// A sea, lake, river, etc situated in the interior of a land mass.
        /// </summary>
        [DomValIx(1000078)]
        [StringValue("INLNDW")]
        [EnumMember]
        InlandWater,
		
        /// <summary>
        /// Natural features of the earth's surface.
        /// </summary>
        [DomValIx(1000079)]
        [StringValue("LNDFRM")]
        [EnumMember]
        Landform,
		
        /// <summary>
        /// Natural features that are characterised by frozen water.
        /// </summary>
        [DomValIx(1000080)]
        [StringValue("SNOWIC")]
        [EnumMember]
        SnowIce,
		
        /// <summary>
        /// A saturated area, at times covered with water.
        /// </summary>
        [DomValIx(1000081)]
        [StringValue("WETLND")]
        [EnumMember]
        Wetland,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000082)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// Any of the world's main continuous expanses of land.
        /// </summary>
        [DomValIx(1000083)]
        [StringValue("CONTNT")]
        [EnumMember]
        Continent,
		
    }
}
