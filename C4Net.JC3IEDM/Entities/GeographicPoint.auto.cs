using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity GEOGRAPHIC-POINT that represents the table GEO_POINT.
	///
	/// An ABSOLUTE-POINT that has its position specified with respect to the surface of the World Geodetic System 1984 (WGS 84) ellipsoid.
    /// </summary>
    [Serializable]
    [DefinitionName("GeographicPoint", "C4Net.JC3IEDM.Definitions.GeographicPoint.definition.xml")]
    public class GeographicPoint : AbsolutePoint, IGeographicPoint
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly GeographicPointExpression _ = new GeographicPointExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column lat_coord
		///
		/// The numeric value that represents the angle between the plane of the equator and a line perpendicular to the ellipsoid surface and passing through the GEOGRAPHIC-POINT.
        /// </summary>
        /// <value>
        /// Value of the column lat_coord
        /// </value>
		public double LatitudeCoordinate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column long_coord
		///
		/// The numeric value that represents the angle between the initial (zero or Greenwich) meridian and the meridian of the GEOGRAPHIC-POINT measured in the plane of the Equator.
        /// </summary>
        /// <value>
        /// Value of the column long_coord
        /// </value>
		public double LongitudeCoordinate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lat_precision_code
		///
		/// The specific value that represents the resolution used for the expression of a value of a latitude coordinate.
        /// </summary>
        /// <value>
        /// Value of the column lat_precision_code
        /// </value>
		public AnglePrecisionEnum? LatitudePrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column long_precision_code
		///
		/// The specific value that represents the resolution used for the expression of a value of a longitude coordinate.
        /// </summary>
        /// <value>
        /// Value of the column long_precision_code
        /// </value>
		public AnglePrecisionEnum? LongitudePrecision { get; set; }
		
        #endregion
    }
}
