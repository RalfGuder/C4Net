using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity RequestAnswerElement.
    /// </summary>
    public class RequestAnswerElementExpression : BaseEntityExpression<RequestAnswerElementExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property RequestId that represents the column request_id.
        /// </summary>
        /// <value>
        /// The value of the property RequestId that represents the column request_id.
        /// </value>
        public ColumnExpression RequestId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property RequestAnswerIndex that represents the column request_ans_ix.
        /// </summary>
        /// <value>
        /// The value of the property RequestAnswerIndex that represents the column request_ans_ix.
        /// </value>
        public ColumnExpression RequestAnswerIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property ComprisingReportingDataId that represents the column comprising_rptd_id.
        /// </summary>
        /// <value>
        /// The value of the property ComprisingReportingDataId that represents the column comprising_rptd_id.
        /// </value>
        public ColumnExpression ComprisingReportingDataId 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[4]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnswerElementExpression"/> class.
        /// </summary>
        public RequestAnswerElementExpression()
            : base("RequestAnswerElement", typeof(IRequestAnswerElement))
        {
        }

        #endregion
    }
}
