using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity HANDLING-CAPABILITY that represents the table HNDL_CAPAB.
	///
	/// A CAPABILITY, required for planning, of those FACILITYs and MATERIELs, or FACILITY-TYPEs and EQUIPMENT-TYPEs that are deemed as having the ability to move materiels (raw materials, scrap, semi-finished, and finished) to, through, and from productive processes; in warehouses and storage; and in receiving and shipping areas.
    /// </summary>
    [Serializable]
    [DefinitionName("HandlingCapability", "C4Net.JC3IEDM.Definitions.HandlingCapability.definition.xml")]
    public class HandlingCapability : Capability, IHandlingCapability
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly HandlingCapabilityExpression _ = new HandlingCapabilityExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cargo_cat_code
		///
		/// The specific value that represents the class of cargo subject to the HANDLING-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cargo_cat_code
        /// </value>
		public CargoCategoryEnum CargoCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dscpt_code
		///
		/// The specific value that represents the HANDLING-CAPABILITY that is being quantified.
        /// </summary>
        /// <value>
        /// Value of the column dscpt_code
        /// </value>
		public HandlingCapabilityDescriptorEnum? Descriptor { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_code
		///
		/// The specific value that represents the type of a specific HANDLING-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column act_code
        /// </value>
		public HandlingCapabilityActionEnum? Action { get; set; }
		
        #endregion
    }
}
