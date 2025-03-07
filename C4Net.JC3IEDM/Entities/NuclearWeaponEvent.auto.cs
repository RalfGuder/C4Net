using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity NUCLEAR-WEAPON-EVENT that represents the table NUC_WEAPON_EVENT.
	///
	/// A NUCLEAR-EVENT that involves the detonation of a nuclear device.
    /// </summary>
    [Serializable]
    [DefinitionName("NuclearWeaponEvent", "C4Net.JC3IEDM.Definitions.NuclearWeaponEvent.definition.xml")]
    public class NuclearWeaponEvent : NuclearEvent, INuclearWeaponEvent
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly NuclearWeaponEventExpression _ = new NuclearWeaponEventExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column flash_to_bang_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds from light being first observed until the sound of the nuclear detonation is heard in a specific NUCLEAR-WEAPON-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column flash_to_bang_dur
        /// </value>
		public decimal? FlashToBangDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column crater_prsnc_code
		///
		/// The specific value that represents the presence of a crater.
        /// </summary>
        /// <value>
        /// Value of the column crater_prsnc_code
        /// </value>
		public NuclearWeaponEventCraterPresenceEnum? CraterPresence { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column crater_width_dim
		///
		/// The one-dimensional linear distance representing the width of a crater caused by the detonation of a nuclear device.
        /// </summary>
        /// <value>
        /// Value of the column crater_width_dim
        /// </value>
		public double? CraterWidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column yield_group_code
		///
		/// The specific value that represents the energy released in the detonation of a nuclear weapon, measured in terms of the kilotons or megatons of trinitrotoluene required to produce the same energy release.
        /// </summary>
        /// <value>
        /// Value of the column yield_group_code
        /// </value>
		public NuclearYieldGroupEnum? YieldGroup { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column yield_qty
		///
		/// The numeric value that represents the energy release or predicted to be released by the detonation of a nuclear weapon. The unit of measure is kiloton.
        /// </summary>
        /// <value>
        /// Value of the column yield_qty
        /// </value>
		public short? YieldQuantity { get; set; }
		
        #endregion
    }
}
