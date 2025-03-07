using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the specific class of NETWORK.
    /// </summary>
    [DomId(100004151)]
    [DataContract]
    public enum NetworkSubcategoryEnum
    {
		
        /// <summary>
        /// A transmission in which a communication channel is established to transmit a message over an optimum path.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CIRCSW")]
        [EnumMember]
        CircuitSwitched,
		
        /// <summary>
        /// A transmission in which a message is broken into a number of parts which are sent independently, over whatever route is optimum for each packet, and reassembled at the destination.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("PCKSWT")]
        [EnumMember]
        PacketSwitched,
		
        /// <summary>
        /// A transmission in which a message is transmitted over a virtual circuit switched communication channel established on top of a packet switched medium.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("VRTSWT")]
        [EnumMember]
        VirtualCircuitSwitched,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
