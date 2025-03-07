using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity MinefieldMaritimeStatus that represents the table MNFLD_MRT_STAT
	/// 
	/// A FACILITY-STATUS that is a record of condition of a specific MINEFIELD-MARITIME.
    /// </summary>
	[EntId(10000326)]
    [EntName("MINEFIELD-MARITIME-STATUS")]
    [EntTableName("MNFLD_MRT_STAT")]
    [EntDepth(5)]
    public interface IMinefieldMaritimeStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mnfld_mrt_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column mnfld_mrt_stat_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("minefield-maritime-status-id")]
		[AttrColumnName("mnfld_mrt_stat_id")]
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
        /// Gets or sets the value of the column code
		///
		/// The specific value that represents the known status of a MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column code
        /// </value>
        [AttrIx(100003)]
		[AttrName("minefield-maritime-status-code")]
		[AttrColumnName("code")]
        [AttrSeqnr(3)]
        [DomId(100004318)]
        [DataLength(6)]
        [DataDecimals(0)]
        MinefieldMaritimeStatusEnum? MinefieldMaritimeStatusCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column colour_code
		///
		/// The specific value that represents the known status of mined channels of a MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column colour_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("minefield-maritime-status-colour-code")]
		[AttrColumnName("colour_code")]
        [AttrSeqnr(4)]
        [DomId(100004319)]
        [DataLength(6)]
        [DataDecimals(0)]
        MinefieldMaritimeStatusColourEnum? Colour { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column expct_lvl_mcm_code
		///
		/// The specific values of expected mine countermeasures (MCM) to be employed against a MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column expct_lvl_mcm_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("minefield-maritime-status-expected-level-mcm-code")]
		[AttrColumnName("expct_lvl_mcm_code")]
        [AttrSeqnr(5)]
        [DomId(100004320)]
        [DataLength(6)]
        [DataDecimals(0)]
        MinefieldMaritimeStatusExpectedLevelMcmEnum? ExpectedLevelMcm { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mines_detected_qty
		///
		/// The numeric value representing the number of mines detected in a specific MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column mines_detected_qty
        /// </value>
        [AttrIx(100006)]
		[AttrName("minefield-maritime-status-mines-detected-quantity")]
		[AttrColumnName("mines_detected_qty")]
        [AttrSeqnr(6)]
        [DomId(100001200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? MinesDetectedQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mines_detected_cnt
		///
		/// The integer value representing the number of mines detected in a specific MINEFIELD-MARITIME at the time of the report.
        /// </summary>
        /// <value>
        /// Value of the column mines_detected_cnt
        /// </value>
        [AttrIx(100007)]
		[AttrName("minefield-maritime-status-mines-detected-count")]
		[AttrColumnName("mines_detected_cnt")]
        [AttrSeqnr(7)]
        [DomId(100001800)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? MinesDetectedCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mine_zone_risk_code
		///
		/// The specific value that represents the known threat (risk) of a MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column mine_zone_risk_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("minefield-maritime-status-mine-zone-risk-code")]
		[AttrColumnName("mine_zone_risk_code")]
        [AttrSeqnr(8)]
        [DomId(100004321)]
        [DataLength(6)]
        [DataDecimals(0)]
        MinefieldMaritimeStatusMineZoneRiskEnum? MineZoneRisk { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column seeding_code
		///
		/// The specific value that indicates the seeding details for a MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column seeding_code
        /// </value>
        [AttrIx(100009)]
		[AttrName("minefield-maritime-status-seeding-code")]
		[AttrColumnName("seeding_code")]
        [AttrSeqnr(9)]
        [DomId(100004322)]
        [DataLength(6)]
        [DataDecimals(0)]
        MinefieldMaritimeStatusSeedingEnum? Seeding { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column swept_depth_qty
		///
		/// The numeric value representing the depth below the surface to which minesweeping has taken place. The unit of measure is metres.
        /// </summary>
        /// <value>
        /// Value of the column swept_depth_qty
        /// </value>
        [AttrIx(100010)]
		[AttrName("minefield-maritime-status-swept-depth-quantity")]
		[AttrColumnName("swept_depth_qty")]
        [AttrSeqnr(10)]
        [DomId(100001200)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? SweptDepthQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column thrt_rat
		///
		/// The numeric quotient value that represents the current percentage threat to the enemy of a specific MINEFIELD-MARITIME. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column thrt_rat
        /// </value>
        [AttrIx(100011)]
		[AttrName("minefield-maritime-status-threat-ratio")]
		[AttrColumnName("thrt_rat")]
        [AttrSeqnr(11)]
        [DomId(100001900)]
        [DataLength(6)]
        [DataDecimals(5)]
        double? ThreatRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mine_dtctn_code
		///
		/// The specific value that represents the status of the means of detection of a mine in a MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column mine_dtctn_code
        /// </value>
        [AttrIx(100012)]
		[AttrName("minefield-maritime-status-mine-detection-code")]
		[AttrColumnName("mine_dtctn_code")]
        [AttrSeqnr(12)]
        [DomId(100004342)]
        [DataLength(6)]
        [DataDecimals(0)]
        MinefieldMaritimeStatusMineDetectionEnum? MineDetection { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mines_cnt
		///
		/// The integer value representing the number of mines within a specific maritime minefield at the time of the report.
        /// </summary>
        /// <value>
        /// Value of the column mines_cnt
        /// </value>
        [AttrIx(100013)]
		[AttrName("minefield-maritime-status-mines-count")]
		[AttrColumnName("mines_cnt")]
        [AttrSeqnr(13)]
        [DomId(100001800)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? MinesCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100014)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(14)]
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
        [AttrIx(100015)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(15)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
