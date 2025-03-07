using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity VESSEL-TYPE that represents the table VESSEL_TYPE.
	///
	/// An EQUIPMENT-TYPE that is designed to operate on or under the water surface.
    /// </summary>
    [Serializable]
    [DefinitionName("VesselType", "C4Net.JC3IEDM.Definitions.VesselType.definition.xml")]
    public class VesselType : EquipmentType, IVesselType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly VesselTypeExpression _ = new VesselTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of VESSEL-TYPE. It serves as a discriminator that partitions VESSEL-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public VesselTypeCategoryEnum VesselTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column magn_degaussing_code_no_qty
		///
		/// The numeric value that represents the peak vertical component of the magnetic field under a ship on the worst heading and at certain depth. The unit of measure is microtesla.
        /// </summary>
        /// <value>
        /// Value of the column magn_degaussing_code_no_qty
        /// </value>
		public long? MagneticDegaussingCodeNumberQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prismatic_coefficient_rat
		///
		/// The numeric quotient value that represents a ratio of the volume displaced by the hull in relation to the volume of a prism or cylinder of cross section equal to the greatest cross-section of the submerged part of the hull and of length equal to the ships length between perpendiculars. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column prismatic_coefficient_rat
        /// </value>
		public double? PrismaticCoefficientRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dead_wt_qty
		///
		/// The numeric value that represents the carrying capacity of a ship. Dead weight is the difference between the Full displacement (Gross weight) and the Light displacement (Net weight). The unit of measure is metric ton.
        /// </summary>
        /// <value>
        /// Value of the column dead_wt_qty
        /// </value>
		public int? DeadWeightQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column draught_dim
		///
		/// The numeric value of the distance from the Deep Water Line (DWL) to the lowest permanent projection on the hull of a vessel type including sonar domes, propellers, rudders, or other projections.
        /// </summary>
        /// <value>
        /// Value of the column draught_dim
        /// </value>
		public double? DraughtDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column gross_rgstrd_tong_qty
		///
		/// The numeric value that represents a ship's internal cubic capacity or freight-carrying capacity. The unit of measure is Gross Registered Tonnage (GRT). A unit of Gross Registered Tonnage is equal to 2.83 cubic metres.
        /// </summary>
        /// <value>
        /// Value of the column gross_rgstrd_tong_qty
        /// </value>
		public int? GrossRegisteredTonnageQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column height_above_the_wtrln_dim
		///
		/// The one-dimensional linear distance representing the distance from the waterline to the topmost point of an unloaded vessel.
        /// </summary>
        /// <value>
        /// Value of the column height_above_the_wtrln_dim
        /// </value>
		public double? HeightAboveTheWaterlineDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column propeller_cnt
		///
		/// The integer value representing the number of propellers on the ship.
        /// </summary>
        /// <value>
        /// Value of the column propeller_cnt
        /// </value>
		public short? PropellerCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column propulsion_type_code
		///
		/// The specific value that represents the type of power used to move the vessel.
        /// </summary>
        /// <value>
        /// Value of the column propulsion_type_code
        /// </value>
		public VesselTypePropulsionTypeEnum? PropulsionType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_displ_qty
		///
		/// The numeric value that represents the weight or volume of water moved by the vessel on the surface of the water. The unit of measure is metric ton.
        /// </summary>
        /// <value>
        /// Value of the column operat_displ_qty
        /// </value>
		public int? OperationalDisplacementQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_speed_rate
		///
		/// The numeric value of the maximum speed that a vessel type can maintain for one hour or less with a clean hull immediately out of dry docking or refit. The speed is measured in knots. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column max_speed_rate
        /// </value>
		public double? MaximumSpeedRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column acoustic_merit_ix_qty
		///
		/// The numeric value that indicates the total acoustic level.
        /// </summary>
        /// <value>
        /// Value of the column acoustic_merit_ix_qty
        /// </value>
		public int? AcousticMeritIndexQuantity { get; set; }
		
        #endregion
    }
}
