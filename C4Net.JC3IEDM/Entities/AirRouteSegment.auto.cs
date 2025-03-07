using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity AIR-ROUTE-SEGMENT that represents the table AIR_ROUTE_SGMNT.
	///
	/// A portion of a route to be flown usually without an intermediate stop, as defined by two consecutive significant points.
    /// </summary>
    [Serializable]
    [DefinitionName("AirRouteSegment", "C4Net.JC3IEDM.Definitions.AirRouteSegment.definition.xml")]
    public class AirRouteSegment : RouteSegment, IAirRouteSegment
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly AirRouteSegmentExpression _ = new AirRouteSegmentExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column req_nvgtn_perf_code
		///
		/// The specific value that represents the required navigation performance when flying routes for which external route navigation aids are not provided.
        /// </summary>
        /// <value>
        /// Value of the column req_nvgtn_perf_code
        /// </value>
		public AirRouteSegmentRequiredNavigationPerformanceEnum RequiredNavigationPerformance { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column civil_mil_code
		///
		/// The specific value that represents the civil/military status of the AIR-ROUTE-SEGMENT.
        /// </summary>
        /// <value>
        /// Value of the column civil_mil_code
        /// </value>
		public AirRouteSegmentCivilMilitaryEnum? CivilMilitary { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column intl_route_code
		///
		/// The specific value that represents the domestic/international status of the AIR-ROUTE-SEGMENT.
        /// </summary>
        /// <value>
        /// Value of the column intl_route_code
        /// </value>
		public AirRouteSegmentInternationalRouteEnum? InternationalRoute { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mntnd_speed_rate
		///
		/// The numeric value that denotes the speed of movement to be maintained between route points. The unit of measure is kilometres per hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column mntnd_speed_rate
        /// </value>
		public double? MaintainedSpeedRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column descr_txt
		///
		/// The character string assigned to represent the description of specific AIR-ROUTE-SEGMENT.
        /// </summary>
        /// <value>
        /// Value of the column descr_txt
        /// </value>
		public string DescriptionText { get; set; }
		
        #endregion
    }
}
