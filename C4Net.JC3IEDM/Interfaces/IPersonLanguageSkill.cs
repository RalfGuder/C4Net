using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity PersonLanguageSkill that represents the table PERS_LANG_SKILL
	/// 
	/// A proficiency or ability of a specific PERSON with regard to a specific language.
    /// </summary>
	[EntId(10000212)]
    [EntName("PERSON-LANGUAGE-SKILL")]
    [EntTableName("PERS_LANG_SKILL")]
    [EntDepth(2)]
    public interface IPersonLanguageSkill
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
        decimal PersonId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pers_lang_skill_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PERSON-LANGUAGE-SKILL for a specific PERSON and to distinguish it from all other PERSON-LANGUAGE-SKILLs for that PERSON.
        /// </summary>
        /// <value>
        /// Value of the column pers_lang_skill_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("person-language-skill-index")]
		[AttrColumnName("pers_lang_skill_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the particular language of PERSON-LANGUAGE-SKILL.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("person-language-skill-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000395)]
        [DataLength(6)]
        [DataDecimals(0)]
        LanguageCategoryEnum PersonLanguageSkillCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column gen_prof_code
		///
		/// The specific value that represents the general level of proficiency of a specific PERSON in a specific language skill.
        /// </summary>
        /// <value>
        /// Value of the column gen_prof_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("person-language-skill-general-proficiency-code")]
		[AttrColumnName("gen_prof_code")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000396)]
        [DataLength(6)]
        [DataDecimals(0)]
        PersonLanguageSkillGeneralProficiencyEnum GeneralProficiency { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lstng_prof_lvl_code
		///
		/// The specific value that represents the level of listening comprehension of a specific PERSON in a specific language skill.
        /// </summary>
        /// <value>
        /// Value of the column lstng_prof_lvl_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("person-language-skill-listening-proficiency-level-code")]
		[AttrColumnName("lstng_prof_lvl_code")]
        [AttrSeqnr(5)]
        [DomId(100000397)]
        [DataLength(6)]
        [DataDecimals(0)]
        LanguageSkillProficiencyEnum? ListeningProficiencyLevel { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rdng_prof_lvl_code
		///
		/// The specific value that represents the level of reading comprehension of a specific PERSON in a specific language skill.
        /// </summary>
        /// <value>
        /// Value of the column rdng_prof_lvl_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("person-language-skill-reading-proficiency-level-code")]
		[AttrColumnName("rdng_prof_lvl_code")]
        [AttrSeqnr(6)]
        [DomId(100000397)]
        [DataLength(6)]
        [DataDecimals(0)]
        LanguageSkillProficiencyEnum? ReadingProficiencyLevel { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column spkng_prof_lvl_code
		///
		/// The specific value that represents the level of speaking proficiency of a specific PERSON in a specific language skill.
        /// </summary>
        /// <value>
        /// Value of the column spkng_prof_lvl_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("person-language-skill-speaking-proficiency-level-code")]
		[AttrColumnName("spkng_prof_lvl_code")]
        [AttrSeqnr(7)]
        [DomId(100000397)]
        [DataLength(6)]
        [DataDecimals(0)]
        LanguageSkillProficiencyEnum? SpeakingProficiencyLevel { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column wrtng_prof_lvl_code
		///
		/// The specific value that represents the level of writing proficiency of a specific PERSON in a specific language skill.
        /// </summary>
        /// <value>
        /// Value of the column wrtng_prof_lvl_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("person-language-skill-writing-proficiency-level-code")]
		[AttrColumnName("wrtng_prof_lvl_code")]
        [AttrSeqnr(8)]
        [DomId(100000397)]
        [DataLength(6)]
        [DataDecimals(0)]
        LanguageSkillProficiencyEnum? WritingProficiencyLevel { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(9)]
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
        [AttrIx(100010)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(10)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
