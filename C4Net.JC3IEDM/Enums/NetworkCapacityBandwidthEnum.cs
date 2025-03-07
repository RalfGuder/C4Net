using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents a bandwidth capacity that is supported by a NETWORK.
    /// </summary>
    [DomId(100004149)]
    [DataContract]
    public enum NetworkCapacityBandwidthEnum
    {
		
        /// <summary>
        /// A dedicated point-to-point transmission line of 2048Kbps bandwidth capacity.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("E1")]
        [EnumMember]
        E1,
		
        /// <summary>
        /// A dedicated point-to-point transmission line of 8192 Kbps bandwidth capacity.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("E2")]
        [EnumMember]
        E2,
		
        /// <summary>
        /// A dedicated point-to-point transmission line of 32768 Kbps bandwidth capacity.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("E3")]
        [EnumMember]
        E3,
		
        /// <summary>
        /// A dedicated point-to-point transmission line of 512 Kbps bandwidth capacity.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("EUROCM")]
        [EnumMember]
        Eurocom,
		
        /// <summary>
        /// A 100 Mbps token passed ring network.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("FDDI")]
        [EnumMember]
        Fddi,
		
        /// <summary>
        /// A 1.544Mbps permanent virtual circuit that uses a packet switching scheme.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("FRMRLY")]
        [EnumMember]
        FrameRelay,
		
        /// <summary>
        /// A 144Kbps basic rate dial-up line.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("ISDN")]
        [EnumMember]
        Isdn,
		
        /// <summary>
        /// A fibre optic NETWORK that delivers data at speeds up to 622 Mbps, and beyond. (Synchronous Optical NETwork).
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("SONET")]
        [EnumMember]
        Sonet,
		
        /// <summary>
        /// A circuit-switched 56Kbps leased line.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("SWTD56")]
        [EnumMember]
        Switched56,
		
        /// <summary>
        /// A dedicated point-to-point transmission line of 1.544Mbps bandwidth capacity.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("T1")]
        [EnumMember]
        T1,
		
        /// <summary>
        /// A dedicated point-to-point transmission line of 45 Mbps bandwidth capacity.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("T3")]
        [EnumMember]
        T3,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A digital bandwidth value representing a transfer speed of 56 Kilobits per second.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("56KBPS")]
        [EnumMember]
        _56Kbps,
		
        /// <summary>
        /// A digital bandwidth value representing a transfer speed of 64 Kilobits per second.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("64KBPS")]
        [EnumMember]
        _64Kbps,
		
        /// <summary>
        /// A digital bandwidth value representing a transfer speed of 10 Megabits per second.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("10MBPS")]
        [EnumMember]
        _10Mbps,
		
        /// <summary>
        /// A digital bandwidth value representing a transfer speed of 100 Megabits per second.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("100MBP")]
        [EnumMember]
        _100Mbps,
		
        /// <summary>
        /// A digital bandwidth value representing a transfer speed of 1 Gigabits per second.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("1GBPS")]
        [EnumMember]
        _1Gbps,
		
        /// <summary>
        /// A digital bandwidth value representing a transfer speed of 10 Gigabits per second.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("10GBPS")]
        [EnumMember]
        _10Gbps,
		
    }
}
