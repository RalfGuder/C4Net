using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity GOVERNMENT-ORGANISATION-TYPE that represents the table GOVT_ORG_TYPE.
	///
	/// An ORGANISATION-TYPE that controls and administers public policy either under a national or international mandate.
    /// </summary>
    [Serializable]
    [DefinitionName("GovernmentOrganisationType", "C4Net.JC3IEDM.Definitions.GovernmentOrganisationType.definition.xml")]
    public class GovernmentOrganisationType : OrganisationType, IGovernmentOrganisationType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly GovernmentOrganisationTypeExpression _ = new GovernmentOrganisationTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of GOVERNMENT-ORGANISATION-TYPE. It serves as a discriminator that partitions GOVERNMENT-ORGANISATION-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public GovernmentOrganisationTypeCategoryEnum GovernmentOrganisationTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column main_actv_code
		///
		/// The specific value that represents the main activity of a GOVERNMENT-ORGANISATION-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column main_actv_code
        /// </value>
		public MainActivityEnum? MainActivity { get; set; }
		
        #endregion
    }
}
