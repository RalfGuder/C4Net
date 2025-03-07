using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-EVENT that represents the table ACT_EVENT.
	///
	/// An ACTION that is an incident, phenomenon, or occasion of military significance which has occurred or is occurring but for which planning is not known.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionEvent", "C4Net.JC3IEDM.Definitions.ActionEvent.definition.xml")]
    public class ActionEvent : Action, IActionEvent
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ActionEventExpression _ = new ActionEventExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the general class or nature of activity prescribed by an ACTION-EVENT. It serves as a discriminator that partitions ACTION-EVENT into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ActionEventCategoryEnum ActionEventCategory { get; set; }
		
        #endregion
    }
}
