using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity TARGET that represents the table TARGET.
	///
	/// An ACTION-OBJECTIVE-ITEM that is subject to capture, destruction or intelligence operations.
    /// </summary>
    [Serializable]
    [DefinitionName("Target", "C4Net.JC3IEDM.Definitions.Target.definition.xml")]
    public class Target : ActionObjectiveItem, ITarget
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly TargetExpression _ = new TargetExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column engage_authy_code
		///
		/// The specific value that represents the type of employment authorised for a specific TARGET.
        /// </summary>
        /// <value>
        /// Value of the column engage_authy_code
        /// </value>
		public TargetEngagementAuthorityEnum? EngagementAuthority { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column id_txt
		///
		/// The character string assigned to represent the common additional reference assigned to the target by an organisation.
        /// </summary>
        /// <value>
        /// Value of the column id_txt
        /// </value>
		public string IdentifierText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column persistence_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds that a specific TARGET is expected to remain available as a target.
        /// </summary>
        /// <value>
        /// Value of the column persistence_dur
        /// </value>
		public decimal? PersistenceDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column descr_txt
		///
		/// The character string assigned to represent the common additional reference assigned to the TARGET.
        /// </summary>
        /// <value>
        /// Value of the column descr_txt
        /// </value>
		public string DescriptionText { get; set; }
		
        #endregion
    }
}
