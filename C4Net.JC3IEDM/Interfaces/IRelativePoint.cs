using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity RelativePoint that represents the table REL_POINT
	/// 
	/// A POINT whose position is specified with respect to a specific RELATIVE-COORDINATE-SYSTEM.
    /// </summary>
	[EntId(10000111)]
    [EntName("RELATIVE-POINT")]
    [EntTableName("REL_POINT")]
    [EntDepth(2)]
    public interface IRelativePoint
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column rel_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column rel_point_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("relative-point-id")]
		[AttrColumnName("rel_point_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column x_coord_dim
		///
		/// The one-dimensional linear distance representing the displacement of the specific RELATIVE-POINT along the x-axis with respect to a specific RELATIVE-COORDINATE-SYSTEM.
        /// </summary>
        /// <value>
        /// Value of the column x_coord_dim
        /// </value>
        [AttrIx(100002)]
		[AttrName("relative-point-x-coordinate-dimension")]
		[AttrColumnName("x_coord_dim")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double XCoordinateDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column y_coord_dim
		///
		/// The one-dimensional linear distance representing the displacement of the specific RELATIVE-POINT along the y-axis with respect to a specific RELATIVE-COORDINATE-SYSTEM.
        /// </summary>
        /// <value>
        /// Value of the column y_coord_dim
        /// </value>
        [AttrIx(100003)]
		[AttrName("relative-point-y-coordinate-dimension")]
		[AttrColumnName("y_coord_dim")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double YCoordinateDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column z_coord_dim
		///
		/// The one-dimensional linear distance representing the displacement of the specific RELATIVE-POINT along the z-axis with respect to a specific RELATIVE-COORDINATE-SYSTEM.
        /// </summary>
        /// <value>
        /// Value of the column z_coord_dim
        /// </value>
        [AttrIx(100004)]
		[AttrName("relative-point-z-coordinate-dimension")]
		[AttrColumnName("z_coord_dim")]
        [AttrSeqnr(4)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? ZCoordinateDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column x_precision_code
		///
		/// The specific value that represents the maximum resolution used for the expression of a value of an x-coordinate.
        /// </summary>
        /// <value>
        /// Value of the column x_precision_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("relative-point-x-precision-code")]
		[AttrColumnName("x_precision_code")]
        [AttrSeqnr(5)]
        [DomId(100004216)]
        [DataLength(6)]
        [DataDecimals(0)]
        DistancePrecisionEnum? XPrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column y_precision_code
		///
		/// The specific value that represents the maximum resolution used for the expression of a value of a y-coordinate.
        /// </summary>
        /// <value>
        /// Value of the column y_precision_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("relative-point-y-precision-code")]
		[AttrColumnName("y_precision_code")]
        [AttrSeqnr(6)]
        [DomId(100004216)]
        [DataLength(6)]
        [DataDecimals(0)]
        DistancePrecisionEnum? YPrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column z_precision_code
		///
		/// The specific value that represents the maximum resolution used for the expression of a value of a z-coordinate.
        /// </summary>
        /// <value>
        /// Value of the column z_precision_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("relative-point-z-precision-code")]
		[AttrColumnName("z_precision_code")]
        [AttrSeqnr(7)]
        [DomId(100004216)]
        [DataLength(6)]
        [DataDecimals(0)]
        DistancePrecisionEnum? ZPrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rel_coord_sys_id
		///
		/// The unique value, or set of characters, assigned to represent a specific RELATIVE-COORDINATE-SYSTEM and to distinguish it from all other RELATIVE-COORDINATE-SYSTEMs.
        /// </summary>
        /// <value>
        /// Value of the column rel_coord_sys_id
        /// </value>
        [AttrIx(100008)]
		[AttrName("relative-coordinate-system-id")]
		[AttrColumnName("rel_coord_sys_id")]
        [AttrSeqnr(8)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000916)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal RelativeCoordinateSystemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(9)]
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
        [AttrIx(100010)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(10)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
