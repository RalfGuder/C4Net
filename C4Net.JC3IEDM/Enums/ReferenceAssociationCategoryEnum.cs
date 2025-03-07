using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of relationship between a subject REFERENCE and an object REFERENCE for a specific REFERENCE-ASSOCIATION.
    /// </summary>
    [DomId(100004231)]
    [DataContract]
    public enum ReferenceAssociationCategoryEnum
    {
		
        /// <summary>
        /// The artefact in the subject REFERENCE cancels the artefact in the object REFERENCE.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CANCEL")]
        [EnumMember]
        Cancels,
		
        /// <summary>
        /// The artefact in the subject REFERENCE graphically depicts the information in the artefact in the object REFERENCE.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("GRPHDP")]
        [EnumMember]
        GraphicallyDepictsInformationContainedIn,
		
        /// <summary>
        /// The artefact in the subject REFERENCE includes the artefact in the object REFERENCE.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("INCLDE")]
        [EnumMember]
        Includes,
		
        /// <summary>
        /// The artefact in the subject REFERENCE is an amendment to the artefact in the object REFERENCE.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ISAMND")]
        [EnumMember]
        IsAnAmendmentTo,
		
        /// <summary>
        /// The artefact in the subject REFERENCE is an attachment to the artefact in the object REFERENCE.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ISATTC")]
        [EnumMember]
        IsAttachmentTo,
		
        /// <summary>
        /// The artefact in the subject REFERENCE is derived from the artefact in the object REFERENCE.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ISDRVD")]
        [EnumMember]
        IsDerivedFrom,
		
        /// <summary>
        /// The artefact in the subject REFERENCE is a modification of the artefact in the object REFERENCE.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("ISMODF")]
        [EnumMember]
        IsModificationOf,
		
        /// <summary>
        /// The stipulations of the artefact in the subject REFERENCE provide authority for the artefact in the object REFERENCE.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("PRVATH")]
        [EnumMember]
        ProvidesAuthorityFor,
		
        /// <summary>
        /// The artefact in the subject REFERENCE references the artefact in the object REFERENCE.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("REFRNC")]
        [EnumMember]
        References,
		
        /// <summary>
        /// The artefact in the subject REFERENCE supersedes the artefact in the object REFERENCE.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("SUPRCD")]
        [EnumMember]
        Supersedes,
		
        /// <summary>
        /// The artefact in the subject REFERENCE supplements the artefact in the object REFERENCE.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("SUPLMN")]
        [EnumMember]
        Supplements,
		
    }
}
