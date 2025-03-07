using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity PlanStatus that represents the table PLN_STAT
	/// 
	/// A record of the condition of a specific PLAN.
    /// </summary>
	[EntId(10000355)]
    [EntName("PLAN-STATUS")]
    [EntTableName("PLN_STAT")]
    [EntDepth(2)]
    public interface IPlanStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column pln_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column pln_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("plan-id")]
		[AttrColumnName("pln_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000933)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal PlanId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pln_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-STATUS for a specific PLAN and to distinguish it from all other PLAN-STATUSs for that PLAN.
        /// </summary>
        /// <value>
        /// Value of the column pln_stat_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("plan-status-index")]
		[AttrColumnName("pln_stat_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dvlpm_stat_code
		///
		/// The specific value assigned to represent the state of preparation for a specific PLAN.
        /// </summary>
        /// <value>
        /// Value of the column dvlpm_stat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("plan-status-development-status-code")]
		[AttrColumnName("dvlpm_stat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100004393)]
        [DataLength(6)]
        [DataDecimals(0)]
        PlanStatusDevelopmentStatusEnum DevelopmentStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column state_code
		///
		/// The specific value assigned to represent the condition for a specific PLAN.
        /// </summary>
        /// <value>
        /// Value of the column state_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("plan-status-state-code")]
		[AttrColumnName("state_code")]
        [AttrSeqnr(4)]
        [DomId(100004394)]
        [DataLength(6)]
        [DataDecimals(0)]
        PlanStatusStateEnum? State { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing the point in time for a specific PLAN-STATUS.
        /// </summary>
        /// <value>
        /// Value of the column dttm
        /// </value>
        [AttrIx(100005)]
		[AttrName("plan-status-datetime")]
		[AttrColumnName("dttm")]
        [AttrSeqnr(5)]
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
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(6)]
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
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(7)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
