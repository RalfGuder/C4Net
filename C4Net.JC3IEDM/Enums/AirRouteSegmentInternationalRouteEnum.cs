using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the domestic/international status of the AIR-ROUTE-SEGMENT.
    /// </summary>
    [DomId(100004221)]
    [DataContract]
    public enum AirRouteSegmentInternationalRouteEnum
    {
		
        /// <summary>
        /// The AIR-ROUTE-SEGMENT is domestic.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DOMSTC")]
        [EnumMember]
        Domestic,
		
        /// <summary>
        /// The AIR-ROUTE-SEGMENT is international.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("INTERN")]
        [EnumMember]
        International,
		
    }
}
