using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the means by which the artefact cited in a specific REFERENCE is transmitted to the recipient.
    /// </summary>
    [DomId(100000293)]
    [DataContract]
    public enum ReferenceTransmittalTypeEnum
    {
		
        /// <summary>
        /// A message received by courier.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("COUMSG")]
        [EnumMember]
        CourierMessage,
		
        /// <summary>
        /// A message received through an E-mail system.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("EMLMSG")]
        [EnumMember]
        EMailMessage,
		
        /// <summary>
        /// A message received by fax.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("FAXMSG")]
        [EnumMember]
        FaxMessage,
		
        /// <summary>
        /// A message received by telephone.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("PHNMSG")]
        [EnumMember]
        PhoneMessage,
		
        /// <summary>
        /// A message received from a radio transmission.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("RADMSG")]
        [EnumMember]
        RadioMessage,
		
        /// <summary>
        /// A message received by secure fax.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("SFXMSG")]
        [EnumMember]
        SecureFaxMessage,
		
        /// <summary>
        /// A message received by a certain kind of civilian means.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("TELEX")]
        [EnumMember]
        TelexMessage,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// The information was received through electronic transfer.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("ELCTRF")]
        [EnumMember]
        ElectronicTransfer,
		
        /// <summary>
        /// The information was received via video.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("VIDEO")]
        [EnumMember]
        Video,
		
    }
}
