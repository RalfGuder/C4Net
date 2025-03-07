using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity PersonType that represents the table PERS_TYPE
	/// 
	/// An OBJECT-TYPE that represents human beings about whom information is to be held.
    /// </summary>
	[EntId(10000104)]
    [EntName("PERSON-TYPE")]
    [EntTableName("PERS_TYPE")]
    [EntDepth(1)]
    public interface IPersonType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column pers_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column pers_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("person-type-id")]
		[AttrColumnName("pers_type_id")]
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
		/// The specific value that represents the class of PERSON-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("person-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000204)]
        [DataLength(6)]
        [DataDecimals(0)]
        PersonTypeCategoryEnum PersonTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the detailed class of PERSON-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("person-type-subcategory-code")]
		[AttrColumnName("subcat_code")]
        [AttrSeqnr(3)]
        [DomId(100000380)]
        [DataLength(6)]
        [DataDecimals(0)]
        PersonTypeSubcategoryEnum? Subcategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rank_code
		///
		/// The specific value that represents a designation for a military, naval, or civil grade that establishes the relative position or status of a specific PERSON-TYPE in an organisation.
        /// </summary>
        /// <value>
        /// Value of the column rank_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("person-type-rank-code")]
		[AttrColumnName("rank_code")]
        [AttrSeqnr(4)]
        [DomId(100000156)]
        [DataLength(6)]
        [DataDecimals(0)]
        PersonTypeRankEnum? Rank { get; set; }
		
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
