using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionTask that represents the table ACT_TASK
	/// 
	/// An ACTION that is being or has been planned and for which the planning details are known.
    /// </summary>
	[EntId(10000152)]
    [EntName("ACTION-TASK")]
    [EntTableName("ACT_TASK")]
    [EntDepth(4)]
    public interface IActionTask
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_task_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_task_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("action-task-id")]
		[AttrColumnName("act_task_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ACTION-TASK. It serves as a discriminator that partitions ACTION-TASK into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-task-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000283)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionTaskCategoryEnum ActionTaskCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column actv_code
		///
		/// The specific value that represents the type of activity prescribed by the ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column actv_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-task-activity-code")]
		[AttrColumnName("actv_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000280)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionTaskActivityEnum Activity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mnm_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds for the minimum permissible period of effectiveness of a specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column mnm_dur
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-task-minimum-duration")]
		[AttrColumnName("mnm_dur")]
        [AttrSeqnr(4)]
        [DomId(100000700)]
        [DataLength(19)]
        [DataDecimals(0)]
        decimal? MinimumDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column estimated_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds for the estimated period of effectiveness of a specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column estimated_dur
        /// </value>
        [AttrIx(100005)]
		[AttrName("action-task-estimated-duration")]
		[AttrColumnName("estimated_dur")]
        [AttrSeqnr(5)]
        [DomId(100000700)]
        [DataLength(19)]
        [DataDecimals(0)]
        decimal? EstimatedDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds for the maximum permissible period of effectiveness of a specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column max_dur
        /// </value>
        [AttrIx(100006)]
		[AttrName("action-task-maximum-duration")]
		[AttrColumnName("max_dur")]
        [AttrSeqnr(6)]
        [DomId(100000700)]
        [DataLength(19)]
        [DataDecimals(0)]
        decimal? MaximumDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column plnd_start_dttm
		///
		/// The character string representing a point in time that designates the occurrence of the planned beginning of the specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column plnd_start_dttm
        /// </value>
        [AttrIx(100007)]
		[AttrName("action-task-planned-start-datetime")]
		[AttrColumnName("plnd_start_dttm")]
        [AttrSeqnr(7)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string PlannedStartDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column start_qual_code
		///
		/// The specific value that denotes the role of starting date and time with respect to the period of effectiveness of a specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column start_qual_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("action-task-start-qualifier-code")]
		[AttrColumnName("start_qual_code")]
        [AttrSeqnr(8)]
        [DomId(100004136)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionTaskStartQualifierEnum? StartQualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column plnd_end_dttm
		///
		/// The character string representing a point in time that designates the occurrence of the planned conclusion of the specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column plnd_end_dttm
        /// </value>
        [AttrIx(100009)]
		[AttrName("action-task-planned-end-datetime")]
		[AttrColumnName("plnd_end_dttm")]
        [AttrSeqnr(9)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string PlannedEndDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column end_qual_code
		///
		/// The specific value that denotes the role of ending date and time with respect to the period of effectiveness of a specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column end_qual_code
        /// </value>
        [AttrIx(100010)]
		[AttrName("action-task-end-qualifier-code")]
		[AttrColumnName("end_qual_code")]
        [AttrSeqnr(10)]
        [DomId(100004137)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionTaskEndQualifierEnum? EndQualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prio_code
		///
		/// The specific value that represents the rank of importance of a specific ACTION-TASK in view of the planning organisation.
        /// </summary>
        /// <value>
        /// Value of the column prio_code
        /// </value>
        [AttrIx(100011)]
		[AttrName("action-task-priority-code")]
		[AttrColumnName("prio_code")]
        [AttrSeqnr(11)]
        [DomId(100000286)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionTaskPriorityEnum? Priority { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column entld_safety_degree_code
		///
		/// The specific value that represents the degree of safety (or risk) entailed with an ordered operation.
        /// </summary>
        /// <value>
        /// Value of the column entld_safety_degree_code
        /// </value>
        [AttrIx(100012)]
		[AttrName("action-task-entailed-safety-degree-code")]
		[AttrColumnName("entld_safety_degree_code")]
        [AttrSeqnr(12)]
        [DomId(100004200)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionTaskEntailedSafetyDegreeEnum? EntailedSafetyDegree { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column overt_covert_code
		///
		/// The specific value that represents the property of an ACTION-TASK to be overt or covert.
        /// </summary>
        /// <value>
        /// Value of the column overt_covert_code
        /// </value>
        [AttrIx(100013)]
		[AttrName("action-task-overt-covert-code")]
		[AttrColumnName("overt_covert_code")]
        [AttrSeqnr(13)]
        [DomId(100004201)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionTaskOvertCovertEnum? OvertCovert { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column det_txt
		///
		/// The character string assigned to represent the description of an ACTION-TASK’s detail.
        /// </summary>
        /// <value>
        /// Value of the column det_txt
        /// </value>
        [AttrIx(100014)]
		[AttrName("action-task-detail-text")]
		[AttrColumnName("det_txt")]
        [AttrSeqnr(14)]
        [DomId(100001500)]
        [DataLength(255)]
        [DataDecimals(0)]
        string DetailText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column timing_day_code
		///
		/// The specific value that represents the notional start of the ACTION in terms of a day with defined operational meaning.
        /// </summary>
        /// <value>
        /// Value of the column timing_day_code
        /// </value>
        [AttrIx(100015)]
		[AttrName("action-task-timing-day-code")]
		[AttrColumnName("timing_day_code")]
        [AttrSeqnr(15)]
        [DomId(100004332)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionTaskTimingDayEnum? TimingDay { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column timing_hour_code
		///
		/// The specific value that represents the notional start of the ACTION in terms of an hour with defined operational meaning.
        /// </summary>
        /// <value>
        /// Value of the column timing_hour_code
        /// </value>
        [AttrIx(100016)]
		[AttrName("action-task-timing-hour-code")]
		[AttrColumnName("timing_hour_code")]
        [AttrSeqnr(16)]
        [DomId(100004333)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionTaskTimingHourEnum? TimingHour { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column meteorological_impact_code
		///
		/// The specific value that represents a subjective indication of the effect of weather conditions on a specific operation.
        /// </summary>
        /// <value>
        /// Value of the column meteorological_impact_code
        /// </value>
        [AttrIx(100017)]
		[AttrName("action-task-meteorological-impact-code")]
		[AttrColumnName("meteorological_impact_code")]
        [AttrSeqnr(17)]
        [DomId(100004343)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionTaskMeteorologicalImpactEnum? MeteorologicalImpact { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_lvl_code
		///
		/// The specific value that represents the operational level of the specific ACTION-TASK.
        /// </summary>
        /// <value>
        /// Value of the column operat_lvl_code
        /// </value>
        [AttrIx(100018)]
		[AttrName("action-task-operational-level-code")]
		[AttrColumnName("operat_lvl_code")]
        [AttrSeqnr(18)]
        [DomId(100004378)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionTaskOperationalLevelEnum? OperationalLevel { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ctgtlst_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-LISTs.
        /// </summary>
        /// <value>
        /// Value of the column ctgtlst_id
        /// </value>
        [AttrIx(100019)]
		[AttrName("candidate-target-list-id")]
		[AttrColumnName("ctgtlst_id")]
        [AttrSeqnr(19)]
        [ForeignKey]
        [DomId(100000910)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? CandidateTargetListId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_struct_root_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column org_struct_root_org_id
        /// </value>
        [AttrIx(100020)]
		[AttrName("organisation-structure-root-organisation-id")]
		[AttrColumnName("org_struct_root_org_id")]
        [AttrSeqnr(20)]
        [ForeignKey]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? OrganisationStructureRootOrganisationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_struct_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ORGANISATION-STRUCTURE for a specific ORGANISATION and to distinguish it from all other ORGANISATION-STRUCTUREs for that ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column org_struct_ix
        /// </value>
        [AttrIx(100021)]
		[AttrName("organisation-structure-index")]
		[AttrColumnName("org_struct_ix")]
        [AttrSeqnr(21)]
        [ForeignKey]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? OrganisationStructureIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100022)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(22)]
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
        [AttrIx(100023)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(23)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
