using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of medium of the artefact cited in a specific REFERENCE.
    /// </summary>
    [DomId(100004234)]
    [DataContract]
    public enum ReferenceMediumTypeEnum
    {
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE is available as an electronic file on a network device.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ELCFLN")]
        [EnumMember]
        ElectronicFileNetwork,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE is available as an electronic file on a discrete physical storage device (e.g., CD, DVD, USB stick, etc.).
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ELCFLD")]
        [EnumMember]
        ElectronicFileDetachedPhysicalStorage,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE is available on negative or positive film.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("FILM")]
        [EnumMember]
        Film,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE is available as a magnetic recording containing audio, data, or video.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("MAGTPE")]
        [EnumMember]
        MagneticTape,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE is available as text or imagery printed on paper.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("PAPERB")]
        [EnumMember]
        PaperBased,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
