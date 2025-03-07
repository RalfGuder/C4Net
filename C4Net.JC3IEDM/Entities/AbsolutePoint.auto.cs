using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ABSOLUTE-POINT that represents the table ABS_POINT.
	///
	/// A POINT in a geodetic system.
    /// </summary>
    [Serializable]
    [DefinitionName("AbsolutePoint", "C4Net.JC3IEDM.Definitions.AbsolutePoint.definition.xml")]
    public class AbsolutePoint : Point, IAbsolutePoint
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly AbsolutePointExpression _ = new AbsolutePointExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ABSOLUTE-POINT with respect to the reference frame. It serves as a discriminator that partitions ABSOLUTE-POINT into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public AbsolutePointCategoryEnum AbsolutePointCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column abs_point_ver_dist_id
		///
		/// The unique value, or set of characters, assigned to represent a specific VERTICAL-DISTANCE and to distinguish it from all other VERTICAL-DISTANCEs.
        /// </summary>
        /// <value>
        /// Value of the column abs_point_ver_dist_id
        /// </value>
		public decimal? VerticalDistanceId { get; set; }
		
        #endregion
    }
}
