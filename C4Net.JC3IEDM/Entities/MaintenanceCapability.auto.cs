using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MAINTENANCE-CAPABILITY that represents the table MNT_CAPAB.
	///
	/// A CAPABILITY, required for planning, of those FACILITYs, MATERIELs, ORGANISATIONs and PERSONs or FACILITY-TYPEs, EQUIPMENT-TYPEs, ORGANISATION-TYPEs, and PERSON-TYPEs that are deemed as having the ability to provide a range of activities required to restore or maintain operational usage.
    /// </summary>
    [Serializable]
    [DefinitionName("MaintenanceCapability", "C4Net.JC3IEDM.Definitions.MaintenanceCapability.definition.xml")]
    public class MaintenanceCapability : Capability, IMaintenanceCapability
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly MaintenanceCapabilityExpression _ = new MaintenanceCapabilityExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of MAINTENANCE-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public MaintenanceCapabilityCategoryEnum MaintenanceCapabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column station_cnt
		///
		/// The integer value representing the number of operational maintenance stations, fully outfitted with the necessary equipment and maintenance personnel, available for the purpose of repairing and servicing materiel.
        /// </summary>
        /// <value>
        /// Value of the column station_cnt
        /// </value>
		public short? StationCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lvl_code
		///
		/// The specific value that represents the extent of repairs or servicing that can be accomplished.
        /// </summary>
        /// <value>
        /// Value of the column lvl_code
        /// </value>
		public MaintenanceCapabilityLevelEnum? Level { get; set; }
		
        #endregion
    }
}
