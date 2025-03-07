using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity GEOGRAPHIC-FEATURE-TYPE that represents the table GEO_FEAT_TYPE.
	///
	/// A FEATURE-TYPE that describes terrain characteristics to which military significance is attached.
    /// </summary>
    [Serializable]
    [DefinitionName("GeographicFeatureType", "C4Net.JC3IEDM.Definitions.GeographicFeatureType.definition.xml")]
    public class GeographicFeatureType : FeatureType, IGeographicFeatureType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly GeographicFeatureTypeExpression _ = new GeographicFeatureTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of GEOGRAPHIC-FEATURE-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public GeographicFeatureTypeCategoryEnum GeographicFeatureTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the detailed class of GEOGRAPHIC-FEATURE-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
		public GeographicFeatureTypeSubcategoryEnum? Subcategory { get; set; }
		
        #endregion
    }
}
