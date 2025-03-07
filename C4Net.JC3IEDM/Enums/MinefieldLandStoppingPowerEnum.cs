using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the stopping power of a particular MINEFIELD-LAND.
    /// </summary>
    [DomId(100000315)]
    [DataContract]
    public enum MinefieldLandStoppingPowerEnum
    {
		
        /// <summary>
        /// Minefield to be covered by light direct fire. Mines per square meter: 0.004.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("HIGH")]
        [EnumMember]
        High,
		
        /// <summary>
        /// Harassment used with other munitions. Mines per square meter: 0.001.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("LOW")]
        [EnumMember]
        Low,
		
        /// <summary>
        /// Minefield to be covered by light direct fire. Mines per square meter: 0.002.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MEDIUM")]
        [EnumMember]
        Medium,
		
    }
}
