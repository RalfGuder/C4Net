using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MILITARY-OBSTACLE-TYPE that represents the table MIL_OBS_TYPE.
	///
	/// A FACILITY-TYPE that is a class of man-made devices or passive defence works that are designed to stop, impede, or divert movement of amphibious or ground forces.
    /// </summary>
    [Serializable]
    [DefinitionName("MilitaryObstacleType", "C4Net.JC3IEDM.Definitions.MilitaryObstacleType.definition.xml")]
    public class MilitaryObstacleType : FacilityType, IMilitaryObstacleType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly MilitaryObstacleTypeExpression _ = new MilitaryObstacleTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of MILITARY-OBSTACLE-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public MilitaryObstacleTypeCategoryEnum MilitaryObstacleTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the detailed class of MILITARY-OBSTACLE-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
		public MilitaryObstacleTypeSubcategoryEnum? Subcategory { get; set; }
		
        #endregion
    }
}
