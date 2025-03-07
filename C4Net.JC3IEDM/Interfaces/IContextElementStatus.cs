using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ContextElementStatus that represents the table CONTXT_ELMT_STAT
	/// 
	/// A record of the perceived state of a specific CONTEXT-ELEMENT as determined by the establishing organisation.
    /// </summary>
	[EntId(10000298)]
    [EntName("CONTEXT-ELEMENT-STATUS")]
    [EntTableName("CONTXT_ELMT_STAT")]
    [EntDepth(4)]
    public interface IContextElementStatus
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
        [ForeignKey]
        [Mandatory]
        [DomId(100000901)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ContextId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column contxt_elmt_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific CONTEXT-ELEMENT for a specific CONTEXT and to distinguish it from all other CONTEXT-ELEMENTs for that CONTEXT.
        /// </summary>
        /// <value>
        /// Value of the column contxt_elmt_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("context-element-index")]
		[AttrColumnName("contxt_elmt_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ContextElementIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column contxt_elmt_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific CONTEXT-ELEMENT-STATUS for a specific CONTEXT-ELEMENT and to distinguish it from all other CONTEXT-ELEMENT-STATUSs for that CONTEXT-ELEMENT.
        /// </summary>
        /// <value>
        /// Value of the column contxt_elmt_stat_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("context-element-status-index")]
		[AttrColumnName("contxt_elmt_stat_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that indicates whether a specific CONTEXT-ELEMENT-STATUS refers to the addition or removal of the CONTEXT-ELEMENT from the CONTEXT.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("context-element-status-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100004245)]
        [DataLength(6)]
        [DataDecimals(0)]
        ContextElementStatusCategoryEnum ContextElementStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_dttm
		///
		/// The character string representing a point in time that designates the beginning of the period of effectiveness for a specific CONTEXT-ELEMENT-STATUS.
        /// </summary>
        /// <value>
        /// Value of the column effctv_dttm
        /// </value>
        [AttrIx(100005)]
		[AttrName("context-element-status-effective-datetime")]
		[AttrColumnName("effctv_dttm")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string EffectiveDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column estblng_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column estblng_org_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("context-element-status-establishing-organisation-id")]
		[AttrColumnName("estblng_org_id")]
        [AttrSeqnr(6)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal EstablishingOrganisationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(7)]
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
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(8)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
