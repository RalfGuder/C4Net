using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity TrackArea that represents the table TRACK_AREA
	/// 
	/// A SURFACE that is a rectangular section with its length defined by the two specific POINTs and its width by the sum of the widths to the left and right of the connecting line between the two points.
    /// </summary>
	[EntId(10000221)]
    [EntName("TRACK-AREA")]
    [EntTableName("TRACK_AREA")]
    [EntDepth(2)]
    public interface ITrackArea
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column track_area_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column track_area_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("track-area-id")]
		[AttrColumnName("track_area_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column left_width_dim
		///
		/// The one-dimensional linear distance representing the horizontal distance to the left measured orthogonally to the reference axis for a specific TRACK-AREA.
        /// </summary>
        /// <value>
        /// Value of the column left_width_dim
        /// </value>
        [AttrIx(100002)]
		[AttrName("track-area-left-width-dimension")]
		[AttrColumnName("left_width_dim")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double LeftWidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column right_width_dim
		///
		/// The one-dimensional linear distance representing the horizontal distance to the right measured orthogonally to the reference axis for a specific TRACK-AREA.
        /// </summary>
        /// <value>
        /// Value of the column right_width_dim
        /// </value>
        [AttrIx(100003)]
		[AttrName("track-area-right-width-dimension")]
		[AttrColumnName("right_width_dim")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double RightWidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column track_area_begin_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column track_area_begin_point_id
        /// </value>
        [AttrIx(100004)]
		[AttrName("track-area-begin-point-id")]
		[AttrColumnName("track_area_begin_point_id")]
        [AttrSeqnr(4)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal BeginPointId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column track_area_end_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column track_area_end_point_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("track-area-end-point-id")]
		[AttrColumnName("track_area_end_point_id")]
        [AttrSeqnr(5)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal EndPointId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(6)]
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
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(7)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
