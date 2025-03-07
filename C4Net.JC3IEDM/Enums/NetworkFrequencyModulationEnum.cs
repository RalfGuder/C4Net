using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the modulation of a specific NETWORK.
    /// </summary>
    [DomId(100004125)]
    [DataContract]
    public enum NetworkFrequencyModulationEnum
    {
		
        /// <summary>
        /// The modulation of a wave by varying its amplitude across the whole channel.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DBSBND")]
        [EnumMember]
        DoubleSideBand,
		
        /// <summary>
        /// The modulation of a radio or other wave by variation of its frequency.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("FRQMOD")]
        [EnumMember]
        FrequencyModulation,
		
        /// <summary>
        /// The modulation of a radio or other wave by shifting central frequency of the signal.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("FRQSHF")]
        [EnumMember]
        FrequencyShiftKeying,
		
        /// <summary>
        /// The modulation of a wave by varying its amplitude with modulation on the lower side band of the channel.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("LWSBND")]
        [EnumMember]
        LowerSideBand,
		
        /// <summary>
        /// The modulation of a radio or other wave by shifting phase of the signal.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("PHSHKY")]
        [EnumMember]
        PhaseShiftKeying,
		
        /// <summary>
        /// The modulation of a wave by varying its amplitude with modulation on the upper side band of the channel.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("UPSBND")]
        [EnumMember]
        UpperSideBand,
		
    }
}
