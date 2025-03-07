using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity NUCLEAR-EVENT that represents the table NUC_EVENT.
	///
	/// A RADIOACTIVE-EVENT involving nuclear materiel and/or nuclear detonation.
    /// </summary>
    [Serializable]
    [DefinitionName("NuclearEvent", "C4Net.JC3IEDM.Definitions.NuclearEvent.definition.xml")]
    public class NuclearEvent : RadioactiveEvent, INuclearEvent
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly NuclearEventExpression _ = new NuclearEventExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of NUCLEAR-EVENT. It serves as a discriminator that partitions NUCLEAR-EVENT into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public NuclearEventCategoryEnum NuclearEventCategory { get; set; }
		
        #endregion
    }
}
