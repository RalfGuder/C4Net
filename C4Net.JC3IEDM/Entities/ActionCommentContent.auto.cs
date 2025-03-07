using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-COMMENT-CONTENT that represents the table ACT_CMT_CNTNT.
	///
	/// The actual text that comprises the comments for a single ACTION-COMMENT.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionCommentContent", "C4Net.JC3IEDM.Definitions.ActionCommentContent.definition.xml")]
    public class ActionCommentContent : IEntity, IActionCommentContent
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ActionCommentContentExpression _ = new ActionCommentContentExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_id
        /// </value>
		public decimal ActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_cmt_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-COMMENT for a specific ACTION and to distinguish it from all other ACTION-COMMENTs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_cmt_ix
        /// </value>
		public decimal ActionCommentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_cmt_cntnt_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-COMMENT-CONTENT for a specific ACTION-COMMENT and to distinguish it from all other ACTION-COMMENT-CONTENTs for that ACTION-COMMENT.
        /// </summary>
        /// <value>
        /// Value of the column act_cmt_cntnt_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column txt
		///
		/// The character string assigned to represent a general comment about a specific ACTION.
        /// </summary>
        /// <value>
        /// Value of the column txt
        /// </value>
		public string Text { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column seq_ord
		///
		/// The integer value that indicates the relative order of an ACTION-COMMENT-CONTENT entry.
        /// </summary>
        /// <value>
        /// Value of the column seq_ord
        /// </value>
		public short SequenceOrdinal { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
		public decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
		public long UpdateSeqnr { get; set; }
		
        #endregion
    }
}
