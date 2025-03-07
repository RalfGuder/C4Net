using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of surface of the GEOGRAPHIC-FEATURE.
    /// </summary>
    [DomId(100004206)]
    [DataContract]
    public enum GeographicFeatureSurfaceCategoryEnum
    {
		
        /// <summary>
        /// The boundary of a liquid with the atmosphere or solid.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("LQDSRF")]
        [EnumMember]
        LiquidSurface,
		
        /// <summary>
        /// The boundary of the ground with the atmosphere or liquid.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("SLDSRF")]
        [EnumMember]
        SolidSurface,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
