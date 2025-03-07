using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity MineStatus.
    /// </summary>
    public class MineStatusExpression : BaseEntityExpression<MineStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column mine_stat_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column mine_stat_id.
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
        /// Expression for the property MineBuriedRatio that represents the column mine_buried_rat.
        /// </summary>
        /// <value>
        /// The value of the property MineBuriedRatio that represents the column mine_buried_rat.
        /// </value>
        public ColumnExpression MineBuriedRatio 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property MineStatusCode that represents the column code.
        /// </summary>
        /// <value>
        /// The value of the property MineStatusCode that represents the column code.
        /// </value>
        public ColumnExpression MineStatusCode 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property AirDropEffect that represents the column air_drop_effect_code.
        /// </summary>
        /// <value>
        /// The value of the property AirDropEffect that represents the column air_drop_effect_code.
        /// </value>
        public ColumnExpression AirDropEffect 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property MaritimeMineQualifier that represents the column mrt_mine_qual_code.
        /// </summary>
        /// <value>
        /// The value of the property MaritimeMineQualifier that represents the column mrt_mine_qual_code.
        /// </value>
        public ColumnExpression MaritimeMineQualifier 
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
        /// Initializes a new instance of the <see cref="MineStatusExpression"/> class.
        /// </summary>
        public MineStatusExpression()
            : base("MineStatus", typeof(IMineStatus))
        {
        }

        #endregion
    }
}
