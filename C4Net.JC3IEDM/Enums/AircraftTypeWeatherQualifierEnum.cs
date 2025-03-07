using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the weather conditions in which an AIRCRAFT-TYPE can perform its mission.
    /// </summary>
    [DomId(100004371)]
    [DataContract]
    public enum AircraftTypeWeatherQualifierEnum
    {
		
        /// <summary>
        /// All weather conditions.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ALL")]
        [EnumMember]
        AllWeather,
		
        /// <summary>
        /// Clear weather conditions only.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CLEAR")]
        [EnumMember]
        ClearWeather,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
