using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CONTEXT-ASSESSMENT that represents the table CONTXT_ASSESS.
	///
	/// A record of appraisal by a specific ORGANISATION regarding the information that is referenced by a specific instance of CONTEXT.
    /// </summary>
    [Serializable]
    [DefinitionName("ContextAssessment", "C4Net.JC3IEDM.Definitions.ContextAssessment.definition.xml")]
    public class ContextAssessment : IEntity, IContextAssessment
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ContextAssessmentExpression _ = new ContextAssessmentExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column contxt_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CONTEXT and to distinguish it from all other CONTEXTs.
        /// </summary>
        /// <value>
        /// Value of the column contxt_id
        /// </value>
		public decimal ContextId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column contxt_assess_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific CONTEXT-ASSESSMENT for a specific CONTEXT and to distinguish it from all other CONTEXT-ASSESSMENTs for that CONTEXT.
        /// </summary>
        /// <value>
        /// Value of the column contxt_assess_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column txt
		///
		/// The character string assigned to represent an appraisal regarding the information that is referenced by a specific instance of CONTEXT.
        /// </summary>
        /// <value>
        /// Value of the column txt
        /// </value>
		public string Text { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column limiting_factors_code
		///
		/// The specific value that represents the logistic factors, which are degrading operational capability in a specific CONTEXT-ASSESSMENT.
        /// </summary>
        /// <value>
        /// Value of the column limiting_factors_code
        /// </value>
		public ContextAssessmentLimitingFactorsEnum? LimitingFactors { get; set; }
		
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
