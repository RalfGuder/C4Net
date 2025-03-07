using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-OBJECTIVE-TYPE-IMAGERY-PRODUCT that represents the table ACT_OBJVE_TYPE_IMGRY_PROD.
	///
	/// The intended characteristics of a specific ACTION-OBJECTIVE-TYPE-IMAGERY-PRODUCT that is an instance of MATERIEL-TYPE.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionObjectiveTypeImageryProduct", "C4Net.JC3IEDM.Definitions.ActionObjectiveTypeImageryProduct.definition.xml")]
    public class ActionObjectiveTypeImageryProduct : ActionObjectiveType, IActionObjectiveTypeImageryProduct
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ActionObjectiveTypeImageryProductExpression _ = new ActionObjectiveTypeImageryProductExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column img_scale_cnt
		///
		/// The integer value representing the scale of the imagery mapping required.
        /// </summary>
        /// <value>
        /// Value of the column img_scale_cnt
        /// </value>
		public int? ImageScaleCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column img_type_code
		///
		/// The specific value that represents the media of transmission and the quality of the photographic product required.
        /// </summary>
        /// <value>
        /// Value of the column img_type_code
        /// </value>
		public ActionObjectiveTypeImageryProductImageTypeEnum? ImageType { get; set; }
		
        #endregion
    }
}
