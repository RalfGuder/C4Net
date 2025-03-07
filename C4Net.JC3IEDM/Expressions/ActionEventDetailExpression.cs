using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionEventDetail.
    /// </summary>
    public class ActionEventDetailExpression : BaseEntityExpression<ActionEventDetailExpression>
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
        /// Expression for the property Index that represents the column act_event_det_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column act_event_det_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Classification that represents the column clsfc_code.
        /// </summary>
        /// <value>
        /// The value of the property Classification that represents the column clsfc_code.
        /// </value>
        public ColumnExpression Classification 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property CrimeIndicator that represents the column crime_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property CrimeIndicator that represents the column crime_ind_code.
        /// </value>
        public ColumnExpression CrimeIndicator 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Text that represents the column txt.
        /// </summary>
        /// <value>
        /// The value of the property Text that represents the column txt.
        /// </value>
        public ColumnExpression Text 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property ReportingDataId that represents the column rptd_id.
        /// </summary>
        /// <value>
        /// The value of the property ReportingDataId that represents the column rptd_id.
        /// </value>
        public ColumnExpression ReportingDataId 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property IntendedOutcome that represents the column intended_outcome_code.
        /// </summary>
        /// <value>
        /// The value of the property IntendedOutcome that represents the column intended_outcome_code.
        /// </value>
        public ColumnExpression IntendedOutcome 
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
        /// Initializes a new instance of the <see cref="ActionEventDetailExpression"/> class.
        /// </summary>
        public ActionEventDetailExpression()
            : base("ActionEventDetail", typeof(IActionEventDetail))
        {
        }

        #endregion
    }
}
