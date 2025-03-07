using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionAircraftEmployment that represents the table ACT_ACFT_EMPLOY
	/// 
	/// The procedure that guides the use of an ACTION-RESOURCE that is capable of atmospheric flight.
    /// </summary>
	[EntId(10000004)]
    [EntName("ACTION-AIRCRAFT-EMPLOYMENT")]
    [EntTableName("ACT_ACFT_EMPLOY")]
    [EntDepth(4)]
    public interface IActionAircraftEmployment
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
        /// Gets or sets the value of the column appr_offset_code
		///
		/// The specific value that represents the side of the initial point-to-target line that the attack aircraft is cleared to manoeuvre in during the target run.
        /// </summary>
        /// <value>
        /// Value of the column appr_offset_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-aircraft-employment-approach-offset-code")]
		[AttrColumnName("appr_offset_code")]
        [AttrSeqnr(4)]
        [DomId(100000221)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionAircraftEmploymentApproachOffsetEnum? ApproachOffset { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column deplane_method_code
		///
		/// The specific value that represents the standard method of deplanement of a specific ACTION-RESOURCE in support of a specific ACTION.
        /// </summary>
        /// <value>
        /// Value of the column deplane_method_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("action-aircraft-employment-deplanement-method-code")]
		[AttrColumnName("deplane_method_code")]
        [AttrSeqnr(5)]
        [DomId(100000307)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionAircraftEmploymentDeplanementMethodEnum? DeplanementMethod { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column egress_dir_angle
		///
		/// The rotational measurement clockwise from the line of true north to the direction to be used by an aircraft when departing an ACTION-OBJECTIVE.
        /// </summary>
        /// <value>
        /// Value of the column egress_dir_angle
        /// </value>
        [AttrIx(100006)]
		[AttrName("action-aircraft-employment-egress-direction-angle")]
		[AttrColumnName("egress_dir_angle")]
        [AttrSeqnr(6)]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double? EgressDirectionAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column iflrp_reqmnt_ind_code
		///
		/// The specific value that represents whether there is a requirement for the flight leader to provide a report of mission accomplishments.
        /// </summary>
        /// <value>
        /// Value of the column iflrp_reqmnt_ind_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("action-aircraft-employment-inflight-report-requirement-indicator-code")]
		[AttrColumnName("iflrp_reqmnt_ind_code")]
        [AttrSeqnr(7)]
        [DomId(100000223)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionAircraftEmploymentInflightReportRequirementIndicatorEnum? InflightReportRequirementIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ingress_dir_angle
		///
		/// The rotational measurement clockwise from the line of true North to the direction to be used by an aircraft when approaching an ACTION-OBJECTIVE. Includes the concept of terminal attack direction.
        /// </summary>
        /// <value>
        /// Value of the column ingress_dir_angle
        /// </value>
        [AttrIx(100008)]
		[AttrName("action-aircraft-employment-ingress-direction-angle")]
		[AttrColumnName("ingress_dir_angle")]
        [AttrSeqnr(8)]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double? IngressDirectionAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column crew_cmps_code
		///
		/// The specific value that represents the composition of the crew.
        /// </summary>
        /// <value>
        /// Value of the column crew_cmps_code
        /// </value>
        [AttrIx(100009)]
		[AttrName("action-aircraft-employment-crew-composition-code")]
		[AttrColumnName("crew_cmps_code")]
        [AttrSeqnr(9)]
        [DomId(100004315)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionAircraftEmploymentCrewCompositionEnum? CrewComposition { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column gen_role_code
		///
		/// The specific value that represents the general operational role of an aircraft.
        /// </summary>
        /// <value>
        /// Value of the column gen_role_code
        /// </value>
        [AttrIx(100010)]
		[AttrName("action-aircraft-employment-general-role-code")]
		[AttrColumnName("gen_role_code")]
        [AttrSeqnr(10)]
        [DomId(100004374)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionAircraftEmploymentGeneralRoleEnum? GeneralRole { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100011)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(11)]
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
        [AttrIx(100012)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(12)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
