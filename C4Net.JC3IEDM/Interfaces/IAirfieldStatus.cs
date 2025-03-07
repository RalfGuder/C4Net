using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity AirfieldStatus that represents the table AIRFIELD_STAT
	/// 
	/// A FACILITY-STATUS that is a record of conditions of a specific AIRFIELD.
    /// </summary>
	[EntId(10000280)]
    [EntName("AIRFIELD-STATUS")]
    [EntTableName("AIRFIELD_STAT")]
    [EntDepth(5)]
    public interface IAirfieldStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column airfield_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column airfield_stat_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("airfield-status-id")]
		[AttrColumnName("airfield_stat_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-STATUS for a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-STATUSs for that OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_stat_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("object-item-status-index")]
		[AttrColumnName("obj_item_stat_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemStatusIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column day_opers_code
		///
		/// The specific value that indicates the status of a specific AIRFIELD to only operate during daylight.
        /// </summary>
        /// <value>
        /// Value of the column day_opers_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("airfield-status-day-operations-code")]
		[AttrColumnName("day_opers_code")]
        [AttrSeqnr(3)]
        [DomId(100004212)]
        [DataLength(6)]
        [DataDecimals(0)]
        AirfieldStatusDayOperationsEnum? DayOperations { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column flight_supp_cat_code
		///
		/// The specific value that indicates the capability of a specific AIRFIELD to function under defined flight rules.
        /// </summary>
        /// <value>
        /// Value of the column flight_supp_cat_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("airfield-status-flight-support-category-code")]
		[AttrColumnName("flight_supp_cat_code")]
        [AttrSeqnr(4)]
        [DomId(100004213)]
        [DataLength(6)]
        [DataDecimals(0)]
        AirfieldStatusFlightSupportCategoryEnum? FlightSupportCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column eval_ind_code
		///
		/// The specific value that indicates that an AIRFIELD has been checked and its characteristics have been verified.
        /// </summary>
        /// <value>
        /// Value of the column eval_ind_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("airfield-status-evaluation-indicator-code")]
		[AttrColumnName("eval_ind_code")]
        [AttrSeqnr(5)]
        [DomId(100004214)]
        [DataLength(6)]
        [DataDecimals(0)]
        AirfieldStatusEvaluationIndicatorEnum? EvaluationIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_nbac_thpt_cnt
		///
		/// The integer value representing the maximum count of narrow body civilian aircrafts (NBAC) that specific AIRFIELD can process per day.
        /// </summary>
        /// <value>
        /// Value of the column max_nbac_thpt_cnt
        /// </value>
        [AttrIx(100006)]
		[AttrName("airfield-status-maximum-nbac-throughput-count")]
		[AttrColumnName("max_nbac_thpt_cnt")]
        [AttrSeqnr(6)]
        [DomId(100001800)]
        [DataLength(4)]
        [DataDecimals(0)]
        short? MaximumNbacThroughputCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_nbac_park_cnt
		///
		/// The integer value representing the maximum count of narrow body civilian aircrafts (NBAC) that can be parked at a specific AIRFIELD at one time.
        /// </summary>
        /// <value>
        /// Value of the column max_nbac_park_cnt
        /// </value>
        [AttrIx(100007)]
		[AttrName("airfield-status-maximum-nbac-park-count")]
		[AttrColumnName("max_nbac_park_cnt")]
        [AttrSeqnr(7)]
        [DomId(100001800)]
        [DataLength(4)]
        [DataDecimals(0)]
        short? MaximumNbacParkCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_wbac_thpt_cnt
		///
		/// The integer value representing the maximum count of wide body civilian aircrafts (WBAC) that specific AIRFIELD can process per day.
        /// </summary>
        /// <value>
        /// Value of the column max_wbac_thpt_cnt
        /// </value>
        [AttrIx(100008)]
		[AttrName("airfield-status-maximum-wbac-throughput-count")]
		[AttrColumnName("max_wbac_thpt_cnt")]
        [AttrSeqnr(8)]
        [DomId(100001800)]
        [DataLength(4)]
        [DataDecimals(0)]
        short? MaximumWbacThroughputCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_wbac_park_cnt
		///
		/// The integer value representing the maximum count of wide body civilian aircrafts (WBAC) that can be parked at a specific AIRFIELD at one time.
        /// </summary>
        /// <value>
        /// Value of the column max_wbac_park_cnt
        /// </value>
        [AttrIx(100009)]
		[AttrName("airfield-status-maximum-wbac-park-count")]
		[AttrColumnName("max_wbac_park_cnt")]
        [AttrSeqnr(9)]
        [DomId(100001800)]
        [DataLength(4)]
        [DataDecimals(0)]
        short? MaximumWbacParkCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100010)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(10)]
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
        [AttrIx(100011)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(11)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
