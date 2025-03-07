using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ABSOLUTE-POINT with respect to the reference frame.
    /// </summary>
    [DomId(100004215)]
    [DataContract]
    public enum AbsolutePointCategoryEnum
    {
		
        /// <summary>
        /// An ABSOLUTE-POINT that has its position specified in a three-dimensional Earth-centred Cartesian system.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CARTPT")]
        [EnumMember]
        CartesianPoint,
		
        /// <summary>
        /// An ABSOLUTE-POINT that has its position specified with respect to the surface of the World Geodetic System 1984 (WGS 84) ellipsoid.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("GEOGPT")]
        [EnumMember]
        GeographicPoint,
		
    }
}
