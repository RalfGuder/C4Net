using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the civil/military status of the AIR-ROUTE-SEGMENT.
    /// </summary>
    [DomId(100004220)]
    [DataContract]
    public enum AirRouteSegmentCivilMilitaryEnum
    {
		
        /// <summary>
        /// The AIR-ROUTE-SEGMENT is civil and military.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BOTH")]
        [EnumMember]
        Both,
		
        /// <summary>
        /// The AIR-ROUTE-SEGMENT is civil.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CIVIL")]
        [EnumMember]
        Civil,
		
        /// <summary>
        /// The AIR-ROUTE-SEGMENT is military.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MIL")]
        [EnumMember]
        Military,
		
    }
}
