using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-MARITIME-EMPLOYMENT that represents the table ACT_MRT_EMPLOY.
	///
	/// The procedure that guides the use of an ACTION-RESOURCE in a maritime environment.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionMaritimeEmployment", "C4Net.JC3IEDM.Definitions.ActionMaritimeEmployment.definition.xml")]
    public class ActionMaritimeEmployment : ActionResourceEmployment, IActionMaritimeEmployment
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ActionMaritimeEmploymentExpression _ = new ActionMaritimeEmploymentExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_res_employ_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-RESOURCE-EMPLOYMENT for a specific ACTION-RESOURCE and to distinguish it from all other ACTION-RESOURCE-EMPLOYMENTs for that ACTION-RESOURCE.
        /// </summary>
        /// <value>
        /// Value of the column act_res_employ_ix
        /// </value>
		public decimal ActionResourceEmploymentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column casp_code
		///
		/// The specific value that represents the coordinated air sea procedure (CASP) category for a friendly force, indicating the nature of the force relationship to the air commander.
        /// </summary>
        /// <value>
        /// Value of the column casp_code
        /// </value>
		public ActionMaritimeEmploymentCoordinatedAirSeaProcedureEnum? CoordinatedAirSeaProcedure { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column no_runs_req_cnt
		///
		/// An integer value that represents the number of MCM runs required through a minefield to achieve the required clearance level.
        /// </summary>
        /// <value>
        /// Value of the column no_runs_req_cnt
        /// </value>
		public short? NumberRunsRequiredCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column swept_lane_actu_width_dim
		///
		/// The one-dimensional linear measurement representing the swept lane width within which mines will be actuated.
        /// </summary>
        /// <value>
        /// Value of the column swept_lane_actu_width_dim
        /// </value>
		public double? SweptLaneActuationWidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vessel_trnst_instr_code
		///
		/// The specific value providing lead through instructions for a convoy or vessel to pass through a maritime minefield.
        /// </summary>
        /// <value>
        /// Value of the column vessel_trnst_instr_code
        /// </value>
		public ActionMaritimeEmploymentVesselTransitInstructionEnum? VesselTransitInstruction { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vessel_trnst_rcmdd_speed_rate
		///
		/// The numeric value that represents the maximum distance per unit time that is recommended for a vessel to traverse a specific maritime minefield. The speed is measured in knots. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column vessel_trnst_rcmdd_speed_rate
        /// </value>
		public double? VesselTransitRecommendedSpeedRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vessel_trnst_lngtd_spc_dim
		///
		/// The one dimensional linear measurement representing the distance between vessels in order to traverse a specific maritime minefield. The distance is measured in metres.
        /// </summary>
        /// <value>
        /// Value of the column vessel_trnst_lngtd_spc_dim
        /// </value>
		public double? VesselTransitLongitudinalSpacingDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column grp_vessel_trnst_lngtd_spc_dim
		///
		/// The one dimensional linear measurement representing the distance between groups of vessels in order to traverse a specific maritime minefield. The distance is measured in nautical miles.
        /// </summary>
        /// <value>
        /// Value of the column grp_vessel_trnst_lngtd_spc_dim
        /// </value>
		public double? GroupVesselTransitLongitudinalSpacingDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lead_vessel_name_txt
		///
		/// An unformatted character string assigned to name a specific lead vessel in a convoy moving through a maritime minefield.
        /// </summary>
        /// <value>
        /// Value of the column lead_vessel_name_txt
        /// </value>
		public string LeadVesselNameText { get; set; }
		
        #endregion
    }
}
