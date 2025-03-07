using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ComponentHeaderContent that represents the table CMPNT_HDR_CNTNT
	/// 
	/// Introductory subject matter intended to identify an element of a plan or order.
    /// </summary>
	[EntId(10000338)]
    [EntName("COMPONENT-HEADER-CONTENT")]
    [EntTableName("CMPNT_HDR_CNTNT")]
    [EntDepth(1)]
    public interface IComponentHeaderContent
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cmpnt_hdr_cntnt_id
		///
		/// The unique value, or set of characters, assigned to represent a specific COMPONENT-HEADER-CONTENT and to distinguish it from all other COMPONENT-HEADER-CONTENTs.
        /// </summary>
        /// <value>
        /// Value of the column cmpnt_hdr_cntnt_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("component-header-content-id")]
		[AttrColumnName("cmpnt_hdr_cntnt_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100000931)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column topic_heading_txt
		///
		/// The character string assigned to represent a user-defined topic in a specific COMPONENT-HEADER-CONTENT.
        /// </summary>
        /// <value>
        /// Value of the column topic_heading_txt
        /// </value>
        [AttrIx(100002)]
		[AttrName("component-header-content-topic-heading-text")]
		[AttrColumnName("topic_heading_txt")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100001500)]
        [DataLength(255)]
        [DataDecimals(0)]
        string TopicHeadingText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column security_clsfc_id
		///
		/// The unique value, or set of characters, assigned to represent a specific SECURITY-CLASSIFICATION and to distinguish it from all other SECURITY-CLASSIFICATIONs.
        /// </summary>
        /// <value>
        /// Value of the column security_clsfc_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("security-classification-id")]
		[AttrColumnName("security_clsfc_id")]
        [AttrSeqnr(3)]
        [ForeignKey]
        [DomId(100000930)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? SecurityClassificationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100004)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(4)]
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
        [AttrIx(100005)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
