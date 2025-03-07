using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity NetworkService that represents the table NETWRK_SERVICE
	/// 
	/// An identification of the specific type of communications service provided by a specific NETWORK.
    /// </summary>
	[EntId(10000232)]
    [EntName("NETWORK-SERVICE")]
    [EntTableName("NETWRK_SERVICE")]
    [EntDepth(4)]
    public interface INetworkService
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column netwrk_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("network-id")]
		[AttrColumnName("netwrk_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal NetworkId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column netwrk_service_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific NETWORK-SERVICE for a specific NETWORK and to distinguish it from all other NETWORK-SERVICEs for that NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_service_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("network-service-index")]
		[AttrColumnName("netwrk_service_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents a general type of service that a specific NETWORK is intended to provide.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("network-service-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100004127)]
        [DataLength(6)]
        [DataDecimals(0)]
        NetworkServiceCategoryEnum NetworkServiceCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents a detailed type of service that a specific NETWORK is intended to provide.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("network-service-subcategory-code")]
		[AttrColumnName("subcat_code")]
        [AttrSeqnr(4)]
        [DomId(100004141)]
        [DataLength(6)]
        [DataDecimals(0)]
        NetworkServiceSubcategoryEnum? Subcategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column crypto_ind_code
		///
		/// The specific value that represents whether a specific NETWORK-SERVICE is encrypted.
        /// </summary>
        /// <value>
        /// Value of the column crypto_ind_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("network-service-cryptographic-indicator-code")]
		[AttrColumnName("crypto_ind_code")]
        [AttrSeqnr(5)]
        [DomId(100004123)]
        [DataLength(6)]
        [DataDecimals(0)]
        NetworkServiceCryptographicIndicatorEnum? CryptographicIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column crypto_plan_short_title_txt
		///
		/// The character string assigned to represent a specific cryptographic plan.
        /// </summary>
        /// <value>
        /// Value of the column crypto_plan_short_title_txt
        /// </value>
        [AttrIx(100006)]
		[AttrName("network-service-cryptographic-plan-short-title-text")]
		[AttrColumnName("crypto_plan_short_title_txt")]
        [AttrSeqnr(6)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string CryptographicPlanShortTitleText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column crypto_code_short_title_txt
		///
		/// The character string assigned to represent a specific cryptographic code.
        /// </summary>
        /// <value>
        /// Value of the column crypto_code_short_title_txt
        /// </value>
        [AttrIx(100007)]
		[AttrName("network-service-cryptographic-code-short-title-text")]
		[AttrColumnName("crypto_code_short_title_txt")]
        [AttrSeqnr(7)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string CryptographicCodeShortTitleText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column iff_mode_code_txt
		///
		/// The character string assigned to represent a specific IFF mode code combination.
        /// </summary>
        /// <value>
        /// Value of the column iff_mode_code_txt
        /// </value>
        [AttrIx(100008)]
		[AttrName("network-service-iff-mode-code-text")]
		[AttrColumnName("iff_mode_code_txt")]
        [AttrSeqnr(8)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string IffModeCodeText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column security_clsfc_id
		///
		/// The unique value, or set of characters, assigned to represent a specific SECURITY-CLASSIFICATION and to distinguish it from all other SECURITY-CLASSIFICATIONs.
        /// </summary>
        /// <value>
        /// Value of the column security_clsfc_id
        /// </value>
        [AttrIx(100009)]
		[AttrName("security-classification-id")]
		[AttrColumnName("security_clsfc_id")]
        [AttrSeqnr(9)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000930)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal SecurityClassificationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100010)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(10)]
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
        [AttrIx(100011)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(11)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
