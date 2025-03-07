using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Jetty that represents the table JETTY
	/// 
	/// A FACILITY that is a platform that may be fixed or floating extending from a shore, normally attached to a wharf or the shore, and which allows access to a vessel lying alongside, used to secure, protect and provide landing and docking for vessels.
    /// </summary>
	[EntId(10000267)]
    [EntName("JETTY")]
    [EntTableName("JETTY")]
    [EntDepth(3)]
    public interface IJetty
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column jetty_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column jetty_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("jetty-id")]
		[AttrColumnName("jetty_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column day_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the JETTY during the day. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column day_limit_net_expl_qty
        /// </value>
        [AttrIx(100002)]
		[AttrName("jetty-day-limit-net-explosive-quantity")]
		[AttrColumnName("day_limit_net_expl_qty")]
        [AttrSeqnr(2)]
        [DomId(100001200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? DayLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_ddw_tong_qty
		///
		/// The numeric value that represents the maximum deadweight tonnage for a vessel at the specific JETTY. The unit of measure is metric ton.
        /// </summary>
        /// <value>
        /// Value of the column max_ddw_tong_qty
        /// </value>
        [AttrIx(100003)]
		[AttrName("jetty-maximum-deadweight-tonnage-quantity")]
		[AttrColumnName("max_ddw_tong_qty")]
        [AttrSeqnr(3)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? MaximumDeadweightTonnageQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_draught_dim
		///
		/// The one-dimensional linear distance representing the maximum draught of vessel that the specific JETTY can accommodate.
        /// </summary>
        /// <value>
        /// Value of the column max_draught_dim
        /// </value>
        [AttrIx(100004)]
		[AttrName("jetty-maximum-draught-dimension")]
		[AttrColumnName("max_draught_dim")]
        [AttrSeqnr(4)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? MaximumDraughtDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column night_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the JETTY during the night. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column night_limit_net_expl_qty
        /// </value>
        [AttrIx(100005)]
		[AttrName("jetty-night-limit-net-explosive-quantity")]
		[AttrColumnName("night_limit_net_expl_qty")]
        [AttrSeqnr(5)]
        [DomId(100001200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? NightLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rail_cap_cnt
		///
		/// The integer value that represents the maximum number of goods/freight cars that the JETTY can accommodate at the same time.
        /// </summary>
        /// <value>
        /// Value of the column rail_cap_cnt
        /// </value>
        [AttrIx(100006)]
		[AttrName("jetty-rail-capacity-count")]
		[AttrColumnName("rail_cap_cnt")]
        [AttrSeqnr(6)]
        [DomId(100001800)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? RailCapacityCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rail_served_ind_code
		///
		/// The specific value that represents whether the JETTY has railway facilities.
        /// </summary>
        /// <value>
        /// Value of the column rail_served_ind_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("jetty-rail-served-indicator-code")]
		[AttrColumnName("rail_served_ind_code")]
        [AttrSeqnr(7)]
        [DomId(100004179)]
        [DataLength(6)]
        [DataDecimals(0)]
        JettyRailServedIndicatorEnum? RailServedIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vessel_max_beam_dim
		///
		/// The one-dimensional linear distance representing the maximum beam or width of vessel that the specific JETTY can accommodate.
        /// </summary>
        /// <value>
        /// Value of the column vessel_max_beam_dim
        /// </value>
        [AttrIx(100008)]
		[AttrName("jetty-vessel-maximum-beam-dimension")]
		[AttrColumnName("vessel_max_beam_dim")]
        [AttrSeqnr(8)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? VesselMaximumBeamDimension { get; set; }
		
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
