using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity SLIPWAY that represents the table SLPWAY.
	///
	/// A FACILITY that provides a sloping surface or inclined structure leading down to the water.
    /// </summary>
    [Serializable]
    [DefinitionName("Slipway", "C4Net.JC3IEDM.Definitions.Slipway.definition.xml")]
    public class Slipway : Facility, ISlipway
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly SlipwayExpression _ = new SlipwayExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column gradient_angle
		///
		/// The rotational measurement of a gradient, measured between the top of the slipway to the surface of the water, for a specific SLIPWAY.
        /// </summary>
        /// <value>
        /// Value of the column gradient_angle
        /// </value>
		public double? GradientAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column loc_txt
		///
		/// The character string assigned to represent a statement of the details that relate to the specific SLIPWAY.
        /// </summary>
        /// <value>
        /// Value of the column loc_txt
        /// </value>
		public string LocationText { get; set; }
		
        #endregion
    }
}
