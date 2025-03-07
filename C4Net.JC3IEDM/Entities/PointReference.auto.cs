using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity POINT-REFERENCE that represents the table POINT_REF.
	///
	/// A RELATIVE-COORDINATE-SYSTEM that uses three specific POINTs to establish its frame of reference.
    /// </summary>
    [Serializable]
    [DefinitionName("PointReference", "C4Net.JC3IEDM.Definitions.PointReference.definition.xml")]
    public class PointReference : RelativeCoordinateSystem, IPointReference
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly PointReferenceExpression _ = new PointReferenceExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column rel_coord_sys_id
		///
		/// The unique value, or set of characters, assigned to represent a specific RELATIVE-COORDINATE-SYSTEM and to distinguish it from all other RELATIVE-COORDINATE-SYSTEMs.
        /// </summary>
        /// <value>
        /// Value of the column rel_coord_sys_id
        /// </value>
		public decimal RelativeCoordinateSystemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column point_ref_orgn_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column point_ref_orgn_point_id
        /// </value>
		public decimal OriginPointId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column point_ref_x_vector_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column point_ref_x_vector_point_id
        /// </value>
		public decimal XVectorPointId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column point_ref_y_vector_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column point_ref_y_vector_point_id
        /// </value>
		public decimal YVectorPointId { get; set; }
		
        #endregion
    }
}
