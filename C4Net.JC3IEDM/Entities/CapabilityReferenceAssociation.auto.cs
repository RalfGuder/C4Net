using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CAPABILITY-REFERENCE-ASSOCIATION that represents the table CAPAB_REF_ASSOC.
	///
	/// A relationship between a specific CAPABILITY and a specific REFERENCE.
    /// </summary>
    [Serializable]
    [DefinitionName("CapabilityReferenceAssociation", "C4Net.JC3IEDM.Definitions.CapabilityReferenceAssociation.definition.xml")]
    public class CapabilityReferenceAssociation : IEntity, ICapabilityReferenceAssociation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly CapabilityReferenceAssociationExpression _ = new CapabilityReferenceAssociationExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column capab_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CAPABILITY and to distinguish it from all other CAPABILITYs.
        /// </summary>
        /// <value>
        /// Value of the column capab_id
        /// </value>
		public decimal CapabilityId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ref_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REFERENCE and to distinguish it from all other REFERENCEs.
        /// </summary>
        /// <value>
        /// Value of the column ref_id
        /// </value>
		public decimal ReferenceId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of a specific CAPABILITY-REFERENCE-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public CapabilityReferenceAssociationCategoryEnum? CapabilityReferenceAssociationCategory { get; set; }
		
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
