using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity AFFILIATION-RELIGION that represents the table AFFL_RELIGION.
	///
	/// A specification of a religion to which membership or allegiance may be ascribed.
    /// </summary>
    [Serializable]
    [DefinitionName("AffiliationReligion", "C4Net.JC3IEDM.Definitions.AffiliationReligion.definition.xml")]
    public class AffiliationReligion : Affiliation, IAffiliationReligion
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly AffiliationReligionExpression _ = new AffiliationReligionExpression();

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
		/// The specific value that represents a religion in a specific AFFILIATION-RELIGION.
        /// </summary>
        /// <value>
        /// Value of the column code
        /// </value>
		public AffiliationReligionEnum AffiliationReligionCode { get; set; }
		
        #endregion
    }
}
