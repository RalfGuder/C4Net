using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ObjectItemGroupAccountDetail that represents the table OBJ_ITEM_GROUP_ACCT_DET
	/// 
	/// The total count and condition of a specific group included in a specific OBJECT-ITEM-GROUP-ACCOUNT. The group is defined as a specific PERSON-TYPE that may also be categorised by a specific GROUP-CHARACTERISTIC.
    /// </summary>
	[EntId(10000253)]
    [EntName("OBJECT-ITEM-GROUP-ACCOUNT-DETAIL")]
    [EntTableName("OBJ_ITEM_GROUP_ACCT_DET")]
    [EntDepth(4)]
    public interface IObjectItemGroupAccountDetail
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("object-item-id")]
		[AttrColumnName("obj_item_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_group_acct_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-GROUP-ACCOUNT for a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-GROUP-ACCOUNTs for that OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_group_acct_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("object-item-group-account-index")]
		[AttrColumnName("obj_item_group_acct_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemGroupAccountIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_group_acct_det_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-GROUP-ACCOUNT-DETAIL for a specific OBJECT-ITEM-GROUP-ACCOUNT and to distinguish it from all other OBJECT-ITEM-GROUP-ACCOUNT-DETAILs for that OBJECT-ITEM-GROUP-ACCOUNT.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_group_acct_det_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("object-item-group-account-detail-index")]
		[AttrColumnName("obj_item_group_acct_det_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cnt
		///
		/// The integer value representing the aggregated units in a specific OBJECT-ITEM-GROUP-ACCOUNT-DETAIL.
        /// </summary>
        /// <value>
        /// Value of the column cnt
        /// </value>
        [AttrIx(100004)]
		[AttrName("object-item-group-account-detail-count")]
		[AttrColumnName("cnt")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100001800)]
        [DataLength(9)]
        [DataDecimals(0)]
        int Count { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qual_code
		///
		/// The specific value that describes the condition of the group counted in a specific OBJECT-ITEM-GROUP-ACCOUNT-DETAIL.
        /// </summary>
        /// <value>
        /// Value of the column qual_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("object-item-group-account-detail-qualifier-code")]
		[AttrColumnName("qual_code")]
        [AttrSeqnr(5)]
        [DomId(100004157)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectItemGroupAccountDetailQualifierEnum? Qualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column group_chrct_id
		///
		/// The unique value, or set of characters, assigned to represent a specific GROUP-CHARACTERISTIC and to distinguish it from all other GROUP-CHARACTERISTICs.
        /// </summary>
        /// <value>
        /// Value of the column group_chrct_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("group-characteristic-id")]
		[AttrColumnName("group_chrct_id")]
        [AttrSeqnr(6)]
        [ForeignKey]
        [DomId(100000918)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? GroupCharacteristicId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pers_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column pers_type_id
        /// </value>
        [AttrIx(100007)]
		[AttrName("person-type-id")]
		[AttrColumnName("pers_type_id")]
        [AttrSeqnr(7)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal PersonTypeId { get; set; }
		
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
