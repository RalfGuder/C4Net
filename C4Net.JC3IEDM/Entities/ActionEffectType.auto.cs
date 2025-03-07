using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-EFFECT-TYPE that represents the table ACT_EFFECT_TYPE.
	///
	/// An ACTION-EFFECT of a specific ACTION in accomplishing its aim in relation to a specific OBJECT-TYPE.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionEffectType", "C4Net.JC3IEDM.Definitions.ActionEffectType.definition.xml")]
    public class ActionEffectType : ActionEffect, IActionEffectType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ActionEffectTypeExpression _ = new ActionEffectTypeExpression();

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
        /// Gets or sets the value of the column cnt
		///
		/// The integer value representing the aggregated units of an OBJECT-TYPE that is estimated in a specific ACTION-EFFECT-TYPE to have the result specified in a particular ACTION-EFFECT.
        /// </summary>
        /// <value>
        /// Value of the column cnt
        /// </value>
		public int Count { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column obj_type_id
        /// </value>
		public decimal ObjectTypeId { get; set; }
		
        #endregion
    }
}
