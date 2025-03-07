using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ObjectItemAddress that represents the table OBJ_ITEM_ADDR
	/// 
	/// An association between an OBJECT-ITEM and an ADDRESS to specify the means by which a FACILITY, ORGANISATION or PERSON can be accessed.
    /// </summary>
	[EntId(10000239)]
    [EntName("OBJECT-ITEM-ADDRESS")]
    [EntTableName("OBJ_ITEM_ADDR")]
    [EntDepth(5)]
    public interface IObjectItemAddress
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("object-item-id")]
		[AttrColumnName("obj_item_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column addr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ADDRESS and to distinguish it from all other ADDRESSs.
        /// </summary>
        /// <value>
        /// Value of the column addr_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("address-id")]
		[AttrColumnName("addr_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000917)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal AddressId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_addr_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-ADDRESS for a specific OBJECT-ITEM and a specific ADDRESS and to distinguish it from all other OBJECT-ITEM-ADDRESSs for that OBJECT-ITEM and that ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_addr_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("object-item-address-index")]
		[AttrColumnName("obj_item_addr_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column call_sign_txt
		///
		/// The character string assigned to represent a specific OBJECT-ITEM that uses a specific ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column call_sign_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("object-item-address-call-sign-text")]
		[AttrColumnName("call_sign_txt")]
        [AttrSeqnr(4)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string CallSignText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column primacy_code
		///
		/// The specific value that represents the priority that a specific ADDRESS has with respect to a specific OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column primacy_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("object-item-address-primacy-code")]
		[AttrColumnName("primacy_code")]
        [AttrSeqnr(5)]
        [DomId(100004236)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectItemAddressPrimacyEnum? Primacy { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column auth_ind_code
		///
		/// The specific value that denotes whether the OBJECT-ITEM is permitted by command authority to use a specific ELECTRONIC-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column auth_ind_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("object-item-address-authorisation-indicator-code")]
		[AttrColumnName("auth_ind_code")]
        [AttrSeqnr(6)]
        [DomId(100004128)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectItemAddressAuthorisationIndicatorEnum? AuthorisationIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column trns_rcv_code
		///
		/// The specific value that denotes the OBJECT-ITEM usage of an ELECTRONIC-ADDRESS in terms of transmission and reception.
        /// </summary>
        /// <value>
        /// Value of the column trns_rcv_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("object-item-address-transmit-receive-code")]
		[AttrColumnName("trns_rcv_code")]
        [AttrSeqnr(7)]
        [DomId(100004254)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectItemAddressTransmitReceiveEnum? TransmitReceive { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column netwrk_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_id
        /// </value>
        [AttrIx(100008)]
		[AttrName("network-id")]
		[AttrColumnName("netwrk_id")]
        [AttrSeqnr(8)]
        [ForeignKey]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? NetworkId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column netwrk_freq_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific NETWORK-FREQUENCY for a specific NETWORK and to distinguish it from all other NETWORK-FREQUENCYs for that NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_freq_ix
        /// </value>
        [AttrIx(100009)]
		[AttrName("network-frequency-index")]
		[AttrColumnName("netwrk_freq_ix")]
        [AttrSeqnr(9)]
        [ForeignKey]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? NetworkFrequencyIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
        [AttrIx(100010)]
		[AttrName("reporting-data-id")]
		[AttrColumnName("rptd_id")]
        [AttrSeqnr(10)]
        [ForeignKey]
        [DomId(100000912)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? ReportingDataId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100011)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(11)]
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
        [AttrIx(100012)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(12)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
