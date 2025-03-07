using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the source of the reference for defining the origin and axial directions for a specific RELATIVE-COORDINATE-SYSTEM.
    /// </summary>
    [DomId(100004121)]
    [DataContract]
    public enum RelativeCoordinateSystemReferenceCategoryEnum
    {
		
        /// <summary>
        /// A RELATIVE-COORDINATE-SYSTEM that has its frame of reference defined by using the position and orientation of a specific OBJECT-ITEM at a given point in time.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("OBJREF")]
        [EnumMember]
        ObjectReference,
		
        /// <summary>
        /// A RELATIVE-COORDINATE-SYSTEM that uses three specific POINTs to establish its frame of reference.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("PNTREF")]
        [EnumMember]
        PointReference,
		
    }
}
