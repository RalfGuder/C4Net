using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity AFFILIATION-ETHNIC-GROUP that represents the table AFFL_ETHNIC_GROUP.
	///
	/// A specification of an ethnic group to which membership or allegiance may be ascribed.
    /// </summary>
    [Serializable]
    [DefinitionName("AffiliationEthnicGroup", "C4Net.JC3IEDM.Definitions.AffiliationEthnicGroup.definition.xml")]
    public class AffiliationEthnicGroup : Affiliation, IAffiliationEthnicGroup
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly AffiliationEthnicGroupExpression _ = new AffiliationEthnicGroupExpression();

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
		/// The specific value that represents an ethnic group in a specific AFFILIATION-ETHNIC-GROUP.
        /// </summary>
        /// <value>
        /// Value of the column code
        /// </value>
		public AffiliationEthnicGroupEnum AffiliationEthnicGroupCode { get; set; }
		
        #endregion
    }
}
