using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-RESOURCE-TYPE that represents the table ACT_RES_TYPE.
	///
	/// An OBJECT-TYPE (FACILITY-TYPE, FEATURE-TYPE, MATERIEL-TYPE, ORGANISATION-TYPE, or PERSON-TYPE) to be used, excluded from use, being used, or having been used, in conducting a specific ACTION.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionResourceType", "C4Net.JC3IEDM.Definitions.ActionResourceType.definition.xml")]
    public class ActionResourceType : ActionResource, IActionResourceType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ActionResourceTypeExpression _ = new ActionResourceTypeExpression();

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
        /// Gets or sets the value of the column qty
		///
		/// The numeric value that represents the aggregated units of a specific ACTION-RESOURCE-TYPE. No unit of measure is required.
        /// </summary>
        /// <value>
        /// Value of the column qty
        /// </value>
		public int? Quantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column aprtnmt_rat
		///
		/// The numeric quotient value that represents a proportion of a specific ACTION-RESOURCE-TYPE devoted to an ACTION. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column aprtnmt_rat
        /// </value>
		public double? ApportionmentRatio { get; set; }
		
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
