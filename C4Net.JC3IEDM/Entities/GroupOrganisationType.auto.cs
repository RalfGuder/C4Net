using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity GROUP-ORGANISATION-TYPE that represents the table GROUP_ORG_TYPE.
	///
	/// An ORGANISATION-TYPE that is non-formal in nature and classes together its members due to mutual or common circumstances.
    /// </summary>
    [Serializable]
    [DefinitionName("GroupOrganisationType", "C4Net.JC3IEDM.Definitions.GroupOrganisationType.definition.xml")]
    public class GroupOrganisationType : OrganisationType, IGroupOrganisationType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly GroupOrganisationTypeExpression _ = new GroupOrganisationTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of GROUP-ORGANISATION-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public GroupOrganisationTypeCategoryEnum GroupOrganisationTypeCategory { get; set; }
		
        #endregion
    }
}
