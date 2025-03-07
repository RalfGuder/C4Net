using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the responsibility of the specific ORGANISATION with respect to the specific PLAN-ORDER.
    /// </summary>
    [DomId(100004384)]
    [DataContract]
    public enum OrganisationPlanOrderAssociationCategoryEnum
    {
		
        /// <summary>
        /// The specific ORGANISATION is empowered to approve the PLAN-ORDER.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("APPR")]
        [EnumMember]
        IsApprovingAuthorityFor,
		
        /// <summary>
        /// The specific ORGANISATION is responsible for delivery of the PLAN-ORDER to the intended recipients.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("DISTR")]
        [EnumMember]
        IsResponsibleForDistributionOf,
		
        /// <summary>
        /// The specific ORGANISATION is responsible creating the contents of the PLAN-ORDER.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("PREP")]
        [EnumMember]
        IsResponsibleForPreparationOf,
		
        /// <summary>
        /// The specific ORGANISATION is responsible for controlling the execution of the PLAN-ORDER.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("EXEC")]
        [EnumMember]
        HasExecutionOversightOf,
		
        /// <summary>
        /// The specific ORGANISATION is the issuing headquarters for the PLAN-ORDER.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ISSHQ")]
        [EnumMember]
        IsTheIssuingHeadquartersFor,
		
    }
}
