using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionResourceEmployment.
    /// </summary>
    public class ActionResourceEmploymentExpression : BaseEntityExpression<ActionResourceEmploymentExpression>
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
        /// Expression for the property ActionResourceIndex that represents the column act_res_ix.
        /// </summary>
        /// <value>
        /// The value of the property ActionResourceIndex that represents the column act_res_ix.
        /// </value>
        public ColumnExpression ActionResourceIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column act_res_employ_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column act_res_employ_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property AzimuthFireAngle that represents the column azimuth_fire_angle.
        /// </summary>
        /// <value>
        /// The value of the property AzimuthFireAngle that represents the column azimuth_fire_angle.
        /// </value>
        public ColumnExpression AzimuthFireAngle 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property MethodOfControl that represents the column method_of_ctrl_code.
        /// </summary>
        /// <value>
        /// The value of the property MethodOfControl that represents the column method_of_ctrl_code.
        /// </value>
        public ColumnExpression MethodOfControl 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property TrajectoryFire that represents the column trajectory_fire_code.
        /// </summary>
        /// <value>
        /// The value of the property TrajectoryFire that represents the column trajectory_fire_code.
        /// </value>
        public ColumnExpression TrajectoryFire 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property ActionObjectiveIndex that represents the column act_objve_ix.
        /// </summary>
        /// <value>
        /// The value of the property ActionObjectiveIndex that represents the column act_objve_ix.
        /// </value>
        public ColumnExpression ActionObjectiveIndex 
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
        /// Initializes a new instance of the <see cref="ActionResourceEmploymentExpression"/> class.
        /// </summary>
        public ActionResourceEmploymentExpression()
            : base("ActionResourceEmployment", typeof(IActionResourceEmployment))
        {
        }

        #endregion
    }
}
