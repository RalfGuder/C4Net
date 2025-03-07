using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Road that represents the table ROAD
	/// 
	/// A FACILITY that is a path or way with a specially prepared surface.
    /// </summary>
	[EntId(10000311)]
    [EntName("ROAD")]
    [EntTableName("ROAD")]
    [EntDepth(3)]
    public interface IRoad
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column road_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column road_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("road-id")]
		[AttrColumnName("road_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type of ROAD.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("road-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004264)]
        [DataLength(6)]
        [DataDecimals(0)]
        RoadCategoryEnum RoadCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column shoulder_width_code
		///
		/// The specific value that represents the average horizontal distance measured from side to side and perpendicular to the central axis of a specific hard shoulder (lane/area beside a highway for broken-down or not running vehicles).
        /// </summary>
        /// <value>
        /// Value of the column shoulder_width_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("road-shoulder-width-code")]
		[AttrColumnName("shoulder_width_code")]
        [AttrSeqnr(3)]
        [DomId(100004265)]
        [DataLength(6)]
        [DataDecimals(0)]
        RoadShoulderWidthEnum? ShoulderWidth { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column traffic_density_cnt
		///
		/// The integer value representing the average number of vehicles that occupy one kilometre of road space, expressed in vehicles per kilometre.
        /// </summary>
        /// <value>
        /// Value of the column traffic_density_cnt
        /// </value>
        [AttrIx(100004)]
		[AttrName("road-traffic-density-count")]
		[AttrColumnName("traffic_density_cnt")]
        [AttrSeqnr(4)]
        [DomId(100001800)]
        [DataLength(4)]
        [DataDecimals(0)]
        short? TrafficDensityCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column weather_cond_cat_code
		///
		/// The specific value that describes the passability of a ROAD considering the impact of weather on that ROAD.
        /// </summary>
        /// <value>
        /// Value of the column weather_cond_cat_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("road-weather-condition-category-code")]
		[AttrColumnName("weather_cond_cat_code")]
        [AttrSeqnr(5)]
        [DomId(100004266)]
        [DataLength(6)]
        [DataDecimals(0)]
        RoadWeatherConditionCategoryEnum? WeatherConditionCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column quality_code
		///
		/// The specific value that represents a subjective rating of the quality of the ROAD.
        /// </summary>
        /// <value>
        /// Value of the column quality_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("road-quality-code")]
		[AttrColumnName("quality_code")]
        [AttrSeqnr(6)]
        [DomId(100004267)]
        [DataLength(6)]
        [DataDecimals(0)]
        RoadQualityEnum? Quality { get; set; }
		
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
