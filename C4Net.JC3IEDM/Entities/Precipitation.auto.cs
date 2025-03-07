using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity PRECIPITATION that represents the table PRECIPITATION.
	///
	/// A METEOROLOGIC-FEATURE that specifies the type of particulate matter in the Earth's atmosphere and the rate of its descent onto the Earth's surface.
    /// </summary>
    [Serializable]
    [DefinitionName("Precipitation", "C4Net.JC3IEDM.Definitions.Precipitation.definition.xml")]
    public class Precipitation : MeteorologicFeature, IPrecipitation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly PrecipitationExpression _ = new PrecipitationExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the prevailing class of a specific PRECIPITATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public PrecipitationCategoryEnum PrecipitationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rate
		///
		/// The numeric value that denotes the amount of PRECIPITATION deposited per unit time. The unit of measure is millimetres per hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column rate
        /// </value>
		public double? Rate { get; set; }
		
        #endregion
    }
}
