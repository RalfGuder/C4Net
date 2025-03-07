using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ROUTE-SEGMENT that represents the table ROUTE_SGMNT.
	///
	/// A portion of a route usually without an intermediate stop, as defined by two consecutive significant points.
    /// </summary>
    [Serializable]
    [DefinitionName("RouteSegment", "C4Net.JC3IEDM.Definitions.RouteSegment.definition.xml")]
    public class RouteSegment : ControlFeature, IRouteSegment
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly RouteSegmentExpression _ = new RouteSegmentExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ROUTE-SEGMENT. It serves as a discriminator that partitions ROUTE-SEGMENT into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public RouteSegmentCategoryEnum RouteSegmentCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mob_code
		///
		/// The specific value that indicates the suitability of a specific ROUTE-SEGMENT for movement.
        /// </summary>
        /// <value>
        /// Value of the column mob_code
        /// </value>
		public MobilityEnum? Mobility { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mode_of_trnsp_code
		///
		/// The specific value that indicates the mode of transportation of a specific ROUTE-SEGMENT.
        /// </summary>
        /// <value>
        /// Value of the column mode_of_trnsp_code
        /// </value>
		public ModeOfTransportationEnum? ModeOfTransportation { get; set; }
		
        #endregion
    }
}
