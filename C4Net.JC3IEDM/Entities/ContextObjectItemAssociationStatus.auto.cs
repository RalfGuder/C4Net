using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CONTEXT-OBJECT-ITEM-ASSOCIATION-STATUS that represents the table CONTXT_OI_ASSOC_STAT.
	///
	/// A record of the perceived state of a specific CONTEXT-OBJECT-ITEM-ASSOCIATION as determined by the establishing organisation.
    /// </summary>
    [Serializable]
    [DefinitionName("ContextObjectItemAssociationStatus", "C4Net.JC3IEDM.Definitions.ContextObjectItemAssociationStatus.definition.xml")]
    public class ContextObjectItemAssociationStatus : IEntity, IContextObjectItemAssociationStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ContextObjectItemAssociationStatusExpression _ = new ContextObjectItemAssociationStatusExpression();

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
        /// Gets or sets the value of the column obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_id
        /// </value>
		public decimal ObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column contxt_oi_assoc_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific CONTEXT-OBJECT-ITEM-ASSOCIATION-STATUS for a specific CONTEXT-OBJECT-ITEM-ASSOCIATION and to distinguish it from all other CONTEXT-OBJECT-ITEM-ASSOCIATION-STATUSs for that CONTEXT-OBJECT-ITEM-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column contxt_oi_assoc_stat_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that indicates whether a specific CONTEXT-OBJECT-ITEM-ASSOCIATION-STATUS refers to the beginning or termination of the association.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public AssociationStatusCategoryEnum ContextObjectItemAssociationStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_dttm
		///
		/// The character string representing a point in time that designates the beginning of the period of effectiveness for a specific CONTEXT-OBJECT-ITEM-ASSOCIATION-STATUS.
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
