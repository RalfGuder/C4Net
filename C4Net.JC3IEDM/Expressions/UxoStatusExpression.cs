using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity UxoStatus.
    /// </summary>
    public class UxoStatusExpression : BaseEntityExpression<UxoStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column uxo_stat_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column uxo_stat_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectItemStatusIndex that represents the column obj_item_stat_ix.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemStatusIndex that represents the column obj_item_stat_ix.
        /// </value>
        public ColumnExpression ObjectItemStatusIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Exposure that represents the column exp_code.
        /// </summary>
        /// <value>
        /// The value of the property Exposure that represents the column exp_code.
        /// </value>
        public ColumnExpression Exposure 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Qualifier that represents the column qual_code.
        /// </summary>
        /// <value>
        /// The value of the property Qualifier that represents the column qual_code.
        /// </value>
        public ColumnExpression Qualifier 
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
        /// Initializes a new instance of the <see cref="UxoStatusExpression"/> class.
        /// </summary>
        public UxoStatusExpression()
            : base("UxoStatus", typeof(IUxoStatus))
        {
        }

        #endregion
    }
}
