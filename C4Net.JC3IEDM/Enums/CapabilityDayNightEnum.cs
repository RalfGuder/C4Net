using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that defines the light conditions that apply to a particular CAPABILITY.
    /// </summary>
    [DomId(100000181)]
    [DataContract]
    public enum CapabilityDayNightEnum
    {
		
        /// <summary>
        /// The figures are based on the capability being invoked during daylight hours.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DAY")]
        [EnumMember]
        Day,
		
        /// <summary>
        /// The figures are based on the capability being invoked at any time.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("DN")]
        [EnumMember]
        DayAndNight,
		
        /// <summary>
        /// The figures are based on the capability being invoked during hours of darkness.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("N")]
        [EnumMember]
        Night,
		
    }
}
