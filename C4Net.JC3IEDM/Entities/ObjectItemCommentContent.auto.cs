using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OBJECT-ITEM-COMMENT-CONTENT that represents the table OBJ_ITEM_CMT_CNTNT.
	///
	/// The actual text that comprises the comments for a single OBJECT-ITEM-COMMENT.
    /// </summary>
    [Serializable]
    [DefinitionName("ObjectItemCommentContent", "C4Net.JC3IEDM.Definitions.ObjectItemCommentContent.definition.xml")]
    public class ObjectItemCommentContent : IEntity, IObjectItemCommentContent
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ObjectItemCommentContentExpression _ = new ObjectItemCommentContentExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_id
        /// </value>
		public decimal ObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_cmt_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-COMMENT for a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-COMMENTs for that OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_cmt_ix
        /// </value>
		public decimal ObjectItemCommentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_cmt_cntnt_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-COMMENT-CONTENT for a specific OBJECT-ITEM-COMMENT and to distinguish it from all other OBJECT-ITEM-COMMENT-CONTENTs for that OBJECT-ITEM-COMMENT.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_cmt_cntnt_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column txt
		///
		/// The character string assigned to represent a general comment about a specific OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column txt
        /// </value>
		public string Text { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column seq_ord
		///
		/// The integer value that indicates the relative order of an OBJECT-ITEM-COMMENT-CONTENT entry.
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
