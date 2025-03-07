using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the required navigation performance when flying routes for which external route navigation aids are not provided.
    /// </summary>
    [DomId(100004219)]
    [DataContract]
    public enum AirRouteSegmentRequiredNavigationPerformanceEnum
    {
		
        /// <summary>
        /// 1 Nautical Mile navigation accuracy.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("1NM")]
        [EnumMember]
        _1,
		
        /// <summary>
        /// 4 Nautical Mile navigation accuracy.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("4NM")]
        [EnumMember]
        _4,
		
        /// <summary>
        /// 5 Nautical Mile navigation accuracy.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("5NM")]
        [EnumMember]
        _5,
		
        /// <summary>
        /// 6 Nautical Mile navigation accuracy.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("6NM")]
        [EnumMember]
        _6,
		
        /// <summary>
        /// 12.5 Nautical Mile navigation accuracy.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("125NM")]
        [EnumMember]
        _125,
		
        /// <summary>
        /// 20 Nautical Mile navigation accuracy.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("20NM")]
        [EnumMember]
        _20,
		
    }
}
