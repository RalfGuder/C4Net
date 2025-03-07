using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity PolyarcArea that represents the table PLYRC_AREA
	/// 
	/// A SURFACE that consists of a circular arc and a polygonal segment defined by a specific LINE whose beginning coincides with the initial point of the arc and whose end coincides with the last point of the arc.
    /// </summary>
	[EntId(10000217)]
    [EntName("POLYARC-AREA")]
    [EntTableName("PLYRC_AREA")]
    [EntDepth(2)]
    public interface IPolyarcArea
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column plyrc_area_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column plyrc_area_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("polyarc-area-id")]
		[AttrColumnName("plyrc_area_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column begin_brng_angle
		///
		/// The rotational measurement clockwise from true North to the left side of a horizontal conical section used in defining a specific POLYARC-AREA.
        /// </summary>
        /// <value>
        /// Value of the column begin_brng_angle
        /// </value>
        [AttrIx(100002)]
		[AttrName("polyarc-area-begin-bearing-angle")]
		[AttrColumnName("begin_brng_angle")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double BeginBearingAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column end_brng_angle
		///
		/// The rotational measurement clockwise from true North to the right side of a horizontal conical section used in defining a specific POLYARC-AREA.
        /// </summary>
        /// <value>
        /// Value of the column end_brng_angle
        /// </value>
        [AttrIx(100003)]
		[AttrName("polyarc-area-end-bearing-angle")]
		[AttrColumnName("end_brng_angle")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double EndBearingAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column arc_radius_dim
		///
		/// The one-dimensional linear distance representing the distance from the vertex to the ring sector used to define part of a specific POLYARC-AREA.
        /// </summary>
        /// <value>
        /// Value of the column arc_radius_dim
        /// </value>
        [AttrIx(100004)]
		[AttrName("polyarc-area-arc-radius-dimension")]
		[AttrColumnName("arc_radius_dim")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double ArcRadiusDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column plyrc_area_dfng_line_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column plyrc_area_dfng_line_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("polyarc-area-defining-line-id")]
		[AttrColumnName("plyrc_area_dfng_line_id")]
        [AttrSeqnr(5)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal DefiningLineId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column plyrc_area_brng_orgn_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column plyrc_area_brng_orgn_point_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("polyarc-area-bearing-origin-point-id")]
		[AttrColumnName("plyrc_area_brng_orgn_point_id")]
        [AttrSeqnr(6)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal BearingOriginPointId { get; set; }
		
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
