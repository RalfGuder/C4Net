using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that describes the passability of a ROAD considering the impact of weather on that ROAD.
    /// </summary>
    [DomId(100004266)]
    [DataContract]
    public enum RoadWeatherConditionCategoryEnum
    {
		
        /// <summary>
        /// The specific value, which determines that the ROAD is passable, to all traffic in any weather except deep snow or flood (normally roads with waterproof surfaces).
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AWR")]
        [EnumMember]
        AllWeather,
		
        /// <summary>
        /// The specific value, which determines that the ROAD is passable only in fair weather. Quickly becomes impassable in bad weather. Cannot be kept open by maintenance short of major construction.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("FWR")]
        [EnumMember]
        FairWeather,
		
        /// <summary>
        /// The specific value, which determines that the volume of ROAD traffic may be limited by bad weather. Heavy unrestricted use during adverse weather may cause complete breakdown of surface (normally roads with non-waterproof surfaces).
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("LAWR")]
        [EnumMember]
        LimitedAllWeather,
		
    }
}
