using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionLocation that represents the table ACT_LOC
	/// 
	/// An association of an ACTION with a LOCATION that enables the geographic position of the ACTION to be specified.
    /// </summary>
	[EntId(10000303)]
    [EntName("ACTION-LOCATION")]
    [EntTableName("ACT_LOC")]
    [EntDepth(3)]
    public interface IActionLocation
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("action-id")]
		[AttrColumnName("act_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column loc_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column loc_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("location-id")]
		[AttrColumnName("loc_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal LocationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_loc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-LOCATION for a specific ACTION and a specific LOCATION and to distinguish it from all other ACTION-LOCATIONs for that ACTION and that LOCATION.
        /// </summary>
        /// <value>
        /// Value of the column act_loc_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-location-index")]
		[AttrColumnName("act_loc_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column acc_dim
		///
		/// The one-dimensional linear distance representing the uncertainty in the estimate of a specific ACTION-LOCATION.
        /// </summary>
        /// <value>
        /// Value of the column acc_dim
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-location-accuracy-dimension")]
		[AttrColumnName("acc_dim")]
        [AttrSeqnr(4)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? AccuracyDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column brng_angle
		///
		/// The rotational measurement clockwise from true North to the right side of a horizontal conical section used in defining a specific ACTION-LOCATION.
        /// </summary>
        /// <value>
        /// Value of the column brng_angle
        /// </value>
        [AttrIx(100005)]
		[AttrName("action-location-bearing-angle")]
		[AttrColumnName("brng_angle")]
        [AttrSeqnr(5)]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double? BearingAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("reporting-data-id")]
		[AttrColumnName("rptd_id")]
        [AttrSeqnr(6)]
        [ForeignKey]
        [DomId(100000912)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? ReportingDataId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(7)]
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
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(8)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
