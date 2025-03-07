using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ObjectItemObjectTypeEstablishment that represents the table OBJ_ITEM_OBJ_TYPE_ESTAB
	/// 
	/// A specification of an OBJECT-TYPE-ESTABLISHMENT that is authorised for a specific OBJECT-ITEM.
    /// </summary>
	[EntId(10000270)]
    [EntName("OBJECT-ITEM-OBJECT-TYPE-ESTABLISHMENT")]
    [EntTableName("OBJ_ITEM_OBJ_TYPE_ESTAB")]
    [EntDepth(2)]
    public interface IObjectItemObjectTypeEstablishment
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("object-item-id")]
		[AttrColumnName("obj_item_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column estabd_obj_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column estabd_obj_type_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("established-object-type-id")]
		[AttrColumnName("estabd_obj_type_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal EstablishedObjectTypeId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_type_estab_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE-ESTABLISHMENT for a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPE-ESTABLISHMENTs for that OBJECT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column obj_type_estab_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("object-type-establishment-index")]
		[AttrColumnName("obj_type_estab_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectTypeEstablishmentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_obj_type_estab_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-OBJECT-TYPE-ESTABLISHMENT for a specific OBJECT-ITEM and a specific OBJECT-TYPE-ESTABLISHMENT and to distinguish it from all other OBJECT-ITEM-OBJECT-TYPE-ESTABLISHMENTs for that OBJECT-ITEM and that OBJECT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_obj_type_estab_ix
        /// </value>
        [AttrIx(100004)]
		[AttrName("object-item-object-type-establishment-index")]
		[AttrColumnName("obj_item_obj_type_estab_ix")]
        [AttrSeqnr(4)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_dttm
		///
		/// The character string representing a point in time that designates the effective assignment date of a specific OBJECT-TYPE-ESTABLISHMENT to a specific OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column effctv_dttm
        /// </value>
        [AttrIx(100005)]
		[AttrName("object-item-object-type-establishment-effective-datetime")]
		[AttrColumnName("effctv_dttm")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string EffectiveDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100000913)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(7)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
