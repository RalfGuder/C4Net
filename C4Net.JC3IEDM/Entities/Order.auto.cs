using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ORDER that represents the table ORDR.
	///
	/// A communication that conveys instructions from a superior to a subordinate.
    /// </summary>
    [Serializable]
    [DefinitionName("Order", "C4Net.JC3IEDM.Definitions.Order.definition.xml")]
    public class Order : PlanOrder, IOrder
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly OrderExpression _ = new OrderExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type of ORDER.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public OrderCategoryEnum OrderCategory { get; set; }
		
        #endregion
    }
}
