using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ObjectTypeEstablishment that represents the table OBJ_TYPE_ESTAB
	/// 
	/// The authorisation or other form of specification that associates with the established OBJECT-TYPE numbers of specific OBJECT-TYPEs under specified conditions.
    /// </summary>
	[EntId(10000271)]
    [EntName("OBJECT-TYPE-ESTABLISHMENT")]
    [EntTableName("OBJ_TYPE_ESTAB")]
    [EntDepth(1)]
    public interface IObjectTypeEstablishment
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
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_dttm
		///
		/// The character string representing a point in time that designates the beginning date of the period of effectiveness of a specific OBJECT-TYPE-ESTABLISHMENT.
        /// </summary>
        /// <value>
        /// Value of the column effctv_dttm
        /// </value>
        [AttrIx(100003)]
		[AttrName("object-type-establishment-effective-datetime")]
		[AttrColumnName("effctv_dttm")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string EffectiveDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of OBJECT-TYPE-ESTABLISHMENT when the established and detail OBJECT-TYPEs are instances of MATERIEL-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("object-type-establishment-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(4)]
        [DomId(100004190)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectTypeEstablishmentCategoryEnum? ObjectTypeEstablishmentCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column environ_cond_code
		///
		/// The specific value that represents the environmental conditions for which a specific OBJECT-TYPE-ESTABLISHMENT is authorised.
        /// </summary>
        /// <value>
        /// Value of the column environ_cond_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("object-type-establishment-environment-condition-code")]
		[AttrColumnName("environ_cond_code")]
        [AttrSeqnr(5)]
        [DomId(100004191)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectTypeEstablishmentEnvironmentConditionEnum? EnvironmentCondition { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column name_txt
		///
		/// The character string assigned to represent a specific OBJECT-TYPE-ESTABLISHMENT.
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
        [AttrIx(100006)]
		[AttrName("object-type-establishment-name-text")]
		[AttrColumnName("name_txt")]
        [AttrSeqnr(6)]
        [DomId(100001500)]
        [DataLength(80)]
        [DataDecimals(0)]
        string NameText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_mode_code
		///
		/// The specific value that represents the operational mode for which a specific OBJECT-TYPE-ESTABLISHMENT is authorised.
        /// </summary>
        /// <value>
        /// Value of the column operat_mode_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("object-type-establishment-operational-mode-code")]
		[AttrColumnName("operat_mode_code")]
        [AttrSeqnr(7)]
        [DomId(100004193)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectTypeEstablishmentOperationalModeEnum? OperationalMode { get; set; }
		
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
