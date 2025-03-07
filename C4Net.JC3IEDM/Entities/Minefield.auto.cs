using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MINEFIELD that represents the table MNFLD.
	///
	/// A MILITARY-OBSTACLE that is an area or volume containing mines.
    /// </summary>
    [Serializable]
    [DefinitionName("Minefield", "C4Net.JC3IEDM.Definitions.Minefield.definition.xml")]
    public class Minefield : MilitaryObstacle, IMinefield
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly MinefieldExpression _ = new MinefieldExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of MINEFIELD. It serves as a discriminator that partitions MINEFIELD into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public MinefieldCategoryEnum MinefieldCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column identific_txt
		///
		/// The character string assigned to represent the designation of a minefield.
        /// </summary>
        /// <value>
        /// Value of the column identific_txt
        /// </value>
		public string IdentificationText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mine_spc_dim
		///
		/// The one-dimensional linear distance representing the distance between the mines emplaced in a specific MINEFIELD.
        /// </summary>
        /// <value>
        /// Value of the column mine_spc_dim
        /// </value>
		public double? MineSpacingDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column destruction_dttm
		///
		/// The character string representing a point in time that designates the destruction of a specific MINEFIELD.
        /// </summary>
        /// <value>
        /// Value of the column destruction_dttm
        /// </value>
		public string DestructionDatetime { get; set; }
		
        #endregion
    }
}
