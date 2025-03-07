using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity PlanOrderHeaderContent that represents the table PLN_ORDR_HDR_CNTNT
	/// 
	/// Introductory subject matter that applies to the entirety of a specific PLAN-ORDER.
    /// </summary>
	[EntId(10000354)]
    [EntName("PLAN-ORDER-HEADER-CONTENT")]
    [EntTableName("PLN_ORDR_HDR_CNTNT")]
    [EntDepth(1)]
    public interface IPlanOrderHeaderContent
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column pln_ordr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column pln_ordr_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("plan-order-id")]
		[AttrColumnName("pln_ordr_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000933)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal PlanOrderId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pln_ordr_hdr_cntnt_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-HEADER-CONTENT for a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDER-HEADER-CONTENTs for that PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column pln_ordr_hdr_cntnt_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("plan-order-header-content-index")]
		[AttrColumnName("pln_ordr_hdr_cntnt_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column name_txt
		///
		/// The character string assigned to represent a specific PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
        [AttrIx(100003)]
		[AttrName("plan-order-header-content-name-text")]
		[AttrColumnName("name_txt")]
        [AttrSeqnr(3)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string NameText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column nickname_txt
		///
		/// The character string assigned to represent an alternative name for a specific PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column nickname_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("plan-order-header-content-nickname-text")]
		[AttrColumnName("nickname_txt")]
        [AttrSeqnr(4)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string NicknameText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column serial_no_txt
		///
		/// The character string assigned to represent a sequential numerical identification of a specific PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column serial_no_txt
        /// </value>
        [AttrIx(100005)]
		[AttrName("plan-order-header-content-serial-number-text")]
		[AttrColumnName("serial_no_txt")]
        [AttrSeqnr(5)]
        [DomId(100001500)]
        [DataLength(15)]
        [DataDecimals(0)]
        string SerialNumberText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column sponsor_type_txt
		///
		/// The character string assigned to represent the type of force, such as combined, joint, army, navy, marine, air force, or other functional command, to which a specific PLAN-ORDER applies.
        /// </summary>
        /// <value>
        /// Value of the column sponsor_type_txt
        /// </value>
        [AttrIx(100006)]
		[AttrName("plan-order-header-content-sponsor-type-text")]
		[AttrColumnName("sponsor_type_txt")]
        [AttrSeqnr(6)]
        [DomId(100001500)]
        [DataLength(60)]
        [DataDecimals(0)]
        string SponsorTypeText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column time_zone_code
		///
		/// The specific value assigned to represent divisions of the Earth's surface in which standard time is kept as it applies to the specific PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column time_zone_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("plan-order-header-content-time-zone-code")]
		[AttrColumnName("time_zone_code")]
        [AttrSeqnr(7)]
        [DomId(100004392)]
        [DataLength(6)]
        [DataDecimals(0)]
        PlanOrderHeaderContentTimeZoneEnum? TimeZone { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing the point in time when the PLAN-ORDER-HEADER-CONTENT is defined.
        /// </summary>
        /// <value>
        /// Value of the column dttm
        /// </value>
        [AttrIx(100008)]
		[AttrName("plan-order-header-content-datetime")]
		[AttrColumnName("dttm")]
        [AttrSeqnr(8)]
        [Mandatory]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string Datetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column msg_ref_no_txt
		///
		/// The character string assigned for use in acknowledging a specific PLAN-ORDER in the clear.
        /// </summary>
        /// <value>
        /// Value of the column msg_ref_no_txt
        /// </value>
        [AttrIx(100009)]
		[AttrName("plan-order-header-content-message-reference-number-text")]
		[AttrColumnName("msg_ref_no_txt")]
        [AttrSeqnr(9)]
        [DomId(100001500)]
        [DataLength(15)]
        [DataDecimals(0)]
        string MessageReferenceNumberText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column security_clsfc_id
		///
		/// The unique value, or set of characters, assigned to represent a specific SECURITY-CLASSIFICATION and to distinguish it from all other SECURITY-CLASSIFICATIONs.
        /// </summary>
        /// <value>
        /// Value of the column security_clsfc_id
        /// </value>
        [AttrIx(100010)]
		[AttrName("security-classification-id")]
		[AttrColumnName("security_clsfc_id")]
        [AttrSeqnr(10)]
        [ForeignKey]
        [DomId(100000930)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? SecurityClassificationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column place_of_issue_txt
		///
		/// The character string assigned to represent the place of issue, which may be in code, for a specific PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column place_of_issue_txt
        /// </value>
        [AttrIx(100013)]
		[AttrName("plan-order-header-content-place-of-issue-text")]
		[AttrColumnName("place_of_issue_txt")]
        [AttrSeqnr(11)]
        [DomId(100001500)]
        [DataLength(100)]
        [DataDecimals(0)]
        string PlaceOfIssueText { get; set; }
		
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
        [AttrIx(100012)]
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
