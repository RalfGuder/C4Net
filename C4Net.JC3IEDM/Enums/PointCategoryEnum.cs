using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of POINT.
    /// </summary>
    [DomId(100000200)]
    [DataContract]
    public enum PointCategoryEnum
    {
		
        /// <summary>
        /// A POINT in a geodetic system.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ABS")]
        [EnumMember]
        AbsolutePoint,
		
        /// <summary>
        /// A POINT whose position is specified with respect to a specific RELATIVE-COORDINATE-SYSTEM.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("REL")]
        [EnumMember]
        RelativePoint,
		
    }
}
