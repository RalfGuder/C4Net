using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity IED-TACTICAL-CHARACTERIZATION that represents the table IED_TAC_CHRTZN.
	///
	/// An ACTION-EVENT-DETAIL that describes how an IED incident was conducted or intended to be conducted.
    /// </summary>
    [Serializable]
    [DefinitionName("IedTacticalCharacterization", "C4Net.JC3IEDM.Definitions.IedTacticalCharacterization.definition.xml")]
    public class IedTacticalCharacterization : ActionEventDetail, IIedTacticalCharacterization
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly IedTacticalCharacterizationExpression _ = new IedTacticalCharacterizationExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_event_det_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-EVENT-DETAIL for a specific ACTION-EVENT and to distinguish it from all other ACTION-EVENT-DETAILs for that ACTION-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column act_event_det_ix
        /// </value>
		public decimal ActionEventDetailIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column empl_code
		///
		/// The specific value that describes where the device is positioned.
        /// </summary>
        /// <value>
        /// Value of the column empl_code
        /// </value>
		public IedTacticalCharacterizationEmplacementEnum? Emplacement { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column employ_mthd_code
		///
		/// The specific value that describes how the device is delivered or attached to the target.
        /// </summary>
        /// <value>
        /// Value of the column employ_mthd_code
        /// </value>
		public IedTacticalCharacterizationEmploymentMethodEnum? EmploymentMethod { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column suicide_code
		///
		/// The specific value that indicates whether an IED was initiated by an operator at a time of his/her choosing in which the operator intentionally kills himself/herself as part of the attack.
        /// </summary>
        /// <value>
        /// Value of the column suicide_code
        /// </value>
		public IedTacticalCharacterizationSuicideEnum? Suicide { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column use_seq_code
		///
		/// The specific value that identifies enemy use of an IED as a primary, secondary, or tertiary form of attack, independent of intended outcome.
        /// </summary>
        /// <value>
        /// Value of the column use_seq_code
        /// </value>
		public IedTacticalCharacterizationUseSequenceEnum? UseSequence { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vehicle_plcmnt_code
		///
		/// The specific value that indicates whether an IED is attached to the underside of a vehicle.
        /// </summary>
        /// <value>
        /// Value of the column vehicle_plcmnt_code
        /// </value>
		public IedTacticalCharacterizationVehiclePlacementEnum? VehiclePlacement { get; set; }
		
        #endregion
    }
}
