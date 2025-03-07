using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ObjectTypeEstablishmentObjectTypeDetail that represents the table OBJ_TYPE_ESTAB_OBJT_DET
	/// 
	/// The number of a specific OBJECT-TYPE that is authorised by a specific OBJECT-TYPE-ESTABLISHMENT.
    /// </summary>
	[EntId(10000272)]
    [EntName("OBJECT-TYPE-ESTABLISHMENT-OBJECT-TYPE-DETAIL")]
    [EntTableName("OBJ_TYPE_ESTAB_OBJT_DET")]
    [EntDepth(2)]
    public interface IObjectTypeEstablishmentObjectTypeDetail
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column estabd_obj_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column estabd_obj_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("established-object-type-id")]
		[AttrColumnName("estabd_obj_type_id")]
        [AttrSeqnr(1)]
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
        [AttrIx(100002)]
		[AttrName("object-type-establishment-index")]
		[AttrColumnName("obj_type_estab_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectTypeEstablishmentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_type_estab_objt_det_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE-ESTABLISHMENT-OBJECT-TYPE-DETAIL for a specific "established" OBJECT-TYPE and to distinguish it from all other OBJECT-TYPE-ESTABLISHMENT-OBJECT-TYPE-DETAILs for that OBJECT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column obj_type_estab_objt_det_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("object-type-establishment-object-type-detail-index")]
		[AttrColumnName("obj_type_estab_objt_det_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column major_part_ind_code
		///
		/// The specific value that denotes whether a detail is a ‘major part’ when the established and detail OBJECT-TYPEs are instances of MATERIEL-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column major_part_ind_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("object-type-establishment-object-type-detail-major-part-indicator-code")]
		[AttrColumnName("major_part_ind_code")]
        [AttrSeqnr(4)]
        [DomId(100004192)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectTypeEstablishmentObjectTypeDetailMajorPartIndicatorEnum? MajorPartIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cnt
		///
		/// The integer value representing the count of the numbers of a specific OBJECT-TYPE authorised to be part of a specific OBJECT-TYPE-ESTABLISHMENT-OBJECT-TYPE-DETAIL.
        /// </summary>
        /// <value>
        /// Value of the column cnt
        /// </value>
        [AttrIx(100005)]
		[AttrName("object-type-establishment-object-type-detail-count")]
		[AttrColumnName("cnt")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100001800)]
        [DataLength(9)]
        [DataDecimals(0)]
        int Count { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column det_obj_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column det_obj_type_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("object-type-establishment-object-type-detail-object-type-id")]
		[AttrColumnName("det_obj_type_id")]
        [AttrSeqnr(6)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectTypeId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column det_obj_type_estab_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE-ESTABLISHMENT for a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPE-ESTABLISHMENTs for that OBJECT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column det_obj_type_estab_ix
        /// </value>
        [AttrIx(100007)]
		[AttrName("object-type-establishment-detail-object-type-establishment-index")]
		[AttrColumnName("det_obj_type_estab_ix")]
        [AttrSeqnr(7)]
        [ForeignKey]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? ObjectTypeEstablishmentDetailObjectTypeEstablishmentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(8)]
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
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(9)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
