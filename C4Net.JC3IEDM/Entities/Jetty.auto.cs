using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity JETTY that represents the table JETTY.
	///
	/// A FACILITY that is a platform that may be fixed or floating extending from a shore, normally attached to a wharf or the shore, and which allows access to a vessel lying alongside, used to secure, protect and provide landing and docking for vessels.
    /// </summary>
    [Serializable]
    [DefinitionName("Jetty", "C4Net.JC3IEDM.Definitions.Jetty.definition.xml")]
    public class Jetty : Facility, IJetty
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly JettyExpression _ = new JettyExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column day_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the JETTY during the day. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column day_limit_net_expl_qty
        /// </value>
		public int? DayLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_ddw_tong_qty
		///
		/// The numeric value that represents the maximum deadweight tonnage for a vessel at the specific JETTY. The unit of measure is metric ton.
        /// </summary>
        /// <value>
        /// Value of the column max_ddw_tong_qty
        /// </value>
		public int? MaximumDeadweightTonnageQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_draught_dim
		///
		/// The one-dimensional linear distance representing the maximum draught of vessel that the specific JETTY can accommodate.
        /// </summary>
        /// <value>
        /// Value of the column max_draught_dim
        /// </value>
		public double? MaximumDraughtDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column night_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the JETTY during the night. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column night_limit_net_expl_qty
        /// </value>
		public int? NightLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rail_cap_cnt
		///
		/// The integer value that represents the maximum number of goods/freight cars that the JETTY can accommodate at the same time.
        /// </summary>
        /// <value>
        /// Value of the column rail_cap_cnt
        /// </value>
		public int? RailCapacityCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rail_served_ind_code
		///
		/// The specific value that represents whether the JETTY has railway facilities.
        /// </summary>
        /// <value>
        /// Value of the column rail_served_ind_code
        /// </value>
		public JettyRailServedIndicatorEnum? RailServedIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vessel_max_beam_dim
		///
		/// The one-dimensional linear distance representing the maximum beam or width of vessel that the specific JETTY can accommodate.
        /// </summary>
        /// <value>
        /// Value of the column vessel_max_beam_dim
        /// </value>
		public double? VesselMaximumBeamDimension { get; set; }
		
        #endregion
    }
}
