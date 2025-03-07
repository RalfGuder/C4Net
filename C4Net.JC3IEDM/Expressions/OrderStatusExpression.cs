using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity OrderStatus.
    /// </summary>
    public class OrderStatusExpression : BaseEntityExpression<OrderStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property OrderId that represents the column ordr_id.
        /// </summary>
        /// <value>
        /// The value of the property OrderId that represents the column ordr_id.
        /// </value>
        public ColumnExpression OrderId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column ordr_stat_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column ordr_stat_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property ExecutionState that represents the column exec_state_code.
        /// </summary>
        /// <value>
        /// The value of the property ExecutionState that represents the column exec_state_code.
        /// </value>
        public ColumnExpression ExecutionState 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Datetime that represents the column dttm.
        /// </summary>
        /// <value>
        /// The value of the property Datetime that represents the column dttm.
        /// </value>
        public ColumnExpression Datetime 
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
        /// Initializes a new instance of the <see cref="OrderStatusExpression"/> class.
        /// </summary>
        public OrderStatusExpression()
            : base("OrderStatus", typeof(IOrderStatus))
        {
        }

        #endregion
    }
}
