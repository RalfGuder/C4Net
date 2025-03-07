using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity VesselType.
    /// </summary>
    public class VesselTypeExpression : BaseEntityExpression<VesselTypeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column vessel_type_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column vessel_type_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property MagneticDegaussingCodeNumberQuantity that represents the column magn_degaussing_code_no_qty.
        /// </summary>
        /// <value>
        /// The value of the property MagneticDegaussingCodeNumberQuantity that represents the column magn_degaussing_code_no_qty.
        /// </value>
        public ColumnExpression MagneticDegaussingCodeNumberQuantity 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property PrismaticCoefficientRatio that represents the column prismatic_coefficient_rat.
        /// </summary>
        /// <value>
        /// The value of the property PrismaticCoefficientRatio that represents the column prismatic_coefficient_rat.
        /// </value>
        public ColumnExpression PrismaticCoefficientRatio 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property DeadWeightQuantity that represents the column dead_wt_qty.
        /// </summary>
        /// <value>
        /// The value of the property DeadWeightQuantity that represents the column dead_wt_qty.
        /// </value>
        public ColumnExpression DeadWeightQuantity 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property DraughtDimension that represents the column draught_dim.
        /// </summary>
        /// <value>
        /// The value of the property DraughtDimension that represents the column draught_dim.
        /// </value>
        public ColumnExpression DraughtDimension 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property GrossRegisteredTonnageQuantity that represents the column gross_rgstrd_tong_qty.
        /// </summary>
        /// <value>
        /// The value of the property GrossRegisteredTonnageQuantity that represents the column gross_rgstrd_tong_qty.
        /// </value>
        public ColumnExpression GrossRegisteredTonnageQuantity 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property HeightAboveTheWaterlineDimension that represents the column height_above_the_wtrln_dim.
        /// </summary>
        /// <value>
        /// The value of the property HeightAboveTheWaterlineDimension that represents the column height_above_the_wtrln_dim.
        /// </value>
        public ColumnExpression HeightAboveTheWaterlineDimension 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property PropellerCount that represents the column propeller_cnt.
        /// </summary>
        /// <value>
        /// The value of the property PropellerCount that represents the column propeller_cnt.
        /// </value>
        public ColumnExpression PropellerCount 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property PropulsionType that represents the column propulsion_type_code.
        /// </summary>
        /// <value>
        /// The value of the property PropulsionType that represents the column propulsion_type_code.
        /// </value>
        public ColumnExpression PropulsionType 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property OperationalDisplacementQuantity that represents the column operat_displ_qty.
        /// </summary>
        /// <value>
        /// The value of the property OperationalDisplacementQuantity that represents the column operat_displ_qty.
        /// </value>
        public ColumnExpression OperationalDisplacementQuantity 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumSpeedRate that represents the column max_speed_rate.
        /// </summary>
        /// <value>
        /// The value of the property MaximumSpeedRate that represents the column max_speed_rate.
        /// </value>
        public ColumnExpression MaximumSpeedRate 
        { 
            get { return this.columns[11]; } 
        }
		
        /// <summary>
        /// Expression for the property AcousticMeritIndexQuantity that represents the column acoustic_merit_ix_qty.
        /// </summary>
        /// <value>
        /// The value of the property AcousticMeritIndexQuantity that represents the column acoustic_merit_ix_qty.
        /// </value>
        public ColumnExpression AcousticMeritIndexQuantity 
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
        /// Initializes a new instance of the <see cref="VesselTypeExpression"/> class.
        /// </summary>
        public VesselTypeExpression()
            : base("VesselType", typeof(IVesselType))
        {
        }

        #endregion
    }
}
