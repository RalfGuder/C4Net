using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionCommentContent.
    /// </summary>
    public class ActionCommentContentExpression : BaseEntityExpression<ActionCommentContentExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property ActionId that represents the column act_id.
        /// </summary>
        /// <value>
        /// The value of the property ActionId that represents the column act_id.
        /// </value>
        public ColumnExpression ActionId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ActionCommentIndex that represents the column act_cmt_ix.
        /// </summary>
        /// <value>
        /// The value of the property ActionCommentIndex that represents the column act_cmt_ix.
        /// </value>
        public ColumnExpression ActionCommentIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column act_cmt_cntnt_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column act_cmt_cntnt_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Text that represents the column txt.
        /// </summary>
        /// <value>
        /// The value of the property Text that represents the column txt.
        /// </value>
        public ColumnExpression Text 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property SequenceOrdinal that represents the column seq_ord.
        /// </summary>
        /// <value>
        /// The value of the property SequenceOrdinal that represents the column seq_ord.
        /// </value>
        public ColumnExpression SequenceOrdinal 
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
        /// Initializes a new instance of the <see cref="ActionCommentContentExpression"/> class.
        /// </summary>
        public ActionCommentContentExpression()
            : base("ActionCommentContent", typeof(IActionCommentContent))
        {
        }

        #endregion
    }
}
