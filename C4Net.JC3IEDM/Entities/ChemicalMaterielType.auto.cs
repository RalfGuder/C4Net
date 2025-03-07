using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CHEMICAL-MATERIEL-TYPE that represents the table CHM_MAT_TYPE.
	///
	/// A CONSUMABLE-MATERIEL-TYPE that is a substance that is not produced by a living organism, and does not emit radiation but may kill, seriously injure, or incapacitate personnel through its physiological effects or cause the deterioration of materiel.
    /// </summary>
    [Serializable]
    [DefinitionName("ChemicalMaterielType", "C4Net.JC3IEDM.Definitions.ChemicalMaterielType.definition.xml")]
    public class ChemicalMaterielType : ConsumableMaterielType, IChemicalMaterielType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ChemicalMaterielTypeExpression _ = new ChemicalMaterielTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the general class of a specific CHEMICAL-MATERIEL-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ChemicalMaterielTypeCategoryEnum ChemicalMaterielTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column persist_code
		///
		/// The specific value that represents the temporal variation of the effectiveness of a CHEMICAL-MATERIEL-TYPE under determined conditions after its dispersal.
        /// </summary>
        /// <value>
        /// Value of the column persist_code
        /// </value>
		public PersistencyEnum? Persistency { get; set; }

        public ChemicalMaterielTypeSubcategoryEnum? Subcategory { get; set; }

        #endregion
    }
}
