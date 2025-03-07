using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity PLAN-ORDER-COMPONENT-CONTENT-REFERENCE that represents the table POC_CNTNT_REF.
	///
	/// The identification of a specific REFERENCE that applies to the given PLAN-ORDER-COMPONENT-CONTENT.
    /// </summary>
    [Serializable]
    [DefinitionName("PlanOrderComponentContentReference", "C4Net.JC3IEDM.Definitions.PlanOrderComponentContentReference.definition.xml")]
    public class PlanOrderComponentContentReference : IEntity, IPlanOrderComponentContentReference
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly PlanOrderComponentContentReferenceExpression _ = new PlanOrderComponentContentReferenceExpression();

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
        /// Gets or sets the value of the column poc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-COMPONENT for a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDER-COMPONENTs for that PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column poc_ix
        /// </value>
		public decimal PlanOrderComponentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poc_cntnt_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-COMPONENT-CONTENT for a specific PLAN-ORDER-COMPONENT and to distinguish it from all other PLAN-ORDER-COMPONENT-CONTENTs for that PLAN-ORDER-COMPONENT.
        /// </summary>
        /// <value>
        /// Value of the column poc_cntnt_ix
        /// </value>
		public decimal PlanOrderComponentContentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poc_cntnt_ref_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-COMPONENT-CONTENT-REFERENCE for a specific PLAN-ORDER-COMPONENT-CONTENT and to distinguish it from all other PLAN-ORDER-COMPONENT-CONTENT-REFERENCEs for that PLAN-ORDER-COMPONENT-CONTENT.
        /// </summary>
        /// <value>
        /// Value of the column poc_cntnt_ref_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the reason a specific REFERENCE is associated to a specific PLAN-ORDER-COMPONENT-CONTENT.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public PlanOrderComponentContentReferenceCategoryEnum PlanOrderComponentContentReferenceCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing the point in time when a specific REFERENCE is associated with a specific PLAN-ORDER-COMPONENT-CONTENT.
        /// </summary>
        /// <value>
        /// Value of the column dttm
        /// </value>
		public string Datetime { get; set; }
		
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
