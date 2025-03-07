using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionMaritimeEmployment that represents the table ACT_MRT_EMPLOY
	/// 
	/// The procedure that guides the use of an ACTION-RESOURCE in a maritime environment.
    /// </summary>
	[EntId(10000329)]
    [EntName("ACTION-MARITIME-EMPLOYMENT")]
    [EntTableName("ACT_MRT_EMPLOY")]
    [EntDepth(4)]
    public interface IActionMaritimeEmployment
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("action-id")]
		[AttrColumnName("act_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_res_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-RESOURCE for a specific ACTION and to distinguish it from all other ACTION-RESOURCEs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_res_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-resource-index")]
		[AttrColumnName("act_res_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionResourceIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_res_employ_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-RESOURCE-EMPLOYMENT for a specific ACTION-RESOURCE and to distinguish it from all other ACTION-RESOURCE-EMPLOYMENTs for that ACTION-RESOURCE.
        /// </summary>
        /// <value>
        /// Value of the column act_res_employ_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-resource-employment-index")]
		[AttrColumnName("act_res_employ_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionResourceEmploymentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column casp_code
		///
		/// The specific value that represents the coordinated air sea procedure (CASP) category for a friendly force, indicating the nature of the force relationship to the air commander.
        /// </summary>
        /// <value>
        /// Value of the column casp_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-maritime-employment-coordinated-air-sea-procedure-code")]
		[AttrColumnName("casp_code")]
        [AttrSeqnr(4)]
        [DomId(100004334)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionMaritimeEmploymentCoordinatedAirSeaProcedureEnum? CoordinatedAirSeaProcedure { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column no_runs_req_cnt
		///
		/// An integer value that represents the number of MCM runs required through a minefield to achieve the required clearance level.
        /// </summary>
        /// <value>
        /// Value of the column no_runs_req_cnt
        /// </value>
        [AttrIx(100005)]
		[AttrName("action-maritime-employment-number-runs-required-count")]
		[AttrColumnName("no_runs_req_cnt")]
        [AttrSeqnr(5)]
        [DomId(100001800)]
        [DataLength(3)]
        [DataDecimals(0)]
        short? NumberRunsRequiredCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column swept_lane_actu_width_dim
		///
		/// The one-dimensional linear measurement representing the swept lane width within which mines will be actuated.
        /// </summary>
        /// <value>
        /// Value of the column swept_lane_actu_width_dim
        /// </value>
        [AttrIx(100006)]
		[AttrName("action-maritime-employment-swept-lane-actuation-width-dimension")]
		[AttrColumnName("swept_lane_actu_width_dim")]
        [AttrSeqnr(6)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? SweptLaneActuationWidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vessel_trnst_instr_code
		///
		/// The specific value providing lead through instructions for a convoy or vessel to pass through a maritime minefield.
        /// </summary>
        /// <value>
        /// Value of the column vessel_trnst_instr_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("action-maritime-employment-vessel-transit-instruction-code")]
		[AttrColumnName("vessel_trnst_instr_code")]
        [AttrSeqnr(7)]
        [DomId(100004377)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionMaritimeEmploymentVesselTransitInstructionEnum? VesselTransitInstruction { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vessel_trnst_rcmdd_speed_rate
		///
		/// The numeric value that represents the maximum distance per unit time that is recommended for a vessel to traverse a specific maritime minefield. The speed is measured in knots. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column vessel_trnst_rcmdd_speed_rate
        /// </value>
        [AttrIx(100008)]
		[AttrName("action-maritime-employment-vessel-transit-recommended-speed-rate")]
		[AttrColumnName("vessel_trnst_rcmdd_speed_rate")]
        [AttrSeqnr(8)]
        [DomId(100001300)]
        [DataLength(8)]
        [DataDecimals(4)]
        double? VesselTransitRecommendedSpeedRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vessel_trnst_lngtd_spc_dim
		///
		/// The one dimensional linear measurement representing the distance between vessels in order to traverse a specific maritime minefield. The distance is measured in metres.
        /// </summary>
        /// <value>
        /// Value of the column vessel_trnst_lngtd_spc_dim
        /// </value>
        [AttrIx(100009)]
		[AttrName("action-maritime-employment-vessel-transit-longitudinal-spacing-dimension")]
		[AttrColumnName("vessel_trnst_lngtd_spc_dim")]
        [AttrSeqnr(9)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? VesselTransitLongitudinalSpacingDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column grp_vessel_trnst_lngtd_spc_dim
		///
		/// The one dimensional linear measurement representing the distance between groups of vessels in order to traverse a specific maritime minefield. The distance is measured in nautical miles.
        /// </summary>
        /// <value>
        /// Value of the column grp_vessel_trnst_lngtd_spc_dim
        /// </value>
        [AttrIx(100010)]
		[AttrName("action-maritime-employment-group-vessel-transit-longitudinal-spacing-dimension")]
		[AttrColumnName("grp_vessel_trnst_lngtd_spc_dim")]
        [AttrSeqnr(10)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? GroupVesselTransitLongitudinalSpacingDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lead_vessel_name_txt
		///
		/// An unformatted character string assigned to name a specific lead vessel in a convoy moving through a maritime minefield.
        /// </summary>
        /// <value>
        /// Value of the column lead_vessel_name_txt
        /// </value>
        [AttrIx(100011)]
		[AttrName("action-maritime-employment-lead-vessel-name-text")]
		[AttrColumnName("lead_vessel_name_txt")]
        [AttrSeqnr(11)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string LeadVesselNameText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100012)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(12)]
        [Mandatory]
        [DomId(100000913)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
        [AttrIx(100013)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(13)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
