using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity MinefieldMaritime.
    /// </summary>
    public class MinefieldMaritimeExpression : BaseEntityExpression<MinefieldMaritimeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column mnfld_mrt_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column mnfld_mrt_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property DepthPlacement that represents the column depth_plcmnt_code.
        /// </summary>
        /// <value>
        /// The value of the property DepthPlacement that represents the column depth_plcmnt_code.
        /// </value>
        public ColumnExpression DepthPlacement 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property ExpectedVesselTransitCount that represents the column expct_vessel_transit_cnt.
        /// </summary>
        /// <value>
        /// The value of the property ExpectedVesselTransitCount that represents the column expct_vessel_transit_cnt.
        /// </value>
        public ColumnExpression ExpectedVesselTransitCount 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Function that represents the column func_code.
        /// </summary>
        /// <value>
        /// The value of the property Function that represents the column func_code.
        /// </value>
        public ColumnExpression Function 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property MmoeInitialThreatProbabilityRatio that represents the column mmoe_initial_thrt_prob_rat.
        /// </summary>
        /// <value>
        /// The value of the property MmoeInitialThreatProbabilityRatio that represents the column mmoe_initial_thrt_prob_rat.
        /// </value>
        public ColumnExpression MmoeInitialThreatProbabilityRatio 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property DetectionProbabilityRatio that represents the column dtctn_prob_rat.
        /// </summary>
        /// <value>
        /// The value of the property DetectionProbabilityRatio that represents the column dtctn_prob_rat.
        /// </value>
        public ColumnExpression DetectionProbabilityRatio 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property LifeDuration that represents the column life_dur.
        /// </summary>
        /// <value>
        /// The value of the property LifeDuration that represents the column life_dur.
        /// </value>
        public ColumnExpression LifeDuration 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property MineDetailedText that represents the column mine_detld_txt.
        /// </summary>
        /// <value>
        /// The value of the property MineDetailedText that represents the column mine_detld_txt.
        /// </value>
        public ColumnExpression MineDetailedText 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property MinesLaidCount that represents the column mines_laid_cnt.
        /// </summary>
        /// <value>
        /// The value of the property MinesLaidCount that represents the column mines_laid_cnt.
        /// </value>
        public ColumnExpression MinesLaidCount 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property BottomNaturalCamouflage that represents the column btm_natural_camo_code.
        /// </summary>
        /// <value>
        /// The value of the property BottomNaturalCamouflage that represents the column btm_natural_camo_code.
        /// </value>
        public ColumnExpression BottomNaturalCamouflage 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property Subfunction that represents the column subf_code.
        /// </summary>
        /// <value>
        /// The value of the property Subfunction that represents the column subf_code.
        /// </value>
        public ColumnExpression Subfunction 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[11]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[12]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="MinefieldMaritimeExpression"/> class.
        /// </summary>
        public MinefieldMaritimeExpression()
            : base("MinefieldMaritime", typeof(IMinefieldMaritime))
        {
        }

        #endregion
    }
}
