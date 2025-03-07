using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CBRN-EQUIPMENT-TYPE that represents the table CBRN_EQPT_TYPE.
	///
	/// An EQUIPMENT-TYPE that is designed for specialised roles in detecting, decontaminating or reconnoitring CBRN agents.
    /// </summary>
    [Serializable]
    [DefinitionName("CbrnEquipmentType", "C4Net.JC3IEDM.Definitions.CbrnEquipmentType.definition.xml")]
    public class CbrnEquipmentType : EquipmentType, ICbrnEquipmentType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly CbrnEquipmentTypeExpression _ = new CbrnEquipmentTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of CBRN-EQUIPMENT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public CbrnEquipmentTypeCategoryEnum CbrnEquipmentTypeCategory { get; set; }
		
        #endregion
    }
}
