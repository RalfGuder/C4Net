using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity HOLDING that represents the table HOLDING.
	///
	/// The quantity of each specific OBJECT-TYPE that is held by, installed in, or included with a specific OBJECT-ITEM.
    /// </summary>
    [Serializable]
    [DefinitionName("Holding", "C4Net.JC3IEDM.Definitions.Holding.definition.xml")]
    public class Holding : IEntity, IHolding
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly HoldingExpression _ = new HoldingExpression();

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
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_cnt
		///
		/// The integer value representing the number of specific OBJECT-TYPEs a specific OBJECT-ITEM has available for operations.
        /// </summary>
        /// <value>
        /// Value of the column operat_cnt
        /// </value>
		public int? OperationalCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column total_qty
		///
		/// The numeric value representing the total quantity, to include reserves, of specific OBJECT-TYPEs physically held by a specific OBJECT-ITEM. The unit of measure is derived from the OBJECT-TYPE specification.
        /// </summary>
        /// <value>
        /// Value of the column total_qty
        /// </value>
		public int? TotalQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column on_hand_qty
		///
		/// The numeric value representing the quantity of specific OBJECT-TYPEs physically held on-hand, not including reserves, by a specific OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column on_hand_qty
        /// </value>
		public int? OnHandQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column req_total_qty
		///
		/// The numeric value representing the total quantity of specific OBJECT-TYPEs required to be held on-hand and in reserve by a specific OBJECT-ITEM to meet the NATO assigned task in accordance with Force Standards or established mission requirements.
        /// </summary>
        /// <value>
        /// Value of the column req_total_qty
        /// </value>
		public int? RequiredTotalQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column req_on_hand_qty
		///
		/// The numeric value representing the quantity of specific OBJECT-TYPEs, not including reserves, required to be held on-hand by a specific OBJECT-ITEM in accordance with Force Standards or established mission requirements.
        /// </summary>
        /// <value>
        /// Value of the column req_on_hand_qty
        /// </value>
		public int? RequiredOnHandQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column req_mthd_calc_code
		///
		/// The specific value that represents the required stocks calculation method used for the count of OBJECT-TYPEs in a specific HOLDING.
        /// </summary>
        /// <value>
        /// Value of the column req_mthd_calc_code
        /// </value>
		public HoldingRequiredCalculationMethodEnum? RequiredCalculationMethod { get; set; }
		
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
