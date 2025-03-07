using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity RAILWAY that represents the table RAILWAY.
	///
	/// A FACILITY that is a track or set of tracks made of steel rails along which trains run.
    /// </summary>
    [Serializable]
    [DefinitionName("Railway", "C4Net.JC3IEDM.Definitions.Railway.definition.xml")]
    public class Railway : Facility, IRailway
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly RailwayExpression _ = new RailwayExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column track_gauge_code
		///
		/// The specific value that represents the distance between the internal sides of rails on a RAILWAY line.
        /// </summary>
        /// <value>
        /// Value of the column track_gauge_code
        /// </value>
		public RailwayTrackGaugeEnum? TrackGauge { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column track_cnt
		///
		/// The integer value representing the number of tracks on a RAILWAY line.
        /// </summary>
        /// <value>
        /// Value of the column track_cnt
        /// </value>
		public short? TrackCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column train_density_cnt
		///
		/// The integer value representing the maximum number of trains, which can be moved in each direction over a specified section of track in a 24 hour period.
        /// </summary>
        /// <value>
        /// Value of the column train_density_cnt
        /// </value>
		public short? TrainDensityCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column block_dist_dim
		///
		/// The one-dimensional linear distance representing the minimum length of the passing track intervals for single track lines or the safety margin related to the signalling system on double or multiple track lines.
        /// </summary>
        /// <value>
        /// Value of the column block_dist_dim
        /// </value>
		public double? BlockDistanceDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column sleeper_density_dim
		///
		/// The one-dimensional linear distance representing the average horizontal distance measured from side to side and perpendicular to the central axis of the gap between two RAILWAY sleepers (ties).
        /// </summary>
        /// <value>
        /// Value of the column sleeper_density_dim
        /// </value>
		public double? SleeperDensityDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column gross_trailing_load_qty
		///
		/// The numeric value that represents the maximum tonnage that can be moved under optimum conditions. The unit of measure is metric ton.
        /// </summary>
        /// <value>
        /// Value of the column gross_trailing_load_qty
        /// </value>
		public int? GrossTrailingLoadQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_speed_rate
		///
		/// The numeric value that denotes the maximum speed that it is possible to move on a specific RAILWAY. The unit of measure is kilometres per hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column max_speed_rate
        /// </value>
		public double? MaximumSpeedRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column traction_sys_code
		///
		/// The specific value that represents the motive power (engine type) that is supported along a specific RAILWAY.
        /// </summary>
        /// <value>
        /// Value of the column traction_sys_code
        /// </value>
		public RailwayTractionSystemEnum? TractionSystem { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column signal_sys_code
		///
		/// The specific value that represents the type of signal system used for the RAILWAY.
        /// </summary>
        /// <value>
        /// Value of the column signal_sys_code
        /// </value>
		public RailwaySignalSystemEnum? SignalSystem { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column signal_sys_effc_code
		///
		/// The specific value that represents the percentage value used to compute the inevitable delays caused by the type of signalling in use on the RAILWAY line.
        /// </summary>
        /// <value>
        /// Value of the column signal_sys_effc_code
        /// </value>
		public RailwaySignalSystemEfficiencyEnum? SignalSystemEfficiency { get; set; }
		
        #endregion
    }
}
