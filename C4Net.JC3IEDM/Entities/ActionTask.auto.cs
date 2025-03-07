using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-TASK that represents the table ACT_TASK.
	///
	/// An ACTION that is being or has been planned and for which the planning details are known.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionTask", "C4Net.JC3IEDM.Definitions.ActionTask.definition.xml")]
    public class ActionTask : Action, IActionTask
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ActionTaskExpression _ = new ActionTaskExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ACTION-TASK. It serves as a discriminator that partitions ACTION-TASK into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ActionTaskCategoryEnum ActionTaskCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column actv_code
		///
		/// The specific value that represents the type of activity prescribed by the ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column actv_code
        /// </value>
		public ActionTaskActivityEnum Activity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mnm_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds for the minimum permissible period of effectiveness of a specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column mnm_dur
        /// </value>
		public decimal? MinimumDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column estimated_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds for the estimated period of effectiveness of a specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column estimated_dur
        /// </value>
		public decimal? EstimatedDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds for the maximum permissible period of effectiveness of a specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column max_dur
        /// </value>
		public decimal? MaximumDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column plnd_start_dttm
		///
		/// The character string representing a point in time that designates the occurrence of the planned beginning of the specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column plnd_start_dttm
        /// </value>
		public string PlannedStartDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column start_qual_code
		///
		/// The specific value that denotes the role of starting date and time with respect to the period of effectiveness of a specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column start_qual_code
        /// </value>
		public ActionTaskStartQualifierEnum? StartQualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column plnd_end_dttm
		///
		/// The character string representing a point in time that designates the occurrence of the planned conclusion of the specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column plnd_end_dttm
        /// </value>
		public string PlannedEndDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column end_qual_code
		///
		/// The specific value that denotes the role of ending date and time with respect to the period of effectiveness of a specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column end_qual_code
        /// </value>
		public ActionTaskEndQualifierEnum? EndQualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prio_code
		///
		/// The specific value that represents the rank of importance of a specific ACTION-TASK in view of the planning organisation.
        /// </summary>
        /// <value>
        /// Value of the column prio_code
        /// </value>
		public ActionTaskPriorityEnum? Priority { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column entld_safety_degree_code
		///
		/// The specific value that represents the degree of safety (or risk) entailed with an ordered operation.
        /// </summary>
        /// <value>
        /// Value of the column entld_safety_degree_code
        /// </value>
		public ActionTaskEntailedSafetyDegreeEnum? EntailedSafetyDegree { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column overt_covert_code
		///
		/// The specific value that represents the property of an ACTION-TASK to be overt or covert.
        /// </summary>
        /// <value>
        /// Value of the column overt_covert_code
        /// </value>
		public ActionTaskOvertCovertEnum? OvertCovert { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column det_txt
		///
		/// The character string assigned to represent the description of an ACTION-TASK’s detail.
        /// </summary>
        /// <value>
        /// Value of the column det_txt
        /// </value>
		public string DetailText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column timing_day_code
		///
		/// The specific value that represents the notional start of the ACTION in terms of a day with defined operational meaning.
        /// </summary>
        /// <value>
        /// Value of the column timing_day_code
        /// </value>
		public ActionTaskTimingDayEnum? TimingDay { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column timing_hour_code
		///
		/// The specific value that represents the notional start of the ACTION in terms of an hour with defined operational meaning.
        /// </summary>
        /// <value>
        /// Value of the column timing_hour_code
        /// </value>
		public ActionTaskTimingHourEnum? TimingHour { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column meteorological_impact_code
		///
		/// The specific value that represents a subjective indication of the effect of weather conditions on a specific operation.
        /// </summary>
        /// <value>
        /// Value of the column meteorological_impact_code
        /// </value>
		public ActionTaskMeteorologicalImpactEnum? MeteorologicalImpact { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_lvl_code
		///
		/// The specific value that represents the operational level of the specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column operat_lvl_code
        /// </value>
		public ActionTaskOperationalLevelEnum? OperationalLevel { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ctgtlst_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-LISTs.
        /// </summary>
        /// <value>
        /// Value of the column ctgtlst_id
        /// </value>
		public decimal? CandidateTargetListId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_struct_root_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column org_struct_root_org_id
        /// </value>
		public decimal? OrganisationStructureRootOrganisationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_struct_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ORGANISATION-STRUCTURE for a specific ORGANISATION and to distinguish it from all other ORGANISATION-STRUCTUREs for that ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column org_struct_ix
        /// </value>
		public decimal? OrganisationStructureIndex { get; set; }
		
        #endregion
    }
}
