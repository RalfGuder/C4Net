using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity PLAN-ORDER that represents the table PLN_ORDR.
	///
	/// A planned or ordered scheme worked out beforehand for the accomplishment of an operational objective.
    /// </summary>
    [Serializable]
    [DefinitionName("PlanOrder", "C4Net.JC3IEDM.Definitions.PlanOrder.definition.xml")]
    public class PlanOrder : IEntity, IPlanOrder
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly PlanOrderExpression _ = new PlanOrderExpression();

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
		public decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type of PLAN-ORDER. It serves as a discriminator that partitions PLAN-ORDER into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public PlanOrderCategoryEnum PlanOrderCategory { get; set; }
		
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
