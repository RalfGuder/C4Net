using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OPERATIONAL-INFORMATION-GROUP-PLAN-ORDER-CONTENT that represents the table OIG_PLN_ORDR_CNTNT.
	///
	/// The identification of a specific PLAN-ORDER that is included as content in a specific OPERATIONAL-INFORMATION-GROUP.
    /// </summary>
    [Serializable]
    [DefinitionName("OperationalInformationGroupPlanOrderContent", "C4Net.JC3IEDM.Definitions.OperationalInformationGroupPlanOrderContent.definition.xml")]
    public class OperationalInformationGroupPlanOrderContent : IEntity, IOperationalInformationGroupPlanOrderContent
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly OperationalInformationGroupPlanOrderContentExpression _ = new OperationalInformationGroupPlanOrderContentExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column oig_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CONTEXT and to distinguish it from all other CONTEXTs.
        /// </summary>
        /// <value>
        /// Value of the column oig_id
        /// </value>
		public decimal OperationalInformationGroupId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column oig_pln_ordr_cntnt_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OPERATIONAL-INFORMATION-GROUP-PLAN-ORDER-CONTENT for a specific OPERATIONAL-INFORMATION-GROUP and to distinguish it from all other OPERATIONAL-INFORMATION-GROUP-PLAN-ORDER-CONTENTs for that OPERATIONAL-INFORMATION-GROUP.
        /// </summary>
        /// <value>
        /// Value of the column oig_pln_ordr_cntnt_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that indicates the beginning or end of the association between a specific OPERATIONAL-INFORMATION-GROUP and a specific PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public AssociationStatusCategoryEnum OperationalInformationGroupPlanOrderContentCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing a point in time for a specific OPERATIONAL-INFORMATION-GROUP-PLAN-ORDER-CONTENT.
        /// </summary>
        /// <value>
        /// Value of the column dttm
        /// </value>
		public string Datetime { get; set; }
		
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
