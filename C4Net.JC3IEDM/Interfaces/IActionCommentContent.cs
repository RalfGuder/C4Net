using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionCommentContent that represents the table ACT_CMT_CNTNT
	/// 
	/// The actual text that comprises the comments for a single ACTION-COMMENT.
    /// </summary>
	[EntId(10000366)]
    [EntName("ACTION-COMMENT-CONTENT")]
    [EntTableName("ACT_CMT_CNTNT")]
    [EntDepth(4)]
    public interface IActionCommentContent
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
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionCommentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_cmt_cntnt_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-COMMENT-CONTENT for a specific ACTION-COMMENT and to distinguish it from all other ACTION-COMMENT-CONTENTs for that ACTION-COMMENT.
        /// </summary>
        /// <value>
        /// Value of the column act_cmt_cntnt_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-comment-content-index")]
		[AttrColumnName("act_cmt_cntnt_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column txt
		///
		/// The character string assigned to represent a general comment about a specific ACTION.
        /// </summary>
        /// <value>
        /// Value of the column txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-comment-content-text")]
		[AttrColumnName("txt")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100001500)]
        [DataLength(2000)]
        [DataDecimals(0)]
        string Text { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column seq_ord
		///
		/// The integer value that indicates the relative order of an ACTION-COMMENT-CONTENT entry.
        /// </summary>
        /// <value>
        /// Value of the column seq_ord
        /// </value>
        [AttrIx(100005)]
		[AttrName("action-comment-content-sequence-ordinal")]
		[AttrColumnName("seq_ord")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100002200)]
        [DataLength(2)]
        [DataDecimals(0)]
        short SequenceOrdinal { get; set; }
		
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
