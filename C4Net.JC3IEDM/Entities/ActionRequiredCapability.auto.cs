using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-REQUIRED-CAPABILITY that represents the table ACT_REQ_CAPAB.
	///
	/// The specific military quality, specified as a CAPABILITY, required to meet an agreed operational need, specified as an ACTION.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionRequiredCapability", "C4Net.JC3IEDM.Definitions.ActionRequiredCapability.definition.xml")]
    public class ActionRequiredCapability : IEntity, IActionRequiredCapability
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ActionRequiredCapabilityExpression _ = new ActionRequiredCapabilityExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_id
        /// </value>
		public decimal ActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column capab_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CAPABILITY and to distinguish it from all other CAPABILITYs.
        /// </summary>
        /// <value>
        /// Value of the column capab_id
        /// </value>
		public decimal CapabilityId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qty
		///
		/// The numeric value that represents the aggregated units of a specific CAPABILITY that is needed for a specific ACTION. The unit of measure is defined in the CAPABILITY specification.
        /// </summary>
        /// <value>
        /// Value of the column qty
        /// </value>
		public double? Quantity { get; set; }
		
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
