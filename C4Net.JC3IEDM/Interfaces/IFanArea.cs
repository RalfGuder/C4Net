using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity FanArea that represents the table FAN_AREA
	/// 
	/// A SURFACE that is in the form of a truncated ring sector, lying between and being bounded by the rays emanating from the centre-point of the ring and having a specified central angle.
    /// </summary>
	[EntId(10000048)]
    [EntName("FAN-AREA")]
    [EntTableName("FAN_AREA")]
    [EntDepth(2)]
    public interface IFanArea
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column fan_area_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column fan_area_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("fan-area-id")]
		[AttrColumnName("fan_area_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mnm_range_dim
		///
		/// The one-dimensional linear distance representing the distance from the vertex to the inner ring of the ring sector used to specify the FAN-AREA.
        /// </summary>
        /// <value>
        /// Value of the column mnm_range_dim
        /// </value>
        [AttrIx(100002)]
		[AttrName("fan-area-minimum-range-dimension")]
		[AttrColumnName("mnm_range_dim")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double MinimumRangeDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_range_dim
		///
		/// The one-dimensional linear distance representing distance from the vertex to the outer ring of the ring sector used to specify the FAN-AREA.
        /// </summary>
        /// <value>
        /// Value of the column max_range_dim
        /// </value>
        [AttrIx(100003)]
		[AttrName("fan-area-maximum-range-dimension")]
		[AttrColumnName("max_range_dim")]
        [AttrSeqnr(3)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? MaximumRangeDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column orient_angle
		///
		/// The rotational measurement clockwise between the line of true north and the left side of the sector for a specific FAN-AREA.
        /// </summary>
        /// <value>
        /// Value of the column orient_angle
        /// </value>
        [AttrIx(100004)]
		[AttrName("fan-area-orientation-angle")]
		[AttrColumnName("orient_angle")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double OrientationAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column sctr_size_angle
		///
		/// The rotational measurement clockwise between the left and right sides of the sector for a specific FAN-AREA.
        /// </summary>
        /// <value>
        /// Value of the column sctr_size_angle
        /// </value>
        [AttrIx(100005)]
		[AttrName("fan-area-sector-size-angle")]
		[AttrColumnName("sctr_size_angle")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double SectorSizeAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fan_area_vertex_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column fan_area_vertex_point_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("fan-area-vertex-point-id")]
		[AttrColumnName("fan_area_vertex_point_id")]
        [AttrSeqnr(6)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal VertexPointId { get; set; }
		
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
