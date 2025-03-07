using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity GroupCharacteristic that represents the table GROUP_CHRCT
	/// 
	/// A reference to a set of characteristics that may be used for identifying a distinct collection of objects.
    /// </summary>
	[EntId(10000251)]
    [EntName("GROUP-CHARACTERISTIC")]
    [EntTableName("GROUP_CHRCT")]
    [EntDepth(0)]
    public interface IGroupCharacteristic
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column group_chrct_id
		///
		/// The unique value, or set of characters, assigned to represent a specific GROUP-CHARACTERISTIC and to distinguish it from all other GROUP-CHARACTERISTICs.
        /// </summary>
        /// <value>
        /// Value of the column group_chrct_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("group-characteristic-id")]
		[AttrColumnName("group_chrct_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100000918)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column age_group_code
		///
		/// The specific value that identifies the age group in a specific GROUP-CHARACTERISTIC.
        /// </summary>
        /// <value>
        /// Value of the column age_group_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("group-characteristic-age-group-code")]
		[AttrColumnName("age_group_code")]
        [AttrSeqnr(2)]
        [DomId(100004153)]
        [DataLength(6)]
        [DataDecimals(0)]
        GroupCharacteristicAgeGroupEnum? AgeGroup { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column malady_code
		///
		/// The specific value that identifies the type of ill health, ailment or disease in a specific GROUP-CHARACTERISTIC.
        /// </summary>
        /// <value>
        /// Value of the column malady_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("group-characteristic-malady-code")]
		[AttrColumnName("malady_code")]
        [AttrSeqnr(3)]
        [DomId(100004154)]
        [DataLength(6)]
        [DataDecimals(0)]
        GroupCharacteristicMaladyEnum? Malady { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column malady_trnsmsbl_ind_code
		///
		/// The specific value that identifies whether the type of ill health, ailment or disease in a specific GROUP-CHARACTERISTIC is communicable.
        /// </summary>
        /// <value>
        /// Value of the column malady_trnsmsbl_ind_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("group-characteristic-malady-transmissibility-indicator-code")]
		[AttrColumnName("malady_trnsmsbl_ind_code")]
        [AttrSeqnr(4)]
        [DomId(100004155)]
        [DataLength(6)]
        [DataDecimals(0)]
        GroupCharacteristicMaladyTransmissibilityIndicatorEnum? MaladyTransmissibilityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column gender_code
		///
		/// The specific value that identifies the gender in a specific GROUP-CHARACTERISTIC.
        /// </summary>
        /// <value>
        /// Value of the column gender_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("group-characteristic-gender-code")]
		[AttrColumnName("gender_code")]
        [AttrSeqnr(5)]
        [DomId(100000174)]
        [DataLength(6)]
        [DataDecimals(0)]
        GenderEnum? Gender { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lang_code
		///
		/// The specific value that identifies the language group in a specific GROUP-CHARACTERISTIC.
        /// </summary>
        /// <value>
        /// Value of the column lang_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("group-characteristic-language-code")]
		[AttrColumnName("lang_code")]
        [AttrSeqnr(6)]
        [DomId(100000395)]
        [DataLength(6)]
        [DataDecimals(0)]
        LanguageCategoryEnum? Language { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column triage_code
		///
		/// The specific value that identifies the triage classification in a specific GROUP-CHARACTERISTIC.
        /// </summary>
        /// <value>
        /// Value of the column triage_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("group-characteristic-triage-code")]
		[AttrColumnName("triage_code")]
        [AttrSeqnr(7)]
        [DomId(100004156)]
        [DataLength(6)]
        [DataDecimals(0)]
        GroupCharacteristicTriageEnum? Triage { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(8)]
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
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(9)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
