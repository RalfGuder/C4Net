using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the assessed CBRN threat level status of a specific CONTROL-FEATURE that defines a given operational area for friendly forces.
    /// </summary>
    [DomId(100004189)]
    [DataContract]
    public enum ControlFeatureStatusCbrnThreatLevelEnum
    {
		
        /// <summary>
        /// Enemy has offensive NBC (CBRN) capability but there is no indication of use in immediate future.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("LOW")]
        [EnumMember]
        Low,
		
        /// <summary>
        /// NBC (CBRN) weapons have been used in another operation area and/or there are strong indications that enemy will use NBC (CBRN) weapons in immediate future.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MEDIUM")]
        [EnumMember]
        Medium,
		
        /// <summary>
        /// NBC (CBRN) attack is imminent in immediate area.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("HIGH")]
        [EnumMember]
        High,
		
    }
}
