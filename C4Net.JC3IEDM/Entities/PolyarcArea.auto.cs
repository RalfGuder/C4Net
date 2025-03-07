using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity POLYARC-AREA that represents the table PLYRC_AREA.
	///
	/// A SURFACE that consists of a circular arc and a polygonal segment defined by a specific LINE whose beginning coincides with the initial point of the arc and whose end coincides with the last point of the arc.
    /// </summary>
    [Serializable]
    [DefinitionName("PolyarcArea", "C4Net.JC3IEDM.Definitions.PolyarcArea.definition.xml")]
    public class PolyarcArea : Surface, IPolyarcArea
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly PolyarcAreaExpression _ = new PolyarcAreaExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column begin_brng_angle
		///
		/// The rotational measurement clockwise from true North to the left side of a horizontal conical section used in defining a specific POLYARC-AREA.
        /// </summary>
        /// <value>
        /// Value of the column begin_brng_angle
        /// </value>
		public double BeginBearingAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column end_brng_angle
		///
		/// The rotational measurement clockwise from true North to the right side of a horizontal conical section used in defining a specific POLYARC-AREA.
        /// </summary>
        /// <value>
        /// Value of the column end_brng_angle
        /// </value>
		public double EndBearingAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column arc_radius_dim
		///
		/// The one-dimensional linear distance representing the distance from the vertex to the ring sector used to define part of a specific POLYARC-AREA.
        /// </summary>
        /// <value>
        /// Value of the column arc_radius_dim
        /// </value>
		public double ArcRadiusDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column plyrc_area_dfng_line_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column plyrc_area_dfng_line_id
        /// </value>
		public decimal DefiningLineId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column plyrc_area_brng_orgn_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column plyrc_area_brng_orgn_point_id
        /// </value>
		public decimal BearingOriginPointId { get; set; }
		
        #endregion
    }
}
