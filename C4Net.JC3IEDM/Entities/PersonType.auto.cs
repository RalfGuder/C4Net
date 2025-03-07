using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity PERSON-TYPE that represents the table PERS_TYPE.
	///
	/// An OBJECT-TYPE that represents human beings about whom information is to be held.
    /// </summary>
    [Serializable]
    [DefinitionName("PersonType", "C4Net.JC3IEDM.Definitions.PersonType.definition.xml")]
    public class PersonType : ObjectType, IPersonType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly PersonTypeExpression _ = new PersonTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of PERSON-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public PersonTypeCategoryEnum PersonTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the detailed class of PERSON-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
		public PersonTypeSubcategoryEnum? Subcategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rank_code
		///
		/// The specific value that represents a designation for a military, naval, or civil grade that establishes the relative position or status of a specific PERSON-TYPE in an organisation.
        /// </summary>
        /// <value>
        /// Value of the column rank_code
        /// </value>
		public PersonTypeRankEnum? Rank { get; set; }
		
        #endregion
    }
}
