using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Railway.
    /// </summary>
    public class RailwayExpression : BaseEntityExpression<RailwayExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column railway_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column railway_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property TrackGauge that represents the column track_gauge_code.
        /// </summary>
        /// <value>
        /// The value of the property TrackGauge that represents the column track_gauge_code.
        /// </value>
        public ColumnExpression TrackGauge 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property TrackCount that represents the column track_cnt.
        /// </summary>
        /// <value>
        /// The value of the property TrackCount that represents the column track_cnt.
        /// </value>
        public ColumnExpression TrackCount 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property TrainDensityCount that represents the column train_density_cnt.
        /// </summary>
        /// <value>
        /// The value of the property TrainDensityCount that represents the column train_density_cnt.
        /// </value>
        public ColumnExpression TrainDensityCount 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property BlockDistanceDimension that represents the column block_dist_dim.
        /// </summary>
        /// <value>
        /// The value of the property BlockDistanceDimension that represents the column block_dist_dim.
        /// </value>
        public ColumnExpression BlockDistanceDimension 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property SleeperDensityDimension that represents the column sleeper_density_dim.
        /// </summary>
        /// <value>
        /// The value of the property SleeperDensityDimension that represents the column sleeper_density_dim.
        /// </value>
        public ColumnExpression SleeperDensityDimension 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property GrossTrailingLoadQuantity that represents the column gross_trailing_load_qty.
        /// </summary>
        /// <value>
        /// The value of the property GrossTrailingLoadQuantity that represents the column gross_trailing_load_qty.
        /// </value>
        public ColumnExpression GrossTrailingLoadQuantity 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumSpeedRate that represents the column max_speed_rate.
        /// </summary>
        /// <value>
        /// The value of the property MaximumSpeedRate that represents the column max_speed_rate.
        /// </value>
        public ColumnExpression MaximumSpeedRate 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property TractionSystem that represents the column traction_sys_code.
        /// </summary>
        /// <value>
        /// The value of the property TractionSystem that represents the column traction_sys_code.
        /// </value>
        public ColumnExpression TractionSystem 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property SignalSystem that represents the column signal_sys_code.
        /// </summary>
        /// <value>
        /// The value of the property SignalSystem that represents the column signal_sys_code.
        /// </value>
        public ColumnExpression SignalSystem 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property SignalSystemEfficiency that represents the column signal_sys_effc_code.
        /// </summary>
        /// <value>
        /// The value of the property SignalSystemEfficiency that represents the column signal_sys_effc_code.
        /// </value>
        public ColumnExpression SignalSystemEfficiency 
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
        /// Initializes a new instance of the <see cref="RailwayExpression"/> class.
        /// </summary>
        public RailwayExpression()
            : base("Railway", typeof(IRailway))
        {
        }

        #endregion
    }
}
