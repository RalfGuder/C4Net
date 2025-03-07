using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ORDER-STATUS that represents the table ORDR_STAT.
	///
	/// A record of the condition of a specific ORDER.
    /// </summary>
    [Serializable]
    [DefinitionName("OrderStatus", "C4Net.JC3IEDM.Definitions.OrderStatus.definition.xml")]
    public class OrderStatus : IEntity, IOrderStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly OrderStatusExpression _ = new OrderStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column ordr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column ordr_id
        /// </value>
		public decimal OrderId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ordr_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ORDER-STATUS for a specific ORDER and to distinguish it from all other ORDER-STATUSs for that ORDER.
        /// </summary>
        /// <value>
        /// Value of the column ordr_stat_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column exec_state_code
		///
		/// The specific value assigned to represent the state of execution for a specific ORDER.
        /// </summary>
        /// <value>
        /// Value of the column exec_state_code
        /// </value>
		public OrderStatusExecutionStateEnum ExecutionState { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing the point in time for a specific ORDER-STATUS.
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
