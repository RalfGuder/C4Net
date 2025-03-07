using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ObjectItemCommentContent.
    /// </summary>
    public class ObjectItemCommentContentExpression : BaseEntityExpression<ObjectItemCommentContentExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property ObjectItemId that represents the column obj_item_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemId that represents the column obj_item_id.
        /// </value>
        public ColumnExpression ObjectItemId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectItemCommentIndex that represents the column obj_item_cmt_ix.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemCommentIndex that represents the column obj_item_cmt_ix.
        /// </value>
        public ColumnExpression ObjectItemCommentIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column obj_item_cmt_cntnt_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column obj_item_cmt_cntnt_ix.
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
        /// Initializes a new instance of the <see cref="ObjectItemCommentContentExpression"/> class.
        /// </summary>
        public ObjectItemCommentContentExpression()
            : base("ObjectItemCommentContent", typeof(IObjectItemCommentContent))
        {
        }

        #endregion
    }
}
