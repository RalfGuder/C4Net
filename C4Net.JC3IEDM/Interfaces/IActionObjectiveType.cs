using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionObjectiveType that represents the table ACT_OBJVE_TYPE
	/// 
	/// A class of battlespace object (FACILITY-TYPE, FEATURE-TYPE, MATERIEL-TYPE, ORGANISATION-TYPE or PERSON-TYPE) which is the focus of a specific ACTION.
    /// </summary>
	[EntId(10000010)]
    [EntName("ACTION-OBJECTIVE-TYPE")]
    [EntTableName("ACT_OBJVE_TYPE")]
    [EntDepth(6)]
    public interface IActionObjectiveType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("action-id")]
		[AttrColumnName("act_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_objve_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-OBJECTIVE for a specific ACTION and to distinguish it from all other ACTION-OBJECTIVEs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_objve_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-objective-index")]
		[AttrColumnName("act_objve_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionObjectiveIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ACTION-OBJECTIVE-TYPE. It serves as a discriminator that partitions ACTION-OBJECTIVE-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-objective-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100004251)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionObjectiveTypeCategoryEnum ActionObjectiveTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prio_txt
		///
		/// The character string assigned to represent the rank of importance of a specific ACTION-OBJECTIVE-TYPE according to the planning authority.
        /// </summary>
        /// <value>
        /// Value of the column prio_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-objective-type-priority-text")]
		[AttrColumnName("prio_txt")]
        [AttrSeqnr(4)]
        [DomId(100001500)]
        [DataLength(20)]
        [DataDecimals(0)]
        string PriorityText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qty
		///
		/// The numeric value that represents the aggregated units of a specific ACTION-OBJECTIVE-TYPE. No unit of measure is required.
        /// </summary>
        /// <value>
        /// Value of the column qty
        /// </value>
        [AttrIx(100005)]
		[AttrName("action-objective-type-quantity")]
		[AttrColumnName("qty")]
        [AttrSeqnr(5)]
        [DomId(100001200)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? Quantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ctgtlst_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-LISTs.
        /// </summary>
        /// <value>
        /// Value of the column ctgtlst_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("candidate-target-list-id")]
		[AttrColumnName("ctgtlst_id")]
        [AttrSeqnr(6)]
        [ForeignKey]
        [DomId(100000910)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? CandidateTargetListId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ctgtdet_type_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-DETAIL for a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-DETAILs for that CANDIDATE-TARGET-LIST.
        /// </summary>
        /// <value>
        /// Value of the column ctgtdet_type_ix
        /// </value>
        [AttrIx(100007)]
		[AttrName("candidate-target-detail-type-index")]
		[AttrColumnName("ctgtdet_type_ix")]
        [AttrSeqnr(7)]
        [ForeignKey]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? CandidateTargetDetailTypeIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column obj_type_id
        /// </value>
        [AttrIx(100008)]
		[AttrName("object-type-id")]
		[AttrColumnName("obj_type_id")]
        [AttrSeqnr(8)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectTypeId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(9)]
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
        [AttrIx(100010)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(10)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
