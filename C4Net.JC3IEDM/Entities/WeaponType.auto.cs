using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity WEAPON-TYPE that represents the table WEAPON_TYPE.
	///
	/// An EQUIPMENT-TYPE of any kind used in warfare or combat to attack and overcome an enemy.
    /// </summary>
    [Serializable]
    [DefinitionName("WeaponType", "C4Net.JC3IEDM.Definitions.WeaponType.definition.xml")]
    public class WeaponType : EquipmentType, IWeaponType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly WeaponTypeExpression _ = new WeaponTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of WEAPON-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public WeaponTypeCategoryEnum WeaponTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the detailed class of WEAPON-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
		public WeaponTypeSubcategoryEnum? Subcategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column calibre_txt
		///
		/// The character string assigned to represent a specific calibre of a WEAPON-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column calibre_txt
        /// </value>
		public string CalibreText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fire_guidance_ind_code
		///
		/// The specific value that indicates whether a specific WEAPON-TYPE provides fire guidance.
        /// </summary>
        /// <value>
        /// Value of the column fire_guidance_ind_code
        /// </value>
		public WeaponTypeFireGuidanceIndicatorEnum? FireGuidanceIndicator { get; set; }
		
        #endregion
    }
}
