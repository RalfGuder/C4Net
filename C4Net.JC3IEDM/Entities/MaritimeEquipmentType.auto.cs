using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MARITIME-EQUIPMENT-TYPE that represents the table MRT_EQPT_TYPE.
	///
	/// An EQUIPMENT-TYPE that is designed to be used in a maritime environment.
    /// </summary>
    [Serializable]
    [DefinitionName("MaritimeEquipmentType", "C4Net.JC3IEDM.Definitions.MaritimeEquipmentType.definition.xml")]
    public class MaritimeEquipmentType : EquipmentType, IMaritimeEquipmentType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly MaritimeEquipmentTypeExpression _ = new MaritimeEquipmentTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of MARITIME-EQUIPMENT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public MaritimeEquipmentTypeCategoryEnum MaritimeEquipmentTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the detailed class of MARITIME-EQUIPMENT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
		public MaritimeEquipmentTypeSubcategoryEnum? Subcategory { get; set; }
		
        #endregion
    }
}
