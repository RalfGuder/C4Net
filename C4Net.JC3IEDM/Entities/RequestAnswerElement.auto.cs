using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity REQUEST-ANSWER-ELEMENT that represents the table REQUEST_ANS_ELMT.
	///
	/// A relationship between a specific REQUEST-ANSWER and a specific REPORTING-DATA that provides linkage to amplifying information for a REQUEST-ANSWER.
    /// </summary>
    [Serializable]
    [DefinitionName("RequestAnswerElement", "C4Net.JC3IEDM.Definitions.RequestAnswerElement.definition.xml")]
    public class RequestAnswerElement : IEntity, IRequestAnswerElement
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly RequestAnswerElementExpression _ = new RequestAnswerElementExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column request_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column request_id
        /// </value>
		public decimal RequestId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column request_ans_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific REQUEST-ANSWER for a specific REQUEST and to distinguish it from all other REQUEST-ANSWERs for that REQUEST.
        /// </summary>
        /// <value>
        /// Value of the column request_ans_ix
        /// </value>
		public decimal RequestAnswerIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column comprising_rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column comprising_rptd_id
        /// </value>
		public decimal ComprisingReportingDataId { get; set; }
		
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
