using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Visibility that represents the table VISIBILITY
	/// 
	/// A METEOROLOGIC-FEATURE that specifies the distance at which an object illuminated by light in the visual spectrum can be detected.
    /// </summary>
	[EntId(10000130)]
    [EntName("VISIBILITY")]
    [EntTableName("VISIBILITY")]
    [EntDepth(3)]
    public interface IVisibility
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column visibility_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column visibility_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("visibility-id")]
		[AttrColumnName("visibility_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of obscurant that governs a particular VISIBILITY.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("visibility-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [DomId(100000305)]
        [DataLength(6)]
        [DataDecimals(0)]
        VisibilityCategoryEnum? VisibilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dir_code
		///
		/// The specific value that represents the direction for which a specific VISIBILITY is valid.
        /// </summary>
        /// <value>
        /// Value of the column dir_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("visibility-direction-code")]
		[AttrColumnName("dir_code")]
        [AttrSeqnr(3)]
        [DomId(100000222)]
        [DataLength(6)]
        [DataDecimals(0)]
        DirectionEnum? Direction { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column range_dim
		///
		/// The one-dimensional linear distance representing the distance which can be surveyed using visual observation for a specific VISIBILITY.
        /// </summary>
        /// <value>
        /// Value of the column range_dim
        /// </value>
        [AttrIx(100004)]
		[AttrName("visibility-range-dimension")]
		[AttrColumnName("range_dim")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double RangeDimension { get; set; }
		
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
