using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ORGANISATION-PLAN-ORDER-ASSOCIATION-STATUS that represents the table ORG_POA_STAT.
	///
	/// A record of the perceived state of a specific ORGANISATION-PLAN-ORDER-ASSOCIATION as determined by the establishing organisation.
    /// </summary>
    [Serializable]
    [DefinitionName("OrganisationPlanOrderAssociationStatus", "C4Net.JC3IEDM.Definitions.OrganisationPlanOrderAssociationStatus.definition.xml")]
    public class OrganisationPlanOrderAssociationStatus : IEntity, IOrganisationPlanOrderAssociationStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly OrganisationPlanOrderAssociationStatusExpression _ = new OrganisationPlanOrderAssociationStatusExpression();

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
		public decimal OrganisationPlanOrderAssociationIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_poa_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ORGANISATION-PLAN-ORDER-ASSOCIATION-STATUS for a specific ORGANISATION-PLAN-ORDER-ASSOCIATION and to distinguish it from all other ORGANISATION-PLAN-ORDER-ASSOCIATION-STATUSs for that ORGANISATION-PLAN-ORDER-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column org_poa_stat_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that indicates whether a specific ORGANISATION-PLAN-ORDER-ASSOCIATION-STATUS refers to the beginning or termination of the association.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public AssociationStatusCategoryEnum OrganisationPlanOrderAssociationStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing a point in time when a specific ORGANISATION-PLAN-ORDER-ASSOCIATION-STATUS has been established.
        /// </summary>
        /// <value>
        /// Value of the column dttm
        /// </value>
		public string Datetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column estblng_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column estblng_org_id
        /// </value>
		public decimal EstablishingOrganisationId { get; set; }
		
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
