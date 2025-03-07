using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity CorridorArea that represents the table CORRIDOR_AREA
	/// 
	/// A SURFACE that is defined by its width and a sequence of points.
    /// </summary>
	[EntId(10000214)]
    [EntName("CORRIDOR-AREA")]
    [EntTableName("CORRIDOR_AREA")]
    [EntDepth(2)]
    public interface ICorridorArea
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column corridor_area_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column corridor_area_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("corridor-area-id")]
		[AttrColumnName("corridor_area_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column width_dim
		///
		/// The one-dimensional linear distance representing the horizontal distance measured from side to side for a CORRIDOR-AREA and distributed equally with respect to its centreline.
        /// </summary>
        /// <value>
        /// Value of the column width_dim
        /// </value>
        [AttrIx(100002)]
		[AttrName("corridor-area-width-dimension")]
		[AttrColumnName("width_dim")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double WidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column corridor_area_centre_line_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column corridor_area_centre_line_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("corridor-area-centre-line-id")]
		[AttrColumnName("corridor_area_centre_line_id")]
        [AttrSeqnr(3)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal CentreLineId { get; set; }
		
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
