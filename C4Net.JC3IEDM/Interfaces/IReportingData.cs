using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ReportingData that represents the table RPTD
	/// 
	/// The specification of source, quality and timing that applies to reported data.
    /// </summary>
	[EntId(10000157)]
    [EntName("REPORTING-DATA")]
    [EntTableName("RPTD")]
    [EntDepth(2)]
    public interface IReportingData
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("reporting-data-id")]
		[AttrColumnName("rptd_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100000912)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column acc_code
		///
		/// The specific value that represents, for intelligence purpose, the general appraisal of the subject matter in graded terms to indicate the extent or degree to which it has been judged to be free from mistake or error or to conform to truth or some recognised standard value.
        /// </summary>
        /// <value>
        /// Value of the column acc_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("reporting-data-accuracy-code")]
		[AttrColumnName("acc_code")]
        [AttrSeqnr(2)]
        [DomId(100000316)]
        [DataLength(6)]
        [DataDecimals(0)]
        ReportingDataAccuracyEnum? Accuracy { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents, for usual operational purposes, the nature of a specific REPORTING-DATA.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("reporting-data-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000294)]
        [DataLength(6)]
        [DataDecimals(0)]
        ReportingDataCategoryEnum ReportingDataCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cntg_ind_code
		///
		/// The specific value that denotes whether the data referred to by a specific REPORTING-DATA is based on a count of objects.
        /// </summary>
        /// <value>
        /// Value of the column cntg_ind_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("reporting-data-counting-indicator-code")]
		[AttrColumnName("cntg_ind_code")]
        [AttrSeqnr(4)]
        [DomId(100000278)]
        [DataLength(6)]
        [DataDecimals(0)]
        ReportingDataCountingIndicatorEnum? CountingIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column credibility_code
		///
		/// The specific value that represents, for normal operational use, the degree of trustworthiness of the data referenced by a specific REPORTING-DATA.
        /// </summary>
        /// <value>
        /// Value of the column credibility_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("reporting-data-credibility-code")]
		[AttrColumnName("credibility_code")]
        [AttrSeqnr(5)]
        [DomId(100000279)]
        [DataLength(6)]
        [DataDecimals(0)]
        ReportingDataCredibilityEnum? Credibility { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column reliability_code
		///
		/// The specific value that represents, for intelligence purpose, the general appraisal of the source in graded terms to indicate the extent to which it has been proven it can be counted on or trusted in to do as expected.
        /// </summary>
        /// <value>
        /// Value of the column reliability_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("reporting-data-reliability-code")]
		[AttrColumnName("reliability_code")]
        [AttrSeqnr(6)]
        [DomId(100000317)]
        [DataLength(6)]
        [DataDecimals(0)]
        ReportingDataReliabilityEnum? Reliability { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rep_dttm
		///
		/// The character string representing a point in time that designates when the data referenced by the REPORTING-DATA is provided.
        /// </summary>
        /// <value>
        /// Value of the column rep_dttm
        /// </value>
        [AttrIx(100007)]
		[AttrName("reporting-data-reporting-datetime")]
		[AttrColumnName("rep_dttm")]
        [AttrSeqnr(7)]
        [Mandatory]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string ReportingDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column source_type_code
		///
		/// The specific value that identifies the source type from which intelligence information is obtained and which is referred to by a specific REPORTING-DATA.
        /// </summary>
        /// <value>
        /// Value of the column source_type_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("reporting-data-source-type-code")]
		[AttrColumnName("source_type_code")]
        [AttrSeqnr(8)]
        [DomId(100000318)]
        [DataLength(6)]
        [DataDecimals(0)]
        ReportingDataSourceTypeEnum? SourceType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column timing_cat_code
		///
		/// The specific value that represents the absolute, uncertain or relative timing for a specific REPORTING-DATA. It serves as a discriminator that partitions REPORTING-DATA into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column timing_cat_code
        /// </value>
        [AttrIx(100009)]
		[AttrName("reporting-data-timing-category-code")]
		[AttrColumnName("timing_cat_code")]
        [AttrSeqnr(9)]
        [Mandatory]
        [DomId(100000291)]
        [DataLength(6)]
        [DataDecimals(0)]
        ReportingDataTimingCategoryEnum TimingCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column real_data_exer_use_only_code
		///
		/// The specific value that determines whether a specific REPORTING-DATA refers to real data in an exercise scenario.
        /// </summary>
        /// <value>
        /// Value of the column real_data_exer_use_only_code
        /// </value>
        [AttrIx(100010)]
		[AttrName("reporting-data-real-data-exercise-use-only-code")]
		[AttrColumnName("real_data_exer_use_only_code")]
        [AttrSeqnr(10)]
        [DomId(100004311)]
        [DataLength(6)]
        [DataDecimals(0)]
        ReportingDataRealDataExerciseUseOnlyEnum? RealDataExerciseUseOnly { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ref_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REFERENCE and to distinguish it from all other REFERENCEs.
        /// </summary>
        /// <value>
        /// Value of the column ref_id
        /// </value>
        [AttrIx(100011)]
		[AttrName("reference-id")]
		[AttrColumnName("ref_id")]
        [AttrSeqnr(11)]
        [ForeignKey]
        [DomId(100000911)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? ReferenceId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rep_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column rep_org_id
        /// </value>
        [AttrIx(100012)]
		[AttrName("reporting-data-reporting-organisation-id")]
		[AttrColumnName("rep_org_id")]
        [AttrSeqnr(12)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ReportingOrganisationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ent_cat_code
		///
		/// The specific value that represents the physical name of the referenced table.
        /// </summary>
        /// <value>
        /// Value of the column ent_cat_code
        /// </value>
        [AttrIx(100013)]
		[AttrName("physical model only")]
		[AttrColumnName("ent_cat_code")]
        [AttrSeqnr(13)]
        [Mandatory]
        [DomId(100004131)]
        [DataLength(6)]
        [DataDecimals(0)]
        RptdEntCatEnum EntCatCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100014)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(14)]
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
        [AttrIx(100015)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(15)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
