using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of crane offloading equipment available at a specific QUAY.
    /// </summary>
    [DomId(100004181)]
    [DataContract]
    public enum QuayCraneOffloadingTypeEnum
    {
		
        /// <summary>
        /// A general-purpose crane that is able to move about by means of a vessel.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("FLTCRN")]
        [EnumMember]
        FloatingCrane,
		
        /// <summary>
        /// A general-purpose crane that is able to move about by means of railway tracks.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("RAILCR")]
        [EnumMember]
        RailedCrane,
		
        /// <summary>
        /// A general-purpose crane fixed to one location.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("STATCR")]
        [EnumMember]
        StaticCrane,
		
        /// <summary>
        /// A general-purpose crane that is able to move about by means of caterpillar tracks.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("TRKCRW")]
        [EnumMember]
        TrackedCrawlerCrane,
		
        /// <summary>
        /// A general-purpose crane that is able to move about by means of wheels.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("WHLCRN")]
        [EnumMember]
        WheeledCrane,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
