using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Convoy that represents the table CONVOY
	/// 
	/// An ORGANISATION that is a group of vehicles or vessels organised for the purpose of control and orderly movement with or without escort protection.
    /// </summary>
	[EntId(10000036)]
    [EntName("CONVOY")]
    [EntTableName("CONVOY")]
    [EntDepth(2)]
    public interface IConvoy
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column convoy_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column convoy_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("convoy-id")]
		[AttrColumnName("convoy_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column day_speed_rate
		///
		/// The numeric value that denotes the maximum distance per unit time that a specific CONVOY is to maintain during daylight operations. The unit of measure is kilometres per hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column day_speed_rate
        /// </value>
        [AttrIx(100002)]
		[AttrName("convoy-day-speed-rate")]
		[AttrColumnName("day_speed_rate")]
        [AttrSeqnr(2)]
        [DomId(100001300)]
        [DataLength(8)]
        [DataDecimals(4)]
        double? DaySpeedRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column day_vehicle_gap_dim
		///
		/// The one-dimensional linear distance representing the distance between vehicles in a particular CONVOY during daylight operations.
        /// </summary>
        /// <value>
        /// Value of the column day_vehicle_gap_dim
        /// </value>
        [AttrIx(100003)]
		[AttrName("convoy-day-vehicle-gap-dimension")]
		[AttrColumnName("day_vehicle_gap_dim")]
        [AttrSeqnr(3)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? DayVehicleGapDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column halt_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds representing the aggregated units of time that a specific CONVOY may remain stationary during operations.
        /// </summary>
        /// <value>
        /// Value of the column halt_dur
        /// </value>
        [AttrIx(100004)]
		[AttrName("convoy-halt-duration")]
		[AttrColumnName("halt_dur")]
        [AttrSeqnr(4)]
        [DomId(100000700)]
        [DataLength(19)]
        [DataDecimals(0)]
        decimal? HaltDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column night_speed_rate
		///
		/// The numeric value that denotes the maximum distance per unit time that a specific CONVOY is to maintain during operations in darkness. The unit of measure is kilometres per hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column night_speed_rate
        /// </value>
        [AttrIx(100005)]
		[AttrName("convoy-night-speed-rate")]
		[AttrColumnName("night_speed_rate")]
        [AttrSeqnr(5)]
        [DomId(100001300)]
        [DataLength(8)]
        [DataDecimals(4)]
        double? NightSpeedRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column night_vehicle_gap_dim
		///
		/// The one-dimensional linear distance representing the distance between vehicles in a particular CONVOY during operations in darkness.
        /// </summary>
        /// <value>
        /// Value of the column night_vehicle_gap_dim
        /// </value>
        [AttrIx(100006)]
		[AttrName("convoy-night-vehicle-gap-dimension")]
		[AttrColumnName("night_vehicle_gap_dim")]
        [AttrSeqnr(6)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? NightVehicleGapDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column packet_gap_dim
		///
		/// The one-dimensional linear distance representing the distance between packets in a particular CONVOY.
        /// </summary>
        /// <value>
        /// Value of the column packet_gap_dim
        /// </value>
        [AttrIx(100007)]
		[AttrName("convoy-packet-gap-dimension")]
		[AttrColumnName("packet_gap_dim")]
        [AttrSeqnr(7)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? PacketGapDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column packet_size_cnt
		///
		/// The integer value that represents the number of vehicles per packet in a particular CONVOY.
        /// </summary>
        /// <value>
        /// Value of the column packet_size_cnt
        /// </value>
        [AttrIx(100008)]
		[AttrName("convoy-packet-size-count")]
		[AttrColumnName("packet_size_cnt")]
        [AttrSeqnr(8)]
        [DomId(100001800)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? PacketSizeCount { get; set; }
		
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
