using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity OrganisationActionTaskRuleOfEngagementStatus that represents the table ORG_ACT_TASK_ROE_STAT
	/// 
	/// The status of the relationship between a specific ORGANISATION and a specific ACTION-TASK-RULE-OF-ENGAGEMENT with respect to a request for application, a request for cancellation, or an authorisation.
    /// </summary>
	[EntId(10000172)]
    [EntName("ORGANISATION-ACTION-TASK-RULE-OF-ENGAGEMENT-STATUS")]
    [EntTableName("ORG_ACT_TASK_ROE_STAT")]
    [EntDepth(6)]
    public interface IOrganisationActionTaskRuleOfEngagementStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_task_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_task_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("action-task-id")]
		[AttrColumnName("act_task_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionTaskId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column roe_id
		///
		/// The unique value, or set of characters, assigned to represent a specific RULE-OF-ENGAGEMENT and to distinguish it from all other RULE-OF-ENGAGEMENTs.
        /// </summary>
        /// <value>
        /// Value of the column roe_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("rule-of-engagement-id")]
		[AttrColumnName("roe_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000907)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal RuleOfEngagementId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_act_task_roe_stat_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column org_act_task_roe_stat_org_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("organisation-action-task-rule-of-engagement-status-organisation-id")]
		[AttrColumnName("org_act_task_roe_stat_org_id")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal OrganisationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_act_task_roe_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ORGANISATION-ACTION-TASK-RULE-OF-ENGAGEMENT-STATUS for a specific ACTION-TASK-RULE-OF-ENGAGEMENT and to distinguish it from all other ORGANISATION-ACTION-TASK-RULE-OF-ENGAGEMENT-STATUSs for that ACTION-TASK-RULE-OF-ENGAGEMENT.
        /// </summary>
        /// <value>
        /// Value of the column org_act_task_roe_stat_ix
        /// </value>
        [AttrIx(100004)]
		[AttrName("organisation-action-task-rule-of-engagement-status-index")]
		[AttrColumnName("org_act_task_roe_stat_ix")]
        [AttrSeqnr(4)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the role a responsible ORGANISATION has with respect to the imposition or removal of a specific ACTION-TASK-RULE-OF-ENGAGEMENT.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("organisation-action-task-rule-of-engagement-status-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100000311)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationActionTaskRuleOfEngagementStatusCategoryEnum OrganisationActionTaskRuleOfEngagementStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_start_dttm
		///
		/// The character string representing a point in time that designates the beginning of the requested or authorised period of effectiveness for a specific ACTION-TASK-RULE-OF-ENGAGEMENT.
        /// </summary>
        /// <value>
        /// Value of the column effctv_start_dttm
        /// </value>
        [AttrIx(100006)]
		[AttrName("organisation-action-task-rule-of-engagement-status-effective-start-datetime")]
		[AttrColumnName("effctv_start_dttm")]
        [AttrSeqnr(6)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string EffectiveStartDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_end_dttm
		///
		/// The character string representing a point in time that designates the ending of the requested or authorised period of effectiveness for a specific ACTION-TASK-RULE-OF-ENGAGEMENT.
        /// </summary>
        /// <value>
        /// Value of the column effctv_end_dttm
        /// </value>
        [AttrIx(100007)]
		[AttrName("organisation-action-task-rule-of-engagement-status-effective-end-datetime")]
		[AttrColumnName("effctv_end_dttm")]
        [AttrSeqnr(7)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string EffectiveEndDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(8)]
        [Mandatory]
        [DomId(100000913)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(9)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
