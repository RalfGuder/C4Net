using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity FIRE-CAPABILITY that represents the table FIRE_CAPAB.
	///
	/// A CAPABILITY, required for planning, of those FACILITYs, MATERIELs, ORGANISATIONs and PERSONs, or FACILITY-TYPEs, EQUIPMENT-TYPEs, ORGANISATION-TYPEs and PERSON-TYPEs that are deemed as having the ability to discharge or launch a projectile or missile.
    /// </summary>
    [Serializable]
    [DefinitionName("FireCapability", "C4Net.JC3IEDM.Definitions.FireCapability.definition.xml")]
    public class FireCapability : Capability, IFireCapability
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly FireCapabilityExpression _ = new FireCapabilityExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of FIRE-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public FireCapabilityCategoryEnum FireCapabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dscpt_code
		///
		/// The specific value that represents the FIRE-CAPABILITY that is being quantified.
        /// </summary>
        /// <value>
        /// Value of the column dscpt_code
        /// </value>
		public FireCapabilityDescriptorEnum? Descriptor { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column weapon_type_code
		///
		/// The specific value that represents the general type of weapon that an EQUIPMENT-TYPE is qualified to employ.
        /// </summary>
        /// <value>
        /// Value of the column weapon_type_code
        /// </value>
		public FireCapabilityWeaponTypeEnum? WeaponType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ammo_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column ammo_type_id
        /// </value>
		public decimal? AmmunitionTypeId { get; set; }
		
        #endregion
    }
}
