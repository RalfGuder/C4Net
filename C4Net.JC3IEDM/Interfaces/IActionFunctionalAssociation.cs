using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionFunctionalAssociation that represents the table ACT_FUNCTL_ASSOC
	/// 
	/// A relationship of an ACTION as a subject with another ACTION as an object in order to specify functional dependence.
    /// </summary>
	[EntId(10000007)]
    [EntName("ACTION-FUNCTIONAL-ASSOCIATION")]
    [EntTableName("ACT_FUNCTL_ASSOC")]
    [EntDepth(1)]
    public interface IActionFunctionalAssociation
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column subj_act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column subj_act_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("action-functional-association-subject-action-id")]
		[AttrColumnName("subj_act_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal SubjectActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column obj_act_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-functional-association-object-action-id")]
		[AttrColumnName("obj_act_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_functl_assoc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-FUNCTIONAL-ASSOCIATION for a specific subject ACTION and a specific object ACTION and to distinguish it from all other ACTION-FUNCTIONAL-ASSOCIATIONs for those ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_functl_assoc_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-functional-association-index")]
		[AttrColumnName("act_functl_assoc_ix")]
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
		/// The specific value that represents the class of relationship of subject ACTION to object ACTION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-functional-association-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000114)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionFunctionalAssociationCategoryEnum ActionFunctionalAssociationCategory { get; set; }
		
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
