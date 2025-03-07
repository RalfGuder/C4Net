using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity QUAY that represents the table QUAY.
	///
	/// A FACILITY that is a solidly constructed platform, usually parallel to the shoreline of navigable water, alongside which a vessel can be docked or berthed and, on which, the vessel can be accessed and cargo can be loaded or unloaded on one side of the vessel only.
    /// </summary>
    [Serializable]
    [DefinitionName("Quay", "C4Net.JC3IEDM.Definitions.Quay.definition.xml")]
    public class Quay : Facility, IQuay
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly QuayExpression _ = new QuayExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cntr_hndl_type_code
		///
		/// The specific value that represents the class of container handling equipment available at a specific QUAY.
        /// </summary>
        /// <value>
        /// Value of the column cntr_hndl_type_code
        /// </value>
		public QuayContainerHandlingTypeEnum? ContainerHandlingType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cntr_max_hndl_length_dim
		///
		/// The one-dimensional linear distance representing the maximum length of a container that can be handled at the QUAY.
        /// </summary>
        /// <value>
        /// Value of the column cntr_max_hndl_length_dim
        /// </value>
		public double? ContainerMaximumHandlingLengthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cntr_max_hndl_wt_qty
		///
		/// The numeric value that represents the maximum container weight that can be handled at the QUAY. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column cntr_max_hndl_wt_qty
        /// </value>
		public int? ContainerMaximumHandlingWeightQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column crane_ofld_lift_qty
		///
		/// The numeric value that represents the maximum weight that can be handled by a crane at the QUAY. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column crane_ofld_lift_qty
        /// </value>
		public int? CraneOffloadingLiftQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column crane_ofld_type_code
		///
		/// The specific value that represents the class of crane offloading equipment available at a specific QUAY.
        /// </summary>
        /// <value>
        /// Value of the column crane_ofld_type_code
        /// </value>
		public QuayCraneOffloadingTypeEnum? CraneOffloadingType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column day_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the QUAY during the day. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column day_limit_net_expl_qty
        /// </value>
		public int? DayLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column draught_dim
		///
		/// The one-dimensional linear distance representing the maximum draught of vessel that the specific QUAY can accommodate.
        /// </summary>
        /// <value>
        /// Value of the column draught_dim
        /// </value>
		public double? DraughtDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_ddw_tong_qty
		///
		/// The numeric value that represents the maximum deadweight tonnage that can be accommodated for a vessel at the specific QUAY. The unit of measure is metric ton.
        /// </summary>
        /// <value>
        /// Value of the column max_ddw_tong_qty
        /// </value>
		public int? MaximumDeadweightTonnageQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column night_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the QUAY during the night. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column night_limit_net_expl_qty
        /// </value>
		public int? NightLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rail_cap_cnt
		///
		/// The integer value representing the maximum number of goods/freight cars that the QUAY can accommodate at the same time.
        /// </summary>
        /// <value>
        /// Value of the column rail_cap_cnt
        /// </value>
		public int? RailCapacityCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rail_served_ind_code
		///
		/// The specific value that represents whether the QUAY has railway facilities.
        /// </summary>
        /// <value>
        /// Value of the column rail_served_ind_code
        /// </value>
		public QuayRailServedIndicatorEnum? RailServedIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column storage_code
		///
		/// The specific value that represents the class of storage facilities available at a specific QUAY.
        /// </summary>
        /// <value>
        /// Value of the column storage_code
        /// </value>
		public QuayStorageEnum? Storage { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vessel_max_beam_dim
		///
		/// The one-dimensional linear distance representing the maximum beam or width of vessel that the specific QUAY can accommodate.
        /// </summary>
        /// <value>
        /// Value of the column vessel_max_beam_dim
        /// </value>
		public double? VesselMaximumBeamDimension { get; set; }
		
        #endregion
    }
}
