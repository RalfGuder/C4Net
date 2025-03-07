using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Basin.
    /// </summary>
    public class BasinExpression : BaseEntityExpression<BasinExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column basin_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column basin_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property DeadweightTonnageQuantity that represents the column ddw_tong_qty.
        /// </summary>
        /// <value>
        /// The value of the property DeadweightTonnageQuantity that represents the column ddw_tong_qty.
        /// </value>
        public ColumnExpression DeadweightTonnageQuantity 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property DepthDimension that represents the column depth_dim.
        /// </summary>
        /// <value>
        /// The value of the property DepthDimension that represents the column depth_dim.
        /// </value>
        public ColumnExpression DepthDimension 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property LocationText that represents the column loc_txt.
        /// </summary>
        /// <value>
        /// The value of the property LocationText that represents the column loc_txt.
        /// </value>
        public ColumnExpression LocationText 
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
        /// Initializes a new instance of the <see cref="BasinExpression"/> class.
        /// </summary>
        public BasinExpression()
            : base("Basin", typeof(IBasin))
        {
        }

        #endregion
    }
}
