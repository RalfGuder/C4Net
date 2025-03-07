using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionAircraftEmployment.
    /// </summary>
    public class ActionAircraftEmploymentExpression : BaseEntityExpression<ActionAircraftEmploymentExpression>
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
        /// Expression for the property ActionResourceEmploymentIndex that represents the column act_res_employ_ix.
        /// </summary>
        /// <value>
        /// The value of the property ActionResourceEmploymentIndex that represents the column act_res_employ_ix.
        /// </value>
        public ColumnExpression ActionResourceEmploymentIndex 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property ApproachOffset that represents the column appr_offset_code.
        /// </summary>
        /// <value>
        /// The value of the property ApproachOffset that represents the column appr_offset_code.
        /// </value>
        public ColumnExpression ApproachOffset 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property DeplanementMethod that represents the column deplane_method_code.
        /// </summary>
        /// <value>
        /// The value of the property DeplanementMethod that represents the column deplane_method_code.
        /// </value>
        public ColumnExpression DeplanementMethod 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property EgressDirectionAngle that represents the column egress_dir_angle.
        /// </summary>
        /// <value>
        /// The value of the property EgressDirectionAngle that represents the column egress_dir_angle.
        /// </value>
        public ColumnExpression EgressDirectionAngle 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property InflightReportRequirementIndicator that represents the column iflrp_reqmnt_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property InflightReportRequirementIndicator that represents the column iflrp_reqmnt_ind_code.
        /// </value>
        public ColumnExpression InflightReportRequirementIndicator 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property IngressDirectionAngle that represents the column ingress_dir_angle.
        /// </summary>
        /// <value>
        /// The value of the property IngressDirectionAngle that represents the column ingress_dir_angle.
        /// </value>
        public ColumnExpression IngressDirectionAngle 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property CrewComposition that represents the column crew_cmps_code.
        /// </summary>
        /// <value>
        /// The value of the property CrewComposition that represents the column crew_cmps_code.
        /// </value>
        public ColumnExpression CrewComposition 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property GeneralRole that represents the column gen_role_code.
        /// </summary>
        /// <value>
        /// The value of the property GeneralRole that represents the column gen_role_code.
        /// </value>
        public ColumnExpression GeneralRole 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[11]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionAircraftEmploymentExpression"/> class.
        /// </summary>
        public ActionAircraftEmploymentExpression()
            : base("ActionAircraftEmployment", typeof(IActionAircraftEmployment))
        {
        }

        #endregion
    }
}
