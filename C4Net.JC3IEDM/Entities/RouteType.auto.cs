using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ROUTE-TYPE that represents the table ROUTE_TYPE.
	///
	/// A CONTROL-FEATURE-TYPE that is the prescribed course to be travelled from a point of origin to a destination.
    /// </summary>
    [Serializable]
    [DefinitionName("RouteType", "C4Net.JC3IEDM.Definitions.RouteType.definition.xml")]
    public class RouteType : ControlFeatureType, IRouteType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly RouteTypeExpression _ = new RouteTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ROUTE-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public RouteTypeCategoryEnum RouteTypeCategory { get; set; }
		
        #endregion
    }
}
