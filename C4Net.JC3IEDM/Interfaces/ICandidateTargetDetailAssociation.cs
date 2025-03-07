using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity CandidateTargetDetailAssociation that represents the table CTGTDET_ASSOC
	/// 
	/// A relationship of a CANDIDATE-TARGET-DETAIL as a subject with another CANDIDATE-TARGET-DETAIL as an object.
    /// </summary>
	[EntId(10000140)]
    [EntName("CANDIDATE-TARGET-DETAIL-ASSOCIATION")]
    [EntTableName("CTGTDET_ASSOC")]
    [EntDepth(5)]
    public interface ICandidateTargetDetailAssociation
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column subj_ctgtlst_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-LISTs.
        /// </summary>
        /// <value>
        /// Value of the column subj_ctgtlst_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("candidate-target-detail-association-subject-candidate-target-list-id")]
		[AttrColumnName("subj_ctgtlst_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000910)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal SubjectCandidateTargetListId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subj_ctgtdet_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-DETAIL for a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-DETAILs for that CANDIDATE-TARGET-LIST.
        /// </summary>
        /// <value>
        /// Value of the column subj_ctgtdet_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("candidate-target-detail-association-subject-candidate-target-detail-index")]
		[AttrColumnName("subj_ctgtdet_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal SubjectCandidateTargetDetailIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_ctgtlst_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-LISTs.
        /// </summary>
        /// <value>
        /// Value of the column obj_ctgtlst_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("candidate-target-detail-association-object-candidate-target-list-id")]
		[AttrColumnName("obj_ctgtlst_id")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000910)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectCandidateTargetListId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_ctgtdet_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-DETAIL for a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-DETAILs for that CANDIDATE-TARGET-LIST.
        /// </summary>
        /// <value>
        /// Value of the column obj_ctgtdet_ix
        /// </value>
        [AttrIx(100004)]
		[AttrName("candidate-target-detail-association-object-candidate-target-detail-index")]
		[AttrColumnName("obj_ctgtdet_ix")]
        [AttrSeqnr(4)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectCandidateTargetDetailIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of CANDIDATE-TARGET-DETAIL-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("candidate-target-detail-association-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100000270)]
        [DataLength(6)]
        [DataDecimals(0)]
        CandidateTargetDetailAssociationCategoryEnum CandidateTargetDetailAssociationCategory { get; set; }
		
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
