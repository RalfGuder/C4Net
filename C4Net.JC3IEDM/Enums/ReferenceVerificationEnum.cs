using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the verification of the artefact cited in a specific REFERENCE.
    /// </summary>
    [DomId(100004312)]
    [DataContract]
    public enum ReferenceVerificationEnum
    {
		
        /// <summary>
        /// The information provided by the artefact cited in a specific REFERENCE is verified.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("REFVER")]
        [EnumMember]
        ReferenceVerified,
		
        /// <summary>
        /// The information provided by the artefact cited in a specific REFERENCE is unverified.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("REFUNV")]
        [EnumMember]
        ReferenceUnverified,
		
        /// <summary>
        /// The information on the verification of the REFERENCE provided by the artefact cited in a specific REFERENCE is not available.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("REFVNA")]
        [EnumMember]
        ReferenceVerificationNotAvailable,
		
    }
}
