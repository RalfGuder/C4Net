using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of WIND.
    /// </summary>
    [DomId(100000172)]
    [DataContract]
    public enum WindCategoryEnum
    {
		
        /// <summary>
        /// Winds that have a constant force.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CONST")]
        [EnumMember]
        Constant,
		
        /// <summary>
        /// A rapid increase in the strength of the wind relative to the mean strength at the time.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("GUST")]
        [EnumMember]
        Gusting,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// A strong wind that rises suddenly, generally lasts for some minutes, and dies comparatively suddenly away. It is distinguished from a gust by its longer duration.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("SQUAL")]
        [EnumMember]
        Squalls,
		
        /// <summary>
        /// Winds that have a variable force.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("VRB")]
        [EnumMember]
        Variable,
		
        /// <summary>
        /// Light turbulence is a transitory atmospheric condition that has varying effects on aircraft operations. It is a serious hazard to pilots that may occur without warning.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("TRBLLI")]
        [EnumMember]
        TurbulenceLight,
		
        /// <summary>
        /// Moderate turbulence is a transitory atmospheric condition that has varying effects on aircraft operations. It is a serious hazard to pilots that may occur without warning.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("TRBLMO")]
        [EnumMember]
        TurbulenceModerate,
		
        /// <summary>
        /// Severe turbulence is a transitory atmospheric condition that has varying effects on aircraft operations. It is a serious hazard to pilots that may occur without warning.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("TRBLSE")]
        [EnumMember]
        TurbulenceSevere,
		
        /// <summary>
        /// Extreme turbulence is a transitory atmospheric condition that has varying effects on aircraft operations. It is a serious hazard to pilots that may occur without warning.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("TRBLEX")]
        [EnumMember]
        TurbulenceExtreme,
		
        /// <summary>
        /// A variation in wind velocity at right angles to the wind's direction.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("WSHEAR")]
        [EnumMember]
        WindShear,
		
    }
}
