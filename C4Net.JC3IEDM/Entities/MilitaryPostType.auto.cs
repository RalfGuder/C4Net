using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MILITARY-POST-TYPE that represents the table MIL_POST_TYPE.
	///
	/// A MILITARY-ORGANISATION-TYPE with a set of duties that can be fulfilled by one person.
    /// </summary>
    [Serializable]
    [DefinitionName("MilitaryPostType", "C4Net.JC3IEDM.Definitions.MilitaryPostType.definition.xml")]
    public class MilitaryPostType : MilitaryOrganisationType, IMilitaryPostType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly MilitaryPostTypeExpression _ = new MilitaryPostTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type classification of a MILITARY-POST-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public MilitaryPostTypeCategoryEnum MilitaryPostTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rank_code
		///
		/// The specific value that represents a designation for a military or naval grade that establishes the relative position or status of a specific MILITARY-POST-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column rank_code
        /// </value>
		public MilitaryPostTypeRankEnum? Rank { get; set; }
		
        #endregion
    }
}
