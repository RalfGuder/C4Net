using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Icing that represents the table ICING
	/// 
	/// A METEOROLOGIC-FEATURE that specifies the accumulation of frozen water on stationary or moving surfaces.
    /// </summary>
	[EntId(10000169)]
    [EntName("ICING")]
    [EntTableName("ICING")]
    [EntDepth(3)]
    public interface IIcing
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column icing_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column icing_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("icing-id")]
		[AttrColumnName("icing_id")]
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
		/// The specific value that represents the class of a particular ICING.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("icing-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [DomId(100000302)]
        [DataLength(6)]
        [DataDecimals(0)]
        IcingCategoryEnum? IcingCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column sev_qual_code
		///
		/// The specific value that represents the severity of a particular ICING.
        /// </summary>
        /// <value>
        /// Value of the column sev_qual_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("icing-severity-qualifier-code")]
		[AttrColumnName("sev_qual_code")]
        [AttrSeqnr(3)]
        [DomId(100000303)]
        [DataLength(6)]
        [DataDecimals(0)]
        IcingSeverityQualifierEnum? SeverityQualifier { get; set; }
		
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
