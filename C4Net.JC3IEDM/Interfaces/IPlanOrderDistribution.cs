using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity PlanOrderDistribution that represents the table PLN_ORDR_DISTR
	/// 
	/// A record that an ORGANISATION is the intended recipient of a specific PLAN-ORDER.
    /// </summary>
	[EntId(10000352)]
    [EntName("PLAN-ORDER-DISTRIBUTION")]
    [EntTableName("PLN_ORDR_DISTR")]
    [EntDepth(2)]
    public interface IPlanOrderDistribution
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
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value assigned to represent the type of PLAN-ORDER-DISTRIBUTION with respect to the reason for its dissemination.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("plan-order-distribution-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100004390)]
        [DataLength(6)]
        [DataDecimals(0)]
        PlanOrderDistributionCategoryEnum PlanOrderDistributionCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column release_dttm
		///
		/// The character string representing the point in time for the intended release of a specific PLAN-ORDER to a specific ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column release_dttm
        /// </value>
        [AttrIx(100004)]
		[AttrName("plan-order-distribution-release-datetime")]
		[AttrColumnName("release_dttm")]
        [AttrSeqnr(4)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string ReleaseDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column recipient_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column recipient_org_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("recipient-organisation-id")]
		[AttrColumnName("recipient_org_id")]
        [AttrSeqnr(5)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal RecipientOrganisationId { get; set; }
		
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
