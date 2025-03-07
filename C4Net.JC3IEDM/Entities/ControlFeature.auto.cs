using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CONTROL-FEATURE that represents the table CTRL_FEAT.
	///
	/// A non-tangible FEATURE of military interest that is administratively specified, may be represented by a geometric figure, and is associated with the conduct of military operations.
    /// </summary>
    [Serializable]
    [DefinitionName("ControlFeature", "C4Net.JC3IEDM.Definitions.ControlFeature.definition.xml")]
    public class ControlFeature : Feature, IControlFeature
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ControlFeatureExpression _ = new ControlFeatureExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of CONTROL-FEATURE. It serves as a discriminator that partitions CONTROL-FEATURE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ControlFeatureCategoryEnum ControlFeatureCategory { get; set; }
		
        #endregion
    }
}
