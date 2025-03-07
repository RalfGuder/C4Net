using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents a class of LOCATION.
    /// </summary>
    [DomId(100000138)]
    [DataContract]
    public enum LocationCategoryEnum
    {
		
        /// <summary>
        /// A zero-dimensional LOCATION.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("PT")]
        [EnumMember]
        Point,
		
        /// <summary>
        /// A LOCATION that is defined by two or more POINTs connected by one-dimensional line segments in an ordered sequence.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("LN")]
        [EnumMember]
        Line,
		
        /// <summary>
        /// A two-dimensional LOCATION.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SURFAC")]
        [EnumMember]
        Surface,
		
        /// <summary>
        /// A specific LOCATION that is a three-dimensional bounded space.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("VL")]
        [EnumMember]
        GeometricVolume,
		
        /// <summary>
        /// A LOCATION that refers to a position that cannot be determined.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("UND")]
        [EnumMember]
        Undefined,
		
    }
}
