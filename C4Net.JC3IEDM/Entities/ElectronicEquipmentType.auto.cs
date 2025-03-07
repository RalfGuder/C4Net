using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ELECTRONIC-EQUIPMENT-TYPE that represents the table ELCTRNC_EQPT_TYPE.
	///
	/// An EQUIPMENT-TYPE that is designed to use electronic processing to realise its primary function.
    /// </summary>
    [Serializable]
    [DefinitionName("ElectronicEquipmentType", "C4Net.JC3IEDM.Definitions.ElectronicEquipmentType.definition.xml")]
    public class ElectronicEquipmentType : EquipmentType, IElectronicEquipmentType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ElectronicEquipmentTypeExpression _ = new ElectronicEquipmentTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ELECTRONIC-EQUIPMENT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ElectronicEquipmentTypeCategoryEnum ElectronicEquipmentTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the detailed class of ELECTRONIC-EQUIPMENT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
		public ElectronicEquipmentTypeSubcategoryEnum? Subcategory { get; set; }
		
        #endregion
    }
}
