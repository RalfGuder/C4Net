using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity NetworkFrequency that represents the table NETWRK_FREQ
	/// 
	/// The specification of a discrete frequency that is used on a specific NETWORK.
    /// </summary>
	[EntId(10000231)]
    [EntName("NETWORK-FREQUENCY")]
    [EntTableName("NETWRK_FREQ")]
    [EntDepth(4)]
    public interface INetworkFrequency
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
        /// Gets or sets the value of the column netwrk_freq_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific NETWORK-FREQUENCY for a specific NETWORK and to distinguish it from all other NETWORK-FREQUENCYs for that NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_freq_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("network-frequency-index")]
		[AttrColumnName("netwrk_freq_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column band_code
		///
		/// The specific value that represents the frequency band of a specific NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column band_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("network-frequency-band-code")]
		[AttrColumnName("band_code")]
        [AttrSeqnr(3)]
        [DomId(100004124)]
        [DataLength(6)]
        [DataDecimals(0)]
        NetworkFrequencyBandEnum? Band { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column chnl_no_txt
		///
		/// The character string assigned to represent the channel number associated with a specific NETWORK-FREQUENCY.
        /// </summary>
        /// <value>
        /// Value of the column chnl_no_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("network-frequency-channel-number-text")]
		[AttrColumnName("chnl_no_txt")]
        [AttrSeqnr(4)]
        [DomId(100001500)]
        [DataLength(6)]
        [DataDecimals(0)]
        string ChannelNumberText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column discrete_freq_qty
		///
		/// The numeric value that represents the radio frequency that a specific NETWORK may use. The unit of measure is kilohertz.
        /// </summary>
        /// <value>
        /// Value of the column discrete_freq_qty
        /// </value>
        [AttrIx(100005)]
		[AttrName("network-frequency-discrete-frequency-quantity")]
		[AttrColumnName("discrete_freq_qty")]
        [AttrSeqnr(5)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? DiscreteFrequencyQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column band_lower_freq_qty
		///
		/// The numeric value that represents the lowest radio frequency of a specific contiguous band that a NETWORK may use. The unit of measure is kilohertz.
        /// </summary>
        /// <value>
        /// Value of the column band_lower_freq_qty
        /// </value>
        [AttrIx(100006)]
		[AttrName("network-frequency-band-lower-frequency-quantity")]
		[AttrColumnName("band_lower_freq_qty")]
        [AttrSeqnr(6)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? BandLowerFrequencyQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column band_upper_freq_qty
		///
		/// The numeric value that represents the highest radio frequency of a specific contiguous band that a NETWORK may use. The unit of measure is kilohertz.
        /// </summary>
        /// <value>
        /// Value of the column band_upper_freq_qty
        /// </value>
        [AttrIx(100007)]
		[AttrName("network-frequency-band-upper-frequency-quantity")]
		[AttrColumnName("band_upper_freq_qty")]
        [AttrSeqnr(7)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? BandUpperFrequencyQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_start_dttm
		///
		/// The character string representing a point in time that designates the effective assignment of a specific OBJECT-TYPE-ESTABLISHMENT to a specific OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column effctv_start_dttm
        /// </value>
        [AttrIx(100008)]
		[AttrName("network-frequency-effective-start-datetime")]
		[AttrColumnName("effctv_start_dttm")]
        [AttrSeqnr(8)]
        [Mandatory]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string EffectiveStartDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_end_dttm
		///
		/// The character string representing a point in time that designates the end of the authorised period of effectiveness for a specific NETWORK-FREQUENCY.
        /// </summary>
        /// <value>
        /// Value of the column effctv_end_dttm
        /// </value>
        [AttrIx(100009)]
		[AttrName("network-frequency-effective-end-datetime")]
		[AttrColumnName("effctv_end_dttm")]
        [AttrSeqnr(9)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string EffectiveEndDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mdltn_code
		///
		/// The specific value that represents the modulation of a specific NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column mdltn_code
        /// </value>
        [AttrIx(100010)]
		[AttrName("network-frequency-modulation-code")]
		[AttrColumnName("mdltn_code")]
        [AttrSeqnr(10)]
        [DomId(100004125)]
        [DataLength(6)]
        [DataDecimals(0)]
        NetworkFrequencyModulationEnum? Modulation { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column purpose_txt
		///
		/// The character string assigned to represent the specific purpose of a NETWORK-FREQUENCY.
        /// </summary>
        /// <value>
        /// Value of the column purpose_txt
        /// </value>
        [AttrIx(100011)]
		[AttrName("network-frequency-purpose-text")]
		[AttrColumnName("purpose_txt")]
        [AttrSeqnr(11)]
        [DomId(100001500)]
        [DataLength(255)]
        [DataDecimals(0)]
        string PurposeText { get; set; }
		
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
