using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Jetty.
    /// </summary>
    public class JettyExpression : BaseEntityExpression<JettyExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column jetty_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column jetty_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property DayLimitNetExplosiveQuantity that represents the column day_limit_net_expl_qty.
        /// </summary>
        /// <value>
        /// The value of the property DayLimitNetExplosiveQuantity that represents the column day_limit_net_expl_qty.
        /// </value>
        public ColumnExpression DayLimitNetExplosiveQuantity 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumDeadweightTonnageQuantity that represents the column max_ddw_tong_qty.
        /// </summary>
        /// <value>
        /// The value of the property MaximumDeadweightTonnageQuantity that represents the column max_ddw_tong_qty.
        /// </value>
        public ColumnExpression MaximumDeadweightTonnageQuantity 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumDraughtDimension that represents the column max_draught_dim.
        /// </summary>
        /// <value>
        /// The value of the property MaximumDraughtDimension that represents the column max_draught_dim.
        /// </value>
        public ColumnExpression MaximumDraughtDimension 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property NightLimitNetExplosiveQuantity that represents the column night_limit_net_expl_qty.
        /// </summary>
        /// <value>
        /// The value of the property NightLimitNetExplosiveQuantity that represents the column night_limit_net_expl_qty.
        /// </value>
        public ColumnExpression NightLimitNetExplosiveQuantity 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property RailCapacityCount that represents the column rail_cap_cnt.
        /// </summary>
        /// <value>
        /// The value of the property RailCapacityCount that represents the column rail_cap_cnt.
        /// </value>
        public ColumnExpression RailCapacityCount 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property RailServedIndicator that represents the column rail_served_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property RailServedIndicator that represents the column rail_served_ind_code.
        /// </value>
        public ColumnExpression RailServedIndicator 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property VesselMaximumBeamDimension that represents the column vessel_max_beam_dim.
        /// </summary>
        /// <value>
        /// The value of the property VesselMaximumBeamDimension that represents the column vessel_max_beam_dim.
        /// </value>
        public ColumnExpression VesselMaximumBeamDimension 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[9]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="JettyExpression"/> class.
        /// </summary>
        public JettyExpression()
            : base("Jetty", typeof(IJetty))
        {
        }

        #endregion
    }
}
