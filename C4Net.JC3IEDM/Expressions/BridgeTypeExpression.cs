using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity BridgeType.
    /// </summary>
    public class BridgeTypeExpression : BaseEntityExpression<BridgeTypeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column bridge_type_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column bridge_type_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property DesignType that represents the column design_type_code.
        /// </summary>
        /// <value>
        /// The value of the property DesignType that represents the column design_type_code.
        /// </value>
        public ColumnExpression DesignType 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[3]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeTypeExpression"/> class.
        /// </summary>
        public BridgeTypeExpression()
            : base("BridgeType", typeof(IBridgeType))
        {
        }

        #endregion
    }
}
