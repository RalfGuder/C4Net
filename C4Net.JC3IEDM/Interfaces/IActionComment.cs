using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionComment that represents the table ACT_CMT
	/// 
	/// A comment that adds information about a specific ACTION.
    /// </summary>
	[EntId(10000356)]
    [EntName("ACTION-COMMENT")]
    [EntTableName("ACT_CMT")]
    [EntDepth(3)]
    public interface IActionComment
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("action-id")]
		[AttrColumnName("act_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_cmt_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-COMMENT for a specific ACTION and to distinguish it from all other ACTION-COMMENTs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_cmt_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-comment-index")]
		[AttrColumnName("act_cmt_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column symbol_annotation_txt
		///
		/// The character string assigned to represent symbology annotation for an ACTION in accordance with symbology representation (e.g. APP-6A).
        /// </summary>
        /// <value>
        /// Value of the column symbol_annotation_txt
        /// </value>
        [AttrIx(100008)]
		[AttrName("action-comment-symbol-annotation-text")]
		[AttrColumnName("symbol_annotation_txt")]
        [AttrSeqnr(3)]
        [DomId(100001500)]
        [DataLength(20)]
        [DataDecimals(0)]
        string SymbolAnnotationText { get; set; }
		
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
        [AttrSeqnr(4)]
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
        [AttrSeqnr(5)]
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
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
