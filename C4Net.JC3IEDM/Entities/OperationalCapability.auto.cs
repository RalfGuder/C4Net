using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OPERATIONAL-CAPABILITY that represents the table OPERAT_CAPAB.
	///
	/// A CAPABILITY, required for planning, of those objects and types of objects that are deemed as having the ability, the training and the equipment to perform an operation.
    /// </summary>
    [Serializable]
    [DefinitionName("OperationalCapability", "C4Net.JC3IEDM.Definitions.OperationalCapability.definition.xml")]
    public class OperationalCapability : Capability, IOperationalCapability
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly OperationalCapabilityExpression _ = new OperationalCapabilityExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that identifies a particular OPERATIONAL-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public OperationalCapabilityCategoryEnum OperationalCapabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lvl_code
		///
		/// The specific value that represents the force level at which the specific OPERATIONAL-CAPABILITY is intended to be performed.
        /// </summary>
        /// <value>
        /// Value of the column lvl_code
        /// </value>
		public OperationalCapabilityLevelEnum? Level { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qual_code
		///
		/// The specific value that represents the degree to which the specific OPERATIONAL-CAPABILITY can be fulfilled.
        /// </summary>
        /// <value>
        /// Value of the column qual_code
        /// </value>
		public OperationalCapabilityQualifierEnum? Qualifier { get; set; }
		
        #endregion
    }
}
