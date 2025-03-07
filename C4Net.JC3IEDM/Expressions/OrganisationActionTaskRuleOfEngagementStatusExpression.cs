using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity OrganisationActionTaskRuleOfEngagementStatus.
    /// </summary>
    public class OrganisationActionTaskRuleOfEngagementStatusExpression : BaseEntityExpression<OrganisationActionTaskRuleOfEngagementStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property ActionTaskId that represents the column act_task_id.
        /// </summary>
        /// <value>
        /// The value of the property ActionTaskId that represents the column act_task_id.
        /// </value>
        public ColumnExpression ActionTaskId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property RuleOfEngagementId that represents the column roe_id.
        /// </summary>
        /// <value>
        /// The value of the property RuleOfEngagementId that represents the column roe_id.
        /// </value>
        public ColumnExpression RuleOfEngagementId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property OrganisationId that represents the column org_act_task_roe_stat_org_id.
        /// </summary>
        /// <value>
        /// The value of the property OrganisationId that represents the column org_act_task_roe_stat_org_id.
        /// </value>
        public ColumnExpression OrganisationId 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column org_act_task_roe_stat_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column org_act_task_roe_stat_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property EffectiveStartDatetime that represents the column effctv_start_dttm.
        /// </summary>
        /// <value>
        /// The value of the property EffectiveStartDatetime that represents the column effctv_start_dttm.
        /// </value>
        public ColumnExpression EffectiveStartDatetime 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property EffectiveEndDatetime that represents the column effctv_end_dttm.
        /// </summary>
        /// <value>
        /// The value of the property EffectiveEndDatetime that represents the column effctv_end_dttm.
        /// </value>
        public ColumnExpression EffectiveEndDatetime 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[8]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganisationActionTaskRuleOfEngagementStatusExpression"/> class.
        /// </summary>
        public OrganisationActionTaskRuleOfEngagementStatusExpression()
            : base("OrganisationActionTaskRuleOfEngagementStatus", typeof(IOrganisationActionTaskRuleOfEngagementStatus))
        {
        }

        #endregion
    }
}
