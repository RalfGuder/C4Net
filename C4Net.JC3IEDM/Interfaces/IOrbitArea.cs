using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity OrbitArea that represents the table ORBIT_AREA
	/// 
	/// A SURFACE that is (a) an open rectangular section defined by its width and the distance between the two specific POINTs, (b) is closed by two half-circles with radii equal to half the width, and is positioned left, centred, or right with respect to the line formed by the defining points.
    /// </summary>
	[EntId(10000216)]
    [EntName("ORBIT-AREA")]
    [EntTableName("ORBIT_AREA")]
    [EntDepth(2)]
    public interface IOrbitArea
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column orbit_area_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column orbit_area_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("orbit-area-id")]
		[AttrColumnName("orbit_area_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column alignment_code
		///
		/// The specific value that represents the placement of a specific ORBIT-AREA with respect to its defining reference axis.
        /// </summary>
        /// <value>
        /// Value of the column alignment_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("orbit-area-alignment-code")]
		[AttrColumnName("alignment_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004105)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrbitAreaAlignmentEnum Alignment { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column width_dim
		///
		/// The one-dimensional linear distance representing the horizontal distance measured from side to side for a specific ORBIT-AREA.
        /// </summary>
        /// <value>
        /// Value of the column width_dim
        /// </value>
        [AttrIx(100003)]
		[AttrName("orbit-area-width-dimension")]
		[AttrColumnName("width_dim")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double WidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column orbit_area_first_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column orbit_area_first_point_id
        /// </value>
        [AttrIx(100004)]
		[AttrName("orbit-area-first-point-id")]
		[AttrColumnName("orbit_area_first_point_id")]
        [AttrSeqnr(4)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal FirstPointId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column orbit_area_scnd_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column orbit_area_scnd_point_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("orbit-area-second-point-id")]
		[AttrColumnName("orbit_area_scnd_point_id")]
        [AttrSeqnr(5)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal SecondPointId { get; set; }
		
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
