using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity EXECUTIVE-MILITARY-ORGANISATION-TYPE that represents the table EXCTV_MIL_ORG_TYPE.
	///
	/// A MILITARY-ORGANISATION-TYPE whose function is to manage and direct the military establishment.
    /// </summary>
    [Serializable]
    [DefinitionName("ExecutiveMilitaryOrganisationType", "C4Net.JC3IEDM.Definitions.ExecutiveMilitaryOrganisationType.definition.xml")]
    public class ExecutiveMilitaryOrganisationType : MilitaryOrganisationType, IExecutiveMilitaryOrganisationType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ExecutiveMilitaryOrganisationTypeExpression _ = new ExecutiveMilitaryOrganisationTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of EXECUTIVE-MILITARY-ORGANISATION-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ExecutiveMilitaryOrganisationTypeCategoryEnum ExecutiveMilitaryOrganisationTypeCategory { get; set; }
		
        #endregion
    }
}
