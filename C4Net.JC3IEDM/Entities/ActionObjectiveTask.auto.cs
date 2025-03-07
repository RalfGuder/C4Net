using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-OBJECTIVE-TASK that represents the table ACT_OBJVE_TASK.
	///
	/// The objective of the specific ACTION is the operation identified as the specific ACTION-TASK.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionObjectiveTask", "C4Net.JC3IEDM.Definitions.ActionObjectiveTask.definition.xml")]
    public class ActionObjectiveTask : ActionObjective, IActionObjectiveTask
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ActionObjectiveTaskExpression _ = new ActionObjectiveTaskExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_objve_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-OBJECTIVE for a specific ACTION and to distinguish it from all other ACTION-OBJECTIVEs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_objve_ix
        /// </value>
		public decimal ActionObjectiveIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_objve_task_act_task_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_objve_task_act_task_id
        /// </value>
		public decimal ActionTaskId { get; set; }
		
        #endregion
    }
}
