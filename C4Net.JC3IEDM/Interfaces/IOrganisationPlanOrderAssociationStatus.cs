using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity OrganisationPlanOrderAssociationStatus that represents the table ORG_POA_STAT
	/// 
	/// A record of the perceived state of a specific ORGANISATION-PLAN-ORDER-ASSOCIATION as determined by the establishing organisation.
    /// </summary>
	[EntId(10000344)]
    [EntName("ORGANISATION-PLAN-ORDER-ASSOCIATION-STATUS")]
    [EntTableName("ORG_POA_STAT")]
    [EntDepth(3)]
    public interface IOrganisationPlanOrderAssociationStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column org_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("organisation-id")]
		[AttrColumnName("org_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal OrganisationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pln_ordr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column pln_ordr_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("plan-order-id")]
		[AttrColumnName("pln_ordr_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000933)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal PlanOrderId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_poa_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ORGANISATION-PLAN-ORDER-ASSOCIATION for a specific ORGANISATION and a specific PLAN-ORDER and to distinguish it from all other ORGANISATION-PLAN-ORDER-ASSOCIATIONs for that ORGANISATION and that PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column org_poa_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("organisation-plan-order-association-index")]
		[AttrColumnName("org_poa_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal OrganisationPlanOrderAssociationIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_poa_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ORGANISATION-PLAN-ORDER-ASSOCIATION-STATUS for a specific ORGANISATION-PLAN-ORDER-ASSOCIATION and to distinguish it from all other ORGANISATION-PLAN-ORDER-ASSOCIATION-STATUSs for that ORGANISATION-PLAN-ORDER-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column org_poa_stat_ix
        /// </value>
        [AttrIx(100004)]
		[AttrName("organisation-plan-order-association-status-index")]
		[AttrColumnName("org_poa_stat_ix")]
        [AttrSeqnr(4)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that indicates whether a specific ORGANISATION-PLAN-ORDER-ASSOCIATION-STATUS refers to the beginning or termination of the association.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("organisation-plan-order-association-status-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100004242)]
        [DataLength(6)]
        [DataDecimals(0)]
        AssociationStatusCategoryEnum OrganisationPlanOrderAssociationStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing a point in time when a specific ORGANISATION-PLAN-ORDER-ASSOCIATION-STATUS has been established.
        /// </summary>
        /// <value>
        /// Value of the column dttm
        /// </value>
        [AttrIx(100006)]
		[AttrName("organisation-plan-order-association-status-datetime")]
		[AttrColumnName("dttm")]
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string Datetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column estblng_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column estblng_org_id
        /// </value>
        [AttrIx(100007)]
		[AttrName("establishing-organisation-id")]
		[AttrColumnName("estblng_org_id")]
        [AttrSeqnr(7)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal EstablishingOrganisationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(8)]
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
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(9)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
