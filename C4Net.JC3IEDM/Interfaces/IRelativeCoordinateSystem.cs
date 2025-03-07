using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity RelativeCoordinateSystem that represents the table REL_COORD_SYS
	/// 
	/// A rectangular frame of reference defined by an origin, x and y axes in the horizontal plane, and a z-axis. The vertical z-axis is normal to the xy-plane with positive direction determined from the right-hand rule when the x-axis is rotated toward the y-axis.
    /// </summary>
	[EntId(10000227)]
    [EntName("RELATIVE-COORDINATE-SYSTEM")]
    [EntTableName("REL_COORD_SYS")]
    [EntDepth(0)]
    public interface IRelativeCoordinateSystem
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
        [Mandatory]
        [DomId(100000916)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ref_cat_code
		///
		/// The specific value that represents the source of the reference for defining the origin and axial directions for a specific RELATIVE-COORDINATE-SYSTEM. It serves as a discriminator that partitions RELATIVE-COORDINATE-SYSTEM into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column ref_cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("relative-coordinate-system-reference-category-code")]
		[AttrColumnName("ref_cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004121)]
        [DataLength(6)]
        [DataDecimals(0)]
        RelativeCoordinateSystemReferenceCategoryEnum ReferenceCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(3)]
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
        [AttrIx(100004)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
