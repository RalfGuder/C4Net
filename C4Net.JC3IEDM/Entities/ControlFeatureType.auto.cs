using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CONTROL-FEATURE-TYPE that represents the table CTRL_FEAT_TYPE.
	///
	/// A non-tangible FEATURE-TYPE of military interest that may be represented as a geometric figure and is associated with the conduct of military operations.
    /// </summary>
    [Serializable]
    [DefinitionName("ControlFeatureType", "C4Net.JC3IEDM.Definitions.ControlFeatureType.definition.xml")]
    public class ControlFeatureType : FeatureType, IControlFeatureType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ControlFeatureTypeExpression _ = new ControlFeatureTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of CONTROL-FEATURE-TYPE. It serves as a discriminator that partitions CONTROL-FEATURE-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ControlFeatureTypeCategoryEnum ControlFeatureTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column echln_code
		///
		/// The specific value that represents the echelon level of an organisation that is to be associated with a specific CONTROL-FEATURE-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column echln_code
        /// </value>
		public EchelonSizeEnum? Echelon { get; set; }
		
        #endregion
    }
}
