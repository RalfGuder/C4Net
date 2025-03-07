using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity VISIBILITY that represents the table VISIBILITY.
	///
	/// A METEOROLOGIC-FEATURE that specifies the distance at which an object illuminated by light in the visual spectrum can be detected.
    /// </summary>
    [Serializable]
    [DefinitionName("Visibility", "C4Net.JC3IEDM.Definitions.Visibility.definition.xml")]
    public class Visibility : MeteorologicFeature, IVisibility
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly VisibilityExpression _ = new VisibilityExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of obscurant that governs a particular VISIBILITY.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public VisibilityCategoryEnum? VisibilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dir_code
		///
		/// The specific value that represents the direction for which a specific VISIBILITY is valid.
        /// </summary>
        /// <value>
        /// Value of the column dir_code
        /// </value>
		public DirectionEnum? Direction { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column range_dim
		///
		/// The one-dimensional linear distance representing the distance which can be surveyed using visual observation for a specific VISIBILITY.
        /// </summary>
        /// <value>
        /// Value of the column range_dim
        /// </value>
		public double RangeDimension { get; set; }
		
        #endregion
    }
}
