using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity MilitaryPostType that represents the table MIL_POST_TYPE
	/// 
	/// A MILITARY-ORGANISATION-TYPE with a set of duties that can be fulfilled by one person.
    /// </summary>
	[EntId(10000204)]
    [EntName("MILITARY-POST-TYPE")]
    [EntTableName("MIL_POST_TYPE")]
    [EntDepth(4)]
    public interface IMilitaryPostType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mil_post_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column mil_post_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("military-post-type-id")]
		[AttrColumnName("mil_post_type_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type classification of a MILITARY-POST-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("military-post-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000375)]
        [DataLength(6)]
        [DataDecimals(0)]
        MilitaryPostTypeCategoryEnum MilitaryPostTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rank_code
		///
		/// The specific value that represents a designation for a military or naval grade that establishes the relative position or status of a specific MILITARY-POST-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column rank_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("military-post-type-rank-code")]
		[AttrColumnName("rank_code")]
        [AttrSeqnr(3)]
        [DomId(100000376)]
        [DataLength(6)]
        [DataDecimals(0)]
        MilitaryPostTypeRankEnum? Rank { get; set; }
		
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
