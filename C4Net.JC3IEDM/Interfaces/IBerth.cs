using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Berth that represents the table BERTH
	/// 
	/// A FACILITY that is a space or length in the water at a harbour allocated to or reserved for a vessel to dock and moor for loading or unloading.
    /// </summary>
	[EntId(10000265)]
    [EntName("BERTH")]
    [EntTableName("BERTH")]
    [EntDepth(3)]
    public interface IBerth
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column berth_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column berth_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("berth-id")]
		[AttrColumnName("berth_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ddw_tong_qty
		///
		/// The numeric value that represents the maximum deadweight tonnage that can be accommodated for a vessel at the specific BERTH. The unit of measure is metric ton.
        /// </summary>
        /// <value>
        /// Value of the column ddw_tong_qty
        /// </value>
        [AttrIx(100002)]
		[AttrName("berth-deadweight-tonnage-quantity")]
		[AttrColumnName("ddw_tong_qty")]
        [AttrSeqnr(2)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? DeadweightTonnageQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column depth_dim
		///
		/// The one-dimensional linear distance representing the depth of water available at the BERTH at low tide.
        /// </summary>
        /// <value>
        /// Value of the column depth_dim
        /// </value>
        [AttrIx(100003)]
		[AttrName("berth-depth-dimension")]
		[AttrColumnName("depth_dim")]
        [AttrSeqnr(3)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? DepthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column loc_txt
		///
		/// The character string assigned to represent a statement of the details that relate to the specific BERTH.
        /// </summary>
        /// <value>
        /// Value of the column loc_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("berth-location-text")]
		[AttrColumnName("loc_txt")]
        [AttrSeqnr(4)]
        [DomId(100001500)]
        [DataLength(255)]
        [DataDecimals(0)]
        string LocationText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column major_vessel_class_code
		///
		/// The specific value that represents the class of vessels to be serviced.
        /// </summary>
        /// <value>
        /// Value of the column major_vessel_class_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("berth-major-vessel-class-code")]
		[AttrColumnName("major_vessel_class_code")]
        [AttrSeqnr(5)]
        [DomId(100004288)]
        [DataLength(6)]
        [DataDecimals(0)]
        BerthMajorVesselClassEnum? MajorVesselClass { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_beam_dim
		///
		/// The one-dimensional linear distance representing the width athwartships, including all projections, of the largest vessel a specific BERTH can process.
        /// </summary>
        /// <value>
        /// Value of the column max_beam_dim
        /// </value>
        [AttrIx(100006)]
		[AttrName("berth-maximum-beam-dimension")]
		[AttrColumnName("max_beam_dim")]
        [AttrSeqnr(6)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? MaximumBeamDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_cap_qty
		///
		/// The numeric value that represents the maximum tonnage a specific BERTH can process per day. The unit of measure is Gross Registered Tonnage (GRT).
        /// </summary>
        /// <value>
        /// Value of the column max_cap_qty
        /// </value>
        [AttrIx(100007)]
		[AttrName("berth-maximum-capacity-quantity")]
		[AttrColumnName("max_cap_qty")]
        [AttrSeqnr(7)]
        [DomId(100001200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? MaximumCapacityQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_vessel_cnt
		///
		/// The integer value representing the maximum number of vessels a specific BERTH can process at the same time.
        /// </summary>
        /// <value>
        /// Value of the column max_vessel_cnt
        /// </value>
        [AttrIx(100008)]
		[AttrName("berth-maximum-vessel-count")]
		[AttrColumnName("max_vessel_cnt")]
        [AttrSeqnr(8)]
        [DomId(100001800)]
        [DataLength(2)]
        [DataDecimals(0)]
        short? MaximumVesselCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column day_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the BERTH during the day. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column day_limit_net_expl_qty
        /// </value>
        [AttrIx(100009)]
		[AttrName("berth-day-limit-net-explosive-quantity")]
		[AttrColumnName("day_limit_net_expl_qty")]
        [AttrSeqnr(9)]
        [DomId(100001200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? DayLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column night_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the BERTH during the night. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column night_limit_net_expl_qty
        /// </value>
        [AttrIx(100010)]
		[AttrName("berth-night-limit-net-explosive-quantity")]
		[AttrColumnName("night_limit_net_expl_qty")]
        [AttrSeqnr(10)]
        [DomId(100001200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? NightLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rail_avlbty_ind_code
		///
		/// The specific value that represents the availability of railroad transportation capability at a specific BERTH.
        /// </summary>
        /// <value>
        /// Value of the column rail_avlbty_ind_code
        /// </value>
        [AttrIx(100011)]
		[AttrName("berth-rail-availability-indicator-code")]
		[AttrColumnName("rail_avlbty_ind_code")]
        [AttrSeqnr(11)]
        [DomId(100004289)]
        [DataLength(6)]
        [DataDecimals(0)]
        BerthRailAvailabilityIndicatorEnum? RailAvailabilityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column roll_on_roll_off_ind_code
		///
		/// The specific value that represents whether or not the BERTH has roll on/roll off capabilities.
        /// </summary>
        /// <value>
        /// Value of the column roll_on_roll_off_ind_code
        /// </value>
        [AttrIx(100012)]
		[AttrName("berth-roll-on-roll-off-indicator-code")]
		[AttrColumnName("roll_on_roll_off_ind_code")]
        [AttrSeqnr(12)]
        [DomId(100004290)]
        [DataLength(6)]
        [DataDecimals(0)]
        BerthRollOnRollOffIndicatorEnum? RollOnRollOffIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column turnaround_time_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds representing the average units of time for the process of docking, unloading, reloading and undocking a ship for a specific BERTH.
        /// </summary>
        /// <value>
        /// Value of the column turnaround_time_dur
        /// </value>
        [AttrIx(100013)]
		[AttrName("berth-turnaround-time-duration")]
		[AttrColumnName("turnaround_time_dur")]
        [AttrSeqnr(13)]
        [DomId(100000700)]
        [DataLength(19)]
        [DataDecimals(0)]
        decimal? TurnaroundTimeDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100014)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(14)]
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
        [AttrIx(100015)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(15)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
