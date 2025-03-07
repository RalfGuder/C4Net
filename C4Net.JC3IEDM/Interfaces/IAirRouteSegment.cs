using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity AirRouteSegment that represents the table AIR_ROUTE_SGMNT
	/// 
	/// A portion of a route to be flown usually without an intermediate stop, as defined by two consecutive significant points.
    /// </summary>
	[EntId(10000283)]
    [EntName("AIR-ROUTE-SEGMENT")]
    [EntTableName("AIR_ROUTE_SGMNT")]
    [EntDepth(4)]
    public interface IAirRouteSegment
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column air_route_sgmnt_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column air_route_sgmnt_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("air-route-segment-id")]
		[AttrColumnName("air_route_sgmnt_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column req_nvgtn_perf_code
		///
		/// The specific value that represents the required navigation performance when flying routes for which external route navigation aids are not provided.
        /// </summary>
        /// <value>
        /// Value of the column req_nvgtn_perf_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("air-route-segment-required-navigation-performance-code")]
		[AttrColumnName("req_nvgtn_perf_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004219)]
        [DataLength(6)]
        [DataDecimals(0)]
        AirRouteSegmentRequiredNavigationPerformanceEnum RequiredNavigationPerformance { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column civil_mil_code
		///
		/// The specific value that represents the civil/military status of the AIR-ROUTE-SEGMENT.
        /// </summary>
        /// <value>
        /// Value of the column civil_mil_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("air-route-segment-civil-military-code")]
		[AttrColumnName("civil_mil_code")]
        [AttrSeqnr(3)]
        [DomId(100004220)]
        [DataLength(6)]
        [DataDecimals(0)]
        AirRouteSegmentCivilMilitaryEnum? CivilMilitary { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column intl_route_code
		///
		/// The specific value that represents the domestic/international status of the AIR-ROUTE-SEGMENT.
        /// </summary>
        /// <value>
        /// Value of the column intl_route_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("air-route-segment-international-route-code")]
		[AttrColumnName("intl_route_code")]
        [AttrSeqnr(4)]
        [DomId(100004221)]
        [DataLength(6)]
        [DataDecimals(0)]
        AirRouteSegmentInternationalRouteEnum? InternationalRoute { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mntnd_speed_rate
		///
		/// The numeric value that denotes the speed of movement to be maintained between route points. The unit of measure is kilometres per hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column mntnd_speed_rate
        /// </value>
        [AttrIx(100005)]
		[AttrName("air-route-segment-maintained-speed-rate")]
		[AttrColumnName("mntnd_speed_rate")]
        [AttrSeqnr(5)]
        [DomId(100001300)]
        [DataLength(8)]
        [DataDecimals(4)]
        double? MaintainedSpeedRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column descr_txt
		///
		/// The character string assigned to represent the description of specific AIR-ROUTE-SEGMENT.
        /// </summary>
        /// <value>
        /// Value of the column descr_txt
        /// </value>
        [AttrIx(100006)]
		[AttrName("air-route-segment-description-text")]
		[AttrColumnName("descr_txt")]
        [AttrSeqnr(6)]
        [DomId(100001500)]
        [DataLength(255)]
        [DataDecimals(0)]
        string DescriptionText { get; set; }
		
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
