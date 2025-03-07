using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity SURVEILLANCE-CAPABILITY that represents the table SURV_CAPAB.
	///
	/// A CAPABILITY, required for planning, of those FACILITYs, MATERIELs, ORGANISATIONs and PERSONs or FACILITY-TYPEs, EQUIPMENT-TYPEs, ORGANISATION-TYPEs and PERSON-TYPEs that are deemed as having the nominal ability to observe aerospace, surface or subsurface areas, places, persons, or things, by visual, aural, electronic, photographic or other means.
    /// </summary>
    [Serializable]
    [DefinitionName("SurveillanceCapability", "C4Net.JC3IEDM.Definitions.SurveillanceCapability.definition.xml")]
    public class SurveillanceCapability : Capability, ISurveillanceCapability
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly SurveillanceCapabilityExpression _ = new SurveillanceCapabilityExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of SURVEILLANCE-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public SurveillanceCapabilityCategoryEnum SurveillanceCapabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dscpt_code
		///
		/// The specific value that represents the SURVEILLANCE-CAPABILITY that is being quantified.
        /// </summary>
        /// <value>
        /// Value of the column dscpt_code
        /// </value>
		public SurveillanceCapabilityDescriptorEnum? Descriptor { get; set; }
		
        #endregion
    }
}
