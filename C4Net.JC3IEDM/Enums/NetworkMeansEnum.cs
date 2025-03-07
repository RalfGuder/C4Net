using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the physical linkage between the nodes of a specific NETWORK.
    /// </summary>
    [DomId(100004139)]
    [DataContract]
    public enum NetworkMeansEnum
    {
		
        /// <summary>
        /// A transmission means using electrical signals, typically through copper cable.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CABLE")]
        [EnumMember]
        Cable,
		
        /// <summary>
        /// A transmission means using light transmission using fibre optic cable.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("FBROPT")]
        [EnumMember]
        FibreOptic,
		
        /// <summary>
        /// A transmission where more than one type of network means is used across a single communication link.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MIXED")]
        [EnumMember]
        Mixed,
		
        /// <summary>
        /// A transmission means using the Electromagnetic spectrum.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("RDLNKG")]
        [EnumMember]
        RadioLinkGeneral,
		
        /// <summary>
        /// A transmission means using the Electromagnetic spectrum specifically through a satellite.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("RDLNKS")]
        [EnumMember]
        RadioLinkSatellite,
		
        /// <summary>
        /// A transmission means using a highly directional line of sight transmission mainly for trunk communications.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("RDRLY")]
        [EnumMember]
        RadioRelay,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// The NETWORK is set up through a reserved public switched telephone network circuit.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("DDCDLN")]
        [EnumMember]
        DedicatedLine,
		
        /// <summary>
        /// The NETWORK is set up through a public switched telephone network.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("DIALUP")]
        [EnumMember]
        DialUp,
		
        /// <summary>
        /// A transmission means consisting of a centre conductor surrounded by an insulating material and a concentric outer conductor.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("COAXCB")]
        [EnumMember]
        CoaxialCable,
		
        /// <summary>
        /// A transmission means made up of one or more separately insulated twisted-wire pairs, none of which is arranged with another to form quads.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("TWTPRC")]
        [EnumMember]
        TwistedPairCable,
		
        /// <summary>
        /// A transmission means using the Electromagnetic spectrum specifically through a path that does not include a satellite.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("RDLTER")]
        [EnumMember]
        RadioLinkTerrestrial,
		
        /// <summary>
        /// A transmission means using the Electromagnetic spectrum and specifically the reflective properties of the troposphere.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("RDLTRO")]
        [EnumMember]
        RadioLinkTropospheric,
		
        /// <summary>
        /// A transmission means using infrared light.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("INFRED")]
        [EnumMember]
        Infrared,
		
        /// <summary>
        /// A transmission means using a laser beam.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("LASER")]
        [EnumMember]
        Laser,
		
        /// <summary>
        /// A transmission means using a maser beam (amplified electromagnetic waves).
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("MASER")]
        [EnumMember]
        Maser,
		
        /// <summary>
        /// A transmission means using micrometric frequency electromagnetic waves.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("MICROW")]
        [EnumMember]
        Microwave,
		
    }
}
