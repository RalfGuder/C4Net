using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the assigned direction for the traffic on the route.
    /// </summary>
    [DomId(100000306)]
    [DataContract]
    public enum RouteDirectionUsageEnum
    {
		
        /// <summary>
        /// Of a thoroughfare: along which traffic is permitted in only one direction; of traffic.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ONEWAY")]
        [EnumMember]
        OneWay,
		
        /// <summary>
        /// The movement of traffic is controlled to be in one direction at any given time.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ALTRNG")]
        [EnumMember]
        Alternating,
		
        /// <summary>
        /// Occurring or existing in two directions; along which traffic is permitted in two directions.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("TWOWAY")]
        [EnumMember]
        TwoWay,
		
    }
}
