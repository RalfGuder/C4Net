using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ObjectItemLocation.
    /// </summary>
    public class ObjectItemLocationExpression : BaseEntityExpression<ObjectItemLocationExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property ObjectItemId that represents the column obj_item_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemId that represents the column obj_item_id.
        /// </value>
        public ColumnExpression ObjectItemId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property LocationId that represents the column loc_id.
        /// </summary>
        /// <value>
        /// The value of the property LocationId that represents the column loc_id.
        /// </value>
        public ColumnExpression LocationId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column obj_item_loc_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column obj_item_loc_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property VerticalAccuracyDimension that represents the column ver_acc_dim.
        /// </summary>
        /// <value>
        /// The value of the property VerticalAccuracyDimension that represents the column ver_acc_dim.
        /// </value>
        public ColumnExpression VerticalAccuracyDimension 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property HorizontalAccuracyDimension that represents the column horz_acc_dim.
        /// </summary>
        /// <value>
        /// The value of the property HorizontalAccuracyDimension that represents the column horz_acc_dim.
        /// </value>
        public ColumnExpression HorizontalAccuracyDimension 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property BearingAngle that represents the column brng_angle.
        /// </summary>
        /// <value>
        /// The value of the property BearingAngle that represents the column brng_angle.
        /// </value>
        public ColumnExpression BearingAngle 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property BearingAccuracyAngle that represents the column brng_acc_angle.
        /// </summary>
        /// <value>
        /// The value of the property BearingAccuracyAngle that represents the column brng_acc_angle.
        /// </value>
        public ColumnExpression BearingAccuracyAngle 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property BearingPrecision that represents the column brng_precision_code.
        /// </summary>
        /// <value>
        /// The value of the property BearingPrecision that represents the column brng_precision_code.
        /// </value>
        public ColumnExpression BearingPrecision 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property InclinationAngle that represents the column incl_angle.
        /// </summary>
        /// <value>
        /// The value of the property InclinationAngle that represents the column incl_angle.
        /// </value>
        public ColumnExpression InclinationAngle 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property InclinationAccuracyAngle that represents the column incl_acc_angle.
        /// </summary>
        /// <value>
        /// The value of the property InclinationAccuracyAngle that represents the column incl_acc_angle.
        /// </value>
        public ColumnExpression InclinationAccuracyAngle 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property InclinationPrecision that represents the column incl_precision_code.
        /// </summary>
        /// <value>
        /// The value of the property InclinationPrecision that represents the column incl_precision_code.
        /// </value>
        public ColumnExpression InclinationPrecision 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property SpeedRate that represents the column speed_rate.
        /// </summary>
        /// <value>
        /// The value of the property SpeedRate that represents the column speed_rate.
        /// </value>
        public ColumnExpression SpeedRate 
        { 
            get { return this.columns[11]; } 
        }
		
        /// <summary>
        /// Expression for the property SpeedAccuracyRate that represents the column speed_acc_rate.
        /// </summary>
        /// <value>
        /// The value of the property SpeedAccuracyRate that represents the column speed_acc_rate.
        /// </value>
        public ColumnExpression SpeedAccuracyRate 
        { 
            get { return this.columns[12]; } 
        }
		
        /// <summary>
        /// Expression for the property SpeedPrecision that represents the column speed_precision_code.
        /// </summary>
        /// <value>
        /// The value of the property SpeedPrecision that represents the column speed_precision_code.
        /// </value>
        public ColumnExpression SpeedPrecision 
        { 
            get { return this.columns[13]; } 
        }
		
        /// <summary>
        /// Expression for the property Meaning that represents the column meaning_code.
        /// </summary>
        /// <value>
        /// The value of the property Meaning that represents the column meaning_code.
        /// </value>
        public ColumnExpression Meaning 
        { 
            get { return this.columns[14]; } 
        }
		
        /// <summary>
        /// Expression for the property RelativeSpeed that represents the column rel_speed_code.
        /// </summary>
        /// <value>
        /// The value of the property RelativeSpeed that represents the column rel_speed_code.
        /// </value>
        public ColumnExpression RelativeSpeed 
        { 
            get { return this.columns[15]; } 
        }
		
        /// <summary>
        /// Expression for the property ReportingDataId that represents the column rptd_id.
        /// </summary>
        /// <value>
        /// The value of the property ReportingDataId that represents the column rptd_id.
        /// </value>
        public ColumnExpression ReportingDataId 
        { 
            get { return this.columns[16]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[17]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[18]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectItemLocationExpression"/> class.
        /// </summary>
        public ObjectItemLocationExpression()
            : base("ObjectItemLocation", typeof(IObjectItemLocation))
        {
        }

        #endregion
    }
}
