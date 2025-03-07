using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity RADIOACTIVE-MATERIEL-TYPE that represents the table RADACT_MAT_TYPE.
	///
	/// A CONSUMABLE-MATERIEL-TYPE that is a substance which spontaneously emits radiation, and which may kill, seriously injure, or incapacitate personnel through its physiological effects or causes the deterioration of materiel.
    /// </summary>
    [Serializable]
    [DefinitionName("RadioactiveMaterielType", "C4Net.JC3IEDM.Definitions.RadioactiveMaterielType.definition.xml")]
    public class RadioactiveMaterielType : ConsumableMaterielType, IRadioactiveMaterielType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly RadioactiveMaterielTypeExpression _ = new RadioactiveMaterielTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of RADIOACTIVE-MATERIEL-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public RadioactiveMaterielTypeCategoryEnum RadioactiveMaterielTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prim_rad_code
		///
		/// The specific value that represents the most intense radiation emitted by a RADIOACTIVE-MATERIEL-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column prim_rad_code
        /// </value>
		public RadioactiveMaterielTypePrimaryRadiationEnum? PrimaryRadiation { get; set; }
		
        #endregion
    }
}
