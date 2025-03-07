using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity BIOLOGICAL-MATERIEL-TYPE that represents the table BIO_MAT_TYPE.
	///
	/// A CONSUMABLE-MATERIEL-TYPE that is either a microorganism that causes disease in man, plants, or animals or causes the deterioration of materiel; or a toxin, produced by an animal, plant, or microorganism, which may kill, seriously injure, or incapacitate personnel through its physiological effects.
    /// </summary>
    [Serializable]
    [DefinitionName("BiologicalMaterielType", "C4Net.JC3IEDM.Definitions.BiologicalMaterielType.definition.xml")]
    public class BiologicalMaterielType : ConsumableMaterielType, IBiologicalMaterielType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly BiologicalMaterielTypeExpression _ = new BiologicalMaterielTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of BIOLOGICAL-MATERIEL-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public BiologicalMaterielTypeCategoryEnum BiologicalMaterielTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column persist_code
		///
		/// The specific value that represents the temporal variation of the effectiveness of a BIOLOGICAL-MATERIEL-TYPE under determined conditions after its dispersal.
        /// </summary>
        /// <value>
        /// Value of the column persist_code
        /// </value>
		public PersistencyEnum? Persistency { get; set; }

        public BiologicalMaterielTypeSubcategoryEnum? Subcategory { get; set; }
		
        #endregion
    }
}
