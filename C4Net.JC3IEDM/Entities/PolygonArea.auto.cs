using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity POLYGON-AREA that represents the table POLYGON_AREA.
	///
	/// A SURFACE that has its boundaries defined by a specific LINE.
    /// </summary>
    [Serializable]
    [DefinitionName("PolygonArea", "C4Net.JC3IEDM.Definitions.PolygonArea.definition.xml")]
    public class PolygonArea : Surface, IPolygonArea
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly PolygonAreaExpression _ = new PolygonAreaExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column polygon_area_bndg_line_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column polygon_area_bndg_line_id
        /// </value>
		public decimal BoundingLineId { get; set; }
		
        #endregion
    }
}
