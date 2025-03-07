using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CIVILIAN-POST-TYPE that represents the table CIV_POST_TYPE.
	///
	/// An ORGANISATION-TYPE with a set of duties that are intended to be fulfilled by one person in private sector and non-military government organisations.
    /// </summary>
    [Serializable]
    [DefinitionName("CivilianPostType", "C4Net.JC3IEDM.Definitions.CivilianPostType.definition.xml")]
    public class CivilianPostType : OrganisationType, ICivilianPostType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly CivilianPostTypeExpression _ = new CivilianPostTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of CIVILIAN-POST-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public CivilianPostTypeCategoryEnum CivilianPostTypeCategory { get; set; }
		
        #endregion
    }
}
