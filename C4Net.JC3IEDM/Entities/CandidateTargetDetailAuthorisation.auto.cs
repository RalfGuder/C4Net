using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CANDIDATE-TARGET-DETAIL-AUTHORISATION that represents the table CTGTDET_AUTH.
	///
	/// The designation by competent authority of an instance of CANDIDATE-TARGET-DETAIL as an approved objective in planning battlespace activities.
    /// </summary>
    [Serializable]
    [DefinitionName("CandidateTargetDetailAuthorisation", "C4Net.JC3IEDM.Definitions.CandidateTargetDetailAuthorisation.definition.xml")]
    public class CandidateTargetDetailAuthorisation : IEntity, ICandidateTargetDetailAuthorisation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly CandidateTargetDetailAuthorisationExpression _ = new CandidateTargetDetailAuthorisationExpression();

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
		public decimal CandidateTargetDetailIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ctgtdet_auth_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-DETAIL-AUTHORISATION for a specific CANDIDATE-TARGET-DETAIL and to distinguish it from all other CANDIDATE-TARGET-DETAIL-AUTHORISATIONs for that CANDIDATE-TARGET-DETAIL.
        /// </summary>
        /// <value>
        /// Value of the column ctgtdet_auth_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column app_code
		///
		/// The specific value that represents the type of approval that a specific CANDIDATE-TARGET-DETAIL is authorised for further consideration in planning military operations.
        /// </summary>
        /// <value>
        /// Value of the column app_code
        /// </value>
		public CandidateTargetDetailAuthorisationApprovalEnum Approval { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prio_ord
		///
		/// The integer value that indicates the rank of importance of a specific CANDIDATE-TARGET-DETAIL in the view of authorising authority.
        /// </summary>
        /// <value>
        /// Value of the column prio_ord
        /// </value>
		public int? PriorityOrdinal { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
		public decimal ReportingDataId { get; set; }
		
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
