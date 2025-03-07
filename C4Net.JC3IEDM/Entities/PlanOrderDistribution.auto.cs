using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity PLAN-ORDER-DISTRIBUTION that represents the table PLN_ORDR_DISTR.
	///
	/// A record that an ORGANISATION is the intended recipient of a specific PLAN-ORDER.
    /// </summary>
    [Serializable]
    [DefinitionName("PlanOrderDistribution", "C4Net.JC3IEDM.Definitions.PlanOrderDistribution.definition.xml")]
    public class PlanOrderDistribution : IEntity, IPlanOrderDistribution
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly PlanOrderDistributionExpression _ = new PlanOrderDistributionExpression();

        #endregion

        #region - Properties -
		
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
        /// Gets or sets the value of the column pln_ordr_distr_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-DISTRIBUTION for a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDER-DISTRIBUTIONs for that PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column pln_ordr_distr_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value assigned to represent the type of PLAN-ORDER-DISTRIBUTION with respect to the reason for its dissemination.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public PlanOrderDistributionCategoryEnum PlanOrderDistributionCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column release_dttm
		///
		/// The character string representing the point in time for the intended release of a specific PLAN-ORDER to a specific ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column release_dttm
        /// </value>
		public string ReleaseDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column recipient_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column recipient_org_id
        /// </value>
		public decimal RecipientOrganisationId { get; set; }
		
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
