using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity PERSON that represents the table PERS.
	///
	/// An OBJECT-ITEM that is a human being to whom military or civilian significance is attached.
    /// </summary>
    [Serializable]
    [DefinitionName("Person", "C4Net.JC3IEDM.Definitions.Person.definition.xml")]
    public class Person : ObjectItem, IPerson
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly PersonExpression _ = new PersonExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column birth_dttm
		///
		/// The character string representing a point in time that designates the date when a specific PERSON was born.
        /// </summary>
        /// <value>
        /// Value of the column birth_dttm
        /// </value>
		public string BirthDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column blood_type_code
		///
		/// A code which represents the specific blood type of a PERSON.
        /// </summary>
        /// <value>
        /// Value of the column blood_type_code
        /// </value>
		public PersonBloodTypeEnum? BloodType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column gender_code
		///
		/// A code that represents the classification of a PERSON based on reproductive physiological traits.
        /// </summary>
        /// <value>
        /// Value of the column gender_code
        /// </value>
		public GenderEnum? Gender { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column professing_ind_code
		///
		/// The specific value that represents whether a specific PERSON professes a religious preference.
        /// </summary>
        /// <value>
        /// Value of the column professing_ind_code
        /// </value>
		public PersonProfessingIndicatorEnum? ProfessingIndicator { get; set; }
		
        #endregion
    }
}
