using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionTemporalAssociation that represents the table ACT_TMPRL_ASSOC
	/// 
	/// The relationship of an ACTION as a subject to another ACTION as an object in order to specify time dependence.
    /// </summary>
	[EntId(10000017)]
    [EntName("ACTION-TEMPORAL-ASSOCIATION")]
    [EntTableName("ACT_TMPRL_ASSOC")]
    [EntDepth(1)]
    public interface IActionTemporalAssociation
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column subj_act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column subj_act_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("action-temporal-association-subject-action-id")]
		[AttrColumnName("subj_act_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal SubjectActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column obj_act_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-temporal-association-object-action-id")]
		[AttrColumnName("obj_act_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_tmprl_assoc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-TEMPORAL-ASSOCIATION for a specific subject ACTION and a specific object ACTION and to distinguish it from all other ACTION-TEMPORAL-ASSOCIATIONs for those ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_tmprl_assoc_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-temporal-association-index")]
		[AttrColumnName("act_tmprl_assoc_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of chronological relationship of a subject ACTION to an object ACTION for a specific ACTION-TEMPORAL-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-temporal-association-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000120)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionTemporalAssociationCategoryEnum ActionTemporalAssociationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ref_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds that elapses after the start or end of a specific object ACTION that a subject ACTION is referenced to for its execution.
        /// </summary>
        /// <value>
        /// Value of the column ref_dur
        /// </value>
        [AttrIx(100005)]
		[AttrName("action-temporal-association-reference-duration")]
		[AttrColumnName("ref_dur")]
        [AttrSeqnr(5)]
        [DomId(100000700)]
        [DataLength(19)]
        [DataDecimals(0)]
        decimal? ReferenceDuration { get; set; }
		
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
