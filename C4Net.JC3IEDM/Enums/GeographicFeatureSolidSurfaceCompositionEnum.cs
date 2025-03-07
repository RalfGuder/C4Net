using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the composition of the surface of the GEOGRAPHIC-FEATURE.
    /// </summary>
    [DomId(100004205)]
    [DataContract]
    public enum GeographicFeatureSolidSurfaceCompositionEnum
    {
		
        /// <summary>
        /// A characterisation of an area which is composed of a naturally exposed material consisting of bedrock.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BDROCK")]
        [EnumMember]
        Bedrock,
		
        /// <summary>
        /// A characterisation of an area which is composed of coral.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CORAL")]
        [EnumMember]
        Coral,
		
        /// <summary>
        /// A characterisation of an area which is composed of soil.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("EARTH")]
        [EnumMember]
        Earth,
		
        /// <summary>
        /// A characterisation of an area which is composed of a layer or mass of frozen water.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ICE")]
        [EnumMember]
        Ice,
		
        /// <summary>
        /// A characterisation of an area that is composed mainly of small, loose grains of worn or disintegrated rock.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("SAND")]
        [EnumMember]
        Sand,
		
        /// <summary>
        /// A characterisation of an area which is composed of snow.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("SNOW")]
        [EnumMember]
        Snow,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
