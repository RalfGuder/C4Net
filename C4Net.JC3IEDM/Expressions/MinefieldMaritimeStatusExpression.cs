using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity MinefieldMaritimeStatus.
    /// </summary>
    public class MinefieldMaritimeStatusExpression : BaseEntityExpression<MinefieldMaritimeStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column mnfld_mrt_stat_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column mnfld_mrt_stat_id.
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
        /// Expression for the property MinefieldMaritimeStatusCode that represents the column code.
        /// </summary>
        /// <value>
        /// The value of the property MinefieldMaritimeStatusCode that represents the column code.
        /// </value>
        public ColumnExpression MinefieldMaritimeStatusCode 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Colour that represents the column colour_code.
        /// </summary>
        /// <value>
        /// The value of the property Colour that represents the column colour_code.
        /// </value>
        public ColumnExpression Colour 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property ExpectedLevelMcm that represents the column expct_lvl_mcm_code.
        /// </summary>
        /// <value>
        /// The value of the property ExpectedLevelMcm that represents the column expct_lvl_mcm_code.
        /// </value>
        public ColumnExpression ExpectedLevelMcm 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property MinesDetectedQuantity that represents the column mines_detected_qty.
        /// </summary>
        /// <value>
        /// The value of the property MinesDetectedQuantity that represents the column mines_detected_qty.
        /// </value>
        public ColumnExpression MinesDetectedQuantity 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property MinesDetectedCount that represents the column mines_detected_cnt.
        /// </summary>
        /// <value>
        /// The value of the property MinesDetectedCount that represents the column mines_detected_cnt.
        /// </value>
        public ColumnExpression MinesDetectedCount 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property MineZoneRisk that represents the column mine_zone_risk_code.
        /// </summary>
        /// <value>
        /// The value of the property MineZoneRisk that represents the column mine_zone_risk_code.
        /// </value>
        public ColumnExpression MineZoneRisk 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property Seeding that represents the column seeding_code.
        /// </summary>
        /// <value>
        /// The value of the property Seeding that represents the column seeding_code.
        /// </value>
        public ColumnExpression Seeding 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property SweptDepthQuantity that represents the column swept_depth_qty.
        /// </summary>
        /// <value>
        /// The value of the property SweptDepthQuantity that represents the column swept_depth_qty.
        /// </value>
        public ColumnExpression SweptDepthQuantity 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property ThreatRatio that represents the column thrt_rat.
        /// </summary>
        /// <value>
        /// The value of the property ThreatRatio that represents the column thrt_rat.
        /// </value>
        public ColumnExpression ThreatRatio 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property MineDetection that represents the column mine_dtctn_code.
        /// </summary>
        /// <value>
        /// The value of the property MineDetection that represents the column mine_dtctn_code.
        /// </value>
        public ColumnExpression MineDetection 
        { 
            get { return this.columns[11]; } 
        }
		
        /// <summary>
        /// Expression for the property MinesCount that represents the column mines_cnt.
        /// </summary>
        /// <value>
        /// The value of the property MinesCount that represents the column mines_cnt.
        /// </value>
        public ColumnExpression MinesCount 
        { 
            get { return this.columns[12]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[13]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[14]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="MinefieldMaritimeStatusExpression"/> class.
        /// </summary>
        public MinefieldMaritimeStatusExpression()
            : base("MinefieldMaritimeStatus", typeof(IMinefieldMaritimeStatus))
        {
        }

        #endregion
    }
}
