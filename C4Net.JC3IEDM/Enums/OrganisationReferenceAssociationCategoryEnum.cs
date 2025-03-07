using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of a specific ORGANISATION-REFERENCE-ASSOCIATION.
    /// </summary>
    [DomId(100004230)]
    [DataContract]
    public enum OrganisationReferenceAssociationCategoryEnum
    {
		
        /// <summary>
        /// The specific ORGANISATION is authorised to approve the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ISAPRL")]
        [EnumMember]
        IsApprovalAuthorityFor,
		
        /// <summary>
        /// The specific ORGANISATION is classification authority for the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ISCLSF")]
        [EnumMember]
        IsClassificationAuthorityFor,
		
        /// <summary>
        /// The specific ORGANISATION is responsible for maintaining the configuration of the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ISCNGF")]
        [EnumMember]
        IsConfigurationManagerOf,
		
        /// <summary>
        /// The specific ORGANISATION is responsible for producing the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ISCRTR")]
        [EnumMember]
        IsCreatorOf,
		
        /// <summary>
        /// The specific ORGANISATION is responsible for the planning aspects of the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ISPLNR")]
        [EnumMember]
        IsPlannerOf,
		
        /// <summary>
        /// The specific ORGANISATION is release authority for the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ISRLSA")]
        [EnumMember]
        IsReleaseAuthorityFor,
		
    }
}
