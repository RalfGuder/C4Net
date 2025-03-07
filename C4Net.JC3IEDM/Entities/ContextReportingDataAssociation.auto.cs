using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CONTEXT-REPORTING-DATA-ASSOCIATION that represents the table CONTXT_RPTD_ASSOC.
	///
	/// A relationship of a CONTEXT as a subject and a REPORTING-DATA as an object.
    /// </summary>
    [Serializable]
    [DefinitionName("ContextReportingDataAssociation", "C4Net.JC3IEDM.Definitions.ContextReportingDataAssociation.definition.xml")]
    public class ContextReportingDataAssociation : IEntity, IContextReportingDataAssociation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ContextReportingDataAssociationExpression _ = new ContextReportingDataAssociationExpression();

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
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
		public decimal ReportingDataId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type of relation of a specific CONTEXT with a specific REPORTING-DATA.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ContextReportingDataAssociationCategoryEnum ContextReportingDataAssociationCategory { get; set; }
		
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
