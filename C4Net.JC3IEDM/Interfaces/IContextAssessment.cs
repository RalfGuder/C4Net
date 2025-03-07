using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ContextAssessment that represents the table CONTXT_ASSESS
	/// 
	/// A record of appraisal by a specific ORGANISATION regarding the information that is referenced by a specific instance of CONTEXT.
    /// </summary>
	[EntId(10000030)]
    [EntName("CONTEXT-ASSESSMENT")]
    [EntTableName("CONTXT_ASSESS")]
    [EntDepth(3)]
    public interface IContextAssessment
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
        /// Gets or sets the value of the column contxt_assess_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific CONTEXT-ASSESSMENT for a specific CONTEXT and to distinguish it from all other CONTEXT-ASSESSMENTs for that CONTEXT.
        /// </summary>
        /// <value>
        /// Value of the column contxt_assess_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("context-assessment-index")]
		[AttrColumnName("contxt_assess_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column txt
		///
		/// The character string assigned to represent an appraisal regarding the information that is referenced by a specific instance of CONTEXT.
        /// </summary>
        /// <value>
        /// Value of the column txt
        /// </value>
        [AttrIx(100003)]
		[AttrName("context-assessment-text")]
		[AttrColumnName("txt")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100001500)]
        [DataLength(4000)]
        [DataDecimals(0)]
        string Text { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column limiting_factors_code
		///
		/// The specific value that represents the logistic factors, which are degrading operational capability in a specific CONTEXT-ASSESSMENT.
        /// </summary>
        /// <value>
        /// Value of the column limiting_factors_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("context-assessment-limiting-factors-code")]
		[AttrColumnName("limiting_factors_code")]
        [AttrSeqnr(4)]
        [DomId(100004331)]
        [DataLength(6)]
        [DataDecimals(0)]
        ContextAssessmentLimitingFactorsEnum? LimitingFactors { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("reporting-data-id")]
		[AttrColumnName("rptd_id")]
        [AttrSeqnr(5)]
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
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(6)]
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
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(7)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
