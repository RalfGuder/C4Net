using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents a general type of service that a specific NETWORK is intended to provide.
    /// </summary>
    [DomId(100004127)]
    [DataContract]
    public enum NetworkServiceCategoryEnum
    {
		
        /// <summary>
        /// A service provided by means of electronic scanning of a document, transmitting it as data by telecommunications links, and producing an exact copy at the receiver.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("FAX")]
        [EnumMember]
        Facsimile,
		
        /// <summary>
        /// A service for electronic transfer of video information.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("VIDSVC")]
        [EnumMember]
        VideoService,
		
        /// <summary>
        /// A service for electronic transfer of voice information.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("VOCSVC")]
        [EnumMember]
        VoiceService,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A service for the electronic transfer of data.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("DATTRF")]
        [EnumMember]
        DataTransfer,
		
        /// <summary>
        /// A system using electromagnetic transmissions to which equipment carried by friendly forces automatically responds, for example, by emitting pulses, thereby distinguishing themselves from enemy forces.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("IFF")]
        [EnumMember]
        IdentificationFriendOrFoe,
		
        /// <summary>
        /// A service for electronic transfer of static or slowly refreshed images.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("IMAGE")]
        [EnumMember]
        Image,
		
        /// <summary>
        /// MIP Common Interface service.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("MCI")]
        [EnumMember]
        Mci,
		
        /// <summary>
        /// An application service that provides a generalised facility for exchanging electronic messages between systems.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("MHS")]
        [EnumMember]
        MessageHandlingService,
		
        /// <summary>
        /// One or more data links organised within a given architecture and supporting a standard set of binary messages exchanged between users of that system, for use in military operations.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("TDL")]
        [EnumMember]
        TacticalDataLink,
		
    }
}
