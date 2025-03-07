using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity PlanOrderComponentContentReference that represents the table POC_CNTNT_REF
	/// 
	/// The identification of a specific REFERENCE that applies to the given PLAN-ORDER-COMPONENT-CONTENT.
    /// </summary>
	[EntId(10000350)]
    [EntName("PLAN-ORDER-COMPONENT-CONTENT-REFERENCE")]
    [EntTableName("POC_CNTNT_REF")]
    [EntDepth(3)]
    public interface IPlanOrderComponentContentReference
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
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal PlanOrderComponentContentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poc_cntnt_ref_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-COMPONENT-CONTENT-REFERENCE for a specific PLAN-ORDER-COMPONENT-CONTENT and to distinguish it from all other PLAN-ORDER-COMPONENT-CONTENT-REFERENCEs for that PLAN-ORDER-COMPONENT-CONTENT.
        /// </summary>
        /// <value>
        /// Value of the column poc_cntnt_ref_ix
        /// </value>
        [AttrIx(100004)]
		[AttrName("plan-order-component-content-reference-index")]
		[AttrColumnName("poc_cntnt_ref_ix")]
        [AttrSeqnr(4)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the reason a specific REFERENCE is associated to a specific PLAN-ORDER-COMPONENT-CONTENT.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("plan-order-component-content-reference-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100004388)]
        [DataLength(6)]
        [DataDecimals(0)]
        PlanOrderComponentContentReferenceCategoryEnum PlanOrderComponentContentReferenceCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing the point in time when a specific REFERENCE is associated with a specific PLAN-ORDER-COMPONENT-CONTENT.
        /// </summary>
        /// <value>
        /// Value of the column dttm
        /// </value>
        [AttrIx(100006)]
		[AttrName("plan-order-component-content-reference-datetime")]
		[AttrColumnName("dttm")]
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string Datetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ref_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REFERENCE and to distinguish it from all other REFERENCEs.
        /// </summary>
        /// <value>
        /// Value of the column ref_id
        /// </value>
        [AttrIx(100007)]
		[AttrName("reference-id")]
		[AttrColumnName("ref_id")]
        [AttrSeqnr(7)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000911)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ReferenceId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(8)]
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
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(9)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
