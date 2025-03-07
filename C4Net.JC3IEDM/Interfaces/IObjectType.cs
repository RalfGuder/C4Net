using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ObjectType that represents the table OBJ_TYPE
	/// 
	/// An individually identified class of objects that has military or civilian significance.
    /// </summary>
	[EntId(10000082)]
    [EntName("OBJECT-TYPE")]
    [EntTableName("OBJ_TYPE")]
    [EntDepth(0)]
    public interface IObjectType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column obj_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column obj_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("object-type-id")]
		[AttrColumnName("obj_type_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of OBJECT-TYPE. It serves as a discriminator that partitions OBJECT-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("object-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000148)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectTypeCategoryEnum ObjectTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column decoy_ind_code
		///
		/// The specific value that denotes whether a specific OBJECT-TYPE represents an object class acting as a decoy.
        /// </summary>
        /// <value>
        /// Value of the column decoy_ind_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("object-type-decoy-indicator-code")]
		[AttrColumnName("decoy_ind_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000300)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectTypeDecoyIndicatorEnum DecoyIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column name_txt
		///
		/// The character string assigned to represent a specific OBJECT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("object-type-name-text")]
		[AttrColumnName("name_txt")]
        [AttrSeqnr(4)]
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
        [AttrIx(100005)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(5)]
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
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
