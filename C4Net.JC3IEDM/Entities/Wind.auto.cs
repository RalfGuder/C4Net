using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity WIND that represents the table WIND.
	///
	/// A METEOROLOGIC-FEATURE that specifies the velocity and directional characteristics of atmospheric movement.
    /// </summary>
    [Serializable]
    [DefinitionName("Wind", "C4Net.JC3IEDM.Definitions.Wind.definition.xml")]
    public class Wind : MeteorologicFeature, IWind
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly WindExpression _ = new WindExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of WIND.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public WindCategoryEnum? WindCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column air_stability_cat_code
		///
		/// The specific value used to indicate the class of air stability.
        /// </summary>
        /// <value>
        /// Value of the column air_stability_cat_code
        /// </value>
		public WindAirStabilityCategoryEnum? AirStabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column altitude_layer_code
		///
		/// The specific value used to indicate the class of the altitude for a specific set of reported wind data.
        /// </summary>
        /// <value>
        /// Value of the column altitude_layer_code
        /// </value>
		public WindAltitudeLayerEnum? AltitudeLayer { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dir_angle
		///
		/// The rotational measurement clockwise between the line of true North and the direction from which a specific WIND originates.
        /// </summary>
        /// <value>
        /// Value of the column dir_angle
        /// </value>
		public double? DirectionAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_downwind_dir_angle
		///
		/// The rotational measurement of the mean downwind direction at ground level in the hazard area towards which the cloud travels.
        /// </summary>
        /// <value>
        /// Value of the column effctv_downwind_dir_angle
        /// </value>
		public double? EffectiveDownwindDirectionAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column speed_rate
		///
		/// The numeric value that denotes the distance per unit time of a specific WIND. The unit of measure is kilometres per hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column speed_rate
        /// </value>
		public double? SpeedRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column nuc_yield_qual_code
		///
		/// The specific value used to identify predicted wind values associated with nuclear fallout prediction for a specific Nuclear yield group.
        /// </summary>
        /// <value>
        /// Value of the column nuc_yield_qual_code
        /// </value>
		public NuclearYieldGroupEnum? NuclearYieldQualifier { get; set; }
		
        #endregion
    }
}
