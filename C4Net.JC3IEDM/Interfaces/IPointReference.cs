using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity PointReference that represents the table POINT_REF
	/// 
	/// A RELATIVE-COORDINATE-SYSTEM that uses three specific POINTs to establish its frame of reference.
    /// </summary>
	[EntId(10000229)]
    [EntName("POINT-REFERENCE")]
    [EntTableName("POINT_REF")]
    [EntDepth(2)]
    public interface IPointReference
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column rel_coord_sys_id
		///
		/// The unique value, or set of characters, assigned to represent a specific RELATIVE-COORDINATE-SYSTEM and to distinguish it from all other RELATIVE-COORDINATE-SYSTEMs.
        /// </summary>
        /// <value>
        /// Value of the column rel_coord_sys_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("relative-coordinate-system-id")]
		[AttrColumnName("rel_coord_sys_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000916)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal RelativeCoordinateSystemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column point_ref_orgn_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column point_ref_orgn_point_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("point-reference-origin-point-id")]
		[AttrColumnName("point_ref_orgn_point_id")]
        [AttrSeqnr(2)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal OriginPointId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column point_ref_x_vector_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column point_ref_x_vector_point_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("point-reference-x-vector-point-id")]
		[AttrColumnName("point_ref_x_vector_point_id")]
        [AttrSeqnr(3)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal XVectorPointId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column point_ref_y_vector_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column point_ref_y_vector_point_id
        /// </value>
        [AttrIx(100004)]
		[AttrName("point-reference-y-vector-point-id")]
		[AttrColumnName("point_ref_y_vector_point_id")]
        [AttrSeqnr(4)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal YVectorPointId { get; set; }
		
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
