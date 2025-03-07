using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity OperationalInformationGroupPlanOrderContent that represents the table OIG_PLN_ORDR_CNTNT
	/// 
	/// The identification of a specific PLAN-ORDER that is included as content in a specific OPERATIONAL-INFORMATION-GROUP.
    /// </summary>
	[EntId(10000340)]
    [EntName("OPERATIONAL-INFORMATION-GROUP-PLAN-ORDER-CONTENT")]
    [EntTableName("OIG_PLN_ORDR_CNTNT")]
    [EntDepth(3)]
    public interface IOperationalInformationGroupPlanOrderContent
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column oig_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CONTEXT and to distinguish it from all other CONTEXTs.
        /// </summary>
        /// <value>
        /// Value of the column oig_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("operational-information-group-id")]
		[AttrColumnName("oig_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000901)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal OperationalInformationGroupId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column oig_pln_ordr_cntnt_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OPERATIONAL-INFORMATION-GROUP-PLAN-ORDER-CONTENT for a specific OPERATIONAL-INFORMATION-GROUP and to distinguish it from all other OPERATIONAL-INFORMATION-GROUP-PLAN-ORDER-CONTENTs for that OPERATIONAL-INFORMATION-GROUP.
        /// </summary>
        /// <value>
        /// Value of the column oig_pln_ordr_cntnt_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("operational-information-group-plan-order-content-index")]
		[AttrColumnName("oig_pln_ordr_cntnt_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that indicates the beginning or end of the association between a specific OPERATIONAL-INFORMATION-GROUP and a specific PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("operational-information-group-plan-order-content-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100004242)]
        [DataLength(6)]
        [DataDecimals(0)]
        AssociationStatusCategoryEnum OperationalInformationGroupPlanOrderContentCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing a point in time for a specific OPERATIONAL-INFORMATION-GROUP-PLAN-ORDER-CONTENT.
        /// </summary>
        /// <value>
        /// Value of the column dttm
        /// </value>
        [AttrIx(100004)]
		[AttrName("operational-information-group-plan-order-content-datetime")]
		[AttrColumnName("dttm")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string Datetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pln_ordr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column pln_ordr_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("plan-order-id")]
		[AttrColumnName("pln_ordr_id")]
        [AttrSeqnr(5)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000933)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal PlanOrderId { get; set; }
		
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
