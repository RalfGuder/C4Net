using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionTask.
    /// </summary>
    public class ActionTaskExpression : BaseEntityExpression<ActionTaskExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column act_task_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column act_task_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Activity that represents the column actv_code.
        /// </summary>
        /// <value>
        /// The value of the property Activity that represents the column actv_code.
        /// </value>
        public ColumnExpression Activity 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property MinimumDuration that represents the column mnm_dur.
        /// </summary>
        /// <value>
        /// The value of the property MinimumDuration that represents the column mnm_dur.
        /// </value>
        public ColumnExpression MinimumDuration 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property EstimatedDuration that represents the column estimated_dur.
        /// </summary>
        /// <value>
        /// The value of the property EstimatedDuration that represents the column estimated_dur.
        /// </value>
        public ColumnExpression EstimatedDuration 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumDuration that represents the column max_dur.
        /// </summary>
        /// <value>
        /// The value of the property MaximumDuration that represents the column max_dur.
        /// </value>
        public ColumnExpression MaximumDuration 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property PlannedStartDatetime that represents the column plnd_start_dttm.
        /// </summary>
        /// <value>
        /// The value of the property PlannedStartDatetime that represents the column plnd_start_dttm.
        /// </value>
        public ColumnExpression PlannedStartDatetime 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property StartQualifier that represents the column start_qual_code.
        /// </summary>
        /// <value>
        /// The value of the property StartQualifier that represents the column start_qual_code.
        /// </value>
        public ColumnExpression StartQualifier 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property PlannedEndDatetime that represents the column plnd_end_dttm.
        /// </summary>
        /// <value>
        /// The value of the property PlannedEndDatetime that represents the column plnd_end_dttm.
        /// </value>
        public ColumnExpression PlannedEndDatetime 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property EndQualifier that represents the column end_qual_code.
        /// </summary>
        /// <value>
        /// The value of the property EndQualifier that represents the column end_qual_code.
        /// </value>
        public ColumnExpression EndQualifier 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property Priority that represents the column prio_code.
        /// </summary>
        /// <value>
        /// The value of the property Priority that represents the column prio_code.
        /// </value>
        public ColumnExpression Priority 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property EntailedSafetyDegree that represents the column entld_safety_degree_code.
        /// </summary>
        /// <value>
        /// The value of the property EntailedSafetyDegree that represents the column entld_safety_degree_code.
        /// </value>
        public ColumnExpression EntailedSafetyDegree 
        { 
            get { return this.columns[11]; } 
        }
		
        /// <summary>
        /// Expression for the property OvertCovert that represents the column overt_covert_code.
        /// </summary>
        /// <value>
        /// The value of the property OvertCovert that represents the column overt_covert_code.
        /// </value>
        public ColumnExpression OvertCovert 
        { 
            get { return this.columns[12]; } 
        }
		
        /// <summary>
        /// Expression for the property DetailText that represents the column det_txt.
        /// </summary>
        /// <value>
        /// The value of the property DetailText that represents the column det_txt.
        /// </value>
        public ColumnExpression DetailText 
        { 
            get { return this.columns[13]; } 
        }
		
        /// <summary>
        /// Expression for the property TimingDay that represents the column timing_day_code.
        /// </summary>
        /// <value>
        /// The value of the property TimingDay that represents the column timing_day_code.
        /// </value>
        public ColumnExpression TimingDay 
        { 
            get { return this.columns[14]; } 
        }
		
        /// <summary>
        /// Expression for the property TimingHour that represents the column timing_hour_code.
        /// </summary>
        /// <value>
        /// The value of the property TimingHour that represents the column timing_hour_code.
        /// </value>
        public ColumnExpression TimingHour 
        { 
            get { return this.columns[15]; } 
        }
		
        /// <summary>
        /// Expression for the property MeteorologicalImpact that represents the column meteorological_impact_code.
        /// </summary>
        /// <value>
        /// The value of the property MeteorologicalImpact that represents the column meteorological_impact_code.
        /// </value>
        public ColumnExpression MeteorologicalImpact 
        { 
            get { return this.columns[16]; } 
        }
		
        /// <summary>
        /// Expression for the property OperationalLevel that represents the column operat_lvl_code.
        /// </summary>
        /// <value>
        /// The value of the property OperationalLevel that represents the column operat_lvl_code.
        /// </value>
        public ColumnExpression OperationalLevel 
        { 
            get { return this.columns[17]; } 
        }
		
        /// <summary>
        /// Expression for the property CandidateTargetListId that represents the column ctgtlst_id.
        /// </summary>
        /// <value>
        /// The value of the property CandidateTargetListId that represents the column ctgtlst_id.
        /// </value>
        public ColumnExpression CandidateTargetListId 
        { 
            get { return this.columns[18]; } 
        }
		
        /// <summary>
        /// Expression for the property OrganisationStructureRootOrganisationId that represents the column org_struct_root_org_id.
        /// </summary>
        /// <value>
        /// The value of the property OrganisationStructureRootOrganisationId that represents the column org_struct_root_org_id.
        /// </value>
        public ColumnExpression OrganisationStructureRootOrganisationId 
        { 
            get { return this.columns[19]; } 
        }
		
        /// <summary>
        /// Expression for the property OrganisationStructureIndex that represents the column org_struct_ix.
        /// </summary>
        /// <value>
        /// The value of the property OrganisationStructureIndex that represents the column org_struct_ix.
        /// </value>
        public ColumnExpression OrganisationStructureIndex 
        { 
            get { return this.columns[20]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[21]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[22]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionTaskExpression"/> class.
        /// </summary>
        public ActionTaskExpression()
            : base("ActionTask", typeof(IActionTask))
        {
        }

        #endregion
    }
}
