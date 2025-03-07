using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionTaskStatus that represents the table ACT_TASK_STAT
	/// 
	/// The perceived appraisal of the planning and execution progress of a particular ACTION-TASK as determined by the reporting organisation.
    /// </summary>
	[EntId(10000153)]
    [EntName("ACTION-TASK-STATUS")]
    [EntTableName("ACT_TASK_STAT")]
    [EntDepth(5)]
    public interface IActionTaskStatus
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
        /// Gets or sets the value of the column act_task_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-TASK-STATUS for a specific ACTION-TASK and to distinguish it from all other ACTION-TASK-STATUSs for that ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column act_task_stat_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-task-status-index")]
		[AttrColumnName("act_task_stat_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the perceived class of a specific ACTION-TASK at a given time.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-task-status-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000287)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionTaskStatusCategoryEnum ActionTaskStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column compl_rat
		///
		/// The numeric quotient value that represents the portion of a whole ACTION-TASK that is estimated to have occurred or been accomplished. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column compl_rat
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-task-status-completion-ratio")]
		[AttrColumnName("compl_rat")]
        [AttrSeqnr(4)]
        [DomId(100001900)]
        [DataLength(6)]
        [DataDecimals(5)]
        double? CompletionRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column planning_ind_code
		///
		/// The specific value that denotes at the reporting time whether an ACTION-TASK is completed in the planning process.
        /// </summary>
        /// <value>
        /// Value of the column planning_ind_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("action-task-status-planning-indicator-code")]
		[AttrColumnName("planning_ind_code")]
        [AttrSeqnr(5)]
        [DomId(100000288)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionTaskStatusPlanningIndicatorEnum? PlanningIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column progress_code
		///
		/// The specific value that represents the perceived appraisal of the progress of a specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column progress_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("action-task-status-progress-code")]
		[AttrColumnName("progress_code")]
        [AttrSeqnr(6)]
        [DomId(100000289)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionTaskStatusProgressEnum? Progress { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column amend_timing_code
		///
		/// The specific value that denotes request or requirement to modify the timing associated with a specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column amend_timing_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("action-task-status-amend-timing-code")]
		[AttrColumnName("amend_timing_code")]
        [AttrSeqnr(7)]
        [DomId(100000290)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionTaskStatusAmendTimingEnum? AmendTiming { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column app_ind_code
		///
		/// The specific value that denotes at the reporting time whether an ACTION-TASK is approved for execution.
        /// </summary>
        /// <value>
        /// Value of the column app_ind_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("action-task-status-approval-indicator-code")]
		[AttrColumnName("app_ind_code")]
        [AttrSeqnr(8)]
        [DomId(100004314)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionTaskStatusApprovalIndicatorEnum? ApprovalIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column feint_ind_code
		///
		/// The specific value that indicates whether the ACTION-TASK is a feint.
        /// </summary>
        /// <value>
        /// Value of the column feint_ind_code
        /// </value>
        [AttrIx(100009)]
		[AttrName("action-task-status-feint-indicator-code")]
		[AttrColumnName("feint_ind_code")]
        [AttrSeqnr(9)]
        [DomId(100004336)]
        [DataLength(6)]
        [DataDecimals(0)]
        FeintIndicatorEnum? FeintIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
        [AttrIx(100010)]
		[AttrName("reporting-data-id")]
		[AttrColumnName("rptd_id")]
        [AttrSeqnr(10)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000912)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ReportingDataId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100011)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(11)]
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
        [AttrIx(100012)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(12)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
