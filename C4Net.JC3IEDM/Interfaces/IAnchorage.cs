using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Anchorage that represents the table ANCHR
	/// 
	/// A FACILITY that is a place where vessels anchor.
    /// </summary>
	[EntId(10000263)]
    [EntName("ANCHORAGE")]
    [EntTableName("ANCHR")]
    [EntDepth(3)]
    public interface IAnchorage
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column anchr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column anchr_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("anchorage-id")]
		[AttrColumnName("anchr_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column btm_type_code
		///
		/// The specific value that represents the description of the ground under the water of a lake, river, ocean, or other body of water at a specific ANCHORAGE.
        /// </summary>
        /// <value>
        /// Value of the column btm_type_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("anchorage-bottom-type-code")]
		[AttrColumnName("btm_type_code")]
        [AttrSeqnr(2)]
        [DomId(100004175)]
        [DataLength(6)]
        [DataDecimals(0)]
        AnchorageBottomTypeEnum? BottomType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column day_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the ANCHORAGE during the day. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column day_limit_net_expl_qty
        /// </value>
        [AttrIx(100003)]
		[AttrName("anchorage-day-limit-net-explosive-quantity")]
		[AttrColumnName("day_limit_net_expl_qty")]
        [AttrSeqnr(3)]
        [DomId(100001200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? DayLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column draught_high_tide_dim
		///
		/// The one-dimensional linear distance representing the maximum draught of vessel at high tide that the specific ANCHORAGE can accommodate.
        /// </summary>
        /// <value>
        /// Value of the column draught_high_tide_dim
        /// </value>
        [AttrIx(100004)]
		[AttrName("anchorage-draught-high-tide-dimension")]
		[AttrColumnName("draught_high_tide_dim")]
        [AttrSeqnr(4)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? DraughtHighTideDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column draught_low_tide_dim
		///
		/// The one-dimensional linear distance representing the maximum draught of vessel at low tide that the specific ANCHORAGE can accommodate.
        /// </summary>
        /// <value>
        /// Value of the column draught_low_tide_dim
        /// </value>
        [AttrIx(100005)]
		[AttrName("anchorage-draught-low-tide-dimension")]
		[AttrColumnName("draught_low_tide_dim")]
        [AttrSeqnr(5)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? DraughtLowTideDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column moorings_type_code
		///
		/// The specific value that represents the class of mooring available at the specific ANCHORAGE.
        /// </summary>
        /// <value>
        /// Value of the column moorings_type_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("anchorage-moorings-type-code")]
		[AttrColumnName("moorings_type_code")]
        [AttrSeqnr(6)]
        [DomId(100004176)]
        [DataLength(6)]
        [DataDecimals(0)]
        AnchorageMooringsTypeEnum? MooringsType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column night_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the ANCHORAGE during the night. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column night_limit_net_expl_qty
        /// </value>
        [AttrIx(100007)]
		[AttrName("anchorage-night-limit-net-explosive-quantity")]
		[AttrColumnName("night_limit_net_expl_qty")]
        [AttrSeqnr(7)]
        [DomId(100001200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? NightLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prvl_wind_dir_code
		///
		/// The specific value that represents the direction of the wind that most frequently occurs for the specific ANCHORAGE.
        /// </summary>
        /// <value>
        /// Value of the column prvl_wind_dir_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("anchorage-prevailing-wind-direction-code")]
		[AttrColumnName("prvl_wind_dir_code")]
        [AttrSeqnr(8)]
        [DomId(100000222)]
        [DataLength(6)]
        [DataDecimals(0)]
        DirectionEnum? PrevailingWindDirection { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vessel_tong_qty
		///
		/// The numeric value that represents the maximum tonnage of a vessel that can be accommodated at a specific ANCHORAGE. The unit of measure is metric ton.
        /// </summary>
        /// <value>
        /// Value of the column vessel_tong_qty
        /// </value>
        [AttrIx(100009)]
		[AttrName("anchorage-vessel-tonnage-quantity")]
		[AttrColumnName("vessel_tong_qty")]
        [AttrSeqnr(9)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? VesselTonnageQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100010)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(10)]
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
        [AttrIx(100011)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(11)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
