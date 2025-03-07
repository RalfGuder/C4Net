using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the role a responsible ORGANISATION has with respect to the imposition or removal of a specific ACTION-TASK-RULE-OF-ENGAGEMENT.
    /// </summary>
    [DomId(100000311)]
    [DataContract]
    public enum OrganisationActionTaskRuleOfEngagementStatusCategoryEnum
    {
		
        /// <summary>
        /// The ORGANISATION activates a particular RULE-OF-ENGAGEMENT for a specific ACTION-TASK.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AUTHRS")]
        [EnumMember]
        Authorise,
		
        /// <summary>
        /// The ORGANISATION deactivates a particular RULE-OF-ENGAGEMENT for a specific ACTION-TASK.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CANCEL")]
        [EnumMember]
        Cancel,
		
        /// <summary>
        /// The ORGANISATION denies a request for activation or cancellation of a particular RULE-OF-ENGAGEMENT for a specific ACTION-TASK.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("DENYRQ")]
        [EnumMember]
        DenyRequest,
		
        /// <summary>
        /// The ORGANISATION requests the activation of a particular RULE-OF-ENGAGEMENT for a specific ACTION-TASK.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("AUTHRQ")]
        [EnumMember]
        AuthorisationRequest,
		
        /// <summary>
        /// The ORGANISATION requests the deactivation of a particular RULE-OF-ENGAGEMENT for a specific ACTION-TASK.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("CNCLRQ")]
        [EnumMember]
        CancellationRequest,
		
    }
}
