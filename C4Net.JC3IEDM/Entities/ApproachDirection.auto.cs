using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity APPROACH-DIRECTION that represents the table APPR_DIR.
	///
	/// A CONTROL-FEATURE that specifies approach directional details for takeoff and landing.
    /// </summary>
    [Serializable]
    [DefinitionName("ApproachDirection", "C4Net.JC3IEDM.Definitions.ApproachDirection.definition.xml")]
    public class ApproachDirection : ControlFeature, IApproachDirection
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ApproachDirectionExpression _ = new ApproachDirectionExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that differentiates between left, right and centre parallel runways, Short Takeoff and Landing (STOL) or true as applicable.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ApproachDirectionCategoryEnum? ApproachDirectionCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column angle_txt
		///
		/// The character string assigned to represent a runway in terms of a whole number nearest one-tenth of the magnetic azimuth of the centreline of the runway, measured clockwise from magnetic north (where six degrees is used as the break off point for the next highest number).
        /// </summary>
        /// <value>
        /// Value of the column angle_txt
        /// </value>
		public string AngleText { get; set; }
		
        #endregion
    }
}
