using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity CandidateTargetListAuthorisation.
    /// </summary>
    public class CandidateTargetListAuthorisationExpression : BaseEntityExpression<CandidateTargetListAuthorisationExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property CandidateTargetListId that represents the column ctgtlst_id.
        /// </summary>
        /// <value>
        /// The value of the property CandidateTargetListId that represents the column ctgtlst_id.
        /// </value>
        public ColumnExpression CandidateTargetListId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column ctgtlst_auth_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column ctgtlst_auth_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Indicator that represents the column ind_code.
        /// </summary>
        /// <value>
        /// The value of the property Indicator that represents the column ind_code.
        /// </value>
        public ColumnExpression Indicator 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property PriorityOrdinal that represents the column prio_ord.
        /// </summary>
        /// <value>
        /// The value of the property PriorityOrdinal that represents the column prio_ord.
        /// </value>
        public ColumnExpression PriorityOrdinal 
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
        /// Initializes a new instance of the <see cref="CandidateTargetListAuthorisationExpression"/> class.
        /// </summary>
        public CandidateTargetListAuthorisationExpression()
            : base("CandidateTargetListAuthorisation", typeof(ICandidateTargetListAuthorisation))
        {
        }

        #endregion
    }
}
