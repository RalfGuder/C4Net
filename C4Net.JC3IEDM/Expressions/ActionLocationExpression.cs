using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionLocation.
    /// </summary>
    public class ActionLocationExpression : BaseEntityExpression<ActionLocationExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property ActionId that represents the column act_id.
        /// </summary>
        /// <value>
        /// The value of the property ActionId that represents the column act_id.
        /// </value>
        public ColumnExpression ActionId 
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
        /// Expression for the property Index that represents the column act_loc_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column act_loc_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property AccuracyDimension that represents the column acc_dim.
        /// </summary>
        /// <value>
        /// The value of the property AccuracyDimension that represents the column acc_dim.
        /// </value>
        public ColumnExpression AccuracyDimension 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property BearingAngle that represents the column brng_angle.
        /// </summary>
        /// <value>
        /// The value of the property BearingAngle that represents the column brng_angle.
        /// </value>
        public ColumnExpression BearingAngle 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property ReportingDataId that represents the column rptd_id.
        /// </summary>
        /// <value>
        /// The value of the property ReportingDataId that represents the column rptd_id.
        /// </value>
        public ColumnExpression ReportingDataId 
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
        /// Initializes a new instance of the <see cref="ActionLocationExpression"/> class.
        /// </summary>
        public ActionLocationExpression()
            : base("ActionLocation", typeof(IActionLocation))
        {
        }

        #endregion
    }
}
