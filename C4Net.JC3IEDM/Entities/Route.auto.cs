using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ROUTE that represents the table ROUTE.
	///
	/// A CONTROL-FEATURE that is the prescribed course to be travelled from a specific point of origin to a specific destination.
    /// </summary>
    [Serializable]
    [DefinitionName("Route", "C4Net.JC3IEDM.Definitions.Route.definition.xml")]
    public class Route : ControlFeature, IRoute
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly RouteExpression _ = new RouteExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column dir_usage_code
		///
		/// The specific value that represents the assigned direction for the traffic on the route.
        /// </summary>
        /// <value>
        /// Value of the column dir_usage_code
        /// </value>
		public RouteDirectionUsageEnum? DirectionUsage { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mob_code
		///
		/// The specific value that indicates the suitability of a specific ROUTE for movement.
        /// </summary>
        /// <value>
        /// Value of the column mob_code
        /// </value>
		public MobilityEnum? Mobility { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mode_of_trnsp_code
		///
		/// The specific value that indicates the mode of transportation of a specific ROUTE.
        /// </summary>
        /// <value>
        /// Value of the column mode_of_trnsp_code
        /// </value>
		public ModeOfTransportationEnum? ModeOfTransportation { get; set; }
		
        #endregion
    }
}
