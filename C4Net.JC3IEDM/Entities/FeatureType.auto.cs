using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity FEATURE-TYPE that represents the table FEAT_TYPE.
	///
	/// An OBJECT-TYPE that encompasses meteorological, geographic, and control features of military significance.
    /// </summary>
    [Serializable]
    [DefinitionName("FeatureType", "C4Net.JC3IEDM.Definitions.FeatureType.definition.xml")]
    public class FeatureType : ObjectType, IFeatureType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly FeatureTypeExpression _ = new FeatureTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of FEATURE-TYPE. It serves as a discriminator that partitions FEATURE-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public FeatureTypeCategoryEnum FeatureTypeCategory { get; set; }
		
        #endregion
    }
}
