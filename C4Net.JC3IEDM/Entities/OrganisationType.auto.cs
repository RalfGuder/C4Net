using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ORGANISATION-TYPE that represents the table ORG_TYPE.
	///
	/// An OBJECT-TYPE that represents administrative or functional structures.
    /// </summary>
    [Serializable]
    [DefinitionName("OrganisationType", "C4Net.JC3IEDM.Definitions.OrganisationType.definition.xml")]
    public class OrganisationType : ObjectType, IOrganisationType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly OrganisationTypeExpression _ = new OrganisationTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ORGANISATION-TYPE. It serves as a discriminator that partitions ORGANISATION-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public OrganisationTypeCategoryEnum OrganisationTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cmd_func_ind_code
		///
		/// The specific value that denotes whether an ORGANISATION-TYPE has a command function.
        /// </summary>
        /// <value>
        /// Value of the column cmd_func_ind_code
        /// </value>
		public OrganisationTypeCommandFunctionIndicatorEnum CommandFunctionIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cmd_and_ctrl_cat_code
		///
		/// The specific value that denotes the command and control classification of an ORGANISATION-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cmd_and_ctrl_cat_code
        /// </value>
		public OrganisationTypeCommandAndControlCategoryEnum? CommandAndControlCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column descr_txt
		///
		/// The character string assigned to represent the specific ORGANISATION-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column descr_txt
        /// </value>
		public string DescriptionText { get; set; }
		
        #endregion
    }
}
