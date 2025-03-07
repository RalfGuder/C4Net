using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity LiquidSurfaceStatus that represents the table LQD_SURF_STAT
	/// 
	/// A GEOGRAPHIC-FEATURE-STATUS that is a record of condition of a specific liquid surface.
    /// </summary>
	[EntId(10000278)]
    [EntName("LIQUID-SURFACE-STATUS")]
    [EntTableName("LQD_SURF_STAT")]
    [EntDepth(5)]
    public interface ILiquidSurfaceStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column lqd_surf_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column lqd_surf_stat_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("liquid-surface-status-id")]
		[AttrColumnName("lqd_surf_stat_id")]
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
        /// Gets or sets the value of the column sea_state_code
		///
		/// The specific value that represents a range of wave heights on a specific liquid surface.
        /// </summary>
        /// <value>
        /// Value of the column sea_state_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("liquid-surface-status-sea-state-code")]
		[AttrColumnName("sea_state_code")]
        [AttrSeqnr(3)]
        [DomId(100004210)]
        [DataLength(6)]
        [DataDecimals(0)]
        LiquidSurfaceStatusSeaStateEnum? SeaState { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column surf_cond_code
		///
		/// The specific value that represents the physical status of a liquid surface area.
        /// </summary>
        /// <value>
        /// Value of the column surf_cond_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("liquid-surface-status-surface-condition-code")]
		[AttrColumnName("surf_cond_code")]
        [AttrSeqnr(4)]
        [DomId(100004255)]
        [DataLength(6)]
        [DataDecimals(0)]
        LiquidSurfaceStatusSurfaceConditionEnum? SurfaceCondition { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column wave_dir_code
		///
		/// The specific value that represents the direction of waves in a specific liquid surface.
        /// </summary>
        /// <value>
        /// Value of the column wave_dir_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("liquid-surface-status-wave-direction-code")]
		[AttrColumnName("wave_dir_code")]
        [AttrSeqnr(5)]
        [DomId(100000222)]
        [DataLength(6)]
        [DataDecimals(0)]
        DirectionEnum? WaveDirection { get; set; }
		
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
