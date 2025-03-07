using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CANDIDATE-TARGET-DETAIL-ASSOCIATION that represents the table CTGTDET_ASSOC.
	///
	/// A relationship of a CANDIDATE-TARGET-DETAIL as a subject with another CANDIDATE-TARGET-DETAIL as an object.
    /// </summary>
    [Serializable]
    [DefinitionName("CandidateTargetDetailAssociation", "C4Net.JC3IEDM.Definitions.CandidateTargetDetailAssociation.definition.xml")]
    public class CandidateTargetDetailAssociation : IEntity, ICandidateTargetDetailAssociation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly CandidateTargetDetailAssociationExpression _ = new CandidateTargetDetailAssociationExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column subj_ctgtlst_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-LISTs.
        /// </summary>
        /// <value>
        /// Value of the column subj_ctgtlst_id
        /// </value>
		public decimal SubjectCandidateTargetListId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subj_ctgtdet_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-DETAIL for a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-DETAILs for that CANDIDATE-TARGET-LIST.
        /// </summary>
        /// <value>
        /// Value of the column subj_ctgtdet_ix
        /// </value>
		public decimal SubjectCandidateTargetDetailIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_ctgtlst_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-LISTs.
        /// </summary>
        /// <value>
        /// Value of the column obj_ctgtlst_id
        /// </value>
		public decimal ObjectCandidateTargetListId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_ctgtdet_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-DETAIL for a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-DETAILs for that CANDIDATE-TARGET-LIST.
        /// </summary>
        /// <value>
        /// Value of the column obj_ctgtdet_ix
        /// </value>
		public decimal ObjectCandidateTargetDetailIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of CANDIDATE-TARGET-DETAIL-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public CandidateTargetDetailAssociationCategoryEnum CandidateTargetDetailAssociationCategory { get; set; }
		
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
