using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MILITARY-OBSTACLE that represents the table MIL_OBS.
	///
	/// A FACILITY designed to stop, impede, or divert movement of amphibious or ground forces.
    /// </summary>
    [Serializable]
    [DefinitionName("MilitaryObstacle", "C4Net.JC3IEDM.Definitions.MilitaryObstacle.definition.xml")]
    public class MilitaryObstacle : Facility, IMilitaryObstacle
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly MilitaryObstacleExpression _ = new MilitaryObstacleExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of MILITARY-OBSTACLE. It serves as a discriminator that partitions MILITARY-OBSTACLE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public MilitaryObstacleCategoryEnum MilitaryObstacleCategory { get; set; }
		
        #endregion
    }
}
