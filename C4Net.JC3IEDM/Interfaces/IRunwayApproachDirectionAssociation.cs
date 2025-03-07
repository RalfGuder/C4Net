using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity RunwayApproachDirectionAssociation that represents the table RUNWAY_APPR_DIR_ASSOC
	/// 
	/// A relationship of a subject RUNWAY with an object APPROACH-DIRECTION.
    /// </summary>
	[EntId(10000320)]
    [EntName("RUNWAY-APPROACH-DIRECTION-ASSOCIATION")]
    [EntTableName("RUNWAY_APPR_DIR_ASSOC")]
    [EntDepth(4)]
    public interface IRunwayApproachDirectionAssociation
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column runway_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column runway_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("runway-id")]
		[AttrColumnName("runway_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal RunwayId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column appr_dir_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column appr_dir_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("approach-direction-id")]
		[AttrColumnName("appr_dir_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ApproachDirectionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column slope_rat
		///
		/// The numeric quotient value that represents the incline of the runway seen from the direction of the APPROACH-DIRECTION as proportion of vertical change with respect to the length of the runway. The value must be in the range from -.09 to +.09. Note: A negative value indicates a downward slope.
        /// </summary>
        /// <value>
        /// Value of the column slope_rat
        /// </value>
        [AttrIx(100003)]
		[AttrName("runway-approach-direction-association-slope-ratio")]
		[AttrColumnName("slope_rat")]
        [AttrSeqnr(3)]
        [DomId(100001900)]
        [DataLength(6)]
        [DataDecimals(5)]
        double? SlopeRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lndg_dist_dim
		///
		/// The one-dimensional linear distance representing the length of the runway that is declared available and suitable for the ground run of an aircraft landing. The unit of measurement is feet.
        /// </summary>
        /// <value>
        /// Value of the column lndg_dist_dim
        /// </value>
        [AttrIx(100004)]
		[AttrName("runway-approach-direction-association-landing-distance-dimension")]
		[AttrColumnName("lndg_dist_dim")]
        [AttrSeqnr(4)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? LandingDistanceDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column takeoff_dist_dim
		///
		/// The one-dimensional linear distance representing the length of the available takeoff run plus the length of the overrun, if available, for an aircraft to takeoff. The unit of measurement is feet.
        /// </summary>
        /// <value>
        /// Value of the column takeoff_dist_dim
        /// </value>
        [AttrIx(100005)]
		[AttrName("runway-approach-direction-association-takeoff-distance-dimension")]
		[AttrColumnName("takeoff_dist_dim")]
        [AttrSeqnr(5)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? TakeoffDistanceDimension { get; set; }
		
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
