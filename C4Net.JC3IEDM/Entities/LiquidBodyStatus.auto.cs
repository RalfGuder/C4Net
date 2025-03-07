using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity LIQUID-BODY-STATUS that represents the table LQD_BODY_STAT.
	///
	/// A GEOGRAPHIC-FEATURE-STATUS that is a record of condition of a specific liquid body.
    /// </summary>
    [Serializable]
    [DefinitionName("LiquidBodyStatus", "C4Net.JC3IEDM.Definitions.LiquidBodyStatus.definition.xml")]
    public class LiquidBodyStatus : GeographicFeatureStatus, ILiquidBodyStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly LiquidBodyStatusExpression _ = new LiquidBodyStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column btm_curr_rate
		///
		/// The numeric value that denotes the rate of the liquid movement at the bottom surface of the sea. The unit of measure is knots. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column btm_curr_rate
        /// </value>
		public double? BottomCurrentRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column thermal_layer_depth_qty
		///
		/// The numeric value that represents the distance below the liquid surface where the distinct interface between surface waters and cooler waters; regions between warmer upper layer (epilimnion) and the lower cold layer (hypolimnion) of the liquid where temperature declines abruptly (1 degree C or more per meter) with increasing depth. The unit of measure is metres.
        /// </summary>
        /// <value>
        /// Value of the column thermal_layer_depth_qty
        /// </value>
		public short? ThermalLayerDepthQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column tidal_stream_rate
		///
		/// The numeric value that represents the horizontal water movements due to tidal forcing. The unit of measure is knots. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column tidal_stream_rate
        /// </value>
		public double? TidalStreamRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column underwater_visibility_qty
		///
		/// The numeric value that represents the distance at which an object disappears given the ambient light, suspended organic and inorganic particulate measure, dissolved substances, plankton and the waters molecular structure. The unit of measure is metres.
        /// </summary>
        /// <value>
        /// Value of the column underwater_visibility_qty
        /// </value>
		public short? UnderwaterVisibilityQuantity { get; set; }
		
        #endregion
    }
}
