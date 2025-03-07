using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity REPORTING-DATA that represents the table RPTD.
	///
	/// The specification of source, quality and timing that applies to reported data.
    /// </summary>
    [Serializable]
    [DefinitionName("ReportingData", "C4Net.JC3IEDM.Definitions.ReportingData.definition.xml")]
    public class ReportingData : IEntity, IReportingData
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ReportingDataExpression _ = new ReportingDataExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
		public decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column acc_code
		///
		/// The specific value that represents, for intelligence purpose, the general appraisal of the subject matter in graded terms to indicate the extent or degree to which it has been judged to be free from mistake or error or to conform to truth or some recognised standard value.
        /// </summary>
        /// <value>
        /// Value of the column acc_code
        /// </value>
		public ReportingDataAccuracyEnum? Accuracy { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents, for usual operational purposes, the nature of a specific REPORTING-DATA.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ReportingDataCategoryEnum ReportingDataCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cntg_ind_code
		///
		/// The specific value that denotes whether the data referred to by a specific REPORTING-DATA is based on a count of objects.
        /// </summary>
        /// <value>
        /// Value of the column cntg_ind_code
        /// </value>
		public ReportingDataCountingIndicatorEnum? CountingIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column credibility_code
		///
		/// The specific value that represents, for normal operational use, the degree of trustworthiness of the data referenced by a specific REPORTING-DATA.
        /// </summary>
        /// <value>
        /// Value of the column credibility_code
        /// </value>
		public ReportingDataCredibilityEnum? Credibility { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column reliability_code
		///
		/// The specific value that represents, for intelligence purpose, the general appraisal of the source in graded terms to indicate the extent to which it has been proven it can be counted on or trusted in to do as expected.
        /// </summary>
        /// <value>
        /// Value of the column reliability_code
        /// </value>
		public ReportingDataReliabilityEnum? Reliability { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rep_dttm
		///
		/// The character string representing a point in time that designates when the data referenced by the REPORTING-DATA is provided.
        /// </summary>
        /// <value>
        /// Value of the column rep_dttm
        /// </value>
		public string ReportingDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column source_type_code
		///
		/// The specific value that identifies the source type from which intelligence information is obtained and which is referred to by a specific REPORTING-DATA.
        /// </summary>
        /// <value>
        /// Value of the column source_type_code
        /// </value>
		public ReportingDataSourceTypeEnum? SourceType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column timing_cat_code
		///
		/// The specific value that represents the absolute, uncertain or relative timing for a specific REPORTING-DATA. It serves as a discriminator that partitions REPORTING-DATA into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column timing_cat_code
        /// </value>
		public ReportingDataTimingCategoryEnum TimingCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column real_data_exer_use_only_code
		///
		/// The specific value that determines whether a specific REPORTING-DATA refers to real data in an exercise scenario.
        /// </summary>
        /// <value>
        /// Value of the column real_data_exer_use_only_code
        /// </value>
		public ReportingDataRealDataExerciseUseOnlyEnum? RealDataExerciseUseOnly { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ref_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REFERENCE and to distinguish it from all other REFERENCEs.
        /// </summary>
        /// <value>
        /// Value of the column ref_id
        /// </value>
		public decimal? ReferenceId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rep_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column rep_org_id
        /// </value>
		public decimal ReportingOrganisationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ent_cat_code
		///
		/// The specific value that represents the physical name of the referenced table.
        /// </summary>
        /// <value>
        /// Value of the column ent_cat_code
        /// </value>
		public RptdEntCatEnum EntCatCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
		public decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
		public long UpdateSeqnr { get; set; }
		
        #endregion
    }
}
