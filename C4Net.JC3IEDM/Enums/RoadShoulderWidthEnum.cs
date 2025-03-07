using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the average horizontal distance measured from side to side and perpendicular to the central axis of a specific hard shoulder (lane/area beside a highway for broken-down or not running vehicles).
    /// </summary>
    [DomId(100004265)]
    [DataContract]
    public enum RoadShoulderWidthEnum
    {
		
        /// <summary>
        /// The specific hard shoulder is over 2 metres.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("1")]
        [EnumMember]
        Over2M,
		
        /// <summary>
        /// The specific hard shoulder is between 1 and 2 metres.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("2")]
        [EnumMember]
        _1To2M,
		
        /// <summary>
        /// The specific hard shoulder is under 1 metre.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("3")]
        [EnumMember]
        Under1M,
		
    }
}
