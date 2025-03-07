using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ObjectItemLocation that represents the table OBJ_ITEM_LOC
	/// 
	/// An association of an OBJECT-ITEM with a LOCATION that enables the geographic position of the OBJECT-ITEM to be specified. The operational meaning of geometry may also be specified.
    /// </summary>
	[EntId(10000224)]
    [EntName("OBJECT-ITEM-LOCATION")]
    [EntTableName("OBJ_ITEM_LOC")]
    [EntDepth(3)]
    public interface IObjectItemLocation
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("object-item-id")]
		[AttrColumnName("obj_item_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemId { get; set; }
		
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
        /// Gets or sets the value of the column obj_item_loc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-LOCATION for a specific OBJECT-ITEM and a specific LOCATION and to distinguish it from all other OBJECT-ITEM-LOCATIONs for that OBJECT-ITEM and that LOCATION.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_loc_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("object-item-location-index")]
		[AttrColumnName("obj_item_loc_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ver_acc_dim
		///
		/// The one-dimensional linear distance representing the uncertainty in terms of probable error range for the vertical axis of a specific OBJECT-ITEM-LOCATION.
        /// </summary>
        /// <value>
        /// Value of the column ver_acc_dim
        /// </value>
        [AttrIx(100004)]
		[AttrName("object-item-location-vertical-accuracy-dimension")]
		[AttrColumnName("ver_acc_dim")]
        [AttrSeqnr(4)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? VerticalAccuracyDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column horz_acc_dim
		///
		/// The one-dimensional linear distance representing the uncertainty in the horizontal plane in terms of probable circular error for a specific OBJECT-ITEM-LOCATION.
        /// </summary>
        /// <value>
        /// Value of the column horz_acc_dim
        /// </value>
        [AttrIx(100005)]
		[AttrName("object-item-location-horizontal-accuracy-dimension")]
		[AttrColumnName("horz_acc_dim")]
        [AttrSeqnr(5)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? HorizontalAccuracyDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column brng_angle
		///
		/// The rotational measurement clockwise from the line of true North to the direction of motion in the horizontal plane of a specific OBJECT-ITEM at a specific LOCATION.
        /// </summary>
        /// <value>
        /// Value of the column brng_angle
        /// </value>
        [AttrIx(100006)]
		[AttrName("object-item-location-bearing-angle")]
		[AttrColumnName("brng_angle")]
        [AttrSeqnr(6)]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double? BearingAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column brng_acc_angle
		///
		/// The rotational measurement of a sector that represents the uncertainty range in the estimate of the bearing at a specific OBJECT-ITEM-LOCATION. The sector is bisected by the bearing.
        /// </summary>
        /// <value>
        /// Value of the column brng_acc_angle
        /// </value>
        [AttrIx(100007)]
		[AttrName("object-item-location-bearing-accuracy-angle")]
		[AttrColumnName("brng_acc_angle")]
        [AttrSeqnr(7)]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double? BearingAccuracyAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column brng_precision_code
		///
		/// The specific value that represents the maximum resolution used for the expression of a bearing angle.
        /// </summary>
        /// <value>
        /// Value of the column brng_precision_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("object-item-location-bearing-precision-code")]
		[AttrColumnName("brng_precision_code")]
        [AttrSeqnr(8)]
        [DomId(100004218)]
        [DataLength(6)]
        [DataDecimals(0)]
        AnglePrecisionEnum? BearingPrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column incl_angle
		///
		/// The rotational measurement from the horizontal plane to the direction of motion of a specific OBJECT-ITEM at a specific LOCATION (point or shape), where the positive angle is vertically upward.
        /// </summary>
        /// <value>
        /// Value of the column incl_angle
        /// </value>
        [AttrIx(100009)]
		[AttrName("object-item-location-inclination-angle")]
		[AttrColumnName("incl_angle")]
        [AttrSeqnr(9)]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double? InclinationAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column incl_acc_angle
		///
		/// The rotational measurement of a vertical sector that represents the uncertainty range in the estimate of the inclination at a specific OBJECT-ITEM-LOCATION. The sector is bisected by the inclination.
        /// </summary>
        /// <value>
        /// Value of the column incl_acc_angle
        /// </value>
        [AttrIx(100010)]
		[AttrName("object-item-location-inclination-accuracy-angle")]
		[AttrColumnName("incl_acc_angle")]
        [AttrSeqnr(10)]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double? InclinationAccuracyAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column incl_precision_code
		///
		/// The specific value that represents the maximum resolution used for the expression of an inclination angle.
        /// </summary>
        /// <value>
        /// Value of the column incl_precision_code
        /// </value>
        [AttrIx(100011)]
		[AttrName("object-item-location-inclination-precision-code")]
		[AttrColumnName("incl_precision_code")]
        [AttrSeqnr(11)]
        [DomId(100004218)]
        [DataLength(6)]
        [DataDecimals(0)]
        AnglePrecisionEnum? InclinationPrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column speed_rate
		///
		/// The numeric value that denotes the motion of a specific OBJECT-ITEM at a specific LOCATION in terms of distance per unit time. The unit of measure is kilometres per hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column speed_rate
        /// </value>
        [AttrIx(100012)]
		[AttrName("object-item-location-speed-rate")]
		[AttrColumnName("speed_rate")]
        [AttrSeqnr(12)]
        [DomId(100001300)]
        [DataLength(8)]
        [DataDecimals(4)]
        double? SpeedRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column speed_acc_rate
		///
		/// The numeric value that denotes the uncertainty range in the estimate for the speed at a specific OBJECT-ITEM-LOCATION where the speed estimate falls at the centre of the accuracy range. The unit of measure is kilometres per hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column speed_acc_rate
        /// </value>
        [AttrIx(100013)]
		[AttrName("object-item-location-speed-accuracy-rate")]
		[AttrColumnName("speed_acc_rate")]
        [AttrSeqnr(13)]
        [DomId(100001300)]
        [DataLength(8)]
        [DataDecimals(4)]
        double? SpeedAccuracyRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column speed_precision_code
		///
		/// The specific value that represents the maximum resolution used for the expression of speed.
        /// </summary>
        /// <value>
        /// Value of the column speed_precision_code
        /// </value>
        [AttrIx(100014)]
		[AttrName("object-item-location-speed-precision-code")]
		[AttrColumnName("speed_precision_code")]
        [AttrSeqnr(14)]
        [DomId(100004217)]
        [DataLength(6)]
        [DataDecimals(0)]
        SpeedPrecisionEnum? SpeedPrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column meaning_code
		///
		/// The specific value that represents the meaning of the LOCATION geometry as it pertains to the OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column meaning_code
        /// </value>
        [AttrIx(100015)]
		[AttrName("object-item-location-meaning-code")]
		[AttrColumnName("meaning_code")]
        [AttrSeqnr(15)]
        [DomId(100004144)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectItemLocationMeaningEnum? Meaning { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rel_speed_code
		///
		/// The specific value that represents the speed of the object relative to its normal speed.
        /// </summary>
        /// <value>
        /// Value of the column rel_speed_code
        /// </value>
        [AttrIx(100016)]
		[AttrName("object-item-location-relative-speed-code")]
		[AttrColumnName("rel_speed_code")]
        [AttrSeqnr(16)]
        [DomId(100004337)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectItemLocationRelativeSpeedEnum? RelativeSpeed { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
        [AttrIx(100017)]
		[AttrName("reporting-data-id")]
		[AttrColumnName("rptd_id")]
        [AttrSeqnr(17)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000912)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ReportingDataId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100018)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(18)]
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
        [AttrIx(100019)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(19)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
