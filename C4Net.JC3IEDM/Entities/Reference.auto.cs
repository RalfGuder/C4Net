using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity REFERENCE that represents the table REF.
	///
	/// Identification of a record of information.
    /// </summary>
    [Serializable]
    [DefinitionName("Reference", "C4Net.JC3IEDM.Definitions.Reference.definition.xml")]
    public class Reference : IEntity, IReference
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ReferenceExpression _ = new ReferenceExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column ref_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REFERENCE and to distinguish it from all other REFERENCEs.
        /// </summary>
        /// <value>
        /// Value of the column ref_id
        /// </value>
		public decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column app_dttm
		///
		/// The character string representing a point in time that designates the date when the artefact that is cited in a specific REFERENCE was approved.
        /// </summary>
        /// <value>
        /// Value of the column app_dttm
        /// </value>
		public string ApprovalDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cntnt_cat_code
		///
		/// The specific value that represents the classification of the general content of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column cntnt_cat_code
        /// </value>
		public ReferenceContentCategoryEnum? ContentCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creation_dttm
		///
		/// The character string representing a point in time that designates the creation date for the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column creation_dttm
        /// </value>
		public string CreationDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column descr_txt
		///
		/// The character string assigned to represent a description of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column descr_txt
        /// </value>
		public string DescriptionText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column elctrnc_source_txt
		///
		/// The character string assigned to represent the electronic source of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column elctrnc_source_txt
        /// </value>
		public string ElectronicSourceText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column file_size_qty
		///
		/// The numeric value that represents the size of an electronic version of the artefact cited in a specific REFERENCE. The unit of measure is kilobyte.
        /// </summary>
        /// <value>
        /// Value of the column file_size_qty
        /// </value>
		public int? FileSizeQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column format_txt
		///
		/// The character string assigned to represent the data format of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column format_txt
        /// </value>
		public string FormatText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lang_code
		///
		/// The specific value that identifies the language used in the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column lang_code
        /// </value>
		public LanguageCategoryEnum? Language { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lifecycle_code
		///
		/// The specific value that represents the lifecycle of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column lifecycle_code
        /// </value>
		public ReferenceLifecycleEnum? Lifecycle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column medium_type_code
		///
		/// The specific value that represents the type of medium of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column medium_type_code
        /// </value>
		public ReferenceMediumTypeEnum? MediumType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column originator_txt
		///
		/// The character string assigned to represent the identity of the originator of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column originator_txt
        /// </value>
		public string OriginatorText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column physcl_size_txt
		///
		/// The character string assigned to represent the size of a physical version of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column physcl_size_txt
        /// </value>
		public string PhysicalSizeText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prim_loc_txt
		///
		/// The character string assigned to represent the identity of the primary physical or electronic location of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column prim_loc_txt
        /// </value>
		public string PrimaryLocationText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column publication_dttm
		///
		/// The character string representing a point in time that designates the date of publication for the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column publication_dttm
        /// </value>
		public string PublicationDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column releasability_txt
		///
		/// The character string assigned to represent the releasability restrictions for the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column releasability_txt
        /// </value>
		public string ReleasabilityText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column short_title_txt
		///
		/// The character string assigned to represent an abbreviated title or name of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column short_title_txt
        /// </value>
		public string ShortTitleText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column title_txt
		///
		/// The character string assigned to represent the name of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column title_txt
        /// </value>
		public string TitleText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column trans_type_code
		///
		/// The specific value that represents the means by which the artefact cited in a specific REFERENCE is transmitted to the recipient.
        /// </summary>
        /// <value>
        /// Value of the column trans_type_code
        /// </value>
		public ReferenceTransmittalTypeEnum? TransmittalType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column validity_period_begin_dttm
		///
		/// The character string representing a point in time that designates the beginning of the period of validity for the content in the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column validity_period_begin_dttm
        /// </value>
		public string ValidityPeriodBeginDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column validity_period_end_dttm
		///
		/// The character string representing a point in time that designates the end of the period of validity for the content in the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column validity_period_end_dttm
        /// </value>
		public string ValidityPeriodEndDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column verf_code
		///
		/// The specific value that represents the verification of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column verf_code
        /// </value>
		public ReferenceVerificationEnum? Verification { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column version_txt
		///
		/// The character string assigned to represent the identification of the version of the artefact cited in a specific REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column version_txt
        /// </value>
		public string VersionText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column security_clsfc_id
		///
		/// The unique value, or set of characters, assigned to represent a specific SECURITY-CLASSIFICATION and to distinguish it from all other SECURITY-CLASSIFICATIONs.
        /// </summary>
        /// <value>
        /// Value of the column security_clsfc_id
        /// </value>
		public decimal? SecurityClassificationId { get; set; }
		
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
