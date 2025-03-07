using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ENGINEERING-EQUIPMENT-TYPE that represents the table ENG_EQPT_TYPE.
	///
	/// An EQUIPMENT-TYPE that is designed to accomplish engineering functions.
    /// </summary>
    [Serializable]
    [DefinitionName("EngineeringEquipmentType", "C4Net.JC3IEDM.Definitions.EngineeringEquipmentType.definition.xml")]
    public class EngineeringEquipmentType : EquipmentType, IEngineeringEquipmentType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly EngineeringEquipmentTypeExpression _ = new EngineeringEquipmentTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ENGINEERING-EQUIPMENT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public EngineeringEquipmentTypeCategoryEnum EngineeringEquipmentTypeCategory { get; set; }
		
        #endregion
    }
}
