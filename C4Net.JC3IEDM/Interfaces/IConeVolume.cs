using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ConeVolume that represents the table CONE_VOL
	/// 
	/// A GEOMETRIC-VOLUME whose boundary is swept by a line that has a fixed point and another that moves along the path defined by the border of a specific SURFACE.
    /// </summary>
	[EntId(10000027)]
    [EntName("CONE-VOLUME")]
    [EntTableName("CONE_VOL")]
    [EntDepth(2)]
    public interface IConeVolume
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cone_vol_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column cone_vol_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("cone-volume-id")]
		[AttrColumnName("cone_vol_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cone_vol_dfng_surf_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column cone_vol_dfng_surf_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("cone-volume-defining-surface-id")]
		[AttrColumnName("cone_vol_dfng_surf_id")]
        [AttrSeqnr(2)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal DefiningSurfaceId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vertex_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column vertex_point_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("cone-volume-vertex-point-id")]
		[AttrColumnName("vertex_point_id")]
        [AttrSeqnr(3)]
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
