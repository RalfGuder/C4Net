using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity MaterielType that represents the table MAT_TYPE
	/// 
	/// An OBJECT-TYPE that represents equipment, apparatus or supplies of military interest without distinction to its application for administrative or combat purposes.
    /// </summary>
	[EntId(10000070)]
    [EntName("MATERIEL-TYPE")]
    [EntTableName("MAT_TYPE")]
    [EntDepth(1)]
    public interface IMaterielType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mat_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column mat_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("materiel-type-id")]
		[AttrColumnName("mat_type_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of MATERIEL-TYPE. It serves as a discriminator that partitions MATERIEL-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("materiel-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000139)]
        [DataLength(6)]
        [DataDecimals(0)]
        MaterielTypeCategoryEnum MaterielTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptbl_item_txt
		///
		/// The character string assigned to represent a specific MATERIEL-TYPE, selected from the Reportable Item Code list issued by NATO.
        /// </summary>
        /// <value>
        /// Value of the column rptbl_item_txt
        /// </value>
        [AttrIx(100003)]
		[AttrName("materiel-type-reportable-item-text")]
		[AttrColumnName("rptbl_item_txt")]
        [AttrSeqnr(3)]
        [DomId(100001500)]
        [DataLength(6)]
        [DataDecimals(0)]
        string ReportableItemText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column stock_no_txt
		///
		/// The character string assigned to represent a specific MATERIEL-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column stock_no_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("materiel-type-stock-number-text")]
		[AttrColumnName("stock_no_txt")]
        [AttrSeqnr(4)]
        [DomId(100001500)]
        [DataLength(15)]
        [DataDecimals(0)]
        string StockNumberText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column supply_class_code
		///
		/// The specific value that represents the NATO supply class of MATERIEL-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column supply_class_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("materiel-type-supply-class-code")]
		[AttrColumnName("supply_class_code")]
        [AttrSeqnr(5)]
        [DomId(100000398)]
        [DataLength(6)]
        [DataDecimals(0)]
        MaterielTypeSupplyClassEnum? SupplyClass { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column issuing_height_dim
		///
		/// The one-dimensional linear distance representing the maximum distance measured perpendicular to the base plane of the specific MATERIEL-TYPE when it is prepared for shipment or storage.
        /// </summary>
        /// <value>
        /// Value of the column issuing_height_dim
        /// </value>
        [AttrIx(100006)]
		[AttrName("materiel-type-issuing-height-dimension")]
		[AttrColumnName("issuing_height_dim")]
        [AttrSeqnr(6)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? IssuingHeightDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column issuing_length_dim
		///
		/// The one-dimensional linear distance representing the maximum distance measured from end to end and parallel to the central axis of specific MATERIEL-TYPE when it is prepared for shipment or storage.
        /// </summary>
        /// <value>
        /// Value of the column issuing_length_dim
        /// </value>
        [AttrIx(100007)]
		[AttrName("materiel-type-issuing-length-dimension")]
		[AttrColumnName("issuing_length_dim")]
        [AttrSeqnr(7)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? IssuingLengthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column issuing_width_dim
		///
		/// The one-dimensional linear distance representing the maximum distance measured from side to side and perpendicular to the central axis of a specific MATERIEL-TYPE when it is prepared for shipment or storage.
        /// </summary>
        /// <value>
        /// Value of the column issuing_width_dim
        /// </value>
        [AttrIx(100008)]
		[AttrName("materiel-type-issuing-width-dimension")]
		[AttrColumnName("issuing_width_dim")]
        [AttrSeqnr(8)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? IssuingWidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(9)]
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
        [AttrIx(100010)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(10)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
