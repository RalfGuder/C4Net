using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Berth.
    /// </summary>
    public class BerthExpression : BaseEntityExpression<BerthExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column berth_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column berth_id.
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
        /// Expression for the property MajorVesselClass that represents the column major_vessel_class_code.
        /// </summary>
        /// <value>
        /// The value of the property MajorVesselClass that represents the column major_vessel_class_code.
        /// </value>
        public ColumnExpression MajorVesselClass 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumBeamDimension that represents the column max_beam_dim.
        /// </summary>
        /// <value>
        /// The value of the property MaximumBeamDimension that represents the column max_beam_dim.
        /// </value>
        public ColumnExpression MaximumBeamDimension 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumCapacityQuantity that represents the column max_cap_qty.
        /// </summary>
        /// <value>
        /// The value of the property MaximumCapacityQuantity that represents the column max_cap_qty.
        /// </value>
        public ColumnExpression MaximumCapacityQuantity 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumVesselCount that represents the column max_vessel_cnt.
        /// </summary>
        /// <value>
        /// The value of the property MaximumVesselCount that represents the column max_vessel_cnt.
        /// </value>
        public ColumnExpression MaximumVesselCount 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property DayLimitNetExplosiveQuantity that represents the column day_limit_net_expl_qty.
        /// </summary>
        /// <value>
        /// The value of the property DayLimitNetExplosiveQuantity that represents the column day_limit_net_expl_qty.
        /// </value>
        public ColumnExpression DayLimitNetExplosiveQuantity 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property NightLimitNetExplosiveQuantity that represents the column night_limit_net_expl_qty.
        /// </summary>
        /// <value>
        /// The value of the property NightLimitNetExplosiveQuantity that represents the column night_limit_net_expl_qty.
        /// </value>
        public ColumnExpression NightLimitNetExplosiveQuantity 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property RailAvailabilityIndicator that represents the column rail_avlbty_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property RailAvailabilityIndicator that represents the column rail_avlbty_ind_code.
        /// </value>
        public ColumnExpression RailAvailabilityIndicator 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property RollOnRollOffIndicator that represents the column roll_on_roll_off_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property RollOnRollOffIndicator that represents the column roll_on_roll_off_ind_code.
        /// </value>
        public ColumnExpression RollOnRollOffIndicator 
        { 
            get { return this.columns[11]; } 
        }
		
        /// <summary>
        /// Expression for the property TurnaroundTimeDuration that represents the column turnaround_time_dur.
        /// </summary>
        /// <value>
        /// The value of the property TurnaroundTimeDuration that represents the column turnaround_time_dur.
        /// </value>
        public ColumnExpression TurnaroundTimeDuration 
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
        /// Initializes a new instance of the <see cref="BerthExpression"/> class.
        /// </summary>
        public BerthExpression()
            : base("Berth", typeof(IBerth))
        {
        }

        #endregion
    }
}
