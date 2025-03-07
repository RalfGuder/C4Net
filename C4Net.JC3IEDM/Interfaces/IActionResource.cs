using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionResource that represents the table ACT_RES
	/// 
	/// An OBJECT-ITEM or an OBJECT-TYPE that is required, requested, allocated or otherwise used or planned to be used in conducting a specific ACTION.
    /// </summary>
	[EntId(10000012)]
    [EntName("ACTION-RESOURCE")]
    [EntTableName("ACT_RES")]
    [EntDepth(2)]
    public interface IActionResource
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("action-id")]
		[AttrColumnName("act_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_res_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-RESOURCE for a specific ACTION and to distinguish it from all other ACTION-RESOURCEs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_res_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-resource-index")]
		[AttrColumnName("act_res_ix")]
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
		/// The specific value that represents the class of ACTION-RESOURCE with respect to item or type. It serves as a discriminator that partitions ACTION-RESOURCE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-resource-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000117)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionResourceCategoryEnum ActionResourceCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column criticality_ind_code
		///
		/// The specific value that denotes a judgement whether a specific resource (OBJECT-ITEM or OBJECT-TYPE) associated with a specific ACTION is essential for the effective completion of that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column criticality_ind_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-resource-criticality-indicator-code")]
		[AttrColumnName("criticality_ind_code")]
        [AttrSeqnr(4)]
        [DomId(100000225)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionResourceCriticalityIndicatorEnum? CriticalityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qual_code
		///
		/// The specific value that represents the type of restriction or other qualification applicable to a specific ACTION-RESOURCE for a specific ACTION.
        /// </summary>
        /// <value>
        /// Value of the column qual_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("action-resource-qualifier-code")]
		[AttrColumnName("qual_code")]
        [AttrSeqnr(5)]
        [DomId(100000119)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionResourceQualifierEnum? Qualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column authorising_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column authorising_org_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("action-resource-authorising-organisation-id")]
		[AttrColumnName("authorising_org_id")]
        [AttrSeqnr(6)]
        [ForeignKey]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? AuthorisingOrganisationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(7)]
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
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(8)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
