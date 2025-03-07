using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MISCELLANEOUS-EQUIPMENT-TYPE that represents the table MISC_EQPT_TYPE.
	///
	/// An EQUIPMENT-TYPE whose designed function does not fit in any other defined category.
    /// </summary>
    [Serializable]
    [DefinitionName("MiscellaneousEquipmentType", "C4Net.JC3IEDM.Definitions.MiscellaneousEquipmentType.definition.xml")]
    public class MiscellaneousEquipmentType : EquipmentType, IMiscellaneousEquipmentType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly MiscellaneousEquipmentTypeExpression _ = new MiscellaneousEquipmentTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of MISCELLANEOUS-EQUIPMENT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public MiscellaneousEquipmentTypeCategoryEnum MiscellaneousEquipmentTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the detailed class of MISCELLANEOUS-EQUIPMENT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
		public MiscellaneousEquipmentTypeSubcategoryEnum? Subcategory { get; set; }
		
        #endregion
    }
}
