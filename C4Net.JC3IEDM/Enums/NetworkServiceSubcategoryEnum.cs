using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents a detailed type of service that a specific NETWORK is intended to provide.
    /// </summary>
    [DomId(100004141)]
    [DataContract]
    public enum NetworkServiceSubcategoryEnum
    {
		
        /// <summary>
        /// A service provided through capabilities used by OSI applications, OSI management processes, other OSI layer entities, and telecommunication services, providing a dynamic "name-to-address mapping".
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DRCTRY")]
        [EnumMember]
        Directory,
		
        /// <summary>
        /// A communications service that provides correspondence in the form of messages transmitted between user terminals over a network.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("EMAIL")]
        [EnumMember]
        ElectronicMail,
		
        /// <summary>
        /// A service that provides the basic elements of file sharing between hosts.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("FTP")]
        [EnumMember]
        FileTransferProtocol,
		
        /// <summary>
        /// A service provided through Hypertext Transfer Protocol (HTTP) that is an application-level protocol with the lightness and speed necessary for distributed, collaborative, hypermedia information systems.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("HTTP")]
        [EnumMember]
        HypertextTransferProtocol,
		
        /// <summary>
        /// A service that provides the data for IFF mode 1.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("IFFM1")]
        [EnumMember]
        IffMode1,
		
        /// <summary>
        /// A service that provides the data for IFF mode 2.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("IFFM2")]
        [EnumMember]
        IffMode2,
		
        /// <summary>
        /// A service that provides the data for IFF mode 3.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("IFFM3")]
        [EnumMember]
        IffMode3,
		
        /// <summary>
        /// A service that provides the data for IFF mode 3A.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("IFFM3A")]
        [EnumMember]
        IffMode3A,
		
        /// <summary>
        /// A service that provides the data for IFF mode 4.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("IFFM4")]
        [EnumMember]
        IffMode4,
		
        /// <summary>
        /// A service that provides the data for IFF mode C.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("IFFMC")]
        [EnumMember]
        IffModeC,
		
        /// <summary>
        /// A service that provides the data for IFF mode 5.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("IFFM5")]
        [EnumMember]
        IffMode5,
		
        /// <summary>
        /// A service that provides the basic elements for the transmission of specific message of Link 1.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("LNK1")]
        [EnumMember]
        Link1,
		
        /// <summary>
        /// A service that provides the basic elements for the transmission of specific message of Link 4.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("LNK4")]
        [EnumMember]
        Link4,
		
        /// <summary>
        /// A service that provides the basic elements for the transmission of specific message of Link 11.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("LNK11")]
        [EnumMember]
        Link11,
		
        /// <summary>
        /// A service that provides the basic elements for the transmission of specific message of Link 11B.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("LNK11B")]
        [EnumMember]
        Link11B,
		
        /// <summary>
        /// A service that provides the basic elements for the transmission of specific message of Link 14.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("LNK14")]
        [EnumMember]
        Link14,
		
        /// <summary>
        /// A service that provides the basic elements for the transmission of specific message of Link 22.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("LNK22")]
        [EnumMember]
        Link22,
		
        /// <summary>
        /// MCI gateway service proving DEM and MEM facilities.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("MCIMD1")]
        [EnumMember]
        MciMode1,
		
        /// <summary>
        /// MCI gateway service proving MEM facilities.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("MCIMD2")]
        [EnumMember]
        MciMode2,
		
        /// <summary>
        /// MCI gateway service proving DEM facilities.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("MCIMD3")]
        [EnumMember]
        MciMode3,
		
        /// <summary>
        /// A service that provides communication services to a non-fixed device.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("MOBILE")]
        [EnumMember]
        MobilePhone,
		
        /// <summary>
        /// A communications service making use of a small radio device which bleeps or vibrates to inform the wearer that someone wishes to contact them or that it has received a short text message.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("PAGER")]
        [EnumMember]
        Pager,
		
        /// <summary>
        /// A communications service using a system consisting of teletypewriters connected to a telephonic network to send and receive signals.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("TELEX")]
        [EnumMember]
        Telex,
		
        /// <summary>
        /// A service using the terminal emulation protocol of TCP/IP. Options give TELNET the ability to transfer binary data, support byte macros, emulate graphics terminals, and convey information to support centralised terminal management.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("TELNET")]
        [EnumMember]
        Telnet,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A service that enable the operation of a remote node from a local node.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("RMTACC")]
        [EnumMember]
        RemoteAccess,
		
        /// <summary>
        /// A service that provides the data for IFF mode S.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("IFFMS")]
        [EnumMember]
        IffModeS,
		
        /// <summary>
        /// A service that provides the basic elements for the transmission of data of Link 16.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("LNK16D")]
        [EnumMember]
        Link16Data,
		
        /// <summary>
        /// A service that provides the basic elements for the transmission of voice of Link 16.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("LNK16V")]
        [EnumMember]
        Link16Voice,
		
        /// <summary>
        /// A service that provides communication services to a fixed device.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("TELEPH")]
        [EnumMember]
        Telephone,
		
    }
}
