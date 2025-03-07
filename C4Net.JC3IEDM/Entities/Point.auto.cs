using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity POINT that represents the table POINT.
	///
	/// A zero dimensional LOCATION.
    /// </summary>
    [Serializable]
    [DefinitionName("Point", "C4Net.JC3IEDM.Definitions.Point.definition.xml")]
    public class Point : Location, IPoint
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly PointExpression _ = new PointExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of POINT. It serves as a discriminator that partitions POINT into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public PointCategoryEnum PointCategory { get; set; }
		
        #endregion
    }
}
