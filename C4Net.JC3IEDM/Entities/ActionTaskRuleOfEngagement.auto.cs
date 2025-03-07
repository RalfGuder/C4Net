using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-TASK-RULE-OF-ENGAGEMENT that represents the table ACT_TASK_ROE.
	///
	/// The imposition of a specific RULE-OF-ENGAGEMENT on a specific ACTION-TASK.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionTaskRuleOfEngagement", "C4Net.JC3IEDM.Definitions.ActionTaskRuleOfEngagement.definition.xml")]
    public class ActionTaskRuleOfEngagement : IEntity, IActionTaskRuleOfEngagement
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ActionTaskRuleOfEngagementExpression _ = new ActionTaskRuleOfEngagementExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_task_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_task_id
        /// </value>
		public decimal ActionTaskId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column roe_id
		///
		/// The unique value, or set of characters, assigned to represent a specific RULE-OF-ENGAGEMENT and to distinguish it from all other RULE-OF-ENGAGEMENTs.
        /// </summary>
        /// <value>
        /// Value of the column roe_id
        /// </value>
		public decimal RuleOfEngagementId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
		public decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
		public long UpdateSeqnr { get; set; }
		
        #endregion
    }
}
