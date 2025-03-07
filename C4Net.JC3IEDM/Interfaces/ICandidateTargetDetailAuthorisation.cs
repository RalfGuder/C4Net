using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity CandidateTargetDetailAuthorisation that represents the table CTGTDET_AUTH
	/// 
	/// The designation by competent authority of an instance of CANDIDATE-TARGET-DETAIL as an approved objective in planning battlespace activities.
    /// </summary>
	[EntId(10000141)]
    [EntName("CANDIDATE-TARGET-DETAIL-AUTHORISATION")]
    [EntTableName("CTGTDET_AUTH")]
    [EntDepth(5)]
    public interface ICandidateTargetDetailAuthorisation
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
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal CandidateTargetDetailIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ctgtdet_auth_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-DETAIL-AUTHORISATION for a specific CANDIDATE-TARGET-DETAIL and to distinguish it from all other CANDIDATE-TARGET-DETAIL-AUTHORISATIONs for that CANDIDATE-TARGET-DETAIL.
        /// </summary>
        /// <value>
        /// Value of the column ctgtdet_auth_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("candidate-target-detail-authorisation-index")]
		[AttrColumnName("ctgtdet_auth_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column app_code
		///
		/// The specific value that represents the type of approval that a specific CANDIDATE-TARGET-DETAIL is authorised for further consideration in planning military operations.
        /// </summary>
        /// <value>
        /// Value of the column app_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("candidate-target-detail-authorisation-approval-code")]
		[AttrColumnName("app_code")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000271)]
        [DataLength(6)]
        [DataDecimals(0)]
        CandidateTargetDetailAuthorisationApprovalEnum Approval { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prio_ord
		///
		/// The integer value that indicates the rank of importance of a specific CANDIDATE-TARGET-DETAIL in the view of authorising authority.
        /// </summary>
        /// <value>
        /// Value of the column prio_ord
        /// </value>
        [AttrIx(100005)]
		[AttrName("candidate-target-detail-authorisation-priority-ordinal")]
		[AttrColumnName("prio_ord")]
        [AttrSeqnr(5)]
        [DomId(100002200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? PriorityOrdinal { get; set; }
		
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
