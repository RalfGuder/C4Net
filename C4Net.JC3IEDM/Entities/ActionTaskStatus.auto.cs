using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-TASK-STATUS that represents the table ACT_TASK_STAT.
	///
	/// The perceived appraisal of the planning and execution progress of a particular ACTION-TASK as determined by the reporting organisation.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionTaskStatus", "C4Net.JC3IEDM.Definitions.ActionTaskStatus.definition.xml")]
    public class ActionTaskStatus : IEntity, IActionTaskStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ActionTaskStatusExpression _ = new ActionTaskStatusExpression();

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
        /// Gets or sets the value of the column act_task_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-TASK-STATUS for a specific ACTION-TASK and to distinguish it from all other ACTION-TASK-STATUSs for that ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column act_task_stat_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the perceived class of a specific ACTION-TASK at a given time.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ActionTaskStatusCategoryEnum ActionTaskStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column compl_rat
		///
		/// The numeric quotient value that represents the portion of a whole ACTION-TASK that is estimated to have occurred or been accomplished. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column compl_rat
        /// </value>
		public double? CompletionRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column planning_ind_code
		///
		/// The specific value that denotes at the reporting time whether an ACTION-TASK is completed in the planning process.
        /// </summary>
        /// <value>
        /// Value of the column planning_ind_code
        /// </value>
		public ActionTaskStatusPlanningIndicatorEnum? PlanningIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column progress_code
		///
		/// The specific value that represents the perceived appraisal of the progress of a specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column progress_code
        /// </value>
		public ActionTaskStatusProgressEnum? Progress { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column amend_timing_code
		///
		/// The specific value that denotes request or requirement to modify the timing associated with a specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column amend_timing_code
        /// </value>
		public ActionTaskStatusAmendTimingEnum? AmendTiming { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column app_ind_code
		///
		/// The specific value that denotes at the reporting time whether an ACTION-TASK is approved for execution.
        /// </summary>
        /// <value>
        /// Value of the column app_ind_code
        /// </value>
		public ActionTaskStatusApprovalIndicatorEnum? ApprovalIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column feint_ind_code
		///
		/// The specific value that indicates whether the ACTION-TASK is a feint.
        /// </summary>
        /// <value>
        /// Value of the column feint_ind_code
        /// </value>
		public FeintIndicatorEnum? FeintIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
		public decimal ReportingDataId { get; set; }
		
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
