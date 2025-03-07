using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity AMMUNITION-TYPE that represents the table AMMO_TYPE.
	///
	/// A CONSUMABLE-MATERIEL-TYPE that is a complete device charged with explosives, propellants, pyrotechnics, initiating composition, or nuclear, biological, or chemical material for use in military operations.
    /// </summary>
    [Serializable]
    [DefinitionName("AmmunitionType", "C4Net.JC3IEDM.Definitions.AmmunitionType.definition.xml")]
    public class AmmunitionType : ConsumableMaterielType, IAmmunitionType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly AmmunitionTypeExpression _ = new AmmunitionTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of AMMUNITION-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public AmmunitionTypeCategoryEnum AmmunitionTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column calibre_txt
		///
		/// The character string assigned to represent a specific calibre of an AMMUNITION-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column calibre_txt
        /// </value>
		public string CalibreText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mine_mrt_firing_code
		///
		/// The specific value that represents the firing mechanism for a maritime mine.
        /// </summary>
        /// <value>
        /// Value of the column mine_mrt_firing_code
        /// </value>
		public AmmunitionTypeMineMaritimeFiringEnum? MineMaritimeFiring { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column exer_mine_flare_colour_code
		///
		/// The specific value that represents the colour of the flare released by the exercise mine.
        /// </summary>
        /// <value>
        /// Value of the column exer_mine_flare_colour_code
        /// </value>
		public AmmunitionTypeExerciseMineFlareColourEnum? ExerciseMineFlareColour { get; set; }
		
        #endregion
    }
}
