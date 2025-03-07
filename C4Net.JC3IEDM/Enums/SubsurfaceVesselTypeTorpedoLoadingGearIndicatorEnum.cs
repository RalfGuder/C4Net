using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates whether a subsurface vessel has torpedo loading rails and lifting bands.
    /// </summary>
    [DomId(100004286)]
    [DataContract]
    public enum SubsurfaceVesselTypeTorpedoLoadingGearIndicatorEnum
    {
		
        /// <summary>
        /// The specific SUBSURFACE-VESSEL-TYPE does not have torpedo loading rails and lifting bands.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The specific SUBSURFACE-VESSEL-TYPE has torpedo loading rails and lifting bands.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
