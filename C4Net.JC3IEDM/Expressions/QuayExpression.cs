using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Quay.
    /// </summary>
    public class QuayExpression : BaseEntityExpression<QuayExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column quay_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column quay_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ContainerHandlingType that represents the column cntr_hndl_type_code.
        /// </summary>
        /// <value>
        /// The value of the property ContainerHandlingType that represents the column cntr_hndl_type_code.
        /// </value>
        public ColumnExpression ContainerHandlingType 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property ContainerMaximumHandlingLengthDimension that represents the column cntr_max_hndl_length_dim.
        /// </summary>
        /// <value>
        /// The value of the property ContainerMaximumHandlingLengthDimension that represents the column cntr_max_hndl_length_dim.
        /// </value>
        public ColumnExpression ContainerMaximumHandlingLengthDimension 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property ContainerMaximumHandlingWeightQuantity that represents the column cntr_max_hndl_wt_qty.
        /// </summary>
        /// <value>
        /// The value of the property ContainerMaximumHandlingWeightQuantity that represents the column cntr_max_hndl_wt_qty.
        /// </value>
        public ColumnExpression ContainerMaximumHandlingWeightQuantity 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property CraneOffloadingLiftQuantity that represents the column crane_ofld_lift_qty.
        /// </summary>
        /// <value>
        /// The value of the property CraneOffloadingLiftQuantity that represents the column crane_ofld_lift_qty.
        /// </value>
        public ColumnExpression CraneOffloadingLiftQuantity 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property CraneOffloadingType that represents the column crane_ofld_type_code.
        /// </summary>
        /// <value>
        /// The value of the property CraneOffloadingType that represents the column crane_ofld_type_code.
        /// </value>
        public ColumnExpression CraneOffloadingType 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property DayLimitNetExplosiveQuantity that represents the column day_limit_net_expl_qty.
        /// </summary>
        /// <value>
        /// The value of the property DayLimitNetExplosiveQuantity that represents the column day_limit_net_expl_qty.
        /// </value>
        public ColumnExpression DayLimitNetExplosiveQuantity 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property DraughtDimension that represents the column draught_dim.
        /// </summary>
        /// <value>
        /// The value of the property DraughtDimension that represents the column draught_dim.
        /// </value>
        public ColumnExpression DraughtDimension 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumDeadweightTonnageQuantity that represents the column max_ddw_tong_qty.
        /// </summary>
        /// <value>
        /// The value of the property MaximumDeadweightTonnageQuantity that represents the column max_ddw_tong_qty.
        /// </value>
        public ColumnExpression MaximumDeadweightTonnageQuantity 
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
        /// Expression for the property RailCapacityCount that represents the column rail_cap_cnt.
        /// </summary>
        /// <value>
        /// The value of the property RailCapacityCount that represents the column rail_cap_cnt.
        /// </value>
        public ColumnExpression RailCapacityCount 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property RailServedIndicator that represents the column rail_served_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property RailServedIndicator that represents the column rail_served_ind_code.
        /// </value>
        public ColumnExpression RailServedIndicator 
        { 
            get { return this.columns[11]; } 
        }
		
        /// <summary>
        /// Expression for the property Storage that represents the column storage_code.
        /// </summary>
        /// <value>
        /// The value of the property Storage that represents the column storage_code.
        /// </value>
        public ColumnExpression Storage 
        { 
            get { return this.columns[12]; } 
        }
		
        /// <summary>
        /// Expression for the property VesselMaximumBeamDimension that represents the column vessel_max_beam_dim.
        /// </summary>
        /// <value>
        /// The value of the property VesselMaximumBeamDimension that represents the column vessel_max_beam_dim.
        /// </value>
        public ColumnExpression VesselMaximumBeamDimension 
        { 
            get { return this.columns[13]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[14]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[15]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="QuayExpression"/> class.
        /// </summary>
        public QuayExpression()
            : base("Quay", typeof(IQuay))
        {
        }

        #endregion
    }
}
