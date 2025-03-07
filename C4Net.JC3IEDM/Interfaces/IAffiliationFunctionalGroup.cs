using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity AffiliationFunctionalGroup that represents the table AFFL_FUNCTL_GROUP
	/// 
	/// A specification of a functional group characterised by its primary purpose to which membership or allegiance may be ascribed.
    /// </summary>
	[EntId(10000257)]
    [EntName("AFFILIATION-FUNCTIONAL-GROUP")]
    [EntTableName("AFFL_FUNCTL_GROUP")]
    [EntDepth(1)]
    public interface IAffiliationFunctionalGroup
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column affl_id
		///
		/// The unique value, or set of characters, assigned to represent a specific AFFILIATION and to distinguish it from all other AFFILIATIONs.
        /// </summary>
        /// <value>
        /// Value of the column affl_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("affiliation-id")]
		[AttrColumnName("affl_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000919)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal AffiliationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column code
		///
		/// The specific value that represents the category of functional group.
        /// </summary>
        /// <value>
        /// Value of the column code
        /// </value>
        [AttrIx(100002)]
		[AttrName("affiliation-functional-group-code")]
		[AttrColumnName("code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004161)]
        [DataLength(6)]
        [DataDecimals(0)]
        AffiliationFunctionalGroupEnum AffiliationFunctionalGroupCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column name_txt
		///
		/// The character string assigned to represent a specific AFFILIATION-FUNCTIONAL-GROUP.
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
        [AttrIx(100003)]
		[AttrName("affiliation-functional-group-name-text")]
		[AttrColumnName("name_txt")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string NameText { get; set; }
		
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
