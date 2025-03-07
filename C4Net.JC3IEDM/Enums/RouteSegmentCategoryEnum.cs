using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ROUTE-SEGMENT.
    /// </summary>
    [DomId(100004258)]
    [DataContract]
    public enum RouteSegmentCategoryEnum
    {
		
        /// <summary>
        /// A portion of a route to be flown usually without an intermediate stop, as defined by two consecutive significant points.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AIRRTE")]
        [EnumMember]
        AirRouteSegment,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
