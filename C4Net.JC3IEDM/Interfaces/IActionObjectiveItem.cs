using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionObjectiveItem that represents the table ACT_OBJVE_ITEM
	/// 
	/// A battlespace object (FACILITY, FEATURE, MATERIEL, ORGANISATION or PERSON) which is the focus of a specific ACTION.
    /// </summary>
	[EntId(10000009)]
    [EntName("ACTION-OBJECTIVE-ITEM")]
    [EntTableName("ACT_OBJVE_ITEM")]
    [EntDepth(6)]
    public interface IActionObjectiveItem
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
        /// Gets or sets the value of the column act_objve_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-OBJECTIVE for a specific ACTION and to distinguish it from all other ACTION-OBJECTIVEs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_objve_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-objective-index")]
		[AttrColumnName("act_objve_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionObjectiveIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ACTION-OBJECTIVE-ITEM. It serves as a discriminator that partitions ACTION-OBJECTIVE-ITEM into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-objective-item-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000206)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionObjectiveItemCategoryEnum ActionObjectiveItemCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column primacy_code
		///
		/// The specific value that represents the relative usage of a specific ACTION-OBJECTIVE-ITEM when more than one instance of ACTION-OBJECTIVE-ITEM is designated for a specific ACTION.
        /// </summary>
        /// <value>
        /// Value of the column primacy_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-objective-item-primacy-code")]
		[AttrColumnName("primacy_code")]
        [AttrSeqnr(4)]
        [DomId(100004317)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionObjectiveItemPrimacyEnum? Primacy { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ctgtlst_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-LISTs.
        /// </summary>
        /// <value>
        /// Value of the column ctgtlst_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("candidate-target-list-id")]
		[AttrColumnName("ctgtlst_id")]
        [AttrSeqnr(5)]
        [ForeignKey]
        [DomId(100000910)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? CandidateTargetListId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ctgtdet_item_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-DETAIL for a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-DETAILs for that CANDIDATE-TARGET-LIST.
        /// </summary>
        /// <value>
        /// Value of the column ctgtdet_item_ix
        /// </value>
        [AttrIx(100006)]
		[AttrName("candidate-target-detail-item-index")]
		[AttrColumnName("ctgtdet_item_ix")]
        [AttrSeqnr(6)]
        [ForeignKey]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? CandidateTargetDetailItemIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_id
        /// </value>
        [AttrIx(100007)]
		[AttrName("object-item-id")]
		[AttrColumnName("obj_item_id")]
        [AttrSeqnr(7)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemId { get; set; }
		
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
