using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Person.
    /// </summary>
    public class PersonExpression : BaseEntityExpression<PersonExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column pers_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column pers_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property BirthDatetime that represents the column birth_dttm.
        /// </summary>
        /// <value>
        /// The value of the property BirthDatetime that represents the column birth_dttm.
        /// </value>
        public ColumnExpression BirthDatetime 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property BloodType that represents the column blood_type_code.
        /// </summary>
        /// <value>
        /// The value of the property BloodType that represents the column blood_type_code.
        /// </value>
        public ColumnExpression BloodType 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Gender that represents the column gender_code.
        /// </summary>
        /// <value>
        /// The value of the property Gender that represents the column gender_code.
        /// </value>
        public ColumnExpression Gender 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property ProfessingIndicator that represents the column professing_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property ProfessingIndicator that represents the column professing_ind_code.
        /// </value>
        public ColumnExpression ProfessingIndicator 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[6]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonExpression"/> class.
        /// </summary>
        public PersonExpression()
            : base("Person", typeof(IPerson))
        {
        }

        #endregion
    }
}
