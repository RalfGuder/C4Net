using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-AIRCRAFT-EMPLOYMENT that represents the table ACT_ACFT_EMPLOY.
	///
	/// The procedure that guides the use of an ACTION-RESOURCE that is capable of atmospheric flight.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionAircraftEmployment", "C4Net.JC3IEDM.Definitions.ActionAircraftEmployment.definition.xml")]
    public class ActionAircraftEmployment : ActionResourceEmployment, IActionAircraftEmployment
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ActionAircraftEmploymentExpression _ = new ActionAircraftEmploymentExpression();

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
        /// Gets or sets the value of the column appr_offset_code
		///
		/// The specific value that represents the side of the initial point-to-target line that the attack aircraft is cleared to manoeuvre in during the target run.
        /// </summary>
        /// <value>
        /// Value of the column appr_offset_code
        /// </value>
		public ActionAircraftEmploymentApproachOffsetEnum? ApproachOffset { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column deplane_method_code
		///
		/// The specific value that represents the standard method of deplanement of a specific ACTION-RESOURCE in support of a specific ACTION.
        /// </summary>
        /// <value>
        /// Value of the column deplane_method_code
        /// </value>
		public ActionAircraftEmploymentDeplanementMethodEnum? DeplanementMethod { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column egress_dir_angle
		///
		/// The rotational measurement clockwise from the line of true north to the direction to be used by an aircraft when departing an ACTION-OBJECTIVE.
        /// </summary>
        /// <value>
        /// Value of the column egress_dir_angle
        /// </value>
		public double? EgressDirectionAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column iflrp_reqmnt_ind_code
		///
		/// The specific value that represents whether there is a requirement for the flight leader to provide a report of mission accomplishments.
        /// </summary>
        /// <value>
        /// Value of the column iflrp_reqmnt_ind_code
        /// </value>
		public ActionAircraftEmploymentInflightReportRequirementIndicatorEnum? InflightReportRequirementIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ingress_dir_angle
		///
		/// The rotational measurement clockwise from the line of true North to the direction to be used by an aircraft when approaching an ACTION-OBJECTIVE. Includes the concept of terminal attack direction.
        /// </summary>
        /// <value>
        /// Value of the column ingress_dir_angle
        /// </value>
		public double? IngressDirectionAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column crew_cmps_code
		///
		/// The specific value that represents the composition of the crew.
        /// </summary>
        /// <value>
        /// Value of the column crew_cmps_code
        /// </value>
		public ActionAircraftEmploymentCrewCompositionEnum? CrewComposition { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column gen_role_code
		///
		/// The specific value that represents the general operational role of an aircraft.
        /// </summary>
        /// <value>
        /// Value of the column gen_role_code
        /// </value>
		public ActionAircraftEmploymentGeneralRoleEnum? GeneralRole { get; set; }
		
        #endregion
    }
}
