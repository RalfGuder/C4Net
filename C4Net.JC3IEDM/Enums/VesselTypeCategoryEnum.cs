using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of VESSEL-TYPE.
    /// </summary>
    [DomId(100000349)]
    [DataContract]
    public enum VesselTypeCategoryEnum
    {
		
        /// <summary>
        /// A vessel principally designed to operate under the water surface.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("SUBSRF")]
        [EnumMember]
        SubsurfaceVesselType,
		
        /// <summary>
        /// A vessel principally designed to operate on the water surface.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("SURFAC")]
        [EnumMember]
        SurfaceVesselType,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// Ship, vessel or craft whose designation has not been classified.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("IX")]
        [EnumMember]
        UnclassifiedMiscellaneousUnit,
		
    }
}
