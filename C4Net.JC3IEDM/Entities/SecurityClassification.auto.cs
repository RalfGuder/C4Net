using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity SECURITY-CLASSIFICATION that represents the table SECURITY_CLSFC.
	///
	/// The security classification applicable to an information resource within the domain of classified security information.
    /// </summary>
    [Serializable]
    [DefinitionName("SecurityClassification", "C4Net.JC3IEDM.Definitions.SecurityClassification.definition.xml")]
    public class SecurityClassification : IEntity, ISecurityClassification
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly SecurityClassificationExpression _ = new SecurityClassificationExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column security_clsfc_id
		///
		/// The unique value, or set of characters, assigned to represent a specific SECURITY-CLASSIFICATION and to distinguish it from all other SECURITY-CLASSIFICATIONs.
        /// </summary>
        /// <value>
        /// Value of the column security_clsfc_id
        /// </value>
		public decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lvl_code
		///
		/// The specific value that represents the security classification level for the information resource.
        /// </summary>
        /// <value>
        /// Value of the column lvl_code
        /// </value>
		public SecurityClassificationLevelEnum Level { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column policy_txt
		///
		/// The character string assigned to represent the organisation that defines the rules relating to the security handling for the information resource.
        /// </summary>
        /// <value>
        /// Value of the column policy_txt
        /// </value>
		public string PolicyText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column caveat_txt
		///
		/// The character string assigned to represent, for the information resource, an indication of an additional specific sensitivity, a dissemination control, or an informal marking.
        /// </summary>
        /// <value>
        /// Value of the column caveat_txt
        /// </value>
		public string CaveatText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
		public decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
		public long UpdateSeqnr { get; set; }
		
        #endregion
    }
}
