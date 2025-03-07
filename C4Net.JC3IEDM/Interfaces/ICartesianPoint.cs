using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity CartesianPoint that represents the table CRTS_POINT
	/// 
	/// An ABSOLUTE-POINT that has its position specified in a three-dimensional Earth-centred Cartesian system.
    /// </summary>
	[EntId(10000281)]
    [EntName("CARTESIAN-POINT")]
    [EntTableName("CRTS_POINT")]
    [EntDepth(3)]
    public interface ICartesianPoint
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column crts_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column crts_point_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("cartesian-point-id")]
		[AttrColumnName("crts_point_id")]
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
		/// The one-dimensional linear distance representing the X-component of a coordinate which expresses the position of a point in a three-dimensional Cartesian coordinate system that is fixed to the earth, where the X-axis lies in the planes of the Equator and the Greenwich meridian.
        /// </summary>
        /// <value>
        /// Value of the column x_coord_dim
        /// </value>
        [AttrIx(100002)]
		[AttrName("cartesian-point-x-coordinate-dimension")]
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
		/// The one-dimensional linear distance representing the Y-component of a coordinate which expresses the position of a point in a three-dimensional Cartesian coordinate system that is fixed to the earth where the Y-axis is perpendicular to both the X- and Z-axes completing the right-handed coordinate system.
        /// </summary>
        /// <value>
        /// Value of the column y_coord_dim
        /// </value>
        [AttrIx(100003)]
		[AttrName("cartesian-point-y-coordinate-dimension")]
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
		/// The one-dimensional linear distance representing the Z-component of a coordinate which expresses the position of a point in a three-dimensional Cartesian coordinate system that is fixed to the earth, where the Z-axis coincides with the mean rotation axis of the Earth.
        /// </summary>
        /// <value>
        /// Value of the column z_coord_dim
        /// </value>
        [AttrIx(100004)]
		[AttrName("cartesian-point-z-coordinate-dimension")]
		[AttrColumnName("z_coord_dim")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double ZCoordinateDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column x_precision_code
		///
		/// The specific value that represents the resolution used for the expression of a value of a Cartesian x-coordinate.
        /// </summary>
        /// <value>
        /// Value of the column x_precision_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("cartesian-point-x-precision-code")]
		[AttrColumnName("x_precision_code")]
        [AttrSeqnr(5)]
        [DomId(100004216)]
        [DataLength(6)]
        [DataDecimals(0)]
        DistancePrecisionEnum? XPrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column y_precision_code
		///
		/// The specific value that represents the resolution used for the expression of a value of a Cartesian y-coordinate.
        /// </summary>
        /// <value>
        /// Value of the column y_precision_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("cartesian-point-y-precision-code")]
		[AttrColumnName("y_precision_code")]
        [AttrSeqnr(6)]
        [DomId(100004216)]
        [DataLength(6)]
        [DataDecimals(0)]
        DistancePrecisionEnum? YPrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column z_precision_code
		///
		/// The specific value that represents the resolution used for the expression of a value of a Cartesian z-coordinate.
        /// </summary>
        /// <value>
        /// Value of the column z_precision_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("cartesian-point-z-precision-code")]
		[AttrColumnName("z_precision_code")]
        [AttrSeqnr(7)]
        [DomId(100004216)]
        [DataLength(6)]
        [DataDecimals(0)]
        DistancePrecisionEnum? ZPrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(8)]
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
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(9)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
