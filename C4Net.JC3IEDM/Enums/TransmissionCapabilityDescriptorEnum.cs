using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the TRANSMISSION-CAPABILITY that is being quantified.
    /// </summary>
    [DomId(100004353)]
    [DataContract]
    public enum TransmissionCapabilityDescriptorEnum
    {
		
        /// <summary>
        /// The highest frequency that can be utilised while being operational.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("MAXFRQ")]
        [EnumMember]
        MaximumFrequency,
		
        /// <summary>
        /// The highest number of distinct pulses that can be generated per second while being operational.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MAXPRF")]
        [EnumMember]
        MaximumPulseRepetitionFrequency,
		
        /// <summary>
        /// The lowest frequency that can be utilised while being operational.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MNMFRQ")]
        [EnumMember]
        MinimumFrequency,
		
        /// <summary>
        /// The lowest number of distinct pulses that can be generated per second while being operational.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("MNMPRF")]
        [EnumMember]
        MinimumPulseRepetitionFrequency,
		
        /// <summary>
        /// Energy that is produced by mechanical, electrical or other means.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("POWER")]
        [EnumMember]
        Power,
		
    }
}
