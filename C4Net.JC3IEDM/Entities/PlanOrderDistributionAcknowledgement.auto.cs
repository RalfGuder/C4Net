using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity PLAN-ORDER-DISTRIBUTION-ACKNOWLEDGEMENT that represents the table PLN_ORDR_DISTR_ACK.
	///
	/// A record that the organisation identified in a specific PLAN-ORDER-DISTRIBUTION has acknowledged the receipt of a specific PLAN-ORDER.
    /// </summary>
    [Serializable]
    [DefinitionName("PlanOrderDistributionAcknowledgement", "C4Net.JC3IEDM.Definitions.PlanOrderDistributionAcknowledgement.definition.xml")]
    public class PlanOrderDistributionAcknowledgement : IEntity, IPlanOrderDistributionAcknowledgement
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly PlanOrderDistributionAcknowledgementExpression _ = new PlanOrderDistributionAcknowledgementExpression();

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
		public decimal PlanOrderDistributionIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pln_ordr_distr_ack_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-DISTRIBUTION-ACKNOWLEDGEMENT for a specific PLAN-ORDER-DISTRIBUTION and to distinguish it from all other PLAN-ORDER-DISTRIBUTION-ACKNOWLEDGEMENTs for that PLAN-ORDER-DISTRIBUTION.
        /// </summary>
        /// <value>
        /// Value of the column pln_ordr_distr_ack_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column code
		///
		/// The specific value that represents the type of acknowledgement of the distribution for a specific PLAN-ORDER and a specific recipient.
        /// </summary>
        /// <value>
        /// Value of the column code
        /// </value>
		public PlanOrderDistributionAcknowledgementEnum PlanOrderDistributionAcknowledgementCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing the point in time when acknowledgement of a distributed PLAN-ORDER by a recipient occurred.
        /// </summary>
        /// <value>
        /// Value of the column dttm
        /// </value>
		public string Datetime { get; set; }
		
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
