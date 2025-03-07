using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity AbsolutePoint that represents the table ABS_POINT
	/// 
	/// A POINT in a geodetic system.
    /// </summary>
	[EntId(10000002)]
    [EntName("ABSOLUTE-POINT")]
    [EntTableName("ABS_POINT")]
    [EntDepth(2)]
    public interface IAbsolutePoint
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column abs_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column abs_point_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("absolute-point-id")]
		[AttrColumnName("abs_point_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ABSOLUTE-POINT with respect to the reference frame. It serves as a discriminator that partitions ABSOLUTE-POINT into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("absolute-point-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004215)]
        [DataLength(6)]
        [DataDecimals(0)]
        AbsolutePointCategoryEnum AbsolutePointCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column abs_point_ver_dist_id
		///
		/// The unique value, or set of characters, assigned to represent a specific VERTICAL-DISTANCE and to distinguish it from all other VERTICAL-DISTANCEs.
        /// </summary>
        /// <value>
        /// Value of the column abs_point_ver_dist_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("absolute-point-vertical-distance-id")]
		[AttrColumnName("abs_point_ver_dist_id")]
        [AttrSeqnr(3)]
        [ForeignKey]
        [DomId(100000915)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? VerticalDistanceId { get; set; }
		
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
