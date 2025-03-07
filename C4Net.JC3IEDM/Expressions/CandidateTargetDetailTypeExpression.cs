using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity CandidateTargetDetailType.
    /// </summary>
    public class CandidateTargetDetailTypeExpression : BaseEntityExpression<CandidateTargetDetailTypeExpression>
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
        /// Expression for the property Index that represents the column ctgtdet_type_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column ctgtdet_type_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectTypeId that represents the column obj_type_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectTypeId that represents the column obj_type_id.
        /// </value>
        public ColumnExpression ObjectTypeId 
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
        /// Initializes a new instance of the <see cref="CandidateTargetDetailTypeExpression"/> class.
        /// </summary>
        public CandidateTargetDetailTypeExpression()
            : base("CandidateTargetDetailType", typeof(ICandidateTargetDetailType))
        {
        }

        #endregion
    }
}
