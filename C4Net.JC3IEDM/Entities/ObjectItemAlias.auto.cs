using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OBJECT-ITEM-ALIAS that represents the table OBJ_ITEM_ALIAS.
	///
	/// An additional name for an OBJECT-ITEM.
    /// </summary>
    [Serializable]
    [DefinitionName("ObjectItemAlias", "C4Net.JC3IEDM.Definitions.ObjectItemAlias.definition.xml")]
    public class ObjectItemAlias : IEntity, IObjectItemAlias
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ObjectItemAliasExpression _ = new ObjectItemAliasExpression();

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
        /// Gets or sets the value of the column obj_item_alias_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-ALIAS for a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-ALIASs for that OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_alias_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of OBJECT-ITEM-ALIAS.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ObjectItemAliasCategoryEnum ObjectItemAliasCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column name_txt
		///
		/// The character string assigned to represent a specific OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
		public string NameText { get; set; }
		
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
