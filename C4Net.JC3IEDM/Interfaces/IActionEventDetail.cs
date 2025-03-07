using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionEventDetail that represents the table ACT_EVENT_DET
	/// 
	/// Supplemental information about the ACTION-EVENT.
    /// </summary>
	[EntId(10000213)]
    [EntName("ACTION-EVENT-DETAIL")]
    [EntTableName("ACT_EVENT_DET")]
    [EntDepth(3)]
    public interface IActionEventDetail
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
        /// Gets or sets the value of the column act_event_det_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-EVENT-DETAIL for a specific ACTION-EVENT and to distinguish it from all other ACTION-EVENT-DETAILs for that ACTION-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column act_event_det_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-event-detail-index")]
		[AttrColumnName("act_event_det_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column clsfc_code
		///
		/// The specific value that represents the classification of a specific ACTION-EVENT according to a broad subject area.
        /// </summary>
        /// <value>
        /// Value of the column clsfc_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-event-detail-classification-code")]
		[AttrColumnName("clsfc_code")]
        [AttrSeqnr(3)]
        [DomId(100000399)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionEventDetailClassificationEnum? Classification { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column crime_ind_code
		///
		/// The specific value that denotes a judgement whether a specific event is a crime or not.
        /// </summary>
        /// <value>
        /// Value of the column crime_ind_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-event-detail-crime-indicator-code")]
		[AttrColumnName("crime_ind_code")]
        [AttrSeqnr(4)]
        [DomId(100004143)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionEventDetailCrimeIndicatorEnum? CrimeIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column txt
		///
		/// The character string assigned to represent the description of the event detail of a specific ACTION-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column txt
        /// </value>
        [AttrIx(100005)]
		[AttrName("action-event-detail-text")]
		[AttrColumnName("txt")]
        [AttrSeqnr(5)]
        [DomId(100001500)]
        [DataLength(255)]
        [DataDecimals(0)]
        string Text { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("reporting-data-id")]
		[AttrColumnName("rptd_id")]
        [AttrSeqnr(6)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000912)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ReportingDataId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ACTION-EVENT-DETAIL. It serves as a discriminator that partitions ACTION-EVENT-DETAIL into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100009)]
		[AttrName("action-event-detail-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(7)]
        [Mandatory]
        [DomId(100004427)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionEventDetailCategoryEnum ActionEventDetailCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column intended_outcome_code
		///
		/// The specific value that describes the immediate and direct goals or objectives of an enemy’s attack.
        /// </summary>
        /// <value>
        /// Value of the column intended_outcome_code
        /// </value>
        [AttrIx(100010)]
		[AttrName("action-event-detail-intended-outcome-code")]
		[AttrColumnName("intended_outcome_code")]
        [AttrSeqnr(8)]
        [DomId(100004428)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionEventDetailIntendedOutcomeEnum? IntendedOutcome { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(9)]
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
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(10)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
