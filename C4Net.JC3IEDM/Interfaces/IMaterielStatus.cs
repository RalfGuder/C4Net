using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity MaterielStatus that represents the table MAT_STAT
	/// 
	/// An OBJECT-ITEM-STATUS that is a record of condition of a specific MATERIEL.
    /// </summary>
	[EntId(10000135)]
    [EntName("MATERIEL-STATUS")]
    [EntTableName("MAT_STAT")]
    [EntDepth(4)]
    public interface IMaterielStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mat_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column mat_stat_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("materiel-status-id")]
		[AttrColumnName("mat_stat_id")]
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
		/// The specific value that represents the class of MATERIEL-STATUS. It serves as a discriminator that partitions MATERIEL-STATUS into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("materiel-status-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100004132)]
        [DataLength(6)]
        [DataDecimals(0)]
        MaterielStatusCategoryEnum MaterielStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column body_colour_code
		///
		/// The specific value that represents the current colour scheme of a specific MATERIEL.
        /// </summary>
        /// <value>
        /// Value of the column body_colour_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("materiel-status-body-colour-code")]
		[AttrColumnName("body_colour_code")]
        [AttrSeqnr(4)]
        [DomId(100000389)]
        [DataLength(6)]
        [DataDecimals(0)]
        MaterielStatusBodyColourEnum? BodyColour { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column marking_code
		///
		/// The specific value that represents the type of marking of a specific MATERIEL.
        /// </summary>
        /// <value>
        /// Value of the column marking_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("materiel-status-marking-code")]
		[AttrColumnName("marking_code")]
        [AttrSeqnr(5)]
        [DomId(100000390)]
        [DataLength(6)]
        [DataDecimals(0)]
        MaterielStatusMarkingEnum? Marking { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column marking_colour_code
		///
		/// The specific value that represents the colour of the markings of a specific MATERIEL.
        /// </summary>
        /// <value>
        /// Value of the column marking_colour_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("materiel-status-marking-colour-code")]
		[AttrColumnName("marking_colour_code")]
        [AttrSeqnr(6)]
        [DomId(100000391)]
        [DataLength(6)]
        [DataDecimals(0)]
        MaterielStatusMarkingColourEnum? MarkingColour { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dmltn_stat_code
		///
		/// The specific value that represents the status of a specific MATERIEL destined for demolition.
        /// </summary>
        /// <value>
        /// Value of the column dmltn_stat_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("materiel-status-demolition-status-code")]
		[AttrColumnName("dmltn_stat_code")]
        [AttrSeqnr(7)]
        [DomId(100000367)]
        [DataLength(6)]
        [DataDecimals(0)]
        DemolitionStatusEnum? DemolitionStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column imo_compliant_ind_code
		///
		/// The specific value that indicates whether a vessel complies with International Maritime Organisation standards.
        /// </summary>
        /// <value>
        /// Value of the column imo_compliant_ind_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("materiel-status-imo-compliant-indicator-code")]
		[AttrColumnName("imo_compliant_ind_code")]
        [AttrSeqnr(8)]
        [DomId(100004287)]
        [DataLength(6)]
        [DataDecimals(0)]
        MaterielStatusImoCompliantIndicatorEnum? ImoCompliantIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_stat_code
		///
		/// The specific value that represents the operational status of a specific MATERIEL.
        /// </summary>
        /// <value>
        /// Value of the column operat_stat_code
        /// </value>
        [AttrIx(100009)]
		[AttrName("materiel-status-operational-status-code")]
		[AttrColumnName("operat_stat_code")]
        [AttrSeqnr(9)]
        [Mandatory]
        [DomId(100000255)]
        [DataLength(6)]
        [DataDecimals(0)]
        MaterielStatusOperationalStatusEnum OperationalStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_stat_qual_code
		///
		/// The specific value that represents the qualification of the operational status of a specific MATERIEL.
        /// </summary>
        /// <value>
        /// Value of the column operat_stat_qual_code
        /// </value>
        [AttrIx(100010)]
		[AttrName("materiel-status-operational-status-qualifier-code")]
		[AttrColumnName("operat_stat_qual_code")]
        [AttrSeqnr(10)]
        [DomId(100000256)]
        [DataLength(6)]
        [DataDecimals(0)]
        MaterielStatusOperationalStatusQualifierEnum? OperationalStatusQualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_stat_mode_code
		///
		/// The specific value that represents the firepower or mobility or communications degradation of a specific MATERIEL.
        /// </summary>
        /// <value>
        /// Value of the column operat_stat_mode_code
        /// </value>
        [AttrIx(100011)]
		[AttrName("materiel-status-operational-status-mode-code")]
		[AttrColumnName("operat_stat_mode_code")]
        [AttrSeqnr(11)]
        [DomId(100000257)]
        [DataLength(6)]
        [DataDecimals(0)]
        MaterielStatusOperationalStatusModeEnum? OperationalStatusMode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column reserve_ind_code
		///
		/// The specific value that represents whether a specific MATERIEL has been placed in reserve.
        /// </summary>
        /// <value>
        /// Value of the column reserve_ind_code
        /// </value>
        [AttrIx(100012)]
		[AttrName("materiel-status-reserve-indicator-code")]
		[AttrColumnName("reserve_ind_code")]
        [AttrSeqnr(12)]
        [DomId(100000258)]
        [DataLength(6)]
        [DataDecimals(0)]
        MaterielStatusReserveIndicatorEnum? ReserveIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column safety_stat_code
		///
		/// The specific value that represents the arming state of a specific MATERIEL that is a weapon or ammunition.
        /// </summary>
        /// <value>
        /// Value of the column safety_stat_code
        /// </value>
        [AttrIx(100013)]
		[AttrName("materiel-status-safety-status-code")]
		[AttrColumnName("safety_stat_code")]
        [AttrSeqnr(13)]
        [DomId(100000393)]
        [DataLength(6)]
        [DataDecimals(0)]
        MaterielStatusSafetyStatusEnum? SafetyStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column usage_stat_code
		///
		/// The specific value that represents the usage of a specific MATERIEL.
        /// </summary>
        /// <value>
        /// Value of the column usage_stat_code
        /// </value>
        [AttrIx(100014)]
		[AttrName("materiel-status-usage-status-code")]
		[AttrColumnName("usage_stat_code")]
        [AttrSeqnr(14)]
        [DomId(100004225)]
        [DataLength(6)]
        [DataDecimals(0)]
        UsageStatusEnum? UsageStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column buoy_malf_code
		///
		/// The specific value that represents the type of malfunction of a buoy.
        /// </summary>
        /// <value>
        /// Value of the column buoy_malf_code
        /// </value>
        [AttrIx(100015)]
		[AttrName("materiel-status-buoy-malfunction-code")]
		[AttrColumnName("buoy_malf_code")]
        [AttrSeqnr(15)]
        [DomId(100004323)]
        [DataLength(6)]
        [DataDecimals(0)]
        MaterielStatusBuoyMalfunctionEnum? BuoyMalfunction { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100016)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(16)]
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
        [AttrIx(100017)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(17)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
