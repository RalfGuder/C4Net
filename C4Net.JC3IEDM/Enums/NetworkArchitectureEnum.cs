using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the architecture of a specific NETWORK.
    /// </summary>
    [DomId(100004152)]
    [DataContract]
    public enum NetworkArchitectureEnum
    {
		
        /// <summary>
        /// The IEEE 802.4 network architecture.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ARCNET")]
        [EnumMember]
        Arcnet,
		
        /// <summary>
        /// The IEEE 802.3 (and derivatives) network architecture.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ETHRNT")]
        [EnumMember]
        Ethernet,
		
        /// <summary>
        /// A network where more than one architecture is used.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MIXED")]
        [EnumMember]
        Mixed,
		
        /// <summary>
        /// The IEEE 802.5 network architecture.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("TKNRNG")]
        [EnumMember]
        TokenRing,
		
        /// <summary>
        /// The IEEE 802.11 network architecture.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("WRLESS")]
        [EnumMember]
        Wireless,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
