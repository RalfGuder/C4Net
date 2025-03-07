using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity AFFILIATION-GEOPOLITICAL that represents the table AFFL_GEOPOLITICAL.
	///
	/// A specification of a country or political entity to which membership or allegiance may be ascribed.
    /// </summary>
    [Serializable]
    [DefinitionName("AffiliationGeopolitical", "C4Net.JC3IEDM.Definitions.AffiliationGeopolitical.definition.xml")]
    public class AffiliationGeopolitical : Affiliation, IAffiliationGeopolitical
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly AffiliationGeopoliticalExpression _ = new AffiliationGeopoliticalExpression();

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
		/// The specific value that represents the identification of the independent first-level geographic-political area and its dependencies, areas of quasi-independence, and areas with special unrecognised sovereignty, including outlying and disputed areas.
        /// </summary>
        /// <value>
        /// Value of the column code
        /// </value>
		public AffiliationGeopoliticalEnum AffiliationGeopoliticalCode { get; set; }
		
        #endregion
    }
}
