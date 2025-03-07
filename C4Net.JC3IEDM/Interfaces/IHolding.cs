using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Holding that represents the table HOLDING
	/// 
	/// The quantity of each specific OBJECT-TYPE that is held by, installed in, or included with a specific OBJECT-ITEM.
    /// </summary>
	[EntId(10000058)]
    [EntName("HOLDING")]
    [EntTableName("HOLDING")]
    [EntDepth(3)]
    public interface IHolding
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
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_cnt
		///
		/// The integer value representing the number of specific OBJECT-TYPEs a specific OBJECT-ITEM has available for operations.
        /// </summary>
        /// <value>
        /// Value of the column operat_cnt
        /// </value>
        [AttrIx(100004)]
		[AttrName("holding-operational-count")]
		[AttrColumnName("operat_cnt")]
        [AttrSeqnr(4)]
        [DomId(100001800)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? OperationalCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column total_qty
		///
		/// The numeric value representing the total quantity, to include reserves, of specific OBJECT-TYPEs physically held by a specific OBJECT-ITEM. The unit of measure is derived from the OBJECT-TYPE specification.
        /// </summary>
        /// <value>
        /// Value of the column total_qty
        /// </value>
        [AttrIx(100005)]
		[AttrName("holding-total-quantity")]
		[AttrColumnName("total_qty")]
        [AttrSeqnr(5)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? TotalQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column on_hand_qty
		///
		/// The numeric value representing the quantity of specific OBJECT-TYPEs physically held on-hand, not including reserves, by a specific OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column on_hand_qty
        /// </value>
        [AttrIx(100006)]
		[AttrName("holding-on-hand-quantity")]
		[AttrColumnName("on_hand_qty")]
        [AttrSeqnr(6)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? OnHandQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column req_total_qty
		///
		/// The numeric value representing the total quantity of specific OBJECT-TYPEs required to be held on-hand and in reserve by a specific OBJECT-ITEM to meet the NATO assigned task in accordance with Force Standards or established mission requirements.
        /// </summary>
        /// <value>
        /// Value of the column req_total_qty
        /// </value>
        [AttrIx(100007)]
		[AttrName("holding-required-total-quantity")]
		[AttrColumnName("req_total_qty")]
        [AttrSeqnr(7)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? RequiredTotalQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column req_on_hand_qty
		///
		/// The numeric value representing the quantity of specific OBJECT-TYPEs, not including reserves, required to be held on-hand by a specific OBJECT-ITEM in accordance with Force Standards or established mission requirements.
        /// </summary>
        /// <value>
        /// Value of the column req_on_hand_qty
        /// </value>
        [AttrIx(100008)]
		[AttrName("holding-required-on-hand-quantity")]
		[AttrColumnName("req_on_hand_qty")]
        [AttrSeqnr(8)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? RequiredOnHandQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column req_mthd_calc_code
		///
		/// The specific value that represents the required stocks calculation method used for the count of OBJECT-TYPEs in a specific HOLDING.
        /// </summary>
        /// <value>
        /// Value of the column req_mthd_calc_code
        /// </value>
        [AttrIx(100009)]
		[AttrName("holding-required-calculation-method-code")]
		[AttrColumnName("req_mthd_calc_code")]
        [AttrSeqnr(9)]
        [DomId(100004330)]
        [DataLength(6)]
        [DataDecimals(0)]
        HoldingRequiredCalculationMethodEnum? RequiredCalculationMethod { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
        [AttrIx(100010)]
		[AttrName("reporting-data-id")]
		[AttrColumnName("rptd_id")]
        [AttrSeqnr(10)]
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
        [AttrIx(100011)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(11)]
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
        [AttrIx(100012)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(12)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
