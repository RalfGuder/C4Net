using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OBJECT-ITEM-AFFILIATION that represents the table OBJ_ITEM_AFFL.
	///
	/// A relationship between a specific OBJECT-ITEM and a specific AFFILIATION. Note:  This entity is intended to record exceptions to affiliations identified in OBJECT-TYPE. Consequently, the native, normal or expected affiliation is identified by associating the item with an appropriate type.
    /// </summary>
    [Serializable]
    [DefinitionName("ObjectItemAffiliation", "C4Net.JC3IEDM.Definitions.ObjectItemAffiliation.definition.xml")]
    public class ObjectItemAffiliation : IEntity, IObjectItemAffiliation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ObjectItemAffiliationExpression _ = new ObjectItemAffiliationExpression();

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
        /// Gets or sets the value of the column affl_id
		///
		/// The unique value, or set of characters, assigned to represent a specific AFFILIATION and to distinguish it from all other AFFILIATIONs.
        /// </summary>
        /// <value>
        /// Value of the column affl_id
        /// </value>
		public decimal AffiliationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_affl_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-AFFILIATION for a specific OBJECT-ITEM and a specific AFFILIATION and to distinguish it from all other OBJECT-ITEM-AFFILIATIONs for that OBJECT-ITEM and that AFFILIATION.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_affl_ix
        /// </value>
		public decimal Index { get; set; }
		
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
