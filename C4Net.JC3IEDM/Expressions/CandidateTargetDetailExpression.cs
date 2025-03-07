using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity CandidateTargetDetail.
    /// </summary>
    public class CandidateTargetDetailExpression : BaseEntityExpression<CandidateTargetDetailExpression>
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
        /// Expression for the property Index that represents the column ctgtdet_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column ctgtdet_ix.
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
        /// Expression for the property FocusType that represents the column focus_type_code.
        /// </summary>
        /// <value>
        /// The value of the property FocusType that represents the column focus_type_code.
        /// </value>
        public ColumnExpression FocusType 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property LabelText that represents the column label_txt.
        /// </summary>
        /// <value>
        /// The value of the property LabelText that represents the column label_txt.
        /// </value>
        public ColumnExpression LabelText 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property PriorityOrdinal that represents the column prio_ord.
        /// </summary>
        /// <value>
        /// The value of the property PriorityOrdinal that represents the column prio_ord.
        /// </value>
        public ColumnExpression PriorityOrdinal 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property Scheme that represents the column scheme_code.
        /// </summary>
        /// <value>
        /// The value of the property Scheme that represents the column scheme_code.
        /// </value>
        public ColumnExpression Scheme 
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
        /// Initializes a new instance of the <see cref="CandidateTargetDetailExpression"/> class.
        /// </summary>
        public CandidateTargetDetailExpression()
            : base("CandidateTargetDetail", typeof(ICandidateTargetDetail))
        {
        }

        #endregion
    }
}
