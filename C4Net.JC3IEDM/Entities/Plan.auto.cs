using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity PLAN that represents the table PLN.
	///
	/// A proposal for putting into effect a command decision or project; it represents the preparation for future or anticipated operations.
    /// </summary>
    [Serializable]
    [DefinitionName("Plan", "C4Net.JC3IEDM.Definitions.Plan.definition.xml")]
    public class Plan : PlanOrder, IPlan
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly PlanExpression _ = new PlanExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type of PLAN.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public PlanCategoryEnum PlanCategory { get; set; }
		
        #endregion
    }
}
