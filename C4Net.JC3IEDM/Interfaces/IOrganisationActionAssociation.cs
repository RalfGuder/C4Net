using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity OrganisationActionAssociation that represents the table ORG_ACT_ASSOC
	/// 
	/// A relationship indicating the role of a specific ORGANISATION with respect to a specific ACTION.
    /// </summary>
	[EntId(10000170)]
    [EntName("ORGANISATION-ACTION-ASSOCIATION")]
    [EntTableName("ORG_ACT_ASSOC")]
    [EntDepth(2)]
    public interface IOrganisationActionAssociation
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
        /// Gets or sets the value of the column act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-id")]
		[AttrColumnName("act_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_act_assoc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ORGANISATION-ACTION-ASSOCIATION for a specific ORGANISATION and a specific ACTION and to distinguish it from all other ORGANISATION-ACTION-ASSOCIATIONs for that ORGANISATION and that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column org_act_assoc_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("organisation-action-association-index")]
		[AttrColumnName("org_act_assoc_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type of relationship between a specific ORGANISATION and a specific ACTION for a specific ORGANISATION-ACTION-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("organisation-action-association-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000310)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationActionAssociationCategoryEnum OrganisationActionAssociationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_dttm
		///
		/// The character string representing a point in time that designates the beginning of the period of effectiveness for a specific ORGANISATION-ACTION-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column effctv_dttm
        /// </value>
        [AttrIx(100005)]
		[AttrName("organisation-action-association-effective-datetime")]
		[AttrColumnName("effctv_dttm")]
        [AttrSeqnr(5)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string EffectiveDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column intent_txt
		///
		/// The character string assigned to represent a statement by a specific ORGANISATION outlining the commander's intent or the concept of operations with regard to a specific ACTION.
        /// </summary>
        /// <value>
        /// Value of the column intent_txt
        /// </value>
        [AttrIx(100006)]
		[AttrName("organisation-action-association-intent-text")]
		[AttrColumnName("intent_txt")]
        [AttrSeqnr(6)]
        [DomId(100001500)]
        [DataLength(4000)]
        [DataDecimals(0)]
        string IntentText { get; set; }
		
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
