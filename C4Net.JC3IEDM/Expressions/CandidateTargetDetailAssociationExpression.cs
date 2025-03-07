using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity CandidateTargetDetailAssociation.
    /// </summary>
    public class CandidateTargetDetailAssociationExpression : BaseEntityExpression<CandidateTargetDetailAssociationExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property SubjectCandidateTargetListId that represents the column subj_ctgtlst_id.
        /// </summary>
        /// <value>
        /// The value of the property SubjectCandidateTargetListId that represents the column subj_ctgtlst_id.
        /// </value>
        public ColumnExpression SubjectCandidateTargetListId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property SubjectCandidateTargetDetailIndex that represents the column subj_ctgtdet_ix.
        /// </summary>
        /// <value>
        /// The value of the property SubjectCandidateTargetDetailIndex that represents the column subj_ctgtdet_ix.
        /// </value>
        public ColumnExpression SubjectCandidateTargetDetailIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectCandidateTargetListId that represents the column obj_ctgtlst_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectCandidateTargetListId that represents the column obj_ctgtlst_id.
        /// </value>
        public ColumnExpression ObjectCandidateTargetListId 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectCandidateTargetDetailIndex that represents the column obj_ctgtdet_ix.
        /// </summary>
        /// <value>
        /// The value of the property ObjectCandidateTargetDetailIndex that represents the column obj_ctgtdet_ix.
        /// </value>
        public ColumnExpression ObjectCandidateTargetDetailIndex 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
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
        /// Initializes a new instance of the <see cref="CandidateTargetDetailAssociationExpression"/> class.
        /// </summary>
        public CandidateTargetDetailAssociationExpression()
            : base("CandidateTargetDetailAssociation", typeof(ICandidateTargetDetailAssociation))
        {
        }

        #endregion
    }
}
