using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-CONTEXT-STATUS that represents the table ACT_CONTXT_STAT.
	///
	/// A record of the perceived state of a specific ACTION-CONTEXT as determined by the establishing organisation.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionContextStatus", "C4Net.JC3IEDM.Definitions.ActionContextStatus.definition.xml")]
    public class ActionContextStatus : IEntity, IActionContextStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ActionContextStatusExpression _ = new ActionContextStatusExpression();

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
        /// Gets or sets the value of the column contxt_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CONTEXT and to distinguish it from all other CONTEXTs.
        /// </summary>
        /// <value>
        /// Value of the column contxt_id
        /// </value>
		public decimal ContextId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_contxt_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-CONTEXT for a specific ACTION and a specific CONTEXT and to distinguish it from all other ACTION-CONTEXTs for that ACTION and that CONTEXT.
        /// </summary>
        /// <value>
        /// Value of the column act_contxt_ix
        /// </value>
		public decimal ActionContextIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_contxt_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-CONTEXT-STATUS for a specific ACTION-CONTEXT and to distinguish it from all other ACTION-CONTEXT-STATUSs for that ACTION-CONTEXT.
        /// </summary>
        /// <value>
        /// Value of the column act_contxt_stat_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that indicates whether a specific ACTION-CONTEXT-STATUS refers to the beginning or termination of the association.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public AssociationStatusCategoryEnum ActionContextStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_dttm
		///
		/// The character string representing a point in time that designates the beginning of the period of effectiveness for a specific ACTION-CONTEXT-STATUS.
        /// </summary>
        /// <value>
        /// Value of the column effctv_dttm
        /// </value>
		public string EffectiveDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column estblng_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column estblng_org_id
        /// </value>
		public decimal EstablishingOrganisationId { get; set; }
		
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
