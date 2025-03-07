using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity FacilityStatus that represents the table FAC_STAT
	/// 
	/// An OBJECT-ITEM-STATUS that is a record of condition of a specific FACILITY.
    /// </summary>
	[EntId(10000133)]
    [EntName("FACILITY-STATUS")]
    [EntTableName("FAC_STAT")]
    [EntDepth(4)]
    public interface IFacilityStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column fac_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column fac_stat_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("facility-status-id")]
		[AttrColumnName("fac_stat_id")]
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
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of FACILITY-STATUS. It serves as a discriminator that partitions FACILITY-STATUS into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("facility-status-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000319)]
        [DataLength(6)]
        [DataDecimals(0)]
        FacilityStatusCategoryEnum FacilityStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dmltn_stat_code
		///
		/// The specific value that represents the status of a specific FACILITY destined for demolition.
        /// </summary>
        /// <value>
        /// Value of the column dmltn_stat_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("facility-status-demolition-status-code")]
		[AttrColumnName("dmltn_stat_code")]
        [AttrSeqnr(4)]
        [DomId(100000367)]
        [DataLength(6)]
        [DataDecimals(0)]
        DemolitionStatusEnum? DemolitionStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column enemy_actv_cond_code
		///
		/// The specific value that represents the status of enemy activity around or at the FACILITY.
        /// </summary>
        /// <value>
        /// Value of the column enemy_actv_cond_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("facility-status-enemy-activity-condition-code")]
		[AttrColumnName("enemy_actv_cond_code")]
        [AttrSeqnr(5)]
        [DomId(100004240)]
        [DataLength(6)]
        [DataDecimals(0)]
        FacilityStatusEnemyActivityConditionEnum? EnemyActivityCondition { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mine_prsnc_code
		///
		/// The specific value that indicates whether a specific FACILITY contains mines.
        /// </summary>
        /// <value>
        /// Value of the column mine_prsnc_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("facility-status-mine-presence-code")]
		[AttrColumnName("mine_prsnc_code")]
        [AttrSeqnr(6)]
        [DomId(100000313)]
        [DataLength(6)]
        [DataDecimals(0)]
        MinePresenceEnum? MinePresence { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ocptn_prog_ind_code
		///
		/// The specific value that indicates whether an occupation programme is present at the facility.
        /// </summary>
        /// <value>
        /// Value of the column ocptn_prog_ind_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("facility-status-occupation-program-indicator-code")]
		[AttrColumnName("ocptn_prog_ind_code")]
        [AttrSeqnr(7)]
        [DomId(100000386)]
        [DataLength(6)]
        [DataDecimals(0)]
        FacilityStatusOccupationProgramIndicatorEnum? OccupationProgramIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_stat_code
		///
		/// The specific value that represents the operational status of a specific FACILITY.
        /// </summary>
        /// <value>
        /// Value of the column operat_stat_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("facility-status-operational-status-code")]
		[AttrColumnName("operat_stat_code")]
        [AttrSeqnr(8)]
        [Mandatory]
        [DomId(100000249)]
        [DataLength(6)]
        [DataDecimals(0)]
        FacilityStatusOperationalStatusEnum OperationalStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_stat_qual_code
		///
		/// The specific value that represents the qualification of the operational status of a specific FACILITY.
        /// </summary>
        /// <value>
        /// Value of the column operat_stat_qual_code
        /// </value>
        [AttrIx(100009)]
		[AttrName("facility-status-operational-status-qualifier-code")]
		[AttrColumnName("operat_stat_qual_code")]
        [AttrSeqnr(9)]
        [DomId(100000250)]
        [DataLength(6)]
        [DataDecimals(0)]
        FacilityStatusOperationalStatusQualifierEnum? OperationalStatusQualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column reserve_ind_code
		///
		/// The specific value that represents whether a specific FACILITY has been placed in reserve.
        /// </summary>
        /// <value>
        /// Value of the column reserve_ind_code
        /// </value>
        [AttrIx(100010)]
		[AttrName("facility-status-reserve-indicator-code")]
		[AttrColumnName("reserve_ind_code")]
        [AttrSeqnr(10)]
        [DomId(100000251)]
        [DataLength(6)]
        [DataDecimals(0)]
        FacilityStatusReserveIndicatorEnum? ReserveIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column security_stat_code
		///
		/// The specific value that represents the security status of a specific FACILITY.
        /// </summary>
        /// <value>
        /// Value of the column security_stat_code
        /// </value>
        [AttrIx(100011)]
		[AttrName("facility-status-security-status-code")]
		[AttrColumnName("security_stat_code")]
        [AttrSeqnr(11)]
        [DomId(100004102)]
        [DataLength(6)]
        [DataDecimals(0)]
        FacilityStatusSecurityStatusEnum? SecurityStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column usage_stat_code
		///
		/// The specific value that represents the usage of a specific FACILITY.
        /// </summary>
        /// <value>
        /// Value of the column usage_stat_code
        /// </value>
        [AttrIx(100012)]
		[AttrName("facility-status-usage-status-code")]
		[AttrColumnName("usage_stat_code")]
        [AttrSeqnr(12)]
        [DomId(100004225)]
        [DataLength(6)]
        [DataDecimals(0)]
        UsageStatusEnum? UsageStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100013)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(13)]
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
        [AttrIx(100014)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(14)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
