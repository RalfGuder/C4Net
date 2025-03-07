using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity PersonIdentificationDocument that represents the table PERS_IDENTIFIC_DOC
	/// 
	/// A document used to identify a specific PERSON.
    /// </summary>
	[EntId(10000207)]
    [EntName("PERSON-IDENTIFICATION-DOCUMENT")]
    [EntTableName("PERS_IDENTIFIC_DOC")]
    [EntDepth(2)]
    public interface IPersonIdentificationDocument
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column pers_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column pers_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("person-id")]
		[AttrColumnName("pers_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal PersonId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pers_identific_doc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PERSON-IDENTIFICATION-DOCUMENT for a specific PERSON and to distinguish it from all other PERSON-IDENTIFICATION-DOCUMENTs for that PERSON.
        /// </summary>
        /// <value>
        /// Value of the column pers_identific_doc_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("person-identification-document-index")]
		[AttrColumnName("pers_identific_doc_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column code
		///
		/// The specific value that represents the type of document used to identify a specific PERSON.
        /// </summary>
        /// <value>
        /// Value of the column code
        /// </value>
        [AttrIx(100003)]
		[AttrName("person-identification-document-code")]
		[AttrColumnName("code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000381)]
        [DataLength(6)]
        [DataDecimals(0)]
        PersonIdentificationDocumentEnum PersonIdentificationDocumentCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column no_txt
		///
		/// The character string assigned to represent the identifying number of the specific document used to identify a PERSON.
        /// </summary>
        /// <value>
        /// Value of the column no_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("person-identification-document-number-text")]
		[AttrColumnName("no_txt")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string NumberText { get; set; }
		
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
