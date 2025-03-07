using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Reference that represents the table REF
	/// 
	/// Identification of a record of information.
    /// </summary>
	[EntId(10000147)]
    [EntName("REFERENCE")]
    [EntTableName("REF")]
    [EntDepth(1)]
    public interface IReference
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column ref_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REFERENCE and to distinguish it from all other REFERENCEs.
        /// </summary>
        /// <value>
        /// Value of the column ref_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("reference-id")]
		[AttrColumnName("ref_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100000911)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column app_dttm
		///
		/// The character string representing a point in time that designates the date when the artefact that is cited in a specific REFERENCE was approved.
        /// </summary>
        /// <value>
        /// Value of the column app_dttm
        /// </value>
        [AttrIx(100002)]
		[AttrName("reference-approval-datetime")]
		[AttrColumnName("app_dttm")]
        [AttrSeqnr(2)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string ApprovalDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cntnt_cat_code
		///
		/// The specific value that represents the classification of the general content of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column cntnt_cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("reference-content-category-code")]
		[AttrColumnName("cntnt_cat_code")]
        [AttrSeqnr(3)]
        [DomId(100004232)]
        [DataLength(6)]
        [DataDecimals(0)]
        ReferenceContentCategoryEnum? ContentCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creation_dttm
		///
		/// The character string representing a point in time that designates the creation date for the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column creation_dttm
        /// </value>
        [AttrIx(100004)]
		[AttrName("reference-creation-datetime")]
		[AttrColumnName("creation_dttm")]
        [AttrSeqnr(4)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string CreationDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column descr_txt
		///
		/// The character string assigned to represent a description of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column descr_txt
        /// </value>
        [AttrIx(100005)]
		[AttrName("reference-description-text")]
		[AttrColumnName("descr_txt")]
        [AttrSeqnr(5)]
        [DomId(100001500)]
        [DataLength(255)]
        [DataDecimals(0)]
        string DescriptionText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column elctrnc_source_txt
		///
		/// The character string assigned to represent the electronic source of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column elctrnc_source_txt
        /// </value>
        [AttrIx(100006)]
		[AttrName("reference-electronic-source-text")]
		[AttrColumnName("elctrnc_source_txt")]
        [AttrSeqnr(6)]
        [DomId(100001500)]
        [DataLength(2000)]
        [DataDecimals(0)]
        string ElectronicSourceText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column file_size_qty
		///
		/// The numeric value that represents the size of an electronic version of the artefact cited in a specific REFERENCE. The unit of measure is kilobyte.
        /// </summary>
        /// <value>
        /// Value of the column file_size_qty
        /// </value>
        [AttrIx(100007)]
		[AttrName("reference-file-size-quantity")]
		[AttrColumnName("file_size_qty")]
        [AttrSeqnr(7)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? FileSizeQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column format_txt
		///
		/// The character string assigned to represent the data format of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column format_txt
        /// </value>
        [AttrIx(100008)]
		[AttrName("reference-format-text")]
		[AttrColumnName("format_txt")]
        [AttrSeqnr(8)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string FormatText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lang_code
		///
		/// The specific value that identifies the language used in the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column lang_code
        /// </value>
        [AttrIx(100009)]
		[AttrName("reference-language-code")]
		[AttrColumnName("lang_code")]
        [AttrSeqnr(9)]
        [DomId(100000395)]
        [DataLength(6)]
        [DataDecimals(0)]
        LanguageCategoryEnum? Language { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lifecycle_code
		///
		/// The specific value that represents the lifecycle of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column lifecycle_code
        /// </value>
        [AttrIx(100010)]
		[AttrName("reference-lifecycle-code")]
		[AttrColumnName("lifecycle_code")]
        [AttrSeqnr(10)]
        [DomId(100004233)]
        [DataLength(6)]
        [DataDecimals(0)]
        ReferenceLifecycleEnum? Lifecycle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column medium_type_code
		///
		/// The specific value that represents the type of medium of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column medium_type_code
        /// </value>
        [AttrIx(100011)]
		[AttrName("reference-medium-type-code")]
		[AttrColumnName("medium_type_code")]
        [AttrSeqnr(11)]
        [DomId(100004234)]
        [DataLength(6)]
        [DataDecimals(0)]
        ReferenceMediumTypeEnum? MediumType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column originator_txt
		///
		/// The character string assigned to represent the identity of the originator of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column originator_txt
        /// </value>
        [AttrIx(100012)]
		[AttrName("reference-originator-text")]
		[AttrColumnName("originator_txt")]
        [AttrSeqnr(12)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string OriginatorText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column physcl_size_txt
		///
		/// The character string assigned to represent the size of a physical version of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column physcl_size_txt
        /// </value>
        [AttrIx(100013)]
		[AttrName("reference-physical-size-text")]
		[AttrColumnName("physcl_size_txt")]
        [AttrSeqnr(13)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string PhysicalSizeText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prim_loc_txt
		///
		/// The character string assigned to represent the identity of the primary physical or electronic location of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column prim_loc_txt
        /// </value>
        [AttrIx(100014)]
		[AttrName("reference-primary-location-text")]
		[AttrColumnName("prim_loc_txt")]
        [AttrSeqnr(14)]
        [DomId(100001500)]
        [DataLength(2000)]
        [DataDecimals(0)]
        string PrimaryLocationText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column publication_dttm
		///
		/// The character string representing a point in time that designates the date of publication for the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column publication_dttm
        /// </value>
        [AttrIx(100015)]
		[AttrName("reference-publication-datetime")]
		[AttrColumnName("publication_dttm")]
        [AttrSeqnr(15)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string PublicationDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column releasability_txt
		///
		/// The character string assigned to represent the releasability restrictions for the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column releasability_txt
        /// </value>
        [AttrIx(100016)]
		[AttrName("reference-releasability-text")]
		[AttrColumnName("releasability_txt")]
        [AttrSeqnr(16)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string ReleasabilityText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column short_title_txt
		///
		/// The character string assigned to represent an abbreviated title or name of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column short_title_txt
        /// </value>
        [AttrIx(100017)]
		[AttrName("reference-short-title-text")]
		[AttrColumnName("short_title_txt")]
        [AttrSeqnr(17)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string ShortTitleText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column title_txt
		///
		/// The character string assigned to represent the name of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column title_txt
        /// </value>
        [AttrIx(100018)]
		[AttrName("reference-title-text")]
		[AttrColumnName("title_txt")]
        [AttrSeqnr(18)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string TitleText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column trans_type_code
		///
		/// The specific value that represents the means by which the artefact cited in a specific REFERENCE is transmitted to the recipient.
        /// </summary>
        /// <value>
        /// Value of the column trans_type_code
        /// </value>
        [AttrIx(100019)]
		[AttrName("reference-transmittal-type-code")]
		[AttrColumnName("trans_type_code")]
        [AttrSeqnr(19)]
        [DomId(100000293)]
        [DataLength(6)]
        [DataDecimals(0)]
        ReferenceTransmittalTypeEnum? TransmittalType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column validity_period_begin_dttm
		///
		/// The character string representing a point in time that designates the beginning of the period of validity for the content in the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column validity_period_begin_dttm
        /// </value>
        [AttrIx(100020)]
		[AttrName("reference-validity-period-begin-datetime")]
		[AttrColumnName("validity_period_begin_dttm")]
        [AttrSeqnr(20)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string ValidityPeriodBeginDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column validity_period_end_dttm
		///
		/// The character string representing a point in time that designates the end of the period of validity for the content in the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column validity_period_end_dttm
        /// </value>
        [AttrIx(100021)]
		[AttrName("reference-validity-period-end-datetime")]
		[AttrColumnName("validity_period_end_dttm")]
        [AttrSeqnr(21)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string ValidityPeriodEndDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column verf_code
		///
		/// The specific value that represents the verification of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column verf_code
        /// </value>
        [AttrIx(100022)]
		[AttrName("reference-verification-code")]
		[AttrColumnName("verf_code")]
        [AttrSeqnr(22)]
        [DomId(100004312)]
        [DataLength(6)]
        [DataDecimals(0)]
        ReferenceVerificationEnum? Verification { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column version_txt
		///
		/// The character string assigned to represent the identification of the version of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column version_txt
        /// </value>
        [AttrIx(100023)]
		[AttrName("reference-version-text")]
		[AttrColumnName("version_txt")]
        [AttrSeqnr(23)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string VersionText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column security_clsfc_id
		///
		/// The unique value, or set of characters, assigned to represent a specific SECURITY-CLASSIFICATION and to distinguish it from all other SECURITY-CLASSIFICATIONs.
        /// </summary>
        /// <value>
        /// Value of the column security_clsfc_id
        /// </value>
        [AttrIx(100024)]
		[AttrName("security-classification-id")]
		[AttrColumnName("security_clsfc_id")]
        [AttrSeqnr(24)]
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
        [AttrIx(100025)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(25)]
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
        [AttrIx(100026)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(26)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
