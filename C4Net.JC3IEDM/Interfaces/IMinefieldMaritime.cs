using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity MinefieldMaritime that represents the table MNFLD_MRT
	/// 
	/// A MINEFIELD that is an area or volume of water containing mines.
    /// </summary>
	[EntId(10000275)]
    [EntName("MINEFIELD-MARITIME")]
    [EntTableName("MNFLD_MRT")]
    [EntDepth(5)]
    public interface IMinefieldMaritime
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mnfld_mrt_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column mnfld_mrt_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("minefield-maritime-id")]
		[AttrColumnName("mnfld_mrt_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column depth_plcmnt_code
		///
		/// The specific value that indicates the intended depth placement of maritime mines.
        /// </summary>
        /// <value>
        /// Value of the column depth_plcmnt_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("minefield-maritime-depth-placement-code")]
		[AttrColumnName("depth_plcmnt_code")]
        [AttrSeqnr(2)]
        [DomId(100004197)]
        [DataLength(6)]
        [DataDecimals(0)]
        MinefieldMaritimeDepthPlacementEnum? DepthPlacement { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column expct_vessel_transit_cnt
		///
		/// The integer value representing the expected number of transiting vessels.
        /// </summary>
        /// <value>
        /// Value of the column expct_vessel_transit_cnt
        /// </value>
        [AttrIx(100003)]
		[AttrName("minefield-maritime-expected-vessel-transit-count")]
		[AttrColumnName("expct_vessel_transit_cnt")]
        [AttrSeqnr(3)]
        [DomId(100001800)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? ExpectedVesselTransitCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column func_code
		///
		/// The specific value that represents the intended function of a specific MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column func_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("minefield-maritime-function-code")]
		[AttrColumnName("func_code")]
        [AttrSeqnr(4)]
        [DomId(100004198)]
        [DataLength(6)]
        [DataDecimals(0)]
        MinefieldMaritimeFunctionEnum? Function { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mmoe_initial_thrt_prob_rat
		///
		/// The numeric quotient value that represents the planned or estimated likelihood that the first target ship to enter the minefield will be a casualty. MMOE stands for Minefield Measurement Of Effectiveness. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column mmoe_initial_thrt_prob_rat
        /// </value>
        [AttrIx(100005)]
		[AttrName("minefield-maritime-mmoe-initial-threat-probability-ratio")]
		[AttrColumnName("mmoe_initial_thrt_prob_rat")]
        [AttrSeqnr(5)]
        [DomId(100001900)]
        [DataLength(6)]
        [DataDecimals(5)]
        double? MmoeInitialThreatProbabilityRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dtctn_prob_rat
		///
		/// The numeric quotient value that represents the probability that a mine will be located during MCM operations. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column dtctn_prob_rat
        /// </value>
        [AttrIx(100006)]
		[AttrName("minefield-maritime-detection-probability-ratio")]
		[AttrColumnName("dtctn_prob_rat")]
        [AttrSeqnr(6)]
        [DomId(100001900)]
        [DataLength(6)]
        [DataDecimals(5)]
        double? DetectionProbabilityRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column life_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds for the estimated life of the MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column life_dur
        /// </value>
        [AttrIx(100007)]
		[AttrName("minefield-maritime-life-duration")]
		[AttrColumnName("life_dur")]
        [AttrSeqnr(7)]
        [DomId(100000700)]
        [DataLength(19)]
        [DataDecimals(0)]
        decimal? LifeDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mine_detld_txt
		///
		/// The character string assigned to represent a description of a specific mine.
        /// </summary>
        /// <value>
        /// Value of the column mine_detld_txt
        /// </value>
        [AttrIx(100008)]
		[AttrName("minefield-maritime-mine-detailed-text")]
		[AttrColumnName("mine_detld_txt")]
        [AttrSeqnr(8)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string MineDetailedText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mines_laid_cnt
		///
		/// The integer value representing the number of maritime mines laid in a specific MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column mines_laid_cnt
        /// </value>
        [AttrIx(100009)]
		[AttrName("minefield-maritime-mines-laid-count")]
		[AttrColumnName("mines_laid_cnt")]
        [AttrSeqnr(9)]
        [DomId(100001800)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? MinesLaidCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column btm_natural_camo_code
		///
		/// The specific value that represents the description of the ground of a lake, river, or ocean, or other body of water with respect to the ability to hide mines on the bottom at a specific MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column btm_natural_camo_code
        /// </value>
        [AttrIx(100010)]
		[AttrName("minefield-maritime-bottom-natural-camouflage-code")]
		[AttrColumnName("btm_natural_camo_code")]
        [AttrSeqnr(10)]
        [DomId(100004325)]
        [DataLength(6)]
        [DataDecimals(0)]
        MinefieldMaritimeBottomNaturalCamouflageEnum? BottomNaturalCamouflage { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subf_code
		///
		/// The specific value that represents the intended purpose of the MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column subf_code
        /// </value>
        [AttrIx(100011)]
		[AttrName("minefield-maritime-subfunction-code")]
		[AttrColumnName("subf_code")]
        [AttrSeqnr(11)]
        [DomId(100004326)]
        [DataLength(6)]
        [DataDecimals(0)]
        MinefieldMaritimeSubfunctionEnum? Subfunction { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100012)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(12)]
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
        [AttrIx(100013)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(13)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
