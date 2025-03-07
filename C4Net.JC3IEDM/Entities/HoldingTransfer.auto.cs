using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity HOLDING-TRANSFER that represents the table HOLDING_TRNSF.
	///
	/// The specification of the OBJECT-TYPE quantity expected to be added to or subtracted from a specific HOLDING.
    /// </summary>
    [Serializable]
    [DefinitionName("HoldingTransfer", "C4Net.JC3IEDM.Definitions.HoldingTransfer.definition.xml")]
    public class HoldingTransfer : IEntity, IHoldingTransfer
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly HoldingTransferExpression _ = new HoldingTransferExpression();

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
        /// Gets or sets the value of the column obj_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column obj_type_id
        /// </value>
		public decimal ObjectTypeId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column holding_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific HOLDING for a specific OBJECT-ITEM and a specific OBJECT-TYPE and to distinguish it from all other HOLDINGs for that OBJECT-ITEM and that OBJECT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column holding_ix
        /// </value>
		public decimal HoldingIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column holding_trnsf_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific HOLDING-TRANSFER for a specific HOLDING and to distinguish it from all other HOLDING-TRANSFERs for that HOLDING.
        /// </summary>
        /// <value>
        /// Value of the column holding_trnsf_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column reason_code
		///
		/// The specific value that characterises the basis for a specific HOLDING-TRANSFER.
        /// </summary>
        /// <value>
        /// Value of the column reason_code
        /// </value>
		public HoldingTransferReasonEnum Reason { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qty
		///
		/// The numeric value representing the quantity of specific OBJECT-TYPE involved in a specific HOLDING-TRANSFER. A negative quantity decreases the HOLDING and a positive quantity increases the HOLDING.
        /// </summary>
        /// <value>
        /// Value of the column qty
        /// </value>
		public int Quantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column holding_trnsf_crsp_obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column holding_trnsf_crsp_obj_item_id
        /// </value>
		public decimal? CorrespondingObjectItemId { get; set; }
		
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
