using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CONVOY that represents the table CONVOY.
	///
	/// An ORGANISATION that is a group of vehicles or vessels organised for the purpose of control and orderly movement with or without escort protection.
    /// </summary>
    [Serializable]
    [DefinitionName("Convoy", "C4Net.JC3IEDM.Definitions.Convoy.definition.xml")]
    public class Convoy : Organisation, IConvoy
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ConvoyExpression _ = new ConvoyExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column day_speed_rate
		///
		/// The numeric value that denotes the maximum distance per unit time that a specific CONVOY is to maintain during daylight operations. The unit of measure is kilometres per hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column day_speed_rate
        /// </value>
		public double? DaySpeedRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column day_vehicle_gap_dim
		///
		/// The one-dimensional linear distance representing the distance between vehicles in a particular CONVOY during daylight operations.
        /// </summary>
        /// <value>
        /// Value of the column day_vehicle_gap_dim
        /// </value>
		public double? DayVehicleGapDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column halt_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds representing the aggregated units of time that a specific CONVOY may remain stationary during operations.
        /// </summary>
        /// <value>
        /// Value of the column halt_dur
        /// </value>
		public decimal? HaltDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column night_speed_rate
		///
		/// The numeric value that denotes the maximum distance per unit time that a specific CONVOY is to maintain during operations in darkness. The unit of measure is kilometres per hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column night_speed_rate
        /// </value>
		public double? NightSpeedRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column night_vehicle_gap_dim
		///
		/// The one-dimensional linear distance representing the distance between vehicles in a particular CONVOY during operations in darkness.
        /// </summary>
        /// <value>
        /// Value of the column night_vehicle_gap_dim
        /// </value>
		public double? NightVehicleGapDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column packet_gap_dim
		///
		/// The one-dimensional linear distance representing the distance between packets in a particular CONVOY.
        /// </summary>
        /// <value>
        /// Value of the column packet_gap_dim
        /// </value>
		public double? PacketGapDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column packet_size_cnt
		///
		/// The integer value that represents the number of vehicles per packet in a particular CONVOY.
        /// </summary>
        /// <value>
        /// Value of the column packet_size_cnt
        /// </value>
		public int? PacketSizeCount { get; set; }
		
        #endregion
    }
}
