using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ReferenceAssociation that represents the table REF_ASSOC
	/// 
	/// A relationship of a REFERENCE as a subject with another REFERENCE as an object.
    /// </summary>
	[EntId(10000291)]
    [EntName("REFERENCE-ASSOCIATION")]
    [EntTableName("REF_ASSOC")]
    [EntDepth(2)]
    public interface IReferenceAssociation
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column subj_ref_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REFERENCE and to distinguish it from all other REFERENCEs.
        /// </summary>
        /// <value>
        /// Value of the column subj_ref_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("reference-association-subject-reference-id")]
		[AttrColumnName("subj_ref_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000911)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal SubjectReferenceId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_ref_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REFERENCE and to distinguish it from all other REFERENCEs.
        /// </summary>
        /// <value>
        /// Value of the column obj_ref_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("reference-association-object-reference-id")]
		[AttrColumnName("obj_ref_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000911)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectReferenceId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ref_assoc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific REFERENCE-ASSOCIATION for a subject REFERENCE and an object REFERENCE and to distinguish it from all other REFERENCE-ASSOCIATIONs for those REFERENCEs.
        /// </summary>
        /// <value>
        /// Value of the column ref_assoc_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("reference-association-index")]
		[AttrColumnName("ref_assoc_ix")]
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
		/// The specific value that represents the class of relationship between a subject REFERENCE and an object REFERENCE for a specific REFERENCE-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("reference-association-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(4)]
        [DomId(100004231)]
        [DataLength(6)]
        [DataDecimals(0)]
        ReferenceAssociationCategoryEnum? ReferenceAssociationCategory { get; set; }
		
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
