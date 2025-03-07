using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CARTESIAN-POINT that represents the table CRTS_POINT.
	///
	/// An ABSOLUTE-POINT that has its position specified in a three-dimensional Earth-centred Cartesian system.
    /// </summary>
    [Serializable]
    [DefinitionName("CartesianPoint", "C4Net.JC3IEDM.Definitions.CartesianPoint.definition.xml")]
    public class CartesianPoint : AbsolutePoint, ICartesianPoint
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly CartesianPointExpression _ = new CartesianPointExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column x_coord_dim
		///
		/// The one-dimensional linear distance representing the X-component of a coordinate which expresses the position of a point in a three-dimensional Cartesian coordinate system that is fixed to the earth, where the X-axis lies in the planes of the Equator and the Greenwich meridian.
        /// </summary>
        /// <value>
        /// Value of the column x_coord_dim
        /// </value>
		public double XCoordinateDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column y_coord_dim
		///
		/// The one-dimensional linear distance representing the Y-component of a coordinate which expresses the position of a point in a three-dimensional Cartesian coordinate system that is fixed to the earth where the Y-axis is perpendicular to both the X- and Z-axes completing the right-handed coordinate system.
        /// </summary>
        /// <value>
        /// Value of the column y_coord_dim
        /// </value>
		public double YCoordinateDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column z_coord_dim
		///
		/// The one-dimensional linear distance representing the Z-component of a coordinate which expresses the position of a point in a three-dimensional Cartesian coordinate system that is fixed to the earth, where the Z-axis coincides with the mean rotation axis of the Earth.
        /// </summary>
        /// <value>
        /// Value of the column z_coord_dim
        /// </value>
		public double ZCoordinateDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column x_precision_code
		///
		/// The specific value that represents the resolution used for the expression of a value of a Cartesian x-coordinate.
        /// </summary>
        /// <value>
        /// Value of the column x_precision_code
        /// </value>
		public DistancePrecisionEnum? XPrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column y_precision_code
		///
		/// The specific value that represents the resolution used for the expression of a value of a Cartesian y-coordinate.
        /// </summary>
        /// <value>
        /// Value of the column y_precision_code
        /// </value>
		public DistancePrecisionEnum? YPrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column z_precision_code
		///
		/// The specific value that represents the resolution used for the expression of a value of a Cartesian z-coordinate.
        /// </summary>
        /// <value>
        /// Value of the column z_precision_code
        /// </value>
		public DistancePrecisionEnum? ZPrecision { get; set; }
		
        #endregion
    }
}
