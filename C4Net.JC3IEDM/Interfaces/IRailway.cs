using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Railway that represents the table RAILWAY
	/// 
	/// A FACILITY that is a track or set of tracks made of steel rails along which trains run.
    /// </summary>
	[EntId(10000310)]
    [EntName("RAILWAY")]
    [EntTableName("RAILWAY")]
    [EntDepth(3)]
    public interface IRailway
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column railway_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column railway_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("railway-id")]
		[AttrColumnName("railway_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column track_gauge_code
		///
		/// The specific value that represents the distance between the internal sides of rails on a RAILWAY line.
        /// </summary>
        /// <value>
        /// Value of the column track_gauge_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("railway-track-gauge-code")]
		[AttrColumnName("track_gauge_code")]
        [AttrSeqnr(2)]
        [DomId(100004260)]
        [DataLength(6)]
        [DataDecimals(0)]
        RailwayTrackGaugeEnum? TrackGauge { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column track_cnt
		///
		/// The integer value representing the number of tracks on a RAILWAY line.
        /// </summary>
        /// <value>
        /// Value of the column track_cnt
        /// </value>
        [AttrIx(100003)]
		[AttrName("railway-track-count")]
		[AttrColumnName("track_cnt")]
        [AttrSeqnr(3)]
        [DomId(100001800)]
        [DataLength(4)]
        [DataDecimals(0)]
        short? TrackCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column train_density_cnt
		///
		/// The integer value representing the maximum number of trains, which can be moved in each direction over a specified section of track in a 24 hour period.
        /// </summary>
        /// <value>
        /// Value of the column train_density_cnt
        /// </value>
        [AttrIx(100004)]
		[AttrName("railway-train-density-count")]
		[AttrColumnName("train_density_cnt")]
        [AttrSeqnr(4)]
        [DomId(100001800)]
        [DataLength(4)]
        [DataDecimals(0)]
        short? TrainDensityCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column block_dist_dim
		///
		/// The one-dimensional linear distance representing the minimum length of the passing track intervals for single track lines or the safety margin related to the signalling system on double or multiple track lines.
        /// </summary>
        /// <value>
        /// Value of the column block_dist_dim
        /// </value>
        [AttrIx(100005)]
		[AttrName("railway-block-distance-dimension")]
		[AttrColumnName("block_dist_dim")]
        [AttrSeqnr(5)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? BlockDistanceDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column sleeper_density_dim
		///
		/// The one-dimensional linear distance representing the average horizontal distance measured from side to side and perpendicular to the central axis of the gap between two RAILWAY sleepers (ties).
        /// </summary>
        /// <value>
        /// Value of the column sleeper_density_dim
        /// </value>
        [AttrIx(100006)]
		[AttrName("railway-sleeper-density-dimension")]
		[AttrColumnName("sleeper_density_dim")]
        [AttrSeqnr(6)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? SleeperDensityDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column gross_trailing_load_qty
		///
		/// The numeric value that represents the maximum tonnage that can be moved under optimum conditions. The unit of measure is metric ton.
        /// </summary>
        /// <value>
        /// Value of the column gross_trailing_load_qty
        /// </value>
        [AttrIx(100007)]
		[AttrName("railway-gross-trailing-load-quantity")]
		[AttrColumnName("gross_trailing_load_qty")]
        [AttrSeqnr(7)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? GrossTrailingLoadQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_speed_rate
		///
		/// The numeric value that denotes the maximum speed that it is possible to move on a specific RAILWAY. The unit of measure is kilometres per hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column max_speed_rate
        /// </value>
        [AttrIx(100008)]
		[AttrName("railway-maximum-speed-rate")]
		[AttrColumnName("max_speed_rate")]
        [AttrSeqnr(8)]
        [DomId(100001300)]
        [DataLength(4)]
        [DataDecimals(1)]
        double? MaximumSpeedRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column traction_sys_code
		///
		/// The specific value that represents the motive power (engine type) that is supported along a specific RAILWAY.
        /// </summary>
        /// <value>
        /// Value of the column traction_sys_code
        /// </value>
        [AttrIx(100009)]
		[AttrName("railway-traction-system-code")]
		[AttrColumnName("traction_sys_code")]
        [AttrSeqnr(9)]
        [DomId(100004261)]
        [DataLength(6)]
        [DataDecimals(0)]
        RailwayTractionSystemEnum? TractionSystem { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column signal_sys_code
		///
		/// The specific value that represents the type of signal system used for the RAILWAY.
        /// </summary>
        /// <value>
        /// Value of the column signal_sys_code
        /// </value>
        [AttrIx(100010)]
		[AttrName("railway-signal-system-code")]
		[AttrColumnName("signal_sys_code")]
        [AttrSeqnr(10)]
        [DomId(100004262)]
        [DataLength(6)]
        [DataDecimals(0)]
        RailwaySignalSystemEnum? SignalSystem { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column signal_sys_effc_code
		///
		/// The specific value that represents the percentage value used to compute the inevitable delays caused by the type of signalling in use on the RAILWAY line.
        /// </summary>
        /// <value>
        /// Value of the column signal_sys_effc_code
        /// </value>
        [AttrIx(100011)]
		[AttrName("railway-signal-system-efficiency-code")]
		[AttrColumnName("signal_sys_effc_code")]
        [AttrSeqnr(11)]
        [DomId(100004263)]
        [DataLength(6)]
        [DataDecimals(0)]
        RailwaySignalSystemEfficiencyEnum? SignalSystemEfficiency { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100012)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(12)]
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
        [AttrIx(100013)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(13)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
