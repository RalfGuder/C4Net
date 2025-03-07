using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ANCHORAGE that represents the table ANCHR.
	///
	/// A FACILITY that is a place where vessels anchor.
    /// </summary>
    [Serializable]
    [DefinitionName("Anchorage", "C4Net.JC3IEDM.Definitions.Anchorage.definition.xml")]
    public class Anchorage : Facility, IAnchorage
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly AnchorageExpression _ = new AnchorageExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column btm_type_code
		///
		/// The specific value that represents the description of the ground under the water of a lake, river, ocean, or other body of water at a specific ANCHORAGE.
        /// </summary>
        /// <value>
        /// Value of the column btm_type_code
        /// </value>
		public AnchorageBottomTypeEnum? BottomType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column day_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the ANCHORAGE during the day. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column day_limit_net_expl_qty
        /// </value>
		public int? DayLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column draught_high_tide_dim
		///
		/// The one-dimensional linear distance representing the maximum draught of vessel at high tide that the specific ANCHORAGE can accommodate.
        /// </summary>
        /// <value>
        /// Value of the column draught_high_tide_dim
        /// </value>
		public double? DraughtHighTideDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column draught_low_tide_dim
		///
		/// The one-dimensional linear distance representing the maximum draught of vessel at low tide that the specific ANCHORAGE can accommodate.
        /// </summary>
        /// <value>
        /// Value of the column draught_low_tide_dim
        /// </value>
		public double? DraughtLowTideDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column moorings_type_code
		///
		/// The specific value that represents the class of mooring available at the specific ANCHORAGE.
        /// </summary>
        /// <value>
        /// Value of the column moorings_type_code
        /// </value>
		public AnchorageMooringsTypeEnum? MooringsType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column night_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the ANCHORAGE during the night. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column night_limit_net_expl_qty
        /// </value>
		public int? NightLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prvl_wind_dir_code
		///
		/// The specific value that represents the direction of the wind that most frequently occurs for the specific ANCHORAGE.
        /// </summary>
        /// <value>
        /// Value of the column prvl_wind_dir_code
        /// </value>
		public DirectionEnum? PrevailingWindDirection { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vessel_tong_qty
		///
		/// The numeric value that represents the maximum tonnage of a vessel that can be accommodated at a specific ANCHORAGE. The unit of measure is metric ton.
        /// </summary>
        /// <value>
        /// Value of the column vessel_tong_qty
        /// </value>
		public int? VesselTonnageQuantity { get; set; }
		
        #endregion
    }
}
