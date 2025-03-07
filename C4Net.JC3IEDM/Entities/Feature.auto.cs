using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity FEATURE that represents the table FEAT.
	///
	/// An OBJECT-ITEM that encompasses meteorological, geographic, and control features of military significance.
    /// </summary>
    [Serializable]
    [DefinitionName("Feature", "C4Net.JC3IEDM.Definitions.Feature.definition.xml")]
    public class Feature : ObjectItem, IFeature
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly FeatureExpression _ = new FeatureExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of FEATURE. It serves as a discriminator that partitions FEATURE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public FeatureCategoryEnum FeatureCategory { get; set; }
		
        #endregion
    }
}
