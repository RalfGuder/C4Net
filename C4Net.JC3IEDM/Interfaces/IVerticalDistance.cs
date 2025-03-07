using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity VerticalDistance that represents the table VER_DIST
	/// 
	/// A specification of the altitude or height of a point or a level as measured with respect to a specified reference datum in the direction normal to the plane that is tangent to the WGS84 ellipsoid of revolution.
    /// </summary>
	[EntId(10000222)]
    [EntName("VERTICAL-DISTANCE")]
    [EntTableName("VER_DIST")]
    [EntDepth(0)]
    public interface IVerticalDistance
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column ver_dist_id
		///
		/// The unique value, or set of characters, assigned to represent a specific VERTICAL-DISTANCE and to distinguish it from all other VERTICAL-DISTANCEs.
        /// </summary>
        /// <value>
        /// Value of the column ver_dist_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("vertical-distance-id")]
		[AttrColumnName("ver_dist_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100000915)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ref_code
		///
		/// The specific value that represents the reference system for a specific VERTICAL-DISTANCE.
        /// </summary>
        /// <value>
        /// Value of the column ref_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("vertical-distance-reference-code")]
		[AttrColumnName("ref_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004211)]
        [DataLength(6)]
        [DataDecimals(0)]
        VerticalDistanceReferenceEnum Reference { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dim
		///
		/// The one-dimensional linear distance representing the distance with respect to the specified vertical datum.
        /// </summary>
        /// <value>
        /// Value of the column dim
        /// </value>
        [AttrIx(100003)]
		[AttrName("vertical-distance-dimension")]
		[AttrColumnName("dim")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double Dimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column precision_code
		///
		/// The specific value that denotes the precision of specifying a VERTICAL-DISTANCE.
        /// </summary>
        /// <value>
        /// Value of the column precision_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("vertical-distance-precision-code")]
		[AttrColumnName("precision_code")]
        [AttrSeqnr(4)]
        [DomId(100004216)]
        [DataLength(6)]
        [DataDecimals(0)]
        DistancePrecisionEnum? Precision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column datum_txt
		///
		/// The character string assigned to represent a specific vertical reference datum.
        /// </summary>
        /// <value>
        /// Value of the column datum_txt
        /// </value>
        [AttrIx(100005)]
		[AttrName("vertical-distance-datum-text")]
		[AttrColumnName("datum_txt")]
        [AttrSeqnr(5)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string DatumText { get; set; }
		
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
