using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ORGANISATION-STATUS that represents the table ORG_STAT.
	///
	/// An OBJECT-ITEM-STATUS that is a record of condition of a specific ORGANISATION.
    /// </summary>
    [Serializable]
    [DefinitionName("OrganisationStatus", "C4Net.JC3IEDM.Definitions.OrganisationStatus.definition.xml")]
    public class OrganisationStatus : ObjectItemStatus, IOrganisationStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly OrganisationStatusExpression _ = new OrganisationStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column org_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column org_stat_id
        /// </value>
		public decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-STATUS for a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-STATUSs for that OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_stat_ix
        /// </value>
		public decimal ObjectItemStatusIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_stat_code
		///
		/// The specific value that represents the operational status of a specific ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column operat_stat_code
        /// </value>
		public OrganisationStatusOperationalStatusEnum OperationalStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_stat_qual_code
		///
		/// The specific value that represents the qualification of the operational status of a specific ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column operat_stat_qual_code
        /// </value>
		public OrganisationStatusOperationalStatusQualifierEnum? OperationalStatusQualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column avlbty_code
		///
		/// The specific value that gives the availability status of an ORGANISATION without regard to readiness.
        /// </summary>
        /// <value>
        /// Value of the column avlbty_code
        /// </value>
		public OrganisationStatusAvailabilityEnum? Availability { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cmd_and_ctrl_role_code
		///
		/// The specific value that represents the role played by a command and control ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column cmd_and_ctrl_role_code
        /// </value>
		public OrganisationStatusCommandAndControlRoleEnum? CommandAndControlRole { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cmtmnt_stat_code
		///
		/// The specific value that gives the commitment status of an ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column cmtmnt_stat_code
        /// </value>
		public OrganisationStatusCommitmentStatusEnum? CommitmentStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fire_mode_code
		///
		/// The specific value that represents the status of weapons employment constraint for a specific ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column fire_mode_code
        /// </value>
		public OrganisationStatusFireModeEnum? FireMode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cbrn_dress_state_code
		///
		/// The specific value that represents the Mission Oriented Protective Posture (MOPP) status defining the NBC (CBRN) dress code of a specific ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column cbrn_dress_state_code
        /// </value>
		public OrganisationStatusCbrnDressStateEnum? CbrnDressState { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rad_dose_qty
		///
		/// The numeric value that represents the average radiation dose to which the members of an organisation have been exposed. The unit of measure is centiGray (cGy).
        /// </summary>
        /// <value>
        /// Value of the column rad_dose_qty
        /// </value>
		public int? RadiationDoseQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rdns_code
		///
		/// The specific value that gives the readiness level of an ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column rdns_code
        /// </value>
		public OrganisationStatusReadinessEnum? Readiness { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rdns_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds reflecting the maximum interval in which an ORGANISATION is to respond to an immediate order.
        /// </summary>
        /// <value>
        /// Value of the column rdns_dur
        /// </value>
		public decimal? ReadinessDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column reinforce_code
		///
		/// The specific value that represents whether a specific ORGANISATION has additional or detached strength.
        /// </summary>
        /// <value>
        /// Value of the column reinforce_code
        /// </value>
		public OrganisationStatusReinforcementEnum? Reinforcement { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column reserve_ind_code
		///
		/// The specific value that represents whether a specific ORGANISATION has been placed in reserve.
        /// </summary>
        /// <value>
        /// Value of the column reserve_ind_code
        /// </value>
		public OrganisationStatusReserveIndicatorEnum? ReserveIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column training_code
		///
		/// The specific value that represents the assessed training status of a specific ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column training_code
        /// </value>
		public OrganisationStatusTrainingEnum? Training { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column usage_stat_code
		///
		/// The specific value that represents the usage of a specific ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column usage_stat_code
        /// </value>
		public OrganisationStatusUsageStatusEnum? UsageStatus { get; set; }
		
        #endregion
    }
}
