using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Context that represents the table CONTXT
	/// 
	/// A collection of information that provides in its entirety the circumstances, conditions, environment, or perspective for a situation.
    /// </summary>
	[EntId(10000029)]
    [EntName("CONTEXT")]
    [EntTableName("CONTXT")]
    [EntDepth(1)]
    public interface IContext
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column contxt_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CONTEXT and to distinguish it from all other CONTEXTs.
        /// </summary>
        /// <value>
        /// Value of the column contxt_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("context-id")]
		[AttrColumnName("contxt_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100000901)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of CONTEXT. It serves as a discriminator that partitions CONTEXT into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("context-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004244)]
        [DataLength(6)]
        [DataDecimals(0)]
        ContextCategoryEnum ContextCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column name_txt
		///
		/// The character string assigned to represent a specific CONTEXT.
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
        [AttrIx(100003)]
		[AttrName("context-name-text")]
		[AttrColumnName("name_txt")]
        [AttrSeqnr(3)]
        [DomId(100001500)]
        [DataLength(80)]
        [DataDecimals(0)]
        string NameText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column security_clsfc_id
		///
		/// The unique value, or set of characters, assigned to represent a specific SECURITY-CLASSIFICATION and to distinguish it from all other SECURITY-CLASSIFICATIONs.
        /// </summary>
        /// <value>
        /// Value of the column security_clsfc_id
        /// </value>
        [AttrIx(100004)]
		[AttrName("security-classification-id")]
		[AttrColumnName("security_clsfc_id")]
        [AttrSeqnr(4)]
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
