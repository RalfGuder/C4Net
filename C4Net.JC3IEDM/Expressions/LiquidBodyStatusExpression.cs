using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity LiquidBodyStatus.
    /// </summary>
    public class LiquidBodyStatusExpression : BaseEntityExpression<LiquidBodyStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column lqd_body_stat_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column lqd_body_stat_id.
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
        /// Expression for the property BottomCurrentRate that represents the column btm_curr_rate.
        /// </summary>
        /// <value>
        /// The value of the property BottomCurrentRate that represents the column btm_curr_rate.
        /// </value>
        public ColumnExpression BottomCurrentRate 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property ThermalLayerDepthQuantity that represents the column thermal_layer_depth_qty.
        /// </summary>
        /// <value>
        /// The value of the property ThermalLayerDepthQuantity that represents the column thermal_layer_depth_qty.
        /// </value>
        public ColumnExpression ThermalLayerDepthQuantity 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property TidalStreamRate that represents the column tidal_stream_rate.
        /// </summary>
        /// <value>
        /// The value of the property TidalStreamRate that represents the column tidal_stream_rate.
        /// </value>
        public ColumnExpression TidalStreamRate 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property UnderwaterVisibilityQuantity that represents the column underwater_visibility_qty.
        /// </summary>
        /// <value>
        /// The value of the property UnderwaterVisibilityQuantity that represents the column underwater_visibility_qty.
        /// </value>
        public ColumnExpression UnderwaterVisibilityQuantity 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[7]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="LiquidBodyStatusExpression"/> class.
        /// </summary>
        public LiquidBodyStatusExpression()
            : base("LiquidBodyStatus", typeof(ILiquidBodyStatus))
        {
        }

        #endregion
    }
}
