using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the physical status of a liquid surface area.
    /// </summary>
    [DomId(100004255)]
    [DataContract]
    public enum LiquidSurfaceStatusSurfaceConditionEnum
    {
		
        /// <summary>
        /// A characterisation of an area temporarily without any liquid present.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DRAIND")]
        [EnumMember]
        Drained,
		
        /// <summary>
        /// A characterisation of an area covered with a layer or mass of frozen water.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ICE")]
        [EnumMember]
        Ice,
		
        /// <summary>
        /// A characterisation of an area covered with liquid that is not frozen.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("LIQUID")]
        [EnumMember]
        Liquid,
		
        /// <summary>
        /// A characterisation of an area covered with a mix of ice and water.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("MIXED")]
        [EnumMember]
        Mixed,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
