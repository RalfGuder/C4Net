using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Quay that represents the table QUAY
	/// 
	/// A FACILITY that is a solidly constructed platform, usually parallel to the shoreline of navigable water, alongside which a vessel can be docked or berthed and, on which, the vessel can be accessed and cargo can be loaded or unloaded on one side of the vessel only.
    /// </summary>
	[EntId(10000268)]
    [EntName("QUAY")]
    [EntTableName("QUAY")]
    [EntDepth(3)]
    public interface IQuay
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column quay_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column quay_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("quay-id")]
		[AttrColumnName("quay_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cntr_hndl_type_code
		///
		/// The specific value that represents the class of container handling equipment available at a specific QUAY.
        /// </summary>
        /// <value>
        /// Value of the column cntr_hndl_type_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("quay-container-handling-type-code")]
		[AttrColumnName("cntr_hndl_type_code")]
        [AttrSeqnr(2)]
        [DomId(100004180)]
        [DataLength(6)]
        [DataDecimals(0)]
        QuayContainerHandlingTypeEnum? ContainerHandlingType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cntr_max_hndl_length_dim
		///
		/// The one-dimensional linear distance representing the maximum length of a container that can be handled at the QUAY.
        /// </summary>
        /// <value>
        /// Value of the column cntr_max_hndl_length_dim
        /// </value>
        [AttrIx(100003)]
		[AttrName("quay-container-maximum-handling-length-dimension")]
		[AttrColumnName("cntr_max_hndl_length_dim")]
        [AttrSeqnr(3)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? ContainerMaximumHandlingLengthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cntr_max_hndl_wt_qty
		///
		/// The numeric value that represents the maximum container weight that can be handled at the QUAY. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column cntr_max_hndl_wt_qty
        /// </value>
        [AttrIx(100004)]
		[AttrName("quay-container-maximum-handling-weight-quantity")]
		[AttrColumnName("cntr_max_hndl_wt_qty")]
        [AttrSeqnr(4)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? ContainerMaximumHandlingWeightQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column crane_ofld_lift_qty
		///
		/// The numeric value that represents the maximum weight that can be handled by a crane at the QUAY. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column crane_ofld_lift_qty
        /// </value>
        [AttrIx(100005)]
		[AttrName("quay-crane-offloading-lift-quantity")]
		[AttrColumnName("crane_ofld_lift_qty")]
        [AttrSeqnr(5)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? CraneOffloadingLiftQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column crane_ofld_type_code
		///
		/// The specific value that represents the class of crane offloading equipment available at a specific QUAY.
        /// </summary>
        /// <value>
        /// Value of the column crane_ofld_type_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("quay-crane-offloading-type-code")]
		[AttrColumnName("crane_ofld_type_code")]
        [AttrSeqnr(6)]
        [DomId(100004181)]
        [DataLength(6)]
        [DataDecimals(0)]
        QuayCraneOffloadingTypeEnum? CraneOffloadingType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column day_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the QUAY during the day. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column day_limit_net_expl_qty
        /// </value>
        [AttrIx(100007)]
		[AttrName("quay-day-limit-net-explosive-quantity")]
		[AttrColumnName("day_limit_net_expl_qty")]
        [AttrSeqnr(7)]
        [DomId(100001200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? DayLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column draught_dim
		///
		/// The one-dimensional linear distance representing the maximum draught of vessel that the specific QUAY can accommodate.
        /// </summary>
        /// <value>
        /// Value of the column draught_dim
        /// </value>
        [AttrIx(100008)]
		[AttrName("quay-draught-dimension")]
		[AttrColumnName("draught_dim")]
        [AttrSeqnr(8)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? DraughtDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_ddw_tong_qty
		///
		/// The numeric value that represents the maximum deadweight tonnage that can be accommodated for a vessel at the specific QUAY. The unit of measure is metric ton.
        /// </summary>
        /// <value>
        /// Value of the column max_ddw_tong_qty
        /// </value>
        [AttrIx(100009)]
		[AttrName("quay-maximum-deadweight-tonnage-quantity")]
		[AttrColumnName("max_ddw_tong_qty")]
        [AttrSeqnr(9)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? MaximumDeadweightTonnageQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column night_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the QUAY during the night. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column night_limit_net_expl_qty
        /// </value>
        [AttrIx(100010)]
		[AttrName("quay-night-limit-net-explosive-quantity")]
		[AttrColumnName("night_limit_net_expl_qty")]
        [AttrSeqnr(10)]
        [DomId(100001200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? NightLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rail_cap_cnt
		///
		/// The integer value representing the maximum number of goods/freight cars that the QUAY can accommodate at the same time.
        /// </summary>
        /// <value>
        /// Value of the column rail_cap_cnt
        /// </value>
        [AttrIx(100011)]
		[AttrName("quay-rail-capacity-count")]
		[AttrColumnName("rail_cap_cnt")]
        [AttrSeqnr(11)]
        [DomId(100001800)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? RailCapacityCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rail_served_ind_code
		///
		/// The specific value that represents whether the QUAY has railway facilities.
        /// </summary>
        /// <value>
        /// Value of the column rail_served_ind_code
        /// </value>
        [AttrIx(100012)]
		[AttrName("quay-rail-served-indicator-code")]
		[AttrColumnName("rail_served_ind_code")]
        [AttrSeqnr(12)]
        [DomId(100004182)]
        [DataLength(6)]
        [DataDecimals(0)]
        QuayRailServedIndicatorEnum? RailServedIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column storage_code
		///
		/// The specific value that represents the class of storage facilities available at a specific QUAY.
        /// </summary>
        /// <value>
        /// Value of the column storage_code
        /// </value>
        [AttrIx(100013)]
		[AttrName("quay-storage-code")]
		[AttrColumnName("storage_code")]
        [AttrSeqnr(13)]
        [DomId(100004183)]
        [DataLength(6)]
        [DataDecimals(0)]
        QuayStorageEnum? Storage { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vessel_max_beam_dim
		///
		/// The one-dimensional linear distance representing the maximum beam or width of vessel that the specific QUAY can accommodate.
        /// </summary>
        /// <value>
        /// Value of the column vessel_max_beam_dim
        /// </value>
        [AttrIx(100014)]
		[AttrName("quay-vessel-maximum-beam-dimension")]
		[AttrColumnName("vessel_max_beam_dim")]
        [AttrSeqnr(14)]
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
        [AttrIx(100015)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(15)]
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
        [AttrIx(100016)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(16)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
