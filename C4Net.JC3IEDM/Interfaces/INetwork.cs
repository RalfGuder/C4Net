using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Network that represents the table NETWRK
	/// 
	/// A FACILITY that provides bearer services for communication and information services and is composed of one or more links and nodes.
    /// </summary>
	[EntId(10000230)]
    [EntName("NETWORK")]
    [EntTableName("NETWRK")]
    [EntDepth(3)]
    public interface INetwork
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
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("network-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004122)]
        [DataLength(6)]
        [DataDecimals(0)]
        NetworkCategoryEnum NetworkCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the specific class of NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("network-subcategory-code")]
		[AttrColumnName("subcat_code")]
        [AttrSeqnr(3)]
        [DomId(100004151)]
        [DataLength(6)]
        [DataDecimals(0)]
        NetworkSubcategoryEnum? Subcategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column arch_code
		///
		/// The specific value that represents the architecture of a specific NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column arch_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("network-architecture-code")]
		[AttrColumnName("arch_code")]
        [AttrSeqnr(4)]
        [DomId(100004152)]
        [DataLength(6)]
        [DataDecimals(0)]
        NetworkArchitectureEnum? Architecture { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column chnl_cnt
		///
		/// The integer value representing the number of channels that a specific NETWORK can provide.
        /// </summary>
        /// <value>
        /// Value of the column chnl_cnt
        /// </value>
        [AttrIx(100005)]
		[AttrName("network-channel-count")]
		[AttrColumnName("chnl_cnt")]
        [AttrSeqnr(5)]
        [DomId(100001800)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? ChannelCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_cap_rate
		///
		/// The numeric value that represents the maximum data rate that a specific NETWORK can process. The unit of measure is kilobits per second (KBS). The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column max_cap_rate
        /// </value>
        [AttrIx(100006)]
		[AttrName("network-maximum-capacity-rate")]
		[AttrColumnName("max_cap_rate")]
        [AttrSeqnr(6)]
        [DomId(100001300)]
        [DataLength(8)]
        [DataDecimals(4)]
        double? MaximumCapacityRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mnm_cap_rate
		///
		/// The numeric value that represents the minimum data rate that a specific NETWORK is required to process. The unit of measure is kilobits per second (KBS). The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column mnm_cap_rate
        /// </value>
        [AttrIx(100007)]
		[AttrName("network-minimum-capacity-rate")]
		[AttrColumnName("mnm_cap_rate")]
        [AttrSeqnr(7)]
        [DomId(100001300)]
        [DataLength(8)]
        [DataDecimals(4)]
        double? MinimumCapacityRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column means_code
		///
		/// The specific value that represents the physical linkage between the nodes of a specific NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column means_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("network-means-code")]
		[AttrColumnName("means_code")]
        [AttrSeqnr(8)]
        [DomId(100004139)]
        [DataLength(6)]
        [DataDecimals(0)]
        NetworkMeansEnum? Means { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column set_no_cnt
		///
		/// The integer value representing the frequency hopping set number parameter for this specific NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column set_no_cnt
        /// </value>
        [AttrIx(100009)]
		[AttrName("network-set-number-count")]
		[AttrColumnName("set_no_cnt")]
        [AttrSeqnr(9)]
        [DomId(100001800)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? SetNumberCount { get; set; }
		
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
