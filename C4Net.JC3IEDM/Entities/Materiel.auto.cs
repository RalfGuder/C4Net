using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MATERIEL that represents the table MAT.
	///
	/// An OBJECT-ITEM that is equipment, apparatus or supplies of military interest without distinction as to its application for administrative or combat purposes.
    /// </summary>
    [Serializable]
    [DefinitionName("Materiel", "C4Net.JC3IEDM.Definitions.Materiel.definition.xml")]
    public class Materiel : ObjectItem, IMateriel
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly MaterielExpression _ = new MaterielExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of MATERIEL. It serves as a discriminator that partitions MATERIEL into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public MaterielCategoryEnum MaterielCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column serial_no_id_txt
		///
		/// The character string assigned to represent a specific MATERIEL.
        /// </summary>
        /// <value>
        /// Value of the column serial_no_id_txt
        /// </value>
		public string SerialNumberIdentificationText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lot_identific_txt
		///
		/// The character string assigned to represent a specific production of a specific MATERIEL.
        /// </summary>
        /// <value>
        /// Value of the column lot_identific_txt
        /// </value>
		public string LotIdentificationText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column hull_no_txt
		///
		/// The character string assigned to represent the number assigned to a specific vessel, which when associated with a specific hull type or ship type, uniquely identifies that vessel.
        /// </summary>
        /// <value>
        /// Value of the column hull_no_txt
        /// </value>
		public string HullNumberText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mine_rqn_case_no_txt
		///
		/// The character string assigned to represent the book/record keeping number to keep track of individual mines.
        /// </summary>
        /// <value>
        /// Value of the column mine_rqn_case_no_txt
        /// </value>
		public string MineRequisitionCaseNumberText { get; set; }
		
        #endregion
    }
}
