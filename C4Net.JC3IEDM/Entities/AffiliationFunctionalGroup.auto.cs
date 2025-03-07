using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity AFFILIATION-FUNCTIONAL-GROUP that represents the table AFFL_FUNCTL_GROUP.
	///
	/// A specification of a functional group characterised by its primary purpose to which membership or allegiance may be ascribed.
    /// </summary>
    [Serializable]
    [DefinitionName("AffiliationFunctionalGroup", "C4Net.JC3IEDM.Definitions.AffiliationFunctionalGroup.definition.xml")]
    public class AffiliationFunctionalGroup : Affiliation, IAffiliationFunctionalGroup
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly AffiliationFunctionalGroupExpression _ = new AffiliationFunctionalGroupExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column affl_id
		///
		/// The unique value, or set of characters, assigned to represent a specific AFFILIATION and to distinguish it from all other AFFILIATIONs.
        /// </summary>
        /// <value>
        /// Value of the column affl_id
        /// </value>
		public decimal AffiliationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column code
		///
		/// The specific value that represents the category of functional group.
        /// </summary>
        /// <value>
        /// Value of the column code
        /// </value>
		public AffiliationFunctionalGroupEnum AffiliationFunctionalGroupCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column name_txt
		///
		/// The character string assigned to represent a specific AFFILIATION-FUNCTIONAL-GROUP.
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
		public string NameText { get; set; }
		
        #endregion
    }
}
