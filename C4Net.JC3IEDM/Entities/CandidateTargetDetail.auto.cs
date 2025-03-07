using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CANDIDATE-TARGET-DETAIL that represents the table CTGTDET.
	///
	/// An element of CANDIDATE-TARGET-LIST.
    /// </summary>
    [Serializable]
    [DefinitionName("CandidateTargetDetail", "C4Net.JC3IEDM.Definitions.CandidateTargetDetail.definition.xml")]
    public class CandidateTargetDetail : IEntity, ICandidateTargetDetail
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly CandidateTargetDetailExpression _ = new CandidateTargetDetailExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column ctgtlst_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-LISTs.
        /// </summary>
        /// <value>
        /// Value of the column ctgtlst_id
        /// </value>
		public decimal CandidateTargetListId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ctgtdet_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-DETAIL for a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-DETAILs for that CANDIDATE-TARGET-LIST.
        /// </summary>
        /// <value>
        /// Value of the column ctgtdet_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that denotes a CANDIDATE-TARGET-DETAIL as being an item or a type. It serves as a discriminator that partitions CANDIDATE-TARGET-DETAIL into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public CandidateTargetDetailCategoryEnum CandidateTargetDetailCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column focus_type_code
		///
		/// The specific value that denotes a general class of actions intended by the nominating authority for a specific CANDIDATE-TARGET-DETAIL.
        /// </summary>
        /// <value>
        /// Value of the column focus_type_code
        /// </value>
		public CandidateTargetDetailFocusTypeEnum FocusType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column label_txt
		///
		/// The character string assigned to represent the identity of a specific CANDIDATE-TARGET-DETAIL in accordance with a specific scheme.
        /// </summary>
        /// <value>
        /// Value of the column label_txt
        /// </value>
		public string LabelText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prio_ord
		///
		/// The integer value that indicates the rank of importance of a specific CANDIDATE-TARGET-DETAIL in the view of nominating authority.
        /// </summary>
        /// <value>
        /// Value of the column prio_ord
        /// </value>
		public int? PriorityOrdinal { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column scheme_code
		///
		/// The specific value that denotes an identification scheme used for recording a CANDIDATE-TARGET-DETAIL.
        /// </summary>
        /// <value>
        /// Value of the column scheme_code
        /// </value>
		public CandidateTargetDetailSchemeEnum? Scheme { get; set; }
		
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
