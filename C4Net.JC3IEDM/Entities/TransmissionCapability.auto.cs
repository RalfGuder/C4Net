using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity TRANSMISSION-CAPABILITY that represents the table TRNSM_CAPAB.
	///
	/// A CAPABILITY, required for planning, of those MATERIELs or MATERIEL-TYPEs that are deemed as having the ability to generate, receive or affect signals in the electromagnetic spectrum.
    /// </summary>
    [Serializable]
    [DefinitionName("TransmissionCapability", "C4Net.JC3IEDM.Definitions.TransmissionCapability.definition.xml")]
    public class TransmissionCapability : Capability, ITransmissionCapability
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly TransmissionCapabilityExpression _ = new TransmissionCapabilityExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of TRANSMISSION-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public TransmissionCapabilityCategoryEnum TransmissionCapabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dscpt_code
		///
		/// The specific value that represents the TRANSMISSION-CAPABILITY that is being quantified.
        /// </summary>
        /// <value>
        /// Value of the column dscpt_code
        /// </value>
		public TransmissionCapabilityDescriptorEnum? Descriptor { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column elctrnc_eqpt_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column elctrnc_eqpt_type_id
        /// </value>
		public decimal? ElectronicEquipmentTypeId { get; set; }
		
        #endregion
    }
}
