using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates the intended depth placement of maritime mines.
    /// </summary>
    [DomId(100004197)]
    [DataContract]
    public enum MinefieldMaritimeDepthPlacementEnum
    {
		
        /// <summary>
        /// A minefield placed on the sea bottom.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BOTTOM")]
        [EnumMember]
        Bottom,
		
        /// <summary>
        /// A minefield placed in the surf zone.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("SURFZN")]
        [EnumMember]
        SurfZone,
		
        /// <summary>
        /// A minefield on the sea surface.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SEASUR")]
        [EnumMember]
        Surface,
		
        /// <summary>
        /// A minefield suspended between the sea surface and the bottom.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("VOLUME")]
        [EnumMember]
        Volume,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
