using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity PERSON-LANGUAGE-SKILL that represents the table PERS_LANG_SKILL.
	///
	/// A proficiency or ability of a specific PERSON with regard to a specific language.
    /// </summary>
    [Serializable]
    [DefinitionName("PersonLanguageSkill", "C4Net.JC3IEDM.Definitions.PersonLanguageSkill.definition.xml")]
    public class PersonLanguageSkill : IEntity, IPersonLanguageSkill
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly PersonLanguageSkillExpression _ = new PersonLanguageSkillExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column pers_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column pers_id
        /// </value>
		public decimal PersonId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pers_lang_skill_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PERSON-LANGUAGE-SKILL for a specific PERSON and to distinguish it from all other PERSON-LANGUAGE-SKILLs for that PERSON.
        /// </summary>
        /// <value>
        /// Value of the column pers_lang_skill_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the particular language of PERSON-LANGUAGE-SKILL.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public LanguageCategoryEnum PersonLanguageSkillCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column gen_prof_code
		///
		/// The specific value that represents the general level of proficiency of a specific PERSON in a specific language skill.
        /// </summary>
        /// <value>
        /// Value of the column gen_prof_code
        /// </value>
		public PersonLanguageSkillGeneralProficiencyEnum GeneralProficiency { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lstng_prof_lvl_code
		///
		/// The specific value that represents the level of listening comprehension of a specific PERSON in a specific language skill.
        /// </summary>
        /// <value>
        /// Value of the column lstng_prof_lvl_code
        /// </value>
		public LanguageSkillProficiencyEnum? ListeningProficiencyLevel { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rdng_prof_lvl_code
		///
		/// The specific value that represents the level of reading comprehension of a specific PERSON in a specific language skill.
        /// </summary>
        /// <value>
        /// Value of the column rdng_prof_lvl_code
        /// </value>
		public LanguageSkillProficiencyEnum? ReadingProficiencyLevel { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column spkng_prof_lvl_code
		///
		/// The specific value that represents the level of speaking proficiency of a specific PERSON in a specific language skill.
        /// </summary>
        /// <value>
        /// Value of the column spkng_prof_lvl_code
        /// </value>
		public LanguageSkillProficiencyEnum? SpeakingProficiencyLevel { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column wrtng_prof_lvl_code
		///
		/// The specific value that represents the level of writing proficiency of a specific PERSON in a specific language skill.
        /// </summary>
        /// <value>
        /// Value of the column wrtng_prof_lvl_code
        /// </value>
		public LanguageSkillProficiencyEnum? WritingProficiencyLevel { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
		public decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
		public long UpdateSeqnr { get; set; }
		
        #endregion
    }
}
