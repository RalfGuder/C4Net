using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionEffect that represents the table ACT_EFFECT
	/// 
	/// A perceived effectiveness of a specific ACTION against a specific battlespace object or its class.
    /// </summary>
	[EntId(10000006)]
    [EntName("ACTION-EFFECT")]
    [EntTableName("ACT_EFFECT")]
    [EntDepth(3)]
    public interface IActionEffect
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
        /// Gets or sets the value of the column act_effect_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-EFFECT for a specific ACTION and to distinguish it from all other ACTION-EFFECTs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_effect_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-effect-index")]
		[AttrColumnName("act_effect_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ACTION-EFFECT with respect to item or type. It serves as a discriminator that partitions ACTION-EFFECT into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-effect-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000113)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionEffectCategoryEnum ActionEffectCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column descr_code
		///
		/// The specific value that represents the type of outcome of a specific ACTION that is being estimated or recorded.
        /// </summary>
        /// <value>
        /// Value of the column descr_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-effect-description-code")]
		[AttrColumnName("descr_code")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000112)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionEffectDescriptionEnum Description { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column sev_code
		///
		/// The specific value that represents the degree of seriousness of a specific ACTION-EFFECT.
        /// </summary>
        /// <value>
        /// Value of the column sev_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("action-effect-severity-code")]
		[AttrColumnName("sev_code")]
        [AttrSeqnr(5)]
        [DomId(100000387)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionEffectSeverityEnum? Severity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("reporting-data-id")]
		[AttrColumnName("rptd_id")]
        [AttrSeqnr(6)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000912)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ReportingDataId { get; set; }
		
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
