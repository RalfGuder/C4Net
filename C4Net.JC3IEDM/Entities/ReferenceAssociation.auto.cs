using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity REFERENCE-ASSOCIATION that represents the table REF_ASSOC.
	///
	/// A relationship of a REFERENCE as a subject with another REFERENCE as an object.
    /// </summary>
    [Serializable]
    [DefinitionName("ReferenceAssociation", "C4Net.JC3IEDM.Definitions.ReferenceAssociation.definition.xml")]
    public class ReferenceAssociation : IEntity, IReferenceAssociation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ReferenceAssociationExpression _ = new ReferenceAssociationExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column subj_ref_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REFERENCE and to distinguish it from all other REFERENCEs.
        /// </summary>
        /// <value>
        /// Value of the column subj_ref_id
        /// </value>
		public decimal SubjectReferenceId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_ref_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REFERENCE and to distinguish it from all other REFERENCEs.
        /// </summary>
        /// <value>
        /// Value of the column obj_ref_id
        /// </value>
		public decimal ObjectReferenceId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ref_assoc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific REFERENCE-ASSOCIATION for a subject REFERENCE and an object REFERENCE and to distinguish it from all other REFERENCE-ASSOCIATIONs for those REFERENCEs.
        /// </summary>
        /// <value>
        /// Value of the column ref_assoc_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of relationship between a subject REFERENCE and an object REFERENCE for a specific REFERENCE-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ReferenceAssociationCategoryEnum? ReferenceAssociationCategory { get; set; }
		
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
