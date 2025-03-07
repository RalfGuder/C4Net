using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ENGINEERING-CAPABILITY that represents the table ENG_CAPAB.
	///
	/// A CAPABILITY, required for planning, of those ORGANISATIONs and PERSONs or ORGANISATION-TYPEs and PERSON-TYPEs that are deemed as having the ability to perform construction or destruction activities.
    /// </summary>
    [Serializable]
    [DefinitionName("EngineeringCapability", "C4Net.JC3IEDM.Definitions.EngineeringCapability.definition.xml")]
    public class EngineeringCapability : Capability, IEngineeringCapability
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly EngineeringCapabilityExpression _ = new EngineeringCapabilityExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ENGINEERING-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public EngineeringCapabilityCategoryEnum EngineeringCapabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dscpt_code
		///
		/// The specific value that represents a specific ENGINEERING-CAPABILITY in terms of a measurable quantity.
        /// </summary>
        /// <value>
        /// Value of the column dscpt_code
        /// </value>
		public EngineeringCapabilityDescriptorEnum? Descriptor { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fac_height_dim
		///
		/// The one-dimensional linear distance representing the vertical distance, measured from the lowest to the highest reference, of either the FACILITY-TYPE itself (in the case of construction) or the breach in the FACILITY-TYPE (in the case of destruction).
        /// </summary>
        /// <value>
        /// Value of the column fac_height_dim
        /// </value>
		public double FacilityHeightDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fac_length_dim
		///
		/// The one-dimensional linear distance representing the horizontal distance, measured from end to end and parallel to the central axis, of either the FACILITY-TYPE itself (in the case of construction) or the breach in the FACILITY-TYPE (in the case of destruction).
        /// </summary>
        /// <value>
        /// Value of the column fac_length_dim
        /// </value>
		public double FacilityLengthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fac_width_dim
		///
		/// The one-dimensional linear distance representing the horizontal distance, measured from side to side and perpendicular to the central axis, of either the FACILITY-TYPE itself (in the case of construction) or the breach in the FACILITY-TYPE (in the case of destruction).
        /// </summary>
        /// <value>
        /// Value of the column fac_width_dim
        /// </value>
		public double FacilityWidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fac_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column fac_type_id
        /// </value>
		public decimal FacilityTypeId { get; set; }
		
        #endregion
    }
}
