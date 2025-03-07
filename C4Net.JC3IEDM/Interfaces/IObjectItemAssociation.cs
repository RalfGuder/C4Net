using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ObjectItemAssociation that represents the table OBJ_ITEM_ASSOC
	/// 
	/// A relationship of an OBJECT-ITEM as a subject with another OBJECT-ITEM as an object.
    /// </summary>
	[EntId(10000243)]
    [EntName("OBJECT-ITEM-ASSOCIATION")]
    [EntTableName("OBJ_ITEM_ASSOC")]
    [EntDepth(5)]
    public interface IObjectItemAssociation
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column subj_obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column subj_obj_item_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("object-item-association-subject-object-item-id")]
		[AttrColumnName("subj_obj_item_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal SubjectObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_obj_item_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("object-item-association-object-object-item-id")]
		[AttrColumnName("obj_obj_item_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_assoc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-ASSOCIATION for a subject OBJECT-ITEM and an object OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-ASSOCIATIONs for those OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_assoc_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("object-item-association-index")]
		[AttrColumnName("obj_item_assoc_ix")]
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
		/// The specific value that represents the type of relationship between the subject OBJECT-ITEM and the object OBJECT-ITEM in a specific OBJECT-ITEM-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("object-item-association-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100004142)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectItemAssociationCategoryEnum ObjectItemAssociationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the detailed type of relationship between the subject OBJECT-ITEM that is an ORGANISATION and the object OBJECT-ITEM that is an ORGANISATION in a specific OBJECT-ITEM-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("object-item-association-subcategory-code")]
		[AttrColumnName("subcat_code")]
        [AttrSeqnr(5)]
        [DomId(100000297)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectItemAssociationSubcategoryEnum? Subcategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_task_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_task_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("action-task-id")]
		[AttrColumnName("act_task_id")]
        [AttrSeqnr(6)]
        [ForeignKey]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? ActionTaskId { get; set; }
		
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
