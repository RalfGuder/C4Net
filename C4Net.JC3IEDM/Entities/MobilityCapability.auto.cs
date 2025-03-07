using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MOBILITY-CAPABILITY that represents the table MOB_CAPAB.
	///
	/// A CAPABILITY, required for planning, of those FACILITYs, MATERIELs, ORGANISATIONs and PERSONs or FACILITY-TYPEs, EQUIPMENT-TYPEs, ORGANISATION-TYPEs, and PERSON-TYPEs that are deemed as having the nominal ability to move in space, air, on water, under water, or over a specific type of terrain.
    /// </summary>
    [Serializable]
    [DefinitionName("MobilityCapability", "C4Net.JC3IEDM.Definitions.MobilityCapability.definition.xml")]
    public class MobilityCapability : Capability, IMobilityCapability
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly MobilityCapabilityExpression _ = new MobilityCapabilityExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of MOBILITY-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public MobilityCapabilityCategoryEnum MobilityCapabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dscpt_code
		///
		/// The specific value that represents the MOBILITY-CAPABILITY that is being quantified.
        /// </summary>
        /// <value>
        /// Value of the column dscpt_code
        /// </value>
		public MobilityCapabilityDescriptorEnum? Descriptor { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column terrain_type_code
		///
		/// The specific value that represents the class of terrain to which a particular MOBILITY-CAPABILITY pertains.
        /// </summary>
        /// <value>
        /// Value of the column terrain_type_code
        /// </value>
		public MobilityCapabilityTerrainTypeEnum? TerrainType { get; set; }
		
        #endregion
    }
}
