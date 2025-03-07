using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ObjectItemStatus that represents the table OBJ_ITEM_STAT
	/// 
	/// A record of the perceived condition of a specific OBJECT-ITEM as determined by the reporting organisation.
    /// </summary>
	[EntId(10000080)]
    [EntName("OBJECT-ITEM-STATUS")]
    [EntTableName("OBJ_ITEM_STAT")]
    [EntDepth(3)]
    public interface IObjectItemStatus
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
        /// Gets or sets the value of the column obj_item_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-STATUS for a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-STATUSs for that OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_stat_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("object-item-status-index")]
		[AttrColumnName("obj_item_stat_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of OBJECT-ITEM-STATUS. It serves as a discriminator that partitions OBJECT-ITEM-STATUS into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("object-item-status-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000146)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectItemStatusCategoryEnum ObjectItemStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column booby_trap_prsnc_code
		///
		/// The specific value that indicates whether a specific OBJECT-ITEM has been booby-trapped.
        /// </summary>
        /// <value>
        /// Value of the column booby_trap_prsnc_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("object-item-status-booby-trap-presence-code")]
		[AttrColumnName("booby_trap_prsnc_code")]
        [AttrSeqnr(4)]
        [DomId(100000385)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectItemStatusBoobyTrapPresenceEnum? BoobyTrapPresence { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column emsn_ctrl_code
		///
		/// The specific value that represents the emission control status of a specific OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column emsn_ctrl_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("object-item-status-emission-control-code")]
		[AttrColumnName("emsn_ctrl_code")]
        [AttrSeqnr(5)]
        [DomId(100004158)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectItemStatusEmissionControlEnum? EmissionControl { get; set; }
		
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
        [AttrSeqnr(7)]
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
        [AttrSeqnr(8)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
