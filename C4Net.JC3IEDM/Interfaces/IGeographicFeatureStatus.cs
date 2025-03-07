using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity GeographicFeatureStatus that represents the table GFEAT_STAT
	/// 
	/// An OBJECT-ITEM-STATUS that is a record of condition of a specific GEOGRAPHIC-FEATURE.
    /// </summary>
	[EntId(10000134)]
    [EntName("GEOGRAPHIC-FEATURE-STATUS")]
    [EntTableName("GFEAT_STAT")]
    [EntDepth(4)]
    public interface IGeographicFeatureStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column gfeat_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column gfeat_stat_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("geographic-feature-status-id")]
		[AttrColumnName("gfeat_stat_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
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
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemStatusIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of GEOGRAPHIC-FEATURE-STATUS. It serves as a discriminator that partitions GEOGRAPHIC-FEATURE-STATUS into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("geographic-feature-status-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100004209)]
        [DataLength(6)]
        [DataDecimals(0)]
        GeographicFeatureStatusCategoryEnum GeographicFeatureStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mine_prsnc_code
		///
		/// The specific value that indicates whether a specific GEOGRAPHIC-FEATURE contains mines.
        /// </summary>
        /// <value>
        /// Value of the column mine_prsnc_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("geographic-feature-status-mine-presence-code")]
		[AttrColumnName("mine_prsnc_code")]
        [AttrSeqnr(4)]
        [DomId(100000313)]
        [DataLength(6)]
        [DataDecimals(0)]
        MinePresenceEnum? MinePresence { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column surf_recirc_ind_code
		///
		/// The specific value that indicates whether the surface will recirculate as a result of rotor downwash.
        /// </summary>
        /// <value>
        /// Value of the column surf_recirc_ind_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("geographic-feature-status-surface-recirculation-indicator-code")]
		[AttrColumnName("surf_recirc_ind_code")]
        [AttrSeqnr(5)]
        [DomId(100000309)]
        [DataLength(6)]
        [DataDecimals(0)]
        GeographicFeatureStatusSurfaceRecirculationIndicatorEnum? SurfaceRecirculationIndicator { get; set; }
		
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
