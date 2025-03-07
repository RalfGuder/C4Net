using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Request.
    /// </summary>
    public class RequestExpression : BaseEntityExpression<RequestExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column request_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column request_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property ImmediateInterestIndicator that represents the column immd_interest_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property ImmediateInterestIndicator that represents the column immd_interest_ind_code.
        /// </value>
        public ColumnExpression ImmediateInterestIndicator 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property LatestAnswerDatetime that represents the column latest_ans_dttm.
        /// </summary>
        /// <value>
        /// The value of the property LatestAnswerDatetime that represents the column latest_ans_dttm.
        /// </value>
        public ColumnExpression LatestAnswerDatetime 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[5]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestExpression"/> class.
        /// </summary>
        public RequestExpression()
            : base("Request", typeof(IRequest))
        {
        }

        #endregion
    }
}
