using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity TRACK-AREA that represents the table TRACK_AREA.
	///
	/// A SURFACE that is a rectangular section with its length defined by the two specific POINTs and its width by the sum of the widths to the left and right of the connecting line between the two points.
    /// </summary>
    [Serializable]
    [DefinitionName("TrackArea", "C4Net.JC3IEDM.Definitions.TrackArea.definition.xml")]
    public class TrackArea : Surface, ITrackArea
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly TrackAreaExpression _ = new TrackAreaExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column left_width_dim
		///
		/// The one-dimensional linear distance representing the horizontal distance to the left measured orthogonally to the reference axis for a specific TRACK-AREA.
        /// </summary>
        /// <value>
        /// Value of the column left_width_dim
        /// </value>
		public double LeftWidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column right_width_dim
		///
		/// The one-dimensional linear distance representing the horizontal distance to the right measured orthogonally to the reference axis for a specific TRACK-AREA.
        /// </summary>
        /// <value>
        /// Value of the column right_width_dim
        /// </value>
		public double RightWidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column track_area_begin_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column track_area_begin_point_id
        /// </value>
		public decimal BeginPointId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column track_area_end_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column track_area_end_point_id
        /// </value>
		public decimal EndPointId { get; set; }
		
        #endregion
    }
}
