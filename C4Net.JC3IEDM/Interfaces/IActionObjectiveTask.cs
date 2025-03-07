using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionObjectiveTask that represents the table ACT_OBJVE_TASK
	/// 
	/// The objective of the specific ACTION is the operation identified as the specific ACTION-TASK.
    /// </summary>
	[EntId(10000304)]
    [EntName("ACTION-OBJECTIVE-TASK")]
    [EntTableName("ACT_OBJVE_TASK")]
    [EntDepth(5)]
    public interface IActionObjectiveTask
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
        /// Gets or sets the value of the column act_objve_task_act_task_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_objve_task_act_task_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-objective-task-action-task-id")]
		[AttrColumnName("act_objve_task_act_task_id")]
        [AttrSeqnr(3)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionTaskId { get; set; }
		
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
