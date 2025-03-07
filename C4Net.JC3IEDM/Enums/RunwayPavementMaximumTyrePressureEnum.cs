using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the pavement maximum tyre pressure classification, which is part of the standard ICAO (International Civil Aviation Organization) method of reporting pavement strength for pavements with bearing strength greater than 5,700 kilograms (12,500 pounds).
    /// </summary>
    [DomId(100004277)]
    [DataContract]
    public enum RunwayPavementMaximumTyrePressureEnum
    {
		
        /// <summary>
        /// The specific value, which indicates that the maximum tyre pressure is not limited.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("W")]
        [EnumMember]
        High,
		
        /// <summary>
        /// The specific value, which indicates that the maximum tyre pressure is limited between 510,212 Pa and 999,739 Pa (74 and 145 (Pounds per square inch)) PSI (1 PSI = 6894.757 Pa).
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("Y")]
        [EnumMember]
        Low,
		
        /// <summary>
        /// The specific value, which indicates that the maximum tyre pressure is limited between 1006,634 Pa and 1496,162 Pa (146 and 217 (Pounds per square inch)) PSI (1 PSI = 6894.757 Pa).
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("X")]
        [EnumMember]
        Medium,
		
        /// <summary>
        /// The specific value, which indicates that the maximum tyre pressure is limited to 503,317 Pa (73 Pounds per square inch) PSI (1 PSI = 6894.757 Pa).
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("Z")]
        [EnumMember]
        UltraLow,
		
    }
}
