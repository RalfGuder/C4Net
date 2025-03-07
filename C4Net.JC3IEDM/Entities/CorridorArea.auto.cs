using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CORRIDOR-AREA that represents the table CORRIDOR_AREA.
	///
	/// A SURFACE that is defined by its width and a sequence of points.
    /// </summary>
    [Serializable]
    [DefinitionName("CorridorArea", "C4Net.JC3IEDM.Definitions.CorridorArea.definition.xml")]
    public class CorridorArea : Surface, ICorridorArea
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly CorridorAreaExpression _ = new CorridorAreaExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column width_dim
		///
		/// The one-dimensional linear distance representing the horizontal distance measured from side to side for a CORRIDOR-AREA and distributed equally with respect to its centreline.
        /// </summary>
        /// <value>
        /// Value of the column width_dim
        /// </value>
		public double WidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column corridor_area_centre_line_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column corridor_area_centre_line_id
        /// </value>
		public decimal CentreLineId { get; set; }
		
        #endregion
    }
}
