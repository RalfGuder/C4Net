using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Person that represents the table PERS
	/// 
	/// An OBJECT-ITEM that is a human being to whom military or civilian significance is attached.
    /// </summary>
	[EntId(10000100)]
    [EntName("PERSON")]
    [EntTableName("PERS")]
    [EntDepth(1)]
    public interface IPerson
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column pers_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column pers_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("person-id")]
		[AttrColumnName("pers_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column birth_dttm
		///
		/// The character string representing a point in time that designates the date when a specific PERSON was born.
        /// </summary>
        /// <value>
        /// Value of the column birth_dttm
        /// </value>
        [AttrIx(100002)]
		[AttrName("person-birth-datetime")]
		[AttrColumnName("birth_dttm")]
        [AttrSeqnr(2)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string BirthDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column blood_type_code
		///
		/// A code which represents the specific blood type of a PERSON.
        /// </summary>
        /// <value>
        /// Value of the column blood_type_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("person-blood-type-code")]
		[AttrColumnName("blood_type_code")]
        [AttrSeqnr(3)]
        [DomId(100000177)]
        [DataLength(6)]
        [DataDecimals(0)]
        PersonBloodTypeEnum? BloodType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column gender_code
		///
		/// A code that represents the classification of a PERSON based on reproductive physiological traits.
        /// </summary>
        /// <value>
        /// Value of the column gender_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("person-gender-code")]
		[AttrColumnName("gender_code")]
        [AttrSeqnr(4)]
        [DomId(100000174)]
        [DataLength(6)]
        [DataDecimals(0)]
        GenderEnum? Gender { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column professing_ind_code
		///
		/// The specific value that represents whether a specific PERSON professes a religious preference.
        /// </summary>
        /// <value>
        /// Value of the column professing_ind_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("person-professing-indicator-code")]
		[AttrColumnName("professing_ind_code")]
        [AttrSeqnr(5)]
        [DomId(100004224)]
        [DataLength(6)]
        [DataDecimals(0)]
        PersonProfessingIndicatorEnum? ProfessingIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100000913)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(7)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
