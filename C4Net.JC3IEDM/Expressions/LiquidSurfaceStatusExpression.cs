using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity LiquidSurfaceStatus.
    /// </summary>
    public class LiquidSurfaceStatusExpression : BaseEntityExpression<LiquidSurfaceStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column lqd_surf_stat_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column lqd_surf_stat_id.
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
        /// Expression for the property SeaState that represents the column sea_state_code.
        /// </summary>
        /// <value>
        /// The value of the property SeaState that represents the column sea_state_code.
        /// </value>
        public ColumnExpression SeaState 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property SurfaceCondition that represents the column surf_cond_code.
        /// </summary>
        /// <value>
        /// The value of the property SurfaceCondition that represents the column surf_cond_code.
        /// </value>
        public ColumnExpression SurfaceCondition 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property WaveDirection that represents the column wave_dir_code.
        /// </summary>
        /// <value>
        /// The value of the property WaveDirection that represents the column wave_dir_code.
        /// </value>
        public ColumnExpression WaveDirection 
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
        /// Initializes a new instance of the <see cref="LiquidSurfaceStatusExpression"/> class.
        /// </summary>
        public LiquidSurfaceStatusExpression()
            : base("LiquidSurfaceStatus", typeof(ILiquidSurfaceStatus))
        {
        }

        #endregion
    }
}
