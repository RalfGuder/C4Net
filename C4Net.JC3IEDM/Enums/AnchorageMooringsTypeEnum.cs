using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of mooring available at the specific ANCHORAGE.
    /// </summary>
    [DomId(100004176)]
    [DataContract]
    public enum AnchorageMooringsTypeEnum
    {
		
        /// <summary>
        /// An anchored float marking the location of a mooring.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BUOY")]
        [EnumMember]
        Buoy,
		
        /// <summary>
        /// An isolated offshore bollard, cluster of piles or columns used for mooring or securing vessels.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("DOLPIN")]
        [EnumMember]
        Dolphin,
		
        /// <summary>
        /// A duc d’albe placed at the location of the anchorage.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("FXDPST")]
        [EnumMember]
        FixedPost,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
