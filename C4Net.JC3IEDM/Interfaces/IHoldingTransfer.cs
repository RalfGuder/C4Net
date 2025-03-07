using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity HoldingTransfer that represents the table HOLDING_TRNSF
	/// 
	/// The specification of the OBJECT-TYPE quantity expected to be added to or subtracted from a specific HOLDING.
    /// </summary>
	[EntId(10000328)]
    [EntName("HOLDING-TRANSFER")]
    [EntTableName("HOLDING_TRNSF")]
    [EntDepth(4)]
    public interface IHoldingTransfer
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("object-item-id")]
		[AttrColumnName("obj_item_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column obj_type_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("object-type-id")]
		[AttrColumnName("obj_type_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectTypeId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column holding_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific HOLDING for a specific OBJECT-ITEM and a specific OBJECT-TYPE and to distinguish it from all other HOLDINGs for that OBJECT-ITEM and that OBJECT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column holding_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("holding-index")]
		[AttrColumnName("holding_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal HoldingIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column holding_trnsf_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific HOLDING-TRANSFER for a specific HOLDING and to distinguish it from all other HOLDING-TRANSFERs for that HOLDING.
        /// </summary>
        /// <value>
        /// Value of the column holding_trnsf_ix
        /// </value>
        [AttrIx(100004)]
		[AttrName("holding-transfer-index")]
		[AttrColumnName("holding_trnsf_ix")]
        [AttrSeqnr(4)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column reason_code
		///
		/// The specific value that characterises the basis for a specific HOLDING-TRANSFER.
        /// </summary>
        /// <value>
        /// Value of the column reason_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("holding-transfer-reason-code")]
		[AttrColumnName("reason_code")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100004329)]
        [DataLength(6)]
        [DataDecimals(0)]
        HoldingTransferReasonEnum Reason { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qty
		///
		/// The numeric value representing the quantity of specific OBJECT-TYPE involved in a specific HOLDING-TRANSFER. A negative quantity decreases the HOLDING and a positive quantity increases the HOLDING.
        /// </summary>
        /// <value>
        /// Value of the column qty
        /// </value>
        [AttrIx(100006)]
		[AttrName("holding-transfer-quantity")]
		[AttrColumnName("qty")]
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int Quantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column holding_trnsf_crsp_obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column holding_trnsf_crsp_obj_item_id
        /// </value>
        [AttrIx(100007)]
		[AttrName("holding-transfer-corresponding-object-item-id")]
		[AttrColumnName("holding_trnsf_crsp_obj_item_id")]
        [AttrSeqnr(7)]
        [ForeignKey]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? CorrespondingObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
        [AttrIx(100008)]
		[AttrName("reporting-data-id")]
		[AttrColumnName("rptd_id")]
        [AttrSeqnr(8)]
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
