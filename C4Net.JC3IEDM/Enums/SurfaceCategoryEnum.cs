using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of SURFACE.
    /// </summary>
    [DomId(100000121)]
    [DataContract]
    public enum SurfaceCategoryEnum
    {
		
        /// <summary>
        /// A SURFACE that is in the form of a truncated ring sector, which is a sector lying between and being bounded by the rays emanating from the centre-point of the ring and having a central angle.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("FA")]
        [EnumMember]
        FanArea,
		
        /// <summary>
        /// A SURFACE that is defined by its width and a sequence of points.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("CORDAR")]
        [EnumMember]
        CorridorArea,
		
        /// <summary>
        /// An AREA that is (a) an open rectangular section defined by its width and the distance between the two specific POINTS, (b) is closed by two half-circles with radii equal to half the width, and is positioned left, centred, or right with respect to the line formed by the defining points.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ORBTAR")]
        [EnumMember]
        OrbitArea,
		
        /// <summary>
        /// An AREA that consists of a circular arc and a polygonal segment defined by a specific LINE whose beginning coincides with the initial point of the arc and whose end coincides with the last point of the arc.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("PLYAAR")]
        [EnumMember]
        PolyarcArea,
		
        /// <summary>
        /// An AREA that has its boundaries defined by a specific LINE.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("PLYGAR")]
        [EnumMember]
        PolygonArea,
		
        /// <summary>
        /// A planar SURFACE in the form of an ellipse.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("ELLPSE")]
        [EnumMember]
        Ellipse,
		
        /// <summary>
        /// An AREA that is a rectangular section with its length defined by the two specific POINTs and its width by the sum of the widths to the left and right of the connecting line between the two points.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("TRCKAR")]
        [EnumMember]
        TrackArea,
		
    }
}
