using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-REFERENCE-ASSOCIATION that represents the table ACT_REF_ASSOC.
	///
	/// A relationship between a specific ACTION and a specific REFERENCE.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionReferenceAssociation", "C4Net.JC3IEDM.Definitions.ActionReferenceAssociation.definition.xml")]
    public class ActionReferenceAssociation : IEntity, IActionReferenceAssociation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ActionReferenceAssociationExpression _ = new ActionReferenceAssociationExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_id
        /// </value>
		public decimal ActionId { get; set; }
		
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
		/// The specific value that represents the class of a specific ACTION-REFERENCE-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ActionReferenceAssociationCategoryEnum? ActionReferenceAssociationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column part_txt
		///
		/// The character string assigned to represent a specific part of the artefact that applies in a specific ACTION-REFERENCE-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column part_txt
        /// </value>
		public string PartText { get; set; }
		
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
