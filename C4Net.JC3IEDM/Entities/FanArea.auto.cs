using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity FAN-AREA that represents the table FAN_AREA.
	///
	/// A SURFACE that is in the form of a truncated ring sector, lying between and being bounded by the rays emanating from the centre-point of the ring and having a specified central angle.
    /// </summary>
    [Serializable]
    [DefinitionName("FanArea", "C4Net.JC3IEDM.Definitions.FanArea.definition.xml")]
    public class FanArea : Surface, IFanArea
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly FanAreaExpression _ = new FanAreaExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mnm_range_dim
		///
		/// The one-dimensional linear distance representing the distance from the vertex to the inner ring of the ring sector used to specify the FAN-AREA.
        /// </summary>
        /// <value>
        /// Value of the column mnm_range_dim
        /// </value>
		public double MinimumRangeDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_range_dim
		///
		/// The one-dimensional linear distance representing distance from the vertex to the outer ring of the ring sector used to specify the FAN-AREA.
        /// </summary>
        /// <value>
        /// Value of the column max_range_dim
        /// </value>
		public double? MaximumRangeDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column orient_angle
		///
		/// The rotational measurement clockwise between the line of true north and the left side of the sector for a specific FAN-AREA.
        /// </summary>
        /// <value>
        /// Value of the column orient_angle
        /// </value>
		public double OrientationAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column sctr_size_angle
		///
		/// The rotational measurement clockwise between the left and right sides of the sector for a specific FAN-AREA.
        /// </summary>
        /// <value>
        /// Value of the column sctr_size_angle
        /// </value>
		public double SectorSizeAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fan_area_vertex_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column fan_area_vertex_point_id
        /// </value>
		public decimal VertexPointId { get; set; }
		
        #endregion
    }
}
