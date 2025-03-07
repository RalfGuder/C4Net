using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionMaritimeEmployment.
    /// </summary>
    public class ActionMaritimeEmploymentExpression : BaseEntityExpression<ActionMaritimeEmploymentExpression>
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
        /// Expression for the property CoordinatedAirSeaProcedure that represents the column casp_code.
        /// </summary>
        /// <value>
        /// The value of the property CoordinatedAirSeaProcedure that represents the column casp_code.
        /// </value>
        public ColumnExpression CoordinatedAirSeaProcedure 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property NumberRunsRequiredCount that represents the column no_runs_req_cnt.
        /// </summary>
        /// <value>
        /// The value of the property NumberRunsRequiredCount that represents the column no_runs_req_cnt.
        /// </value>
        public ColumnExpression NumberRunsRequiredCount 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property SweptLaneActuationWidthDimension that represents the column swept_lane_actu_width_dim.
        /// </summary>
        /// <value>
        /// The value of the property SweptLaneActuationWidthDimension that represents the column swept_lane_actu_width_dim.
        /// </value>
        public ColumnExpression SweptLaneActuationWidthDimension 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property VesselTransitInstruction that represents the column vessel_trnst_instr_code.
        /// </summary>
        /// <value>
        /// The value of the property VesselTransitInstruction that represents the column vessel_trnst_instr_code.
        /// </value>
        public ColumnExpression VesselTransitInstruction 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property VesselTransitRecommendedSpeedRate that represents the column vessel_trnst_rcmdd_speed_rate.
        /// </summary>
        /// <value>
        /// The value of the property VesselTransitRecommendedSpeedRate that represents the column vessel_trnst_rcmdd_speed_rate.
        /// </value>
        public ColumnExpression VesselTransitRecommendedSpeedRate 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property VesselTransitLongitudinalSpacingDimension that represents the column vessel_trnst_lngtd_spc_dim.
        /// </summary>
        /// <value>
        /// The value of the property VesselTransitLongitudinalSpacingDimension that represents the column vessel_trnst_lngtd_spc_dim.
        /// </value>
        public ColumnExpression VesselTransitLongitudinalSpacingDimension 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property GroupVesselTransitLongitudinalSpacingDimension that represents the column grp_vessel_trnst_lngtd_spc_dim.
        /// </summary>
        /// <value>
        /// The value of the property GroupVesselTransitLongitudinalSpacingDimension that represents the column grp_vessel_trnst_lngtd_spc_dim.
        /// </value>
        public ColumnExpression GroupVesselTransitLongitudinalSpacingDimension 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property LeadVesselNameText that represents the column lead_vessel_name_txt.
        /// </summary>
        /// <value>
        /// The value of the property LeadVesselNameText that represents the column lead_vessel_name_txt.
        /// </value>
        public ColumnExpression LeadVesselNameText 
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
        /// Initializes a new instance of the <see cref="ActionMaritimeEmploymentExpression"/> class.
        /// </summary>
        public ActionMaritimeEmploymentExpression()
            : base("ActionMaritimeEmployment", typeof(IActionMaritimeEmployment))
        {
        }

        #endregion
    }
}
