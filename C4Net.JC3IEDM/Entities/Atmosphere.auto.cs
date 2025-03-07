using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ATMOSPHERE that represents the table ATMOSPHERE.
	///
	/// A METEOROLOGIC-FEATURE that specifies humidity, pressure, and temperature characteristics of Earth's atmosphere.
    /// </summary>
    [Serializable]
    [DefinitionName("Atmosphere", "C4Net.JC3IEDM.Definitions.Atmosphere.definition.xml")]
    public class Atmosphere : MeteorologicFeature, IAtmosphere
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly AtmosphereExpression _ = new AtmosphereExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column humidity_rat
		///
		/// The numeric quotient value that represents the proportion of water present in the air to the maximum amount of water (saturation point) possible at a given temperature and pressure. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column humidity_rat
        /// </value>
		public double? HumidityRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column inversion_layer_code
		///
		/// The specific value that represents the height of the inversion layer in the atmosphere. The stability class describes the degree of mixing of released material in the atmosphere.
        /// </summary>
        /// <value>
        /// Value of the column inversion_layer_code
        /// </value>
		public AtmosphereInversionLayerEnum? InversionLayer { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prs_qty
		///
		/// The numeric value that denotes the ambient air pressure in terms of force per unit area. The unit of measure is kPa (Kilopascals).
        /// </summary>
        /// <value>
        /// Value of the column prs_qty
        /// </value>
		public double? PressureQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prs_sys_cat_code
		///
		/// The specific value that represents the class of a pressure system in a particular ATMOSPHERE.
        /// </summary>
        /// <value>
        /// Value of the column prs_sys_cat_code
        /// </value>
		public AtmospherePressureSystemCategoryEnum? PressureSystemCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column tmpr
		///
		/// The numeric value that indicates the heat of the ambient air for a specific ATMOSPHERE.
        /// </summary>
        /// <value>
        /// Value of the column tmpr
        /// </value>
		public double? Temperature { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column tmpr_gradient_code
		///
		/// The specific value that represents heat change with respect to the ground and 100 m in elevation in a certain area. Acts as an indication of vertical air movement between the ground and higher elevations.
        /// </summary>
        /// <value>
        /// Value of the column tmpr_gradient_code
        /// </value>
		public AtmosphereTemperatureGradientEnum? TemperatureGradient { get; set; }
		
        #endregion
    }
}
