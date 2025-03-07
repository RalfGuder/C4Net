using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of TRANSMISSION-CAPABILITY.
    /// </summary>
    [DomId(100004352)]
    [DataContract]
    public enum TransmissionCapabilityCategoryEnum
    {
		
        /// <summary>
        /// The ability to detect or pick up a broadcast, a signal or programme.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("RECEIV")]
        [EnumMember]
        Receive,
		
        /// <summary>
        /// The ability to detect, pick up, broadcast or send out a signal or programme.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("TRNSRC")]
        [EnumMember]
        Transceive,
		
        /// <summary>
        /// The ability to broadcast or send out a signal or programme.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("TRNSMT")]
        [EnumMember]
        Transmit,
		
    }
}
