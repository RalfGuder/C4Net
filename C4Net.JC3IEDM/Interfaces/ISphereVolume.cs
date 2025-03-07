using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity SphereVolume that represents the table SPHERE_VOL
	/// 
	/// A GEOMETRIC-VOLUME that has its horizontal boundaries defined by the spherical surface determined by the radius and the specified POINT.
    /// </summary>
	[EntId(10000219)]
    [EntName("SPHERE-VOLUME")]
    [EntTableName("SPHERE_VOL")]
    [EntDepth(2)]
    public interface ISphereVolume
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column sphere_vol_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column sphere_vol_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("sphere-volume-id")]
		[AttrColumnName("sphere_vol_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column radius_dim
		///
		/// The one-dimensional linear distance representing the radius from the centre that defines the surface for a specific SPHERE-VOLUME.
        /// </summary>
        /// <value>
        /// Value of the column radius_dim
        /// </value>
        [AttrIx(100002)]
		[AttrName("sphere-volume-radius-dimension")]
		[AttrColumnName("radius_dim")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double RadiusDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column sphere_vol_centre_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column sphere_vol_centre_point_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("sphere-volume-centre-point-id")]
		[AttrColumnName("sphere_vol_centre_point_id")]
        [AttrSeqnr(3)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal CentrePointId { get; set; }
		
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
