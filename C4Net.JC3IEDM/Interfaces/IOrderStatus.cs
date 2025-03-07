using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity OrderStatus that represents the table ORDR_STAT
	/// 
	/// A record of the condition of a specific ORDER.
    /// </summary>
	[EntId(10000342)]
    [EntName("ORDER-STATUS")]
    [EntTableName("ORDR_STAT")]
    [EntDepth(2)]
    public interface IOrderStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column ordr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column ordr_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("order-id")]
		[AttrColumnName("ordr_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000933)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal OrderId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ordr_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ORDER-STATUS for a specific ORDER and to distinguish it from all other ORDER-STATUSs for that ORDER.
        /// </summary>
        /// <value>
        /// Value of the column ordr_stat_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("order-status-index")]
		[AttrColumnName("ordr_stat_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column exec_state_code
		///
		/// The specific value assigned to represent the state of execution for a specific ORDER.
        /// </summary>
        /// <value>
        /// Value of the column exec_state_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("order-status-execution-state-code")]
		[AttrColumnName("exec_state_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100004383)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrderStatusExecutionStateEnum ExecutionState { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing the point in time for a specific ORDER-STATUS.
        /// </summary>
        /// <value>
        /// Value of the column dttm
        /// </value>
        [AttrIx(100004)]
		[AttrName("order-status-datetime")]
		[AttrColumnName("dttm")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string Datetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100000913)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
