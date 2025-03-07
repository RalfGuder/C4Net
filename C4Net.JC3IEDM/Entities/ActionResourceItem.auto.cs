using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-RESOURCE-ITEM that represents the table ACT_RES_ITEM.
	///
	/// An OBJECT-ITEM (FACILITY, FEATURE, MATERIEL, ORGANISATION, or PERSON) to be used, excluded from use, being used, or having been used, in conducting a specific ACTION.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionResourceItem", "C4Net.JC3IEDM.Definitions.ActionResourceItem.definition.xml")]
    public class ActionResourceItem : ActionResource, IActionResourceItem
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ActionResourceItemExpression _ = new ActionResourceItemExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_res_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-RESOURCE for a specific ACTION and to distinguish it from all other ACTION-RESOURCEs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_res_ix
        /// </value>
		public decimal ActionResourceIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_id
        /// </value>
		public decimal ObjectItemId { get; set; }
		
        #endregion
    }
}
