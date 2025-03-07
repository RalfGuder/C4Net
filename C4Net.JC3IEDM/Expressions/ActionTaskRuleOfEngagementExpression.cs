using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionTaskRuleOfEngagement.
    /// </summary>
    public class ActionTaskRuleOfEngagementExpression : BaseEntityExpression<ActionTaskRuleOfEngagementExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property ActionTaskId that represents the column act_task_id.
        /// </summary>
        /// <value>
        /// The value of the property ActionTaskId that represents the column act_task_id.
        /// </value>
        public ColumnExpression ActionTaskId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property RuleOfEngagementId that represents the column roe_id.
        /// </summary>
        /// <value>
        /// The value of the property RuleOfEngagementId that represents the column roe_id.
        /// </value>
        public ColumnExpression RuleOfEngagementId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[3]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionTaskRuleOfEngagementExpression"/> class.
        /// </summary>
        public ActionTaskRuleOfEngagementExpression()
            : base("ActionTaskRuleOfEngagement", typeof(IActionTaskRuleOfEngagement))
        {
        }

        #endregion
    }
}
