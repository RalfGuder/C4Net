using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity TASK-FORMATION-TYPE that represents the table TASK_FRMTN_TYPE.
	///
	/// A MILITARY-ORGANISATION-TYPE that is constituted on a temporary or semi-permanent basis for the purpose of carrying out a specific operation, mission or task.
    /// </summary>
    [Serializable]
    [DefinitionName("TaskFormationType", "C4Net.JC3IEDM.Definitions.TaskFormationType.definition.xml")]
    public class TaskFormationType : MilitaryOrganisationType, ITaskFormationType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly TaskFormationTypeExpression _ = new TaskFormationTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of TASK-FORMATION-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public TaskFormationTypeCategoryEnum TaskFormationTypeCategory { get; set; }
		
        #endregion
    }
}
