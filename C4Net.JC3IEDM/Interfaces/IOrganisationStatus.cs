using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity OrganisationStatus that represents the table ORG_STAT
	/// 
	/// An OBJECT-ITEM-STATUS that is a record of condition of a specific ORGANISATION.
    /// </summary>
	[EntId(10000136)]
    [EntName("ORGANISATION-STATUS")]
    [EntTableName("ORG_STAT")]
    [EntDepth(4)]
    public interface IOrganisationStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column org_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column org_stat_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("organisation-status-id")]
		[AttrColumnName("org_stat_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-STATUS for a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-STATUSs for that OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_stat_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("object-item-status-index")]
		[AttrColumnName("obj_item_stat_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemStatusIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_stat_code
		///
		/// The specific value that represents the operational status of a specific ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column operat_stat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("organisation-status-operational-status-code")]
		[AttrColumnName("operat_stat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000260)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationStatusOperationalStatusEnum OperationalStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_stat_qual_code
		///
		/// The specific value that represents the qualification of the operational status of a specific ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column operat_stat_qual_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("organisation-status-operational-status-qualifier-code")]
		[AttrColumnName("operat_stat_qual_code")]
        [AttrSeqnr(4)]
        [DomId(100000261)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationStatusOperationalStatusQualifierEnum? OperationalStatusQualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column avlbty_code
		///
		/// The specific value that gives the availability status of an ORGANISATION without regard to readiness.
        /// </summary>
        /// <value>
        /// Value of the column avlbty_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("organisation-status-availability-code")]
		[AttrColumnName("avlbty_code")]
        [AttrSeqnr(5)]
        [DomId(100004115)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationStatusAvailabilityEnum? Availability { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cmd_and_ctrl_role_code
		///
		/// The specific value that represents the role played by a command and control ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column cmd_and_ctrl_role_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("organisation-status-command-and-control-role-code")]
		[AttrColumnName("cmd_and_ctrl_role_code")]
        [AttrSeqnr(6)]
        [DomId(100004185)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationStatusCommandAndControlRoleEnum? CommandAndControlRole { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cmtmnt_stat_code
		///
		/// The specific value that gives the commitment status of an ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column cmtmnt_stat_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("organisation-status-commitment-status-code")]
		[AttrColumnName("cmtmnt_stat_code")]
        [AttrSeqnr(7)]
        [DomId(100004116)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationStatusCommitmentStatusEnum? CommitmentStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fire_mode_code
		///
		/// The specific value that represents the status of weapons employment constraint for a specific ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column fire_mode_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("organisation-status-fire-mode-code")]
		[AttrColumnName("fire_mode_code")]
        [AttrSeqnr(8)]
        [DomId(100000262)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationStatusFireModeEnum? FireMode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cbrn_dress_state_code
		///
		/// The specific value that represents the Mission Oriented Protective Posture (MOPP) status defining the NBC (CBRN) dress code of a specific ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column cbrn_dress_state_code
        /// </value>
        [AttrIx(100009)]
		[AttrName("organisation-status-cbrn-dress-state-code")]
		[AttrColumnName("cbrn_dress_state_code")]
        [AttrSeqnr(9)]
        [DomId(100004159)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationStatusCbrnDressStateEnum? CbrnDressState { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rad_dose_qty
		///
		/// The numeric value that represents the average radiation dose to which the members of an organisation have been exposed. The unit of measure is centiGray (cGy).
        /// </summary>
        /// <value>
        /// Value of the column rad_dose_qty
        /// </value>
        [AttrIx(100010)]
		[AttrName("organisation-status-radiation-dose-quantity")]
		[AttrColumnName("rad_dose_qty")]
        [AttrSeqnr(10)]
        [DomId(100001200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? RadiationDoseQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rdns_code
		///
		/// The specific value that gives the readiness level of an ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column rdns_code
        /// </value>
        [AttrIx(100011)]
		[AttrName("organisation-status-readiness-code")]
		[AttrColumnName("rdns_code")]
        [AttrSeqnr(11)]
        [DomId(100004117)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationStatusReadinessEnum? Readiness { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rdns_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds reflecting the maximum interval in which an ORGANISATION is to respond to an immediate order.
        /// </summary>
        /// <value>
        /// Value of the column rdns_dur
        /// </value>
        [AttrIx(100012)]
		[AttrName("organisation-status-readiness-duration")]
		[AttrColumnName("rdns_dur")]
        [AttrSeqnr(12)]
        [DomId(100000700)]
        [DataLength(19)]
        [DataDecimals(0)]
        decimal? ReadinessDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column reinforce_code
		///
		/// The specific value that represents whether a specific ORGANISATION has additional or detached strength.
        /// </summary>
        /// <value>
        /// Value of the column reinforce_code
        /// </value>
        [AttrIx(100013)]
		[AttrName("organisation-status-reinforcement-code")]
		[AttrColumnName("reinforce_code")]
        [AttrSeqnr(13)]
        [DomId(100000263)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationStatusReinforcementEnum? Reinforcement { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column reserve_ind_code
		///
		/// The specific value that represents whether a specific ORGANISATION has been placed in reserve.
        /// </summary>
        /// <value>
        /// Value of the column reserve_ind_code
        /// </value>
        [AttrIx(100014)]
		[AttrName("organisation-status-reserve-indicator-code")]
		[AttrColumnName("reserve_ind_code")]
        [AttrSeqnr(14)]
        [DomId(100000264)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationStatusReserveIndicatorEnum? ReserveIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column training_code
		///
		/// The specific value that represents the assessed training status of a specific ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column training_code
        /// </value>
        [AttrIx(100015)]
		[AttrName("organisation-status-training-code")]
		[AttrColumnName("training_code")]
        [AttrSeqnr(15)]
        [DomId(100004199)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationStatusTrainingEnum? Training { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column usage_stat_code
		///
		/// The specific value that represents the usage of a specific ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column usage_stat_code
        /// </value>
        [AttrIx(100016)]
		[AttrName("organisation-status-usage-status-code")]
		[AttrColumnName("usage_stat_code")]
        [AttrSeqnr(16)]
        [DomId(100000265)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationStatusUsageStatusEnum? UsageStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100017)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(17)]
        [Mandatory]
        [DomId(100000913)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
        [AttrIx(100018)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(18)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
