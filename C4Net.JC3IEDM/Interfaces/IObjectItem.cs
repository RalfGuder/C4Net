using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ObjectItem that represents the table OBJ_ITEM
	/// 
	/// An individually identified object that has military or civilian significance.
    /// </summary>
	[EntId(10000076)]
    [EntName("OBJECT-ITEM")]
    [EntTableName("OBJ_ITEM")]
    [EntDepth(0)]
    public interface IObjectItem
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
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of OBJECT-ITEM. It serves as a discriminator that partitions OBJECT-ITEM into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("object-item-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000144)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectItemCategoryEnum ObjectItemCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column name_txt
		///
		/// The character string assigned to represent a specific OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
        [AttrIx(100003)]
		[AttrName("object-item-name-text")]
		[AttrColumnName("name_txt")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100001500)]
        [DataLength(100)]
        [DataDecimals(0)]
        string NameText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100004)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(4)]
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
        [AttrIx(100005)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
