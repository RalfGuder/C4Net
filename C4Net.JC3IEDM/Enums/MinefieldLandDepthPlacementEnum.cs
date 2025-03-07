using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates the placement of mines with respect to the surface.
    /// </summary>
    [DomId(100000314)]
    [DataContract]
    public enum MinefieldLandDepthPlacementEnum
    {
		
        /// <summary>
        /// A minefield placed on the surface.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("SURFCE")]
        [EnumMember]
        Surface,
		
        /// <summary>
        /// A minefield placed below the surface so as to be hidden from view.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("SUBSRF")]
        [EnumMember]
        Subsurface,
		
        /// <summary>
        /// A minefield that contains both surface and sub-surface laid mines.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MIXED")]
        [EnumMember]
        Mixed,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
