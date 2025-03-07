using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-EVENT-STATUS that represents the table ACT_EVENT_STAT.
	///
	/// The perceived appraisal of the actual progress of a specific ACTION-EVENT as determined by the reporting organisation.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionEventStatus", "C4Net.JC3IEDM.Definitions.ActionEventStatus.definition.xml")]
    public class ActionEventStatus : IEntity, IActionEventStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ActionEventStatusExpression _ = new ActionEventStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_event_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_event_id
        /// </value>
		public decimal ActionEventId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_event_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-EVENT-STATUS for a specific ACTION-EVENT and to distinguish it from all other ACTION-EVENT-STATUSs for that ACTION-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column act_event_stat_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column compl_rat
		///
		/// The numeric quotient value that represents the portion of a whole ACTION-EVENT that is estimated to have been accomplished. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column compl_rat
        /// </value>
		public double? CompletionRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column feint_ind_code
		///
		/// The specific value that indicates whether the ACTION-EVENT is a feint.
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
