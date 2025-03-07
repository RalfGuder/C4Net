using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity PlanOrderDistributionAcknowledgement that represents the table PLN_ORDR_DISTR_ACK
	/// 
	/// A record that the organisation identified in a specific PLAN-ORDER-DISTRIBUTION has acknowledged the receipt of a specific PLAN-ORDER.
    /// </summary>
	[EntId(10000353)]
    [EntName("PLAN-ORDER-DISTRIBUTION-ACKNOWLEDGEMENT")]
    [EntTableName("PLN_ORDR_DISTR_ACK")]
    [EntDepth(3)]
    public interface IPlanOrderDistributionAcknowledgement
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column pln_ordr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column pln_ordr_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("plan-order-id")]
		[AttrColumnName("pln_ordr_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000933)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal PlanOrderId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pln_ordr_distr_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-DISTRIBUTION for a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDER-DISTRIBUTIONs for that PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column pln_ordr_distr_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("plan-order-distribution-index")]
		[AttrColumnName("pln_ordr_distr_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal PlanOrderDistributionIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pln_ordr_distr_ack_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-DISTRIBUTION-ACKNOWLEDGEMENT for a specific PLAN-ORDER-DISTRIBUTION and to distinguish it from all other PLAN-ORDER-DISTRIBUTION-ACKNOWLEDGEMENTs for that PLAN-ORDER-DISTRIBUTION.
        /// </summary>
        /// <value>
        /// Value of the column pln_ordr_distr_ack_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("plan-order-distribution-acknowledgement-index")]
		[AttrColumnName("pln_ordr_distr_ack_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column code
		///
		/// The specific value that represents the type of acknowledgement of the distribution for a specific PLAN-ORDER and a specific recipient.
        /// </summary>
        /// <value>
        /// Value of the column code
        /// </value>
        [AttrIx(100004)]
		[AttrName("plan-order-distribution-acknowledgement-code")]
		[AttrColumnName("code")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100004391)]
        [DataLength(6)]
        [DataDecimals(0)]
        PlanOrderDistributionAcknowledgementEnum PlanOrderDistributionAcknowledgementCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing the point in time when acknowledgement of a distributed PLAN-ORDER by a recipient occurred.
        /// </summary>
        /// <value>
        /// Value of the column dttm
        /// </value>
        [AttrIx(100005)]
		[AttrName("plan-order-distribution-acknowledgement-datetime")]
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
