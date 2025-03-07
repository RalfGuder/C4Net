using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MILITARY-ORGANISATION-TYPE that represents the table MIL_ORG_TYPE.
	///
	/// A GOVERNMENT-ORGANISATION-TYPE that is officially sanctioned and is trained and equipped to exert force.
    /// </summary>
    [Serializable]
    [DefinitionName("MilitaryOrganisationType", "C4Net.JC3IEDM.Definitions.MilitaryOrganisationType.definition.xml")]
    public class MilitaryOrganisationType : GovernmentOrganisationType, IMilitaryOrganisationType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly MilitaryOrganisationTypeExpression _ = new MilitaryOrganisationTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of MILITARY-ORGANISATION-TYPE. It serves as a discriminator that partitions MILITARY-ORGANISATION-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public MilitaryOrganisationTypeCategoryEnum MilitaryOrganisationTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column service_code
		///
		/// The specific value that represents a military, paramilitary, irregular force, force or group, capable of functioning as an offensive or defensive combat or support organisation.
        /// </summary>
        /// <value>
        /// Value of the column service_code
        /// </value>
		public MilitaryOrganisationTypeServiceEnum Service { get; set; }
		
        #endregion
    }
}
