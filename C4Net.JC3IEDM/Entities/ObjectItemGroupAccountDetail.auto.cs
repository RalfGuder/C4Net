using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OBJECT-ITEM-GROUP-ACCOUNT-DETAIL that represents the table OBJ_ITEM_GROUP_ACCT_DET.
	///
	/// The total count and condition of a specific group included in a specific OBJECT-ITEM-GROUP-ACCOUNT. The group is defined as a specific PERSON-TYPE that may also be categorised by a specific GROUP-CHARACTERISTIC.
    /// </summary>
    [Serializable]
    [DefinitionName("ObjectItemGroupAccountDetail", "C4Net.JC3IEDM.Definitions.ObjectItemGroupAccountDetail.definition.xml")]
    public class ObjectItemGroupAccountDetail : IEntity, IObjectItemGroupAccountDetail
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ObjectItemGroupAccountDetailExpression _ = new ObjectItemGroupAccountDetailExpression();

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
        /// Gets or sets the value of the column obj_item_group_acct_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-GROUP-ACCOUNT for a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-GROUP-ACCOUNTs for that OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_group_acct_ix
        /// </value>
		public decimal ObjectItemGroupAccountIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_group_acct_det_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-GROUP-ACCOUNT-DETAIL for a specific OBJECT-ITEM-GROUP-ACCOUNT and to distinguish it from all other OBJECT-ITEM-GROUP-ACCOUNT-DETAILs for that OBJECT-ITEM-GROUP-ACCOUNT.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_group_acct_det_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cnt
		///
		/// The integer value representing the aggregated units in a specific OBJECT-ITEM-GROUP-ACCOUNT-DETAIL.
        /// </summary>
        /// <value>
        /// Value of the column cnt
        /// </value>
		public int Count { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qual_code
		///
		/// The specific value that describes the condition of the group counted in a specific OBJECT-ITEM-GROUP-ACCOUNT-DETAIL.
        /// </summary>
        /// <value>
        /// Value of the column qual_code
        /// </value>
		public ObjectItemGroupAccountDetailQualifierEnum? Qualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column group_chrct_id
		///
		/// The unique value, or set of characters, assigned to represent a specific GROUP-CHARACTERISTIC and to distinguish it from all other GROUP-CHARACTERISTICs.
        /// </summary>
        /// <value>
        /// Value of the column group_chrct_id
        /// </value>
		public decimal? GroupCharacteristicId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pers_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column pers_type_id
        /// </value>
		public decimal PersonTypeId { get; set; }
		
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
