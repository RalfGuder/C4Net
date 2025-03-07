using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity CandidateTargetDetail that represents the table CTGTDET
	/// 
	/// An element of CANDIDATE-TARGET-LIST.
    /// </summary>
	[EntId(10000139)]
    [EntName("CANDIDATE-TARGET-DETAIL")]
    [EntTableName("CTGTDET")]
    [EntDepth(4)]
    public interface ICandidateTargetDetail
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column ctgtlst_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-LISTs.
        /// </summary>
        /// <value>
        /// Value of the column ctgtlst_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("candidate-target-list-id")]
		[AttrColumnName("ctgtlst_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000910)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal CandidateTargetListId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ctgtdet_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-DETAIL for a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-DETAILs for that CANDIDATE-TARGET-LIST.
        /// </summary>
        /// <value>
        /// Value of the column ctgtdet_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("candidate-target-detail-index")]
		[AttrColumnName("ctgtdet_ix")]
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
		/// The specific value that denotes a CANDIDATE-TARGET-DETAIL as being an item or a type. It serves as a discriminator that partitions CANDIDATE-TARGET-DETAIL into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("candidate-target-detail-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000267)]
        [DataLength(6)]
        [DataDecimals(0)]
        CandidateTargetDetailCategoryEnum CandidateTargetDetailCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column focus_type_code
		///
		/// The specific value that denotes a general class of actions intended by the nominating authority for a specific CANDIDATE-TARGET-DETAIL.
        /// </summary>
        /// <value>
        /// Value of the column focus_type_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("candidate-target-detail-focus-type-code")]
		[AttrColumnName("focus_type_code")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000268)]
        [DataLength(6)]
        [DataDecimals(0)]
        CandidateTargetDetailFocusTypeEnum FocusType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column label_txt
		///
		/// The character string assigned to represent the identity of a specific CANDIDATE-TARGET-DETAIL in accordance with a specific scheme.
        /// </summary>
        /// <value>
        /// Value of the column label_txt
        /// </value>
        [AttrIx(100005)]
		[AttrName("candidate-target-detail-label-text")]
		[AttrColumnName("label_txt")]
        [AttrSeqnr(5)]
        [DomId(100001500)]
        [DataLength(255)]
        [DataDecimals(0)]
        string LabelText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prio_ord
		///
		/// The integer value that indicates the rank of importance of a specific CANDIDATE-TARGET-DETAIL in the view of nominating authority.
        /// </summary>
        /// <value>
        /// Value of the column prio_ord
        /// </value>
        [AttrIx(100006)]
		[AttrName("candidate-target-detail-priority-ordinal")]
		[AttrColumnName("prio_ord")]
        [AttrSeqnr(6)]
        [DomId(100002200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? PriorityOrdinal { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column scheme_code
		///
		/// The specific value that denotes an identification scheme used for recording a CANDIDATE-TARGET-DETAIL.
        /// </summary>
        /// <value>
        /// Value of the column scheme_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("candidate-target-detail-scheme-code")]
		[AttrColumnName("scheme_code")]
        [AttrSeqnr(7)]
        [DomId(100000269)]
        [DataLength(6)]
        [DataDecimals(0)]
        CandidateTargetDetailSchemeEnum? Scheme { get; set; }
		
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
