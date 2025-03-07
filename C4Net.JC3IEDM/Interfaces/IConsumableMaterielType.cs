using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ConsumableMaterielType that represents the table CONS_MAT_TYPE
	/// 
	/// A MATERIEL-TYPE that is an expendable class of supply.
    /// </summary>
	[EntId(10000028)]
    [EntName("CONSUMABLE-MATERIEL-TYPE")]
    [EntTableName("CONS_MAT_TYPE")]
    [EntDepth(2)]
    public interface IConsumableMaterielType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cons_mat_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column cons_mat_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("consumable-materiel-type-id")]
		[AttrColumnName("cons_mat_type_id")]
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
		/// The specific value that represents the class of CONSUMABLE-MATERIEL-TYPE. It serves as a discriminator that partitions CONSUMABLE-MATERIEL-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("consumable-materiel-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000123)]
        [DataLength(6)]
        [DataDecimals(0)]
        ConsumableMaterielTypeCategoryEnum ConsumableMaterielTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the detailed class of a specific CONSUMABLE-MATERIEL-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("consumable-materiel-type-subcategory-code")]
		[AttrColumnName("subcat_code")]
        [AttrSeqnr(3)]
        [DomId(100000185)]
        [DataLength(6)]
        [DataDecimals(0)]
        ConsumableMaterielTypeSubcategoryEnum? Subcategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column hazard_code
		///
		/// The specific value that represents a CONSUMABLE-MATERIEL-TYPE that requires special handling because of environmental or safety reasons.
        /// </summary>
        /// <value>
        /// Value of the column hazard_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("consumable-materiel-type-hazard-code")]
		[AttrColumnName("hazard_code")]
        [AttrSeqnr(4)]
        [DomId(100000186)]
        [DataLength(6)]
        [DataDecimals(0)]
        ConsumableMaterielTypeHazardEnum? Hazard { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column issuing_elmt_code
		///
		/// The specific value that represents a standard unit in which a specific CONSUMABLE-MATERIEL-TYPE is made available.
        /// </summary>
        /// <value>
        /// Value of the column issuing_elmt_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("consumable-materiel-type-issuing-element-code")]
		[AttrColumnName("issuing_elmt_code")]
        [AttrSeqnr(5)]
        [DomId(100000132)]
        [DataLength(6)]
        [DataDecimals(0)]
        ConsumableMaterielTypeIssuingElementEnum? IssuingElement { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column issuing_cnt
		///
		/// The integer value representing the aggregated units in which a specific CONSUMABLE-MATERIEL-TYPE is made available.
        /// </summary>
        /// <value>
        /// Value of the column issuing_cnt
        /// </value>
        [AttrIx(100006)]
		[AttrName("consumable-materiel-type-issuing-count")]
		[AttrColumnName("issuing_cnt")]
        [AttrSeqnr(6)]
        [DomId(100001800)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? IssuingCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column issuing_uom_code
		///
		/// The specific value that represents the unit of measure of which a standard quantity (unit) of a specific CONSUMABLE-MATERIEL-TYPE is made available.
        /// </summary>
        /// <value>
        /// Value of the column issuing_uom_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("consumable-materiel-type-issuing-unit-of-measure-code")]
		[AttrColumnName("issuing_uom_code")]
        [AttrSeqnr(7)]
        [DomId(100000124)]
        [DataLength(6)]
        [DataDecimals(0)]
        ConsumableMaterielTypeIssuingUnitOfMeasureEnum? IssuingUnitOfMeasure { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column issuing_wt_qty
		///
		/// The numeric value that represents the gravitational force exerted on an amount of a standard unit of issue for a specific CONSUMABLE-MATERIEL-TYPE when it is prepared for delivery. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column issuing_wt_qty
        /// </value>
        [AttrIx(100008)]
		[AttrName("consumable-materiel-type-issuing-weight-quantity")]
		[AttrColumnName("issuing_wt_qty")]
        [AttrSeqnr(8)]
        [DomId(100001200)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? IssuingWeightQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column perishability_ind_code
		///
		/// The specific value that represents whether a particular CONSUMABLE-MATERIEL-TYPE is liable to decay or spoil.
        /// </summary>
        /// <value>
        /// Value of the column perishability_ind_code
        /// </value>
        [AttrIx(100009)]
		[AttrName("consumable-materiel-type-perishability-indicator-code")]
		[AttrColumnName("perishability_ind_code")]
        [AttrSeqnr(9)]
        [DomId(100000228)]
        [DataLength(6)]
        [DataDecimals(0)]
        ConsumableMaterielTypePerishabilityIndicatorEnum? PerishabilityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column united_nations_no_code
		///
		/// The specific value that represents the United Nations (UN) Numbers that are four-digit numbers used world-wide in international commerce and transportation to identify hazardous chemicals or classes of hazardous materials.
        /// </summary>
        /// <value>
        /// Value of the column united_nations_no_code
        /// </value>
        [AttrIx(100010)]
		[AttrName("consumable-materiel-type-united-nations-number-code")]
		[AttrColumnName("united_nations_no_code")]
        [AttrSeqnr(10)]
        [DomId(100004268)]
        [DataLength(6)]
        [DataDecimals(0)]
        ConsumableMaterielTypeUnitedNationsNumberEnum? UnitedNationsNumber { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100011)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(11)]
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
        [AttrIx(100012)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(12)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
