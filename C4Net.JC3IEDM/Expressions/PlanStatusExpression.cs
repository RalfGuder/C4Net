using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity PlanStatus.
    /// </summary>
    public class PlanStatusExpression : BaseEntityExpression<PlanStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property PlanId that represents the column pln_id.
        /// </summary>
        /// <value>
        /// The value of the property PlanId that represents the column pln_id.
        /// </value>
        public ColumnExpression PlanId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column pln_stat_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column pln_stat_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property DevelopmentStatus that represents the column dvlpm_stat_code.
        /// </summary>
        /// <value>
        /// The value of the property DevelopmentStatus that represents the column dvlpm_stat_code.
        /// </value>
        public ColumnExpression DevelopmentStatus 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property State that represents the column state_code.
        /// </summary>
        /// <value>
        /// The value of the property State that represents the column state_code.
        /// </value>
        public ColumnExpression State 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Datetime that represents the column dttm.
        /// </summary>
        /// <value>
        /// The value of the property Datetime that represents the column dttm.
        /// </value>
        public ColumnExpression Datetime 
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
        /// Initializes a new instance of the <see cref="PlanStatusExpression"/> class.
        /// </summary>
        public PlanStatusExpression()
            : base("PlanStatus", typeof(IPlanStatus))
        {
        }

        #endregion
    }
}
