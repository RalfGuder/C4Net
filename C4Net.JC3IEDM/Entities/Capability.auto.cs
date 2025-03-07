using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CAPABILITY that represents the table CAPAB.
	///
	/// The potential ability to do work, perform a function or mission, achieve an objective, or provide a service.
    /// </summary>
    [Serializable]
    [DefinitionName("Capability", "C4Net.JC3IEDM.Definitions.Capability.definition.xml")]
    public class Capability : IEntity, ICapability
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly CapabilityExpression _ = new CapabilityExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column capab_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CAPABILITY and to distinguish it from all other CAPABILITYs.
        /// </summary>
        /// <value>
        /// Value of the column capab_id
        /// </value>
		public decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the general class of a CAPABILITY. It serves as a discriminator that partitions CAPABILITY into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public CapabilityCategoryEnum CapabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column day_night_code
		///
		/// The specific value that defines the light conditions that apply to a particular CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column day_night_code
        /// </value>
		public CapabilityDayNightEnum? DayNight { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column uom_code
		///
		/// The specific value that represents the quantities in terms of which the magnitude of a specific CAPABILITY descriptor is stated.
        /// </summary>
        /// <value>
        /// Value of the column uom_code
        /// </value>
		public CapabilityUnitOfMeasureEnum UnitOfMeasure { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
		public decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
		public long UpdateSeqnr { get; set; }
		
        #endregion
    }
}
