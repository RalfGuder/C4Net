using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents an application-level (OSI model level 3 to 7) protocol governing the information transfer in a NETWORK.
    /// </summary>
    [DomId(100004140)]
    [DataContract]
    public enum NetworkCapacityProtocolEnum
    {
		
        /// <summary>
        /// The protocol used within ATM (Asynchronous Transfer Mode) based networks.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ATM")]
        [EnumMember]
        Atm,
		
        /// <summary>
        /// The protocol used within HAVE QUICK networks.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("HVQCK")]
        [EnumMember]
        HaveQuick,
		
        /// <summary>
        /// The protocol used within HAVE QUICK2 networks.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("HVQCK2")]
        [EnumMember]
        HaveQuick2,
		
        /// <summary>
        /// The protocol used within MIDS (Multi-functional Information Distribution System) networks.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("MIDS")]
        [EnumMember]
        Mids,
		
        /// <summary>
        /// The protocol used within UDP (User Datagram Protocol) wide area networks.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("UDP")]
        [EnumMember]
        Udp,
		
        /// <summary>
        /// The protocol used within ISO standard X25 based networks.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("X25")]
        [EnumMember]
        X25,
		
        /// <summary>
        /// The protocol used within ISO standard X400 based networks.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("X400")]
        [EnumMember]
        X400,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// Apple networks protocol suite.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("APLTLK")]
        [EnumMember]
        Appletalk,
		
        /// <summary>
        /// Digital Equipment’s proprietary protocol suite.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("DECNET")]
        [EnumMember]
        Decnet,
		
        /// <summary>
        /// Novell networks protocol suite.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("IPXSPX")]
        [EnumMember]
        IpxSpx,
		
        /// <summary>
        /// Microsoft networks protocol suite.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("NETBEU")]
        [EnumMember]
        Netbeui,
		
        /// <summary>
        /// An OSI 7-layer model compatible protocol suite.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("OSI")]
        [EnumMember]
        Osi,
		
        /// <summary>
        /// An SNA layer model compatible protocol suite.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("SNA")]
        [EnumMember]
        Sna,
		
        /// <summary>
        /// The protocol used within TCP/IP (Transfer Control Protocol/Internet Protocol) wide area networks.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("TCPIP")]
        [EnumMember]
        TcpIp,
		
        /// <summary>
        /// The protocol used within IPv6 (Internet Protocol Version 6) wide area networks.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("IPV6")]
        [EnumMember]
        Ipv6,
		
    }
}
