using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ORGANISATION that represents the table ORG.
	///
	/// An OBJECT-ITEM that is an administrative or functional structure.
    /// </summary>
    [Serializable]
    [DefinitionName("Organisation", "C4Net.JC3IEDM.Definitions.Organisation.definition.xml")]
    public class Organisation : ObjectItem, IOrganisation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly OrganisationExpression _ = new OrganisationExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ORGANISATION. It serves as a discriminator that partitions ORGANISATION into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public OrganisationCategoryEnum OrganisationCategory { get; set; }
		
        #endregion
    }
}
