using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionEventStatus.
    /// </summary>
    public class ActionEventStatusExpression : BaseEntityExpression<ActionEventStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property ActionEventId that represents the column act_event_id.
        /// </summary>
        /// <value>
        /// The value of the property ActionEventId that represents the column act_event_id.
        /// </value>
        public ColumnExpression ActionEventId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column act_event_stat_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column act_event_stat_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property CompletionRatio that represents the column compl_rat.
        /// </summary>
        /// <value>
        /// The value of the property CompletionRatio that represents the column compl_rat.
        /// </value>
        public ColumnExpression CompletionRatio 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property FeintIndicator that represents the column feint_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property FeintIndicator that represents the column feint_ind_code.
        /// </value>
        public ColumnExpression FeintIndicator 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property ReportingDataId that represents the column rptd_id.
        /// </summary>
        /// <value>
        /// The value of the property ReportingDataId that represents the column rptd_id.
        /// </value>
        public ColumnExpression ReportingDataId 
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
        /// Initializes a new instance of the <see cref="ActionEventStatusExpression"/> class.
        /// </summary>
        public ActionEventStatusExpression()
            : base("ActionEventStatus", typeof(IActionEventStatus))
        {
        }

        #endregion
    }
}
