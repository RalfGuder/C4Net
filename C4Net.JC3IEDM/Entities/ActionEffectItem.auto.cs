using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-EFFECT-ITEM that represents the table ACT_EFFECT_ITEM.
	///
	/// An ACTION-EFFECT of a specific ACTION in accomplishing its aim in relation to a specific OBJECT-ITEM.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionEffectItem", "C4Net.JC3IEDM.Definitions.ActionEffectItem.definition.xml")]
    public class ActionEffectItem : ActionEffect, IActionEffectItem
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ActionEffectItemExpression _ = new ActionEffectItemExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_effect_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-EFFECT for a specific ACTION and to distinguish it from all other ACTION-EFFECTs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_effect_ix
        /// </value>
		public decimal ActionEffectIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rat
		///
		/// The numeric quotient value that represents the portion of a whole OBJECT-ITEM that is estimated in a specific ACTION-EFFECT-ITEM to have the result specified in ACTION-EFFECT. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column rat
        /// </value>
		public double Ratio { get; set; }
		
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
