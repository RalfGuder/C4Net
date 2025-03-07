using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Request that represents the table REQUEST
	/// 
	/// An ACTION-TASK that states a requirement.
    /// </summary>
	[EntId(10000112)]
    [EntName("REQUEST")]
    [EntTableName("REQUEST")]
    [EntDepth(5)]
    public interface IRequest
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column request_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column request_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("request-id")]
		[AttrColumnName("request_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type classification of a specific REQUEST.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("request-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000217)]
        [DataLength(6)]
        [DataDecimals(0)]
        RequestCategoryEnum RequestCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column immd_interest_ind_code
		///
		/// The specific value that indicates whether the information sought in a request is of immediate interest.
        /// </summary>
        /// <value>
        /// Value of the column immd_interest_ind_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("request-immediate-interest-indicator-code")]
		[AttrColumnName("immd_interest_ind_code")]
        [AttrSeqnr(3)]
        [DomId(100000218)]
        [DataLength(6)]
        [DataDecimals(0)]
        RequestImmediateInterestIndicatorEnum? ImmediateInterestIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column latest_ans_dttm
		///
		/// The character string representing a point in time that designates the end of the period of usefulness of the information sought in a specific REQUEST.
        /// </summary>
        /// <value>
        /// Value of the column latest_ans_dttm
        /// </value>
        [AttrIx(100004)]
		[AttrName("request-latest-answer-datetime")]
		[AttrColumnName("latest_ans_dttm")]
        [AttrSeqnr(4)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string LatestAnswerDatetime { get; set; }
		
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
