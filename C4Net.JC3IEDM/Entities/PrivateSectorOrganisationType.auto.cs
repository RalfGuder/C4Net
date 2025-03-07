using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity PRIVATE-SECTOR-ORGANISATION-TYPE that represents the table PRV_SCTR_ORG_TYPE.
	///
	/// An ORGANISATION-TYPE that is a non-government organisation and is constituted for business, commerce, manufacturing, trade, relief or philanthropy.
    /// </summary>
    [Serializable]
    [DefinitionName("PrivateSectorOrganisationType", "C4Net.JC3IEDM.Definitions.PrivateSectorOrganisationType.definition.xml")]
    public class PrivateSectorOrganisationType : OrganisationType, IPrivateSectorOrganisationType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly PrivateSectorOrganisationTypeExpression _ = new PrivateSectorOrganisationTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of PRIVATE-SECTOR-ORGANISATION-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public PrivateSectorOrganisationTypeCategoryEnum PrivateSectorOrganisationTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column main_actv_code
		///
		/// The specific value that represents the main activity of a PRIVATE-SECTOR-ORGANISATION-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column main_actv_code
        /// </value>
		public MainActivityEnum? MainActivity { get; set; }
		
        #endregion
    }
}
