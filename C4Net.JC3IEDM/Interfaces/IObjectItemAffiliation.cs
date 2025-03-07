using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ObjectItemAffiliation that represents the table OBJ_ITEM_AFFL
	/// 
	/// A relationship between a specific OBJECT-ITEM and a specific AFFILIATION. Note:  This entity is intended to record exceptions to affiliations identified in OBJECT-TYPE. Consequently, the native, normal or expected affiliation is identified by associating the item with an appropriate type.
    /// </summary>
	[EntId(10000260)]
    [EntName("OBJECT-ITEM-AFFILIATION")]
    [EntTableName("OBJ_ITEM_AFFL")]
    [EntDepth(3)]
    public interface IObjectItemAffiliation
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
        /// Gets or sets the value of the column affl_id
		///
		/// The unique value, or set of characters, assigned to represent a specific AFFILIATION and to distinguish it from all other AFFILIATIONs.
        /// </summary>
        /// <value>
        /// Value of the column affl_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("affiliation-id")]
		[AttrColumnName("affl_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000919)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal AffiliationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_affl_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-AFFILIATION for a specific OBJECT-ITEM and a specific AFFILIATION and to distinguish it from all other OBJECT-ITEM-AFFILIATIONs for that OBJECT-ITEM and that AFFILIATION.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_affl_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("object-item-affiliation-index")]
		[AttrColumnName("obj_item_affl_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
        [AttrIx(100004)]
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
        [AttrIx(100005)]
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
        [AttrIx(100006)]
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
