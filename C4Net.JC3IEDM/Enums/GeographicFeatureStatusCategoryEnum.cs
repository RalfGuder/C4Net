using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of GEOGRAPHIC-FEATURE-STATUS.
    /// </summary>
    [DomId(100004209)]
    [DataContract]
    public enum GeographicFeatureStatusCategoryEnum
    {
		
        /// <summary>
        /// A GEOGRAPHIC-FEATURE-STATUS that is a record of condition of a specific liquid surface.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("LQDSRF")]
        [EnumMember]
        LiquidSurfaceStatus,
		
        /// <summary>
        /// A GEOGRAPHIC-FEATURE-STATUS that is a record of condition of a specific solid surface.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("SLDSRF")]
        [EnumMember]
        SolidSurfaceStatus,
		
        /// <summary>
        /// A GEOGRAPHIC-FEATURE-STATUS that is a record of condition of a specific liquid body.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("LQDBDY")]
        [EnumMember]
        LiquidBodyStatus,
		
    }
}
