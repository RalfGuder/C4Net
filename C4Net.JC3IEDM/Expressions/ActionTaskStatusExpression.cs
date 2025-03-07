using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionTaskStatus.
    /// </summary>
    public class ActionTaskStatusExpression : BaseEntityExpression<ActionTaskStatusExpression>
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
        /// Expression for the property Index that represents the column act_task_stat_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column act_task_stat_ix.
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
        /// Expression for the property CompletionRatio that represents the column compl_rat.
        /// </summary>
        /// <value>
        /// The value of the property CompletionRatio that represents the column compl_rat.
        /// </value>
        public ColumnExpression CompletionRatio 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property PlanningIndicator that represents the column planning_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property PlanningIndicator that represents the column planning_ind_code.
        /// </value>
        public ColumnExpression PlanningIndicator 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property Progress that represents the column progress_code.
        /// </summary>
        /// <value>
        /// The value of the property Progress that represents the column progress_code.
        /// </value>
        public ColumnExpression Progress 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property AmendTiming that represents the column amend_timing_code.
        /// </summary>
        /// <value>
        /// The value of the property AmendTiming that represents the column amend_timing_code.
        /// </value>
        public ColumnExpression AmendTiming 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property ApprovalIndicator that represents the column app_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property ApprovalIndicator that represents the column app_ind_code.
        /// </value>
        public ColumnExpression ApprovalIndicator 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property FeintIndicator that represents the column feint_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property FeintIndicator that represents the column feint_ind_code.
        /// </value>
        public ColumnExpression FeintIndicator 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property ReportingDataId that represents the column rptd_id.
        /// </summary>
        /// <value>
        /// The value of the property ReportingDataId that represents the column rptd_id.
        /// </value>
        public ColumnExpression ReportingDataId 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[11]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionTaskStatusExpression"/> class.
        /// </summary>
        public ActionTaskStatusExpression()
            : base("ActionTaskStatus", typeof(IActionTaskStatus))
        {
        }

        #endregion
    }
}
