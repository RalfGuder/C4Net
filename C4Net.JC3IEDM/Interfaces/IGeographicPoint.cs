using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity GeographicPoint that represents the table GEO_POINT
	/// 
	/// An ABSOLUTE-POINT that has its position specified with respect to the surface of the World Geodetic System 1984 (WGS 84) ellipsoid.
    /// </summary>
	[EntId(10000282)]
    [EntName("GEOGRAPHIC-POINT")]
    [EntTableName("GEO_POINT")]
    [EntDepth(3)]
    public interface IGeographicPoint
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column geo_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column geo_point_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("geographic-point-id")]
		[AttrColumnName("geo_point_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lat_coord
		///
		/// The numeric value that represents the angle between the plane of the equator and a line perpendicular to the ellipsoid surface and passing through the GEOGRAPHIC-POINT.
        /// </summary>
        /// <value>
        /// Value of the column lat_coord
        /// </value>
        [AttrIx(100002)]
		[AttrName("geographic-point-latitude-coordinate")]
		[AttrColumnName("lat_coord")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000401)]
        [DataLength(9)]
        [DataDecimals(6)]
        double LatitudeCoordinate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column long_coord
		///
		/// The numeric value that represents the angle between the initial (zero or Greenwich) meridian and the meridian of the GEOGRAPHIC-POINT measured in the plane of the Equator.
        /// </summary>
        /// <value>
        /// Value of the column long_coord
        /// </value>
        [AttrIx(100003)]
		[AttrName("geographic-point-longitude-coordinate")]
		[AttrColumnName("long_coord")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000402)]
        [DataLength(10)]
        [DataDecimals(6)]
        double LongitudeCoordinate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lat_precision_code
		///
		/// The specific value that represents the resolution used for the expression of a value of a latitude coordinate.
        /// </summary>
        /// <value>
        /// Value of the column lat_precision_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("geographic-point-latitude-precision-code")]
		[AttrColumnName("lat_precision_code")]
        [AttrSeqnr(4)]
        [DomId(100004218)]
        [DataLength(6)]
        [DataDecimals(0)]
        AnglePrecisionEnum? LatitudePrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column long_precision_code
		///
		/// The specific value that represents the resolution used for the expression of a value of a longitude coordinate.
        /// </summary>
        /// <value>
        /// Value of the column long_precision_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("geographic-point-longitude-precision-code")]
		[AttrColumnName("long_precision_code")]
        [AttrSeqnr(5)]
        [DomId(100004218)]
        [DataLength(6)]
        [DataDecimals(0)]
        AnglePrecisionEnum? LongitudePrecision { get; set; }
		
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
