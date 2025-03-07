using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity CandidateTargetList that represents the table CTGTLST
	/// 
	/// A list of selected battlespace objects or types that have potential value for destruction or exploitation, nominated by competent authority for consideration in planning battlespace activities.
    /// </summary>
	[EntId(10000144)]
    [EntName("CANDIDATE-TARGET-LIST")]
    [EntTableName("CTGTLST")]
    [EntDepth(3)]
    public interface ICandidateTargetList
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
        [Mandatory]
        [DomId(100000910)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column name_txt
		///
		/// The character string assigned to represent a specific CANDIDATE-TARGET-LIST.
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
        [AttrIx(100002)]
		[AttrName("candidate-target-list-name-text")]
		[AttrColumnName("name_txt")]
        [AttrSeqnr(2)]
        [DomId(100001500)]
        [DataLength(80)]
        [DataDecimals(0)]
        string NameText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("reporting-data-id")]
		[AttrColumnName("rptd_id")]
        [AttrSeqnr(3)]
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
        [AttrIx(100004)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(4)]
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
        [AttrIx(100005)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
