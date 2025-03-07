using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Runway that represents the table RUNWAY
	/// 
	/// A FACILITY that is a specifically prepared surface along which aircraft take off and land.
    /// </summary>
	[EntId(10000273)]
    [EntName("RUNWAY")]
    [EntTableName("RUNWAY")]
    [EntDepth(3)]
    public interface IRunway
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column runway_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column runway_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("runway-id")]
		[AttrColumnName("runway_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lgtng_prsnc_ind_code
		///
		/// The specific value that indicates whether a specific RUNWAY has runway lighting.
        /// </summary>
        /// <value>
        /// Value of the column lgtng_prsnc_ind_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("runway-lighting-presence-indicator-code")]
		[AttrColumnName("lgtng_prsnc_ind_code")]
        [AttrSeqnr(2)]
        [DomId(100004113)]
        [DataLength(6)]
        [DataDecimals(0)]
        RunwayLightingPresenceIndicatorEnum? LightingPresenceIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column wt_brng_cap_qty
		///
		/// The numeric value that denotes the maximum pressure that a specific RUNWAY is capable of carrying. The unit of measure is kilograms per square centimetre.
        /// </summary>
        /// <value>
        /// Value of the column wt_brng_cap_qty
        /// </value>
        [AttrIx(100003)]
		[AttrName("runway-weight-bearing-capacity-quantity")]
		[AttrColumnName("wt_brng_cap_qty")]
        [AttrSeqnr(3)]
        [DomId(100001200)]
        [DataLength(8)]
        [DataDecimals(4)]
        double? WeightBearingCapacityQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pvm_clsfc_no_cnt
		///
		/// The integer value representing the pavement Classification Number (PCN), which is part of the standard ICAO (International Civil Aviation Organization) method of reporting pavement strength for pavements with bearing strength greater than 5,700 kilograms (12,500 pounds).
        /// </summary>
        /// <value>
        /// Value of the column pvm_clsfc_no_cnt
        /// </value>
        [AttrIx(100004)]
		[AttrName("runway-pavement-classification-number-count")]
		[AttrColumnName("pvm_clsfc_no_cnt")]
        [AttrSeqnr(4)]
        [DomId(100001800)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? PavementClassificationNumberCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pvm_type_code
		///
		/// The specific value that represents the type of pavement classification, which is part of the standard ICAO (International Civil Aviation Organization) method of reporting pavement strength for pavements with bearing strength greater than 5,700 kilograms (12,500 pounds).
        /// </summary>
        /// <value>
        /// Value of the column pvm_type_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("runway-pavement-type-code")]
		[AttrColumnName("pvm_type_code")]
        [AttrSeqnr(5)]
        [DomId(100004275)]
        [DataLength(6)]
        [DataDecimals(0)]
        RunwayPavementTypeEnum? PavementType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pvm_subgrade_cat_code
		///
		/// The specific value that represents the pavement subgrade classification, which is part of the standard ICAO (International Civil Aviation Organization) method of reporting pavement strength for pavements with bearing strength greater than 5,700 kilograms (12,500 pounds).
        /// </summary>
        /// <value>
        /// Value of the column pvm_subgrade_cat_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("runway-pavement-subgrade-category-code")]
		[AttrColumnName("pvm_subgrade_cat_code")]
        [AttrSeqnr(6)]
        [DomId(100004276)]
        [DataLength(6)]
        [DataDecimals(0)]
        RunwayPavementSubgradeCategoryEnum? PavementSubgradeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pvm_max_tyre_prs_code
		///
		/// The specific value that represents the pavement maximum tyre pressure classification, which is part of the standard ICAO (International Civil Aviation Organization) method of reporting pavement strength for pavements with bearing strength greater than 5,700 kilograms (12,500 pounds).
        /// </summary>
        /// <value>
        /// Value of the column pvm_max_tyre_prs_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("runway-pavement-maximum-tyre-pressure-code")]
		[AttrColumnName("pvm_max_tyre_prs_code")]
        [AttrSeqnr(7)]
        [DomId(100004277)]
        [DataLength(6)]
        [DataDecimals(0)]
        RunwayPavementMaximumTyrePressureEnum? PavementMaximumTyrePressure { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pvm_eval_method_code
		///
		/// The specific value that represents the pavement evaluation method classification, which is part of the standard ICAO (International Civil Aviation Organization) method of reporting pavement strength for pavements with bearing strength greater than 5,700 kilograms (12,500 pounds).
        /// </summary>
        /// <value>
        /// Value of the column pvm_eval_method_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("runway-pavement-evaluation-method-code")]
		[AttrColumnName("pvm_eval_method_code")]
        [AttrSeqnr(8)]
        [DomId(100004278)]
        [DataLength(6)]
        [DataDecimals(0)]
        RunwayPavementEvaluationMethodEnum? PavementEvaluationMethod { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(9)]
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
        [AttrIx(100010)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(10)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
