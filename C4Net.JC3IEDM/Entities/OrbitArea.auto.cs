using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ORBIT-AREA that represents the table ORBIT_AREA.
	///
	/// A SURFACE that is (a) an open rectangular section defined by its width and the distance between the two specific POINTs, (b) is closed by two half-circles with radii equal to half the width, and is positioned left, centred, or right with respect to the line formed by the defining points.
    /// </summary>
    [Serializable]
    [DefinitionName("OrbitArea", "C4Net.JC3IEDM.Definitions.OrbitArea.definition.xml")]
    public class OrbitArea : Surface, IOrbitArea
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly OrbitAreaExpression _ = new OrbitAreaExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column alignment_code
		///
		/// The specific value that represents the placement of a specific ORBIT-AREA with respect to its defining reference axis.
        /// </summary>
        /// <value>
        /// Value of the column alignment_code
        /// </value>
		public OrbitAreaAlignmentEnum Alignment { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column width_dim
		///
		/// The one-dimensional linear distance representing the horizontal distance measured from side to side for a specific ORBIT-AREA.
        /// </summary>
        /// <value>
        /// Value of the column width_dim
        /// </value>
		public double WidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column orbit_area_first_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column orbit_area_first_point_id
        /// </value>
		public decimal FirstPointId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column orbit_area_scnd_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column orbit_area_scnd_point_id
        /// </value>
		public decimal SecondPointId { get; set; }
		
        #endregion
    }
}
