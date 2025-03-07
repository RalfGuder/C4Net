using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ORGANISATION-REFERENCE-ASSOCIATION that represents the table ORG_REF_ASSOC.
	///
	/// A relationship between a specific ORGANISATION and a specific REFERENCE.
    /// </summary>
    [Serializable]
    [DefinitionName("OrganisationReferenceAssociation", "C4Net.JC3IEDM.Definitions.OrganisationReferenceAssociation.definition.xml")]
    public class OrganisationReferenceAssociation : IEntity, IOrganisationReferenceAssociation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly OrganisationReferenceAssociationExpression _ = new OrganisationReferenceAssociationExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column org_id
        /// </value>
		public decimal OrganisationId { get; set; }
		
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
        /// Gets or sets the value of the column org_ref_assoc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ORGANISATION-REFERENCE-ASSOCIATION for a specific ORGANISATION and a specific REFERENCE and to distinguish it from all other ORGANISATION-REFERENCE-ASSOCIATIONs for that ORGANISATION and that REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column org_ref_assoc_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of a specific ORGANISATION-REFERENCE-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public OrganisationReferenceAssociationCategoryEnum? OrganisationReferenceAssociationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column start_dttm
		///
		/// The character string representing a point in time that designates the start of a specific ORGANISATION-REFERENCE-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column start_dttm
        /// </value>
		public string StartDatetime { get; set; }
		
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
