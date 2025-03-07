using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity PLAN-ORDER-ASSOCIATION that represents the table POA.
	///
	/// A relationship of a PLAN-ORDER as a subject with another PLAN-ORDER as an object.
    /// </summary>
    [Serializable]
    [DefinitionName("PlanOrderAssociation", "C4Net.JC3IEDM.Definitions.PlanOrderAssociation.definition.xml")]
    public class PlanOrderAssociation : IEntity, IPlanOrderAssociation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly PlanOrderAssociationExpression _ = new PlanOrderAssociationExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column poa_subj_pln_ordr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column poa_subj_pln_ordr_id
        /// </value>
		public decimal SubjectPlanOrderId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poa_obj_pln_ordr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column poa_obj_pln_ordr_id
        /// </value>
		public decimal ObjectPlanOrderId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poa_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-ASSOCIATION for a subject PLAN-ORDER and an object PLAN-ORDER and to distinguish it from all other PLAN-ORDER-ASSOCIATIONs for those PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column poa_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type of relationship between a subject PLAN-ORDER and an object PLAN-ORDER in a specific PLAN-ORDER-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public PlanOrderAssociationCategoryEnum PlanOrderAssociationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing the point in time when a specific PLAN-ORDER-ASSOCIATION is established.
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
