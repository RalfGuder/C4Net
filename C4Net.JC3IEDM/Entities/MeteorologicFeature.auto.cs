using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity METEOROLOGIC-FEATURE that represents the table MET_FEAT.
	///
	/// A FEATURE that describes reported or forecast weather and light conditions.
    /// </summary>
    [Serializable]
    [DefinitionName("MeteorologicFeature", "C4Net.JC3IEDM.Definitions.MeteorologicFeature.definition.xml")]
    public class MeteorologicFeature : Feature, IMeteorologicFeature
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly MeteorologicFeatureExpression _ = new MeteorologicFeatureExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of METEOROLOGIC-FEATURE. It serves as a discriminator that partitions METEOROLOGIC-FEATURE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public MeteorologicFeatureCategoryEnum MeteorologicFeatureCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column interpretation_code
		///
		/// The specific value that denotes the statistical meaning of a specified METEOROLOGIC-FEATURE.
        /// </summary>
        /// <value>
        /// Value of the column interpretation_code
        /// </value>
		public MeteorologicFeatureInterpretationEnum Interpretation { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prob_rat
		///
		/// The numeric quotient value that represents the likelihood that a specific condition will occur for a specific METEOROLOGIC-FEATURE. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column prob_rat
        /// </value>
		public double? ProbabilityRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column source_code
		///
		/// The specific value that denotes the basis for the estimate of a condition for a specific METEOROLOGIC-FEATURE.
        /// </summary>
        /// <value>
        /// Value of the column source_code
        /// </value>
		public MeteorologicFeatureSourceEnum? Source { get; set; }
		
        #endregion
    }
}
