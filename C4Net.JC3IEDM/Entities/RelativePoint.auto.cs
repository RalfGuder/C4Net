using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity RELATIVE-POINT that represents the table REL_POINT.
	///
	/// A POINT whose position is specified with respect to a specific RELATIVE-COORDINATE-SYSTEM.
    /// </summary>
    [Serializable]
    [DefinitionName("RelativePoint", "C4Net.JC3IEDM.Definitions.RelativePoint.definition.xml")]
    public class RelativePoint : Point, IRelativePoint
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly RelativePointExpression _ = new RelativePointExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column x_coord_dim
		///
		/// The one-dimensional linear distance representing the displacement of the specific RELATIVE-POINT along the x-axis with respect to a specific RELATIVE-COORDINATE-SYSTEM.
        /// </summary>
        /// <value>
        /// Value of the column x_coord_dim
        /// </value>
		public double XCoordinateDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column y_coord_dim
		///
		/// The one-dimensional linear distance representing the displacement of the specific RELATIVE-POINT along the y-axis with respect to a specific RELATIVE-COORDINATE-SYSTEM.
        /// </summary>
        /// <value>
        /// Value of the column y_coord_dim
        /// </value>
		public double YCoordinateDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column z_coord_dim
		///
		/// The one-dimensional linear distance representing the displacement of the specific RELATIVE-POINT along the z-axis with respect to a specific RELATIVE-COORDINATE-SYSTEM.
        /// </summary>
        /// <value>
        /// Value of the column z_coord_dim
        /// </value>
		public double? ZCoordinateDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column x_precision_code
		///
		/// The specific value that represents the maximum resolution used for the expression of a value of an x-coordinate.
        /// </summary>
        /// <value>
        /// Value of the column x_precision_code
        /// </value>
		public DistancePrecisionEnum? XPrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column y_precision_code
		///
		/// The specific value that represents the maximum resolution used for the expression of a value of a y-coordinate.
        /// </summary>
        /// <value>
        /// Value of the column y_precision_code
        /// </value>
		public DistancePrecisionEnum? YPrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column z_precision_code
		///
		/// The specific value that represents the maximum resolution used for the expression of a value of a z-coordinate.
        /// </summary>
        /// <value>
        /// Value of the column z_precision_code
        /// </value>
		public DistancePrecisionEnum? ZPrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rel_coord_sys_id
		///
		/// The unique value, or set of characters, assigned to represent a specific RELATIVE-COORDINATE-SYSTEM and to distinguish it from all other RELATIVE-COORDINATE-SYSTEMs.
        /// </summary>
        /// <value>
        /// Value of the column rel_coord_sys_id
        /// </value>
		public decimal RelativeCoordinateSystemId { get; set; }
		
        #endregion
    }
}
