using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity AffiliationEthnicGroup that represents the table AFFL_ETHNIC_GROUP
	/// 
	/// A specification of an ethnic group to which membership or allegiance may be ascribed.
    /// </summary>
	[EntId(10000255)]
    [EntName("AFFILIATION-ETHNIC-GROUP")]
    [EntTableName("AFFL_ETHNIC_GROUP")]
    [EntDepth(1)]
    public interface IAffiliationEthnicGroup
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
		/// The specific value that represents an ethnic group in a specific AFFILIATION-ETHNIC-GROUP.
        /// </summary>
        /// <value>
        /// Value of the column code
        /// </value>
        [AttrIx(100002)]
		[AttrName("affiliation-ethnic-group-code")]
		[AttrColumnName("code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004129)]
        [DataLength(6)]
        [DataDecimals(0)]
        AffiliationEthnicGroupEnum AffiliationEthnicGroupCode { get; set; }
		
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
