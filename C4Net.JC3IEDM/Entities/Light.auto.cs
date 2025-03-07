using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity LIGHT that represents the table LIGHT.
	///
	/// A METEOROLOGIC-FEATURE that specifies the availability of natural illumination by type and time.
    /// </summary>
    [Serializable]
    [DefinitionName("Light", "C4Net.JC3IEDM.Definitions.Light.definition.xml")]
    public class Light : MeteorologicFeature, ILight
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly LightExpression _ = new LightExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of LIGHT.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public LightCategoryEnum? LightCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column up_dttm
		///
		/// The character string representing a point in time that designates the time of day that marks the beginning of the period of effectiveness of the specified type of LIGHT.
        /// </summary>
        /// <value>
        /// Value of the column up_dttm
        /// </value>
		public string UpDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column down_dttm
		///
		/// The character string representing a point in time that designates the time of day that marks the end of the period of effectiveness of the specified type of LIGHT.
        /// </summary>
        /// <value>
        /// Value of the column down_dttm
        /// </value>
		public string DownDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column moon_phase_code
		///
		/// The specific value that represents the phase of the moon for a specific LIGHT.
        /// </summary>
        /// <value>
        /// Value of the column moon_phase_code
        /// </value>
		public LightMoonPhaseEnum? MoonPhase { get; set; }
		
        #endregion
    }
}
