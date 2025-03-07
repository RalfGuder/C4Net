using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionContextStatus that represents the table ACT_CONTXT_STAT
	/// 
	/// A record of the perceived state of a specific ACTION-CONTEXT as determined by the establishing organisation.
    /// </summary>
	[EntId(10000295)]
    [EntName("ACTION-CONTEXT-STATUS")]
    [EntTableName("ACT_CONTXT_STAT")]
    [EntDepth(3)]
    public interface IActionContextStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("action-id")]
		[AttrColumnName("act_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column contxt_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CONTEXT and to distinguish it from all other CONTEXTs.
        /// </summary>
        /// <value>
        /// Value of the column contxt_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("context-id")]
		[AttrColumnName("contxt_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000901)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ContextId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_contxt_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-CONTEXT for a specific ACTION and a specific CONTEXT and to distinguish it from all other ACTION-CONTEXTs for that ACTION and that CONTEXT.
        /// </summary>
        /// <value>
        /// Value of the column act_contxt_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-context-index")]
		[AttrColumnName("act_contxt_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionContextIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_contxt_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-CONTEXT-STATUS for a specific ACTION-CONTEXT and to distinguish it from all other ACTION-CONTEXT-STATUSs for that ACTION-CONTEXT.
        /// </summary>
        /// <value>
        /// Value of the column act_contxt_stat_ix
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-context-status-index")]
		[AttrColumnName("act_contxt_stat_ix")]
        [AttrSeqnr(4)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that indicates whether a specific ACTION-CONTEXT-STATUS refers to the beginning or termination of the association.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("action-context-status-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100004242)]
        [DataLength(6)]
        [DataDecimals(0)]
        AssociationStatusCategoryEnum ActionContextStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_dttm
		///
		/// The character string representing a point in time that designates the beginning of the period of effectiveness for a specific ACTION-CONTEXT-STATUS.
        /// </summary>
        /// <value>
        /// Value of the column effctv_dttm
        /// </value>
        [AttrIx(100006)]
		[AttrName("action-context-status-effective-datetime")]
		[AttrColumnName("effctv_dttm")]
        [AttrSeqnr(6)]
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
        [AttrIx(100007)]
		[AttrName("action-context-status-establishing-organisation-id")]
		[AttrColumnName("estblng_org_id")]
        [AttrSeqnr(7)]
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
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(8)]
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
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(9)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
