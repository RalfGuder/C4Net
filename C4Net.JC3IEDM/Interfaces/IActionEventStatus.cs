using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionEventStatus that represents the table ACT_EVENT_STAT
	/// 
	/// The perceived appraisal of the actual progress of a specific ACTION-EVENT as determined by the reporting organisation.
    /// </summary>
	[EntId(10000151)]
    [EntName("ACTION-EVENT-STATUS")]
    [EntTableName("ACT_EVENT_STAT")]
    [EntDepth(3)]
    public interface IActionEventStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_event_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_event_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("action-event-id")]
		[AttrColumnName("act_event_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionEventId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_event_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-EVENT-STATUS for a specific ACTION-EVENT and to distinguish it from all other ACTION-EVENT-STATUSs for that ACTION-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column act_event_stat_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-event-status-index")]
		[AttrColumnName("act_event_stat_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column compl_rat
		///
		/// The numeric quotient value that represents the portion of a whole ACTION-EVENT that is estimated to have been accomplished. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column compl_rat
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-event-status-completion-ratio")]
		[AttrColumnName("compl_rat")]
        [AttrSeqnr(3)]
        [DomId(100001900)]
        [DataLength(6)]
        [DataDecimals(5)]
        double? CompletionRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column feint_ind_code
		///
		/// The specific value that indicates whether the ACTION-EVENT is a feint.
        /// </summary>
        /// <value>
        /// Value of the column feint_ind_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-event-status-feint-indicator-code")]
		[AttrColumnName("feint_ind_code")]
        [AttrSeqnr(4)]
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
        [AttrIx(100005)]
		[AttrName("reporting-data-id")]
		[AttrColumnName("rptd_id")]
        [AttrSeqnr(5)]
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
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(6)]
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
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(7)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
