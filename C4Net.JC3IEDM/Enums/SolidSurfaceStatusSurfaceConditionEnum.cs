using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the physical status of a solid surface area.
    /// </summary>
    [DomId(100000254)]
    [DataContract]
    public enum SolidSurfaceStatusSurfaceConditionEnum
    {
		
        /// <summary>
        /// A characterisation of an area covered with fine dry particles of matter.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DUST")]
        [EnumMember]
        Dust,
		
        /// <summary>
        /// A characterisation of an area covered with a layer or mass of frozen water.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ICE")]
        [EnumMember]
        Ice,
		
        /// <summary>
        /// A characterisation of an area covered with small, loose grains of worn or disintegrated rock.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("SAND")]
        [EnumMember]
        Sand,
		
        /// <summary>
        /// A characterisation of an area covered with snow.
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
		
        /// <summary>
        /// A characteristic of an area covered with soil.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("EARTH")]
        [EnumMember]
        Earth,
		
        /// <summary>
        /// A characterisation of an area covered or submerged temporarily in water.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("FLOOD")]
        [EnumMember]
        Flood,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
