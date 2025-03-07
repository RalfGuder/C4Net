using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity EquipmentType that represents the table EQPT_TYPE
	/// 
	/// A MATERIEL-TYPE that is not intended for consumption.
    /// </summary>
	[EntId(10000041)]
    [EntName("EQUIPMENT-TYPE")]
    [EntTableName("EQPT_TYPE")]
    [EntDepth(2)]
    public interface IEquipmentType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column eqpt_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column eqpt_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("equipment-type-id")]
		[AttrColumnName("eqpt_type_id")]
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
		/// The specific value that represents the class of EQUIPMENT-TYPE. It serves as a discriminator that partitions EQUIPMENT-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("equipment-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000334)]
        [DataLength(6)]
        [DataDecimals(0)]
        EquipmentTypeCategoryEnum EquipmentTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column loaded_wt_qty
		///
		/// The numeric value that represents the weight of a specific EQUIPMENT-TYPE including the normal maximum payload, crew, and personal/organisation equipment as well as the basic issue items. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column loaded_wt_qty
        /// </value>
        [AttrIx(100003)]
		[AttrName("equipment-type-loaded-weight-quantity")]
		[AttrColumnName("loaded_wt_qty")]
        [AttrSeqnr(3)]
        [DomId(100001200)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? LoadedWeightQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column unloaded_wt_qty
		///
		/// The numeric value that represents the weight of a specific EQUIPMENT-TYPE including on-equipment materiel that is an integral part of the equipment when issued. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column unloaded_wt_qty
        /// </value>
        [AttrIx(100004)]
		[AttrName("equipment-type-unloaded-weight-quantity")]
		[AttrColumnName("unloaded_wt_qty")]
        [AttrSeqnr(4)]
        [DomId(100001200)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? UnloadedWeightQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_height_dim
		///
		/// The one-dimensional linear distance representing the maximum distance measured perpendicular to the base plane of the specific EQUIPMENT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column max_height_dim
        /// </value>
        [AttrIx(100005)]
		[AttrName("equipment-type-maximum-height-dimension")]
		[AttrColumnName("max_height_dim")]
        [AttrSeqnr(5)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? MaximumHeightDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_length_dim
		///
		/// The one-dimensional linear distance representing the maximum distance measured from end to end and parallel to the central axis of a specific EQUIPMENT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column max_length_dim
        /// </value>
        [AttrIx(100006)]
		[AttrName("equipment-type-maximum-length-dimension")]
		[AttrColumnName("max_length_dim")]
        [AttrSeqnr(6)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? MaximumLengthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_width_dim
		///
		/// The one-dimensional linear distance representing the maximum distance measured from side to side and perpendicular to the central axis of a specific EQUIPMENT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column max_width_dim
        /// </value>
        [AttrIx(100007)]
		[AttrName("equipment-type-maximum-width-dimension")]
		[AttrColumnName("max_width_dim")]
        [AttrSeqnr(7)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? MaximumWidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fuel_cap_qty
		///
		/// The numeric value that represents the usable fuel capacity of an EQUIPMENT-TYPE. The unit of measure is litre.
        /// </summary>
        /// <value>
        /// Value of the column fuel_cap_qty
        /// </value>
        [AttrIx(100008)]
		[AttrName("equipment-type-fuel-capacity-quantity")]
		[AttrColumnName("fuel_cap_qty")]
        [AttrSeqnr(8)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? FuelCapacityQuantity { get; set; }
		
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
