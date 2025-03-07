using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ORGANISATION-ACTION-TASK-RULE-OF-ENGAGEMENT-STATUS that represents the table ORG_ACT_TASK_ROE_STAT.
	///
	/// The status of the relationship between a specific ORGANISATION and a specific ACTION-TASK-RULE-OF-ENGAGEMENT with respect to a request for application, a request for cancellation, or an authorisation.
    /// </summary>
    [Serializable]
    [DefinitionName("OrganisationActionTaskRuleOfEngagementStatus", "C4Net.JC3IEDM.Definitions.OrganisationActionTaskRuleOfEngagementStatus.definition.xml")]
    public class OrganisationActionTaskRuleOfEngagementStatus : IEntity, IOrganisationActionTaskRuleOfEngagementStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly OrganisationActionTaskRuleOfEngagementStatusExpression _ = new OrganisationActionTaskRuleOfEngagementStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_task_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_task_id
        /// </value>
		public decimal ActionTaskId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column roe_id
		///
		/// The unique value, or set of characters, assigned to represent a specific RULE-OF-ENGAGEMENT and to distinguish it from all other RULE-OF-ENGAGEMENTs.
        /// </summary>
        /// <value>
        /// Value of the column roe_id
        /// </value>
		public decimal RuleOfEngagementId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_act_task_roe_stat_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column org_act_task_roe_stat_org_id
        /// </value>
		public decimal OrganisationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_act_task_roe_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ORGANISATION-ACTION-TASK-RULE-OF-ENGAGEMENT-STATUS for a specific ACTION-TASK-RULE-OF-ENGAGEMENT and to distinguish it from all other ORGANISATION-ACTION-TASK-RULE-OF-ENGAGEMENT-STATUSs for that ACTION-TASK-RULE-OF-ENGAGEMENT.
        /// </summary>
        /// <value>
        /// Value of the column org_act_task_roe_stat_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the role a responsible ORGANISATION has with respect to the imposition or removal of a specific ACTION-TASK-RULE-OF-ENGAGEMENT.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public OrganisationActionTaskRuleOfEngagementStatusCategoryEnum OrganisationActionTaskRuleOfEngagementStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_start_dttm
		///
		/// The character string representing a point in time that designates the beginning of the requested or authorised period of effectiveness for a specific ACTION-TASK-RULE-OF-ENGAGEMENT.
        /// </summary>
        /// <value>
        /// Value of the column effctv_start_dttm
        /// </value>
		public string EffectiveStartDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_end_dttm
		///
		/// The character string representing a point in time that designates the ending of the requested or authorised period of effectiveness for a specific ACTION-TASK-RULE-OF-ENGAGEMENT.
        /// </summary>
        /// <value>
        /// Value of the column effctv_end_dttm
        /// </value>
		public string EffectiveEndDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
		public decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
		public long UpdateSeqnr { get; set; }
		
        #endregion
    }
}
