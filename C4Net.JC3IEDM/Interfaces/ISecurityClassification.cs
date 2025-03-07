using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity SecurityClassification that represents the table SECURITY_CLSFC
	/// 
	/// The security classification applicable to an information resource within the domain of classified security information.
    /// </summary>
	[EntId(10000337)]
    [EntName("SECURITY-CLASSIFICATION")]
    [EntTableName("SECURITY_CLSFC")]
    [EntDepth(0)]
    public interface ISecurityClassification
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column security_clsfc_id
		///
		/// The unique value, or set of characters, assigned to represent a specific SECURITY-CLASSIFICATION and to distinguish it from all other SECURITY-CLASSIFICATIONs.
        /// </summary>
        /// <value>
        /// Value of the column security_clsfc_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("security-classification-id")]
		[AttrColumnName("security_clsfc_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100000930)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lvl_code
		///
		/// The specific value that represents the security classification level for the information resource.
        /// </summary>
        /// <value>
        /// Value of the column lvl_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("security-classification-level-code")]
		[AttrColumnName("lvl_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004381)]
        [DataLength(6)]
        [DataDecimals(0)]
        SecurityClassificationLevelEnum Level { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column policy_txt
		///
		/// The character string assigned to represent the organisation that defines the rules relating to the security handling for the information resource.
        /// </summary>
        /// <value>
        /// Value of the column policy_txt
        /// </value>
        [AttrIx(100003)]
		[AttrName("security-classification-policy-text")]
		[AttrColumnName("policy_txt")]
        [AttrSeqnr(3)]
        [DomId(100001500)]
        [DataLength(100)]
        [DataDecimals(0)]
        string PolicyText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column caveat_txt
		///
		/// The character string assigned to represent, for the information resource, an indication of an additional specific sensitivity, a dissemination control, or an informal marking.
        /// </summary>
        /// <value>
        /// Value of the column caveat_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("security-classification-caveat-text")]
		[AttrColumnName("caveat_txt")]
        [AttrSeqnr(4)]
        [DomId(100001500)]
        [DataLength(100)]
        [DataDecimals(0)]
        string CaveatText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(5)]
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
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
