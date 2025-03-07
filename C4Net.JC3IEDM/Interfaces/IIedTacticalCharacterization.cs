using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity IedTacticalCharacterization that represents the table IED_TAC_CHRTZN
	/// 
	/// An ACTION-EVENT-DETAIL that describes how an IED incident was conducted or intended to be conducted.
    /// </summary>
	[EntId(10000365)]
    [EntName("IED-TACTICAL-CHARACTERIZATION")]
    [EntTableName("IED_TAC_CHRTZN")]
    [EntDepth(4)]
    public interface IIedTacticalCharacterization
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_event_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_event_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("action-event-id")]
		[AttrColumnName("act_event_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionEventId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_event_det_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-EVENT-DETAIL for a specific ACTION-EVENT and to distinguish it from all other ACTION-EVENT-DETAILs for that ACTION-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column act_event_det_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-event-detail-index")]
		[AttrColumnName("act_event_det_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionEventDetailIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column empl_code
		///
		/// The specific value that describes where the device is positioned.
        /// </summary>
        /// <value>
        /// Value of the column empl_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("ied-tactical-characterization-emplacement-code")]
		[AttrColumnName("empl_code")]
        [AttrSeqnr(3)]
        [DomId(100004422)]
        [DataLength(6)]
        [DataDecimals(0)]
        IedTacticalCharacterizationEmplacementEnum? Emplacement { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column employ_mthd_code
		///
		/// The specific value that describes how the device is delivered or attached to the target.
        /// </summary>
        /// <value>
        /// Value of the column employ_mthd_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("ied-tactical-characterization-employment-method-code")]
		[AttrColumnName("employ_mthd_code")]
        [AttrSeqnr(4)]
        [DomId(100004423)]
        [DataLength(6)]
        [DataDecimals(0)]
        IedTacticalCharacterizationEmploymentMethodEnum? EmploymentMethod { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column suicide_code
		///
		/// The specific value that indicates whether an IED was initiated by an operator at a time of his/her choosing in which the operator intentionally kills himself/herself as part of the attack.
        /// </summary>
        /// <value>
        /// Value of the column suicide_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("ied-tactical-characterization-suicide-code")]
		[AttrColumnName("suicide_code")]
        [AttrSeqnr(5)]
        [DomId(100004424)]
        [DataLength(6)]
        [DataDecimals(0)]
        IedTacticalCharacterizationSuicideEnum? Suicide { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column use_seq_code
		///
		/// The specific value that identifies enemy use of an IED as a primary, secondary, or tertiary form of attack, independent of intended outcome.
        /// </summary>
        /// <value>
        /// Value of the column use_seq_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("ied-tactical-characterization-use-sequence-code")]
		[AttrColumnName("use_seq_code")]
        [AttrSeqnr(6)]
        [DomId(100004425)]
        [DataLength(6)]
        [DataDecimals(0)]
        IedTacticalCharacterizationUseSequenceEnum? UseSequence { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vehicle_plcmnt_code
		///
		/// The specific value that indicates whether an IED is attached to the underside of a vehicle.
        /// </summary>
        /// <value>
        /// Value of the column vehicle_plcmnt_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("ied-tactical-characterization-vehicle-placement-code")]
		[AttrColumnName("vehicle_plcmnt_code")]
        [AttrSeqnr(7)]
        [DomId(100004426)]
        [DataLength(6)]
        [DataDecimals(0)]
        IedTacticalCharacterizationVehiclePlacementEnum? VehiclePlacement { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(8)]
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
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(9)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
