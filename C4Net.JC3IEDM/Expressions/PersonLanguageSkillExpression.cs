using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity PersonLanguageSkill.
    /// </summary>
    public class PersonLanguageSkillExpression : BaseEntityExpression<PersonLanguageSkillExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property PersonId that represents the column pers_id.
        /// </summary>
        /// <value>
        /// The value of the property PersonId that represents the column pers_id.
        /// </value>
        public ColumnExpression PersonId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column pers_lang_skill_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column pers_lang_skill_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property GeneralProficiency that represents the column gen_prof_code.
        /// </summary>
        /// <value>
        /// The value of the property GeneralProficiency that represents the column gen_prof_code.
        /// </value>
        public ColumnExpression GeneralProficiency 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property ListeningProficiencyLevel that represents the column lstng_prof_lvl_code.
        /// </summary>
        /// <value>
        /// The value of the property ListeningProficiencyLevel that represents the column lstng_prof_lvl_code.
        /// </value>
        public ColumnExpression ListeningProficiencyLevel 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property ReadingProficiencyLevel that represents the column rdng_prof_lvl_code.
        /// </summary>
        /// <value>
        /// The value of the property ReadingProficiencyLevel that represents the column rdng_prof_lvl_code.
        /// </value>
        public ColumnExpression ReadingProficiencyLevel 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property SpeakingProficiencyLevel that represents the column spkng_prof_lvl_code.
        /// </summary>
        /// <value>
        /// The value of the property SpeakingProficiencyLevel that represents the column spkng_prof_lvl_code.
        /// </value>
        public ColumnExpression SpeakingProficiencyLevel 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property WritingProficiencyLevel that represents the column wrtng_prof_lvl_code.
        /// </summary>
        /// <value>
        /// The value of the property WritingProficiencyLevel that represents the column wrtng_prof_lvl_code.
        /// </value>
        public ColumnExpression WritingProficiencyLevel 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[9]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonLanguageSkillExpression"/> class.
        /// </summary>
        public PersonLanguageSkillExpression()
            : base("PersonLanguageSkill", typeof(IPersonLanguageSkill))
        {
        }

        #endregion
    }
}
