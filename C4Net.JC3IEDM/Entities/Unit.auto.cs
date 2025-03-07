using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity UNIT that represents the table UNIT.
	///
	/// A military ORGANISATION whose structure is prescribed by competent authority.
    /// </summary>
    [Serializable]
    [DefinitionName("Unit", "C4Net.JC3IEDM.Definitions.Unit.definition.xml")]
    public class Unit : Organisation, IUnit
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly UnitExpression _ = new UnitExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column formal_abbrd_name_txt
		///
		/// The character string specifying the common formal abbreviation used to designate a specific UNIT.
        /// </summary>
        /// <value>
        /// Value of the column formal_abbrd_name_txt
        /// </value>
		public string FormalAbbreviatedNameText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column identific_txt
		///
		/// The character string assigned to represent a unit’s identification.
        /// </summary>
        /// <value>
        /// Value of the column identific_txt
        /// </value>
		public string IdentificationText { get; set; }
		
        #endregion
    }
}
