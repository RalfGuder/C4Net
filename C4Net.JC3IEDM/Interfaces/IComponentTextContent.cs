using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ComponentTextContent that represents the table CMPNT_TXT_CNTNT
	/// 
	/// A textual statement of substantive subject matter.
    /// </summary>
	[EntId(10000339)]
    [EntName("COMPONENT-TEXT-CONTENT")]
    [EntTableName("CMPNT_TXT_CNTNT")]
    [EntDepth(0)]
    public interface IComponentTextContent
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cmpnt_txt_cntnt_id
		///
		/// The unique value, or set of characters, assigned to represent a specific COMPONENT-TEXT-CONTENT and to distinguish it from all other COMPONENT-TEXT-CONTENTs.
        /// </summary>
        /// <value>
        /// Value of the column cmpnt_txt_cntnt_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("component-text-content-id")]
		[AttrColumnName("cmpnt_txt_cntnt_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100000932)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column txt
		///
		/// The character string that is the substantive textual content for a specific COMPONENT-TEXT-CONTENT.
        /// </summary>
        /// <value>
        /// Value of the column txt
        /// </value>
        [AttrIx(100002)]
		[AttrName("component-text-content-text")]
		[AttrColumnName("txt")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100001500)]
        [DataLength(4000)]
        [DataDecimals(0)]
        string Text { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(3)]
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
        [AttrIx(100004)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
