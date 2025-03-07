using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity BERTH that represents the table BERTH.
	///
	/// A FACILITY that is a space or length in the water at a harbour allocated to or reserved for a vessel to dock and moor for loading or unloading.
    /// </summary>
    [Serializable]
    [DefinitionName("Berth", "C4Net.JC3IEDM.Definitions.Berth.definition.xml")]
    public class Berth : Facility, IBerth
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly BerthExpression _ = new BerthExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column ddw_tong_qty
		///
		/// The numeric value that represents the maximum deadweight tonnage that can be accommodated for a vessel at the specific BERTH. The unit of measure is metric ton.
        /// </summary>
        /// <value>
        /// Value of the column ddw_tong_qty
        /// </value>
		public int? DeadweightTonnageQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column depth_dim
		///
		/// The one-dimensional linear distance representing the depth of water available at the BERTH at low tide.
        /// </summary>
        /// <value>
        /// Value of the column depth_dim
        /// </value>
		public double? DepthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column loc_txt
		///
		/// The character string assigned to represent a statement of the details that relate to the specific BERTH.
        /// </summary>
        /// <value>
        /// Value of the column loc_txt
        /// </value>
		public string LocationText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column major_vessel_class_code
		///
		/// The specific value that represents the class of vessels to be serviced.
        /// </summary>
        /// <value>
        /// Value of the column major_vessel_class_code
        /// </value>
		public BerthMajorVesselClassEnum? MajorVesselClass { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_beam_dim
		///
		/// The one-dimensional linear distance representing the width athwartships, including all projections, of the largest vessel a specific BERTH can process.
        /// </summary>
        /// <value>
        /// Value of the column max_beam_dim
        /// </value>
		public double? MaximumBeamDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_cap_qty
		///
		/// The numeric value that represents the maximum tonnage a specific BERTH can process per day. The unit of measure is Gross Registered Tonnage (GRT).
        /// </summary>
        /// <value>
        /// Value of the column max_cap_qty
        /// </value>
		public int? MaximumCapacityQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_vessel_cnt
		///
		/// The integer value representing the maximum number of vessels a specific BERTH can process at the same time.
        /// </summary>
        /// <value>
        /// Value of the column max_vessel_cnt
        /// </value>
		public short? MaximumVesselCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column day_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the BERTH during the day. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column day_limit_net_expl_qty
        /// </value>
		public int? DayLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column night_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the BERTH during the night. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column night_limit_net_expl_qty
        /// </value>
		public int? NightLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rail_avlbty_ind_code
		///
		/// The specific value that represents the availability of railroad transportation capability at a specific BERTH.
        /// </summary>
        /// <value>
        /// Value of the column rail_avlbty_ind_code
        /// </value>
		public BerthRailAvailabilityIndicatorEnum? RailAvailabilityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column roll_on_roll_off_ind_code
		///
		/// The specific value that represents whether or not the BERTH has roll on/roll off capabilities.
        /// </summary>
        /// <value>
        /// Value of the column roll_on_roll_off_ind_code
        /// </value>
		public BerthRollOnRollOffIndicatorEnum? RollOnRollOffIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column turnaround_time_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds representing the average units of time for the process of docking, unloading, reloading and undocking a ship for a specific BERTH.
        /// </summary>
        /// <value>
        /// Value of the column turnaround_time_dur
        /// </value>
		public decimal? TurnaroundTimeDuration { get; set; }
		
        #endregion
    }
}
