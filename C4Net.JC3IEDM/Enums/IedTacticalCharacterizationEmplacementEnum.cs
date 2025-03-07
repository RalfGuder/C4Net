using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that describes where the device is positioned.
    /// </summary>
    [DomId(100004422)]
    [DataContract]
    public enum IedTacticalCharacterizationEmplacementEnum
    {
		
        /// <summary>
        /// IED emplaced inside or directly on an object.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("INON")]
        [EnumMember]
        InOn,
		
        /// <summary>
        /// IED emplaced in a structure above the intended target.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("OVERHD")]
        [EnumMember]
        Overhead,
		
        /// <summary>
        /// IED emplaced under the surface or below the intended target, i.e. buried, in a culvert, underwater.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SUBSFC")]
        [EnumMember]
        Subsurface,
		
        /// <summary>
        /// IED emplaced directly on the ground or water surface.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("SURFAC")]
        [EnumMember]
        Surface,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
