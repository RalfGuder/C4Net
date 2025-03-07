using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionResourceItem.
    /// </summary>
    public class ActionResourceItemExpression : BaseEntityExpression<ActionResourceItemExpression>
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
        /// Expression for the property ActionResourceIndex that represents the column act_res_ix.
        /// </summary>
        /// <value>
        /// The value of the property ActionResourceIndex that represents the column act_res_ix.
        /// </value>
        public ColumnExpression ActionResourceIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectItemId that represents the column obj_item_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemId that represents the column obj_item_id.
        /// </value>
        public ColumnExpression ObjectItemId 
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
        /// Initializes a new instance of the <see cref="ActionResourceItemExpression"/> class.
        /// </summary>
        public ActionResourceItemExpression()
            : base("ActionResourceItem", typeof(IActionResourceItem))
        {
        }

        #endregion
    }
}
