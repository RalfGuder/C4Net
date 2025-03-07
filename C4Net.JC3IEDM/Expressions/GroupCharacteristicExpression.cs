using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity GroupCharacteristic.
    /// </summary>
    public class GroupCharacteristicExpression : BaseEntityExpression<GroupCharacteristicExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column group_chrct_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column group_chrct_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property AgeGroup that represents the column age_group_code.
        /// </summary>
        /// <value>
        /// The value of the property AgeGroup that represents the column age_group_code.
        /// </value>
        public ColumnExpression AgeGroup 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Malady that represents the column malady_code.
        /// </summary>
        /// <value>
        /// The value of the property Malady that represents the column malady_code.
        /// </value>
        public ColumnExpression Malady 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property MaladyTransmissibilityIndicator that represents the column malady_trnsmsbl_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property MaladyTransmissibilityIndicator that represents the column malady_trnsmsbl_ind_code.
        /// </value>
        public ColumnExpression MaladyTransmissibilityIndicator 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Gender that represents the column gender_code.
        /// </summary>
        /// <value>
        /// The value of the property Gender that represents the column gender_code.
        /// </value>
        public ColumnExpression Gender 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property Language that represents the column lang_code.
        /// </summary>
        /// <value>
        /// The value of the property Language that represents the column lang_code.
        /// </value>
        public ColumnExpression Language 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property Triage that represents the column triage_code.
        /// </summary>
        /// <value>
        /// The value of the property Triage that represents the column triage_code.
        /// </value>
        public ColumnExpression Triage 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[8]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupCharacteristicExpression"/> class.
        /// </summary>
        public GroupCharacteristicExpression()
            : base("GroupCharacteristic", typeof(IGroupCharacteristic))
        {
        }

        #endregion
    }
}
