using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity RequestAnswerElement that represents the table REQUEST_ANS_ELMT
	/// 
	/// A relationship between a specific REQUEST-ANSWER and a specific REPORTING-DATA that provides linkage to amplifying information for a REQUEST-ANSWER.
    /// </summary>
	[EntId(10000114)]
    [EntName("REQUEST-ANSWER-ELEMENT")]
    [EntTableName("REQUEST_ANS_ELMT")]
    [EntDepth(7)]
    public interface IRequestAnswerElement
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column request_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column request_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("request-id")]
		[AttrColumnName("request_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal RequestId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column request_ans_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific REQUEST-ANSWER for a specific REQUEST and to distinguish it from all other REQUEST-ANSWERs for that REQUEST.
        /// </summary>
        /// <value>
        /// Value of the column request_ans_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("request-answer-index")]
		[AttrColumnName("request_ans_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal RequestAnswerIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column comprising_rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column comprising_rptd_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("comprising-reporting-data-id")]
		[AttrColumnName("comprising_rptd_id")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000912)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ComprisingReportingDataId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100004)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(4)]
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
        [AttrIx(100005)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
