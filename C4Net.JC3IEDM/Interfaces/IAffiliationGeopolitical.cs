using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity AffiliationGeopolitical that represents the table AFFL_GEOPOLITICAL
	/// 
	/// A specification of a country or political entity to which membership or allegiance may be ascribed.
    /// </summary>
	[EntId(10000258)]
    [EntName("AFFILIATION-GEOPOLITICAL")]
    [EntTableName("AFFL_GEOPOLITICAL")]
    [EntDepth(1)]
    public interface IAffiliationGeopolitical
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
		/// The specific value that represents the identification of the independent first-level geographic-political area and its dependencies, areas of quasi-independence, and areas with special unrecognised sovereignty, including outlying and disputed areas.
        /// </summary>
        /// <value>
        /// Value of the column code
        /// </value>
        [AttrIx(100002)]
		[AttrName("affiliation-geopolitical-code")]
		[AttrColumnName("code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000247)]
        [DataLength(6)]
        [DataDecimals(0)]
        AffiliationGeopoliticalEnum AffiliationGeopoliticalCode { get; set; }
		
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
