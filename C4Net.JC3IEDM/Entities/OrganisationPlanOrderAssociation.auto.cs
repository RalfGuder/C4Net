using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ORGANISATION-PLAN-ORDER-ASSOCIATION that represents the table ORG_POA.
	///
	/// A relationship of an ORGANISATION to a PLAN-ORDER specifying the role of the ORGANISATION with respect to the PLAN-ORDER.
    /// </summary>
    [Serializable]
    [DefinitionName("OrganisationPlanOrderAssociation", "C4Net.JC3IEDM.Definitions.OrganisationPlanOrderAssociation.definition.xml")]
    public class OrganisationPlanOrderAssociation : IEntity, IOrganisationPlanOrderAssociation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly OrganisationPlanOrderAssociationExpression _ = new OrganisationPlanOrderAssociationExpression();

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
        /// Gets or sets the value of the column pln_ordr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column pln_ordr_id
        /// </value>
		public decimal PlanOrderId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_poa_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ORGANISATION-PLAN-ORDER-ASSOCIATION for a specific ORGANISATION and a specific PLAN-ORDER and to distinguish it from all other ORGANISATION-PLAN-ORDER-ASSOCIATIONs for that ORGANISATION and that PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column org_poa_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the responsibility of the specific ORGANISATION with respect to the specific PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public OrganisationPlanOrderAssociationCategoryEnum OrganisationPlanOrderAssociationCategory { get; set; }
		
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
