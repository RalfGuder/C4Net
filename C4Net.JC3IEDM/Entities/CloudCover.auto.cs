using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CLOUD-COVER that represents the table CLOUD_COVER.
	///
	/// A METEOROLOGIC-FEATURE that specifies the characteristics of clouds above Earth's surface.
    /// </summary>
    [Serializable]
    [DefinitionName("CloudCover", "C4Net.JC3IEDM.Definitions.CloudCover.definition.xml")]
    public class CloudCover : MeteorologicFeature, ICloudCover
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly CloudCoverExpression _ = new CloudCoverExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the prevailing class of a specific CLOUD-COVER.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public CloudCoverCategoryEnum CloudCoverCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column base_dim
		///
		/// The one-dimensional linear distance representing the elevation of the lowest cloud base for a specific CLOUD-COVER.
        /// </summary>
        /// <value>
        /// Value of the column base_dim
        /// </value>
		public double? BaseDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column top_dim
		///
		/// The one-dimensional linear distance representing the elevation of the highest cloud ceiling for a specific CLOUD-COVER.
        /// </summary>
        /// <value>
        /// Value of the column top_dim
        /// </value>
		public double? TopDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column avg_cvrg_code
		///
		/// The specific value that represents the average density of a specific CLOUD-COVER as fractional coverage.
        /// </summary>
        /// <value>
        /// Value of the column avg_cvrg_code
        /// </value>
		public CloudCoverAverageCoverageEnum? AverageCoverage { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column light_refraction_rat
		///
		/// The numeric quotient value that represents the velocity of light in a specific CLOUD-COVER as a fraction of the velocity of light in a vacuum, based on cloud height. This represents the inverse of the index of refraction. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column light_refraction_rat
        /// </value>
		public double? LightRefractionRatio { get; set; }
		
        #endregion
    }
}
