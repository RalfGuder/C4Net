using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OBJECT-ITEM-OBJECT-TYPE-ESTABLISHMENT that represents the table OBJ_ITEM_OBJ_TYPE_ESTAB.
	///
	/// A specification of an OBJECT-TYPE-ESTABLISHMENT that is authorised for a specific OBJECT-ITEM.
    /// </summary>
    [Serializable]
    [DefinitionName("ObjectItemObjectTypeEstablishment", "C4Net.JC3IEDM.Definitions.ObjectItemObjectTypeEstablishment.definition.xml")]
    public class ObjectItemObjectTypeEstablishment : IEntity, IObjectItemObjectTypeEstablishment
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ObjectItemObjectTypeEstablishmentExpression _ = new ObjectItemObjectTypeEstablishmentExpression();

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
        /// Gets or sets the value of the column estabd_obj_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column estabd_obj_type_id
        /// </value>
		public decimal EstablishedObjectTypeId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_type_estab_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE-ESTABLISHMENT for a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPE-ESTABLISHMENTs for that OBJECT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column obj_type_estab_ix
        /// </value>
		public decimal ObjectTypeEstablishmentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_obj_type_estab_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-OBJECT-TYPE-ESTABLISHMENT for a specific OBJECT-ITEM and a specific OBJECT-TYPE-ESTABLISHMENT and to distinguish it from all other OBJECT-ITEM-OBJECT-TYPE-ESTABLISHMENTs for that OBJECT-ITEM and that OBJECT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_obj_type_estab_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_dttm
		///
		/// The character string representing a point in time that designates the effective assignment date of a specific OBJECT-TYPE-ESTABLISHMENT to a specific OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column effctv_dttm
        /// </value>
		public string EffectiveDatetime { get; set; }
		
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
