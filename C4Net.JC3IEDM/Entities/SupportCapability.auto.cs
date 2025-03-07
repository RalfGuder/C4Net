using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity SUPPORT-CAPABILITY that represents the table SUPP_CAPAB.
	///
	/// A CAPABILITY, required for planning, of those FACILITYs, MATERIELs and ORGANISATIONs or FACILITY-TYPEs, EQUIPMENT-TYPEs and ORGANISATION-TYPEs that are deemed as having the ability to provide supplies or services.
    /// </summary>
    [Serializable]
    [DefinitionName("SupportCapability", "C4Net.JC3IEDM.Definitions.SupportCapability.definition.xml")]
    public class SupportCapability : Capability, ISupportCapability
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly SupportCapabilityExpression _ = new SupportCapabilityExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of SUPPORT-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public SupportCapabilityCategoryEnum SupportCapabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dscpt_code
		///
		/// The specific value that represents the SUPPORT-CAPABILITY that is being quantified.
        /// </summary>
        /// <value>
        /// Value of the column dscpt_code
        /// </value>
		public SupportCapabilityDescriptorEnum? Descriptor { get; set; }
		
        #endregion
    }
}
