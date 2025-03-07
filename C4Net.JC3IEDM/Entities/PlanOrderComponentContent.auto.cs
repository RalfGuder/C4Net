using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity PLAN-ORDER-COMPONENT-CONTENT that represents the table POC_CNTNT.
	///
	/// The aggregation of substantive subject matter for a specific PLAN-ORDER-COMPONENT.
    /// </summary>
    [Serializable]
    [DefinitionName("PlanOrderComponentContent", "C4Net.JC3IEDM.Definitions.PlanOrderComponentContent.definition.xml")]
    public class PlanOrderComponentContent : IEntity, IPlanOrderComponentContent
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly PlanOrderComponentContentExpression _ = new PlanOrderComponentContentExpression();

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
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing the point in time when PLAN-ORDER-COMPONENT-CONTENT is defined.
        /// </summary>
        /// <value>
        /// Value of the column dttm
        /// </value>
		public string Datetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column seq_ord
		///
		/// The sequence number in a specific PLAN-ORDER-COMPONENT-CONTENT that permits the proper ordering of the components of a PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column seq_ord
        /// </value>
		public int? SequenceOrdinal { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cmpnt_hdr_cntnt_id
		///
		/// The unique value, or set of characters, assigned to represent a specific COMPONENT-HEADER-CONTENT and to distinguish it from all other COMPONENT-HEADER-CONTENTs.
        /// </summary>
        /// <value>
        /// Value of the column cmpnt_hdr_cntnt_id
        /// </value>
		public decimal ComponentHeaderContentId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cmpnt_txt_cntnt_id
		///
		/// The unique value, or set of characters, assigned to represent a specific COMPONENT-TEXT-CONTENT and to distinguish it from all other COMPONENT-TEXT-CONTENTs.
        /// </summary>
        /// <value>
        /// Value of the column cmpnt_txt_cntnt_id
        /// </value>
		public decimal? ComponentTextContentId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poc_cntnt_data_contxt_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CONTEXT and to distinguish it from all other CONTEXTs.
        /// </summary>
        /// <value>
        /// Value of the column poc_cntnt_data_contxt_id
        /// </value>
		public decimal? DataContextId { get; set; }
		
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
