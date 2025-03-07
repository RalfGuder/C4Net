using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ROAD that represents the table ROAD.
	///
	/// A FACILITY that is a path or way with a specially prepared surface.
    /// </summary>
    [Serializable]
    [DefinitionName("Road", "C4Net.JC3IEDM.Definitions.Road.definition.xml")]
    public class Road : Facility, IRoad
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly RoadExpression _ = new RoadExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type of ROAD.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public RoadCategoryEnum RoadCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column shoulder_width_code
		///
		/// The specific value that represents the average horizontal distance measured from side to side and perpendicular to the central axis of a specific hard shoulder (lane/area beside a highway for broken-down or not running vehicles).
        /// </summary>
        /// <value>
        /// Value of the column shoulder_width_code
        /// </value>
		public RoadShoulderWidthEnum? ShoulderWidth { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column traffic_density_cnt
		///
		/// The integer value representing the average number of vehicles that occupy one kilometre of road space, expressed in vehicles per kilometre.
        /// </summary>
        /// <value>
        /// Value of the column traffic_density_cnt
        /// </value>
		public short? TrafficDensityCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column weather_cond_cat_code
		///
		/// The specific value that describes the passability of a ROAD considering the impact of weather on that ROAD.
        /// </summary>
        /// <value>
        /// Value of the column weather_cond_cat_code
        /// </value>
		public RoadWeatherConditionCategoryEnum? WeatherConditionCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column quality_code
		///
		/// The specific value that represents a subjective rating of the quality of the ROAD.
        /// </summary>
        /// <value>
        /// Value of the column quality_code
        /// </value>
		public RoadQualityEnum? Quality { get; set; }
		
        #endregion
    }
}
