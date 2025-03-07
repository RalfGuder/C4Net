using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of GEOMETRIC-VOLUME.
    /// </summary>
    [DomId(100000167)]
    [DataContract]
    public enum GeometricVolumeCategoryEnum
    {
		
        /// <summary>
        /// A GEOMETRIC-VOLUME whose boundary is swept by a line that has a fixed point and another that moves along the path defined by the border of a specific SURFACE.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CN")]
        [EnumMember]
        ConeVolume,
		
        /// <summary>
        /// A VOLUME that has its horizontal boundaries defined by the spherical surface determined by the radius and the specified POINT.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("SPHVOL")]
        [EnumMember]
        SphereVolume,
		
        /// <summary>
        /// A VOLUME that has its horizontal boundaries defined by a specific SURFACE.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("SURVOL")]
        [EnumMember]
        SurfaceVolume,
		
    }
}
