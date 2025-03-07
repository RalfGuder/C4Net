using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Anchorage.
    /// </summary>
    public class AnchorageExpression : BaseEntityExpression<AnchorageExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column anchr_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column anchr_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property BottomType that represents the column btm_type_code.
        /// </summary>
        /// <value>
        /// The value of the property BottomType that represents the column btm_type_code.
        /// </value>
        public ColumnExpression BottomType 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property DayLimitNetExplosiveQuantity that represents the column day_limit_net_expl_qty.
        /// </summary>
        /// <value>
        /// The value of the property DayLimitNetExplosiveQuantity that represents the column day_limit_net_expl_qty.
        /// </value>
        public ColumnExpression DayLimitNetExplosiveQuantity 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property DraughtHighTideDimension that represents the column draught_high_tide_dim.
        /// </summary>
        /// <value>
        /// The value of the property DraughtHighTideDimension that represents the column draught_high_tide_dim.
        /// </value>
        public ColumnExpression DraughtHighTideDimension 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property DraughtLowTideDimension that represents the column draught_low_tide_dim.
        /// </summary>
        /// <value>
        /// The value of the property DraughtLowTideDimension that represents the column draught_low_tide_dim.
        /// </value>
        public ColumnExpression DraughtLowTideDimension 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property MooringsType that represents the column moorings_type_code.
        /// </summary>
        /// <value>
        /// The value of the property MooringsType that represents the column moorings_type_code.
        /// </value>
        public ColumnExpression MooringsType 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property NightLimitNetExplosiveQuantity that represents the column night_limit_net_expl_qty.
        /// </summary>
        /// <value>
        /// The value of the property NightLimitNetExplosiveQuantity that represents the column night_limit_net_expl_qty.
        /// </value>
        public ColumnExpression NightLimitNetExplosiveQuantity 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property PrevailingWindDirection that represents the column prvl_wind_dir_code.
        /// </summary>
        /// <value>
        /// The value of the property PrevailingWindDirection that represents the column prvl_wind_dir_code.
        /// </value>
        public ColumnExpression PrevailingWindDirection 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property VesselTonnageQuantity that represents the column vessel_tong_qty.
        /// </summary>
        /// <value>
        /// The value of the property VesselTonnageQuantity that represents the column vessel_tong_qty.
        /// </value>
        public ColumnExpression VesselTonnageQuantity 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[10]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="AnchorageExpression"/> class.
        /// </summary>
        public AnchorageExpression()
            : base("Anchorage", typeof(IAnchorage))
        {
        }

        #endregion
    }
}
