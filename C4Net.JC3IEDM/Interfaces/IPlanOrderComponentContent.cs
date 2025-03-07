using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity PlanOrderComponentContent that represents the table POC_CNTNT
	/// 
	/// The aggregation of substantive subject matter for a specific PLAN-ORDER-COMPONENT.
    /// </summary>
	[EntId(10000349)]
    [EntName("PLAN-ORDER-COMPONENT-CONTENT")]
    [EntTableName("POC_CNTNT")]
    [EntDepth(2)]
    public interface IPlanOrderComponentContent
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column pln_ordr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column pln_ordr_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("plan-order-id")]
		[AttrColumnName("pln_ordr_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000933)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal PlanOrderId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-COMPONENT for a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDER-COMPONENTs for that PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column poc_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("plan-order-component-index")]
		[AttrColumnName("poc_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal PlanOrderComponentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poc_cntnt_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-COMPONENT-CONTENT for a specific PLAN-ORDER-COMPONENT and to distinguish it from all other PLAN-ORDER-COMPONENT-CONTENTs for that PLAN-ORDER-COMPONENT.
        /// </summary>
        /// <value>
        /// Value of the column poc_cntnt_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("plan-order-component-content-index")]
		[AttrColumnName("poc_cntnt_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing the point in time when PLAN-ORDER-COMPONENT-CONTENT is defined.
        /// </summary>
        /// <value>
        /// Value of the column dttm
        /// </value>
        [AttrIx(100004)]
		[AttrName("plan-order-component-content-datetime")]
		[AttrColumnName("dttm")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string Datetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column seq_ord
		///
		/// The sequence number in a specific PLAN-ORDER-COMPONENT-CONTENT that permits the proper ordering of the components of a PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column seq_ord
        /// </value>
        [AttrIx(100005)]
		[AttrName("plan-order-component-content-sequence-ordinal")]
		[AttrColumnName("seq_ord")]
        [AttrSeqnr(5)]
        [DomId(100002200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? SequenceOrdinal { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cmpnt_hdr_cntnt_id
		///
		/// The unique value, or set of characters, assigned to represent a specific COMPONENT-HEADER-CONTENT and to distinguish it from all other COMPONENT-HEADER-CONTENTs.
        /// </summary>
        /// <value>
        /// Value of the column cmpnt_hdr_cntnt_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("component-header-content-id")]
		[AttrColumnName("cmpnt_hdr_cntnt_id")]
        [AttrSeqnr(6)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000931)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ComponentHeaderContentId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cmpnt_txt_cntnt_id
		///
		/// The unique value, or set of characters, assigned to represent a specific COMPONENT-TEXT-CONTENT and to distinguish it from all other COMPONENT-TEXT-CONTENTs.
        /// </summary>
        /// <value>
        /// Value of the column cmpnt_txt_cntnt_id
        /// </value>
        [AttrIx(100007)]
		[AttrName("component-text-content-id")]
		[AttrColumnName("cmpnt_txt_cntnt_id")]
        [AttrSeqnr(7)]
        [ForeignKey]
        [DomId(100000932)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? ComponentTextContentId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poc_cntnt_data_contxt_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CONTEXT and to distinguish it from all other CONTEXTs.
        /// </summary>
        /// <value>
        /// Value of the column poc_cntnt_data_contxt_id
        /// </value>
        [AttrIx(100008)]
		[AttrName("plan-order-component-content-data-context-id")]
		[AttrColumnName("poc_cntnt_data_contxt_id")]
        [AttrSeqnr(8)]
        [ForeignKey]
        [DomId(100000901)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? DataContextId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100009)]
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
        [AttrIx(100010)]
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
