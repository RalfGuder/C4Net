using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity SolidSurfaceStatus that represents the table SLD_SURF_STAT
	/// 
	/// A GEOGRAPHIC-FEATURE-STATUS that is a record of condition of a specific solid surface.
    /// </summary>
	[EntId(10000279)]
    [EntName("SOLID-SURFACE-STATUS")]
    [EntTableName("SLD_SURF_STAT")]
    [EntDepth(5)]
    public interface ISolidSurfaceStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column sld_surf_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column sld_surf_stat_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("solid-surface-status-id")]
		[AttrColumnName("sld_surf_stat_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-STATUS for a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-STATUSs for that OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_stat_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("object-item-status-index")]
		[AttrColumnName("obj_item_stat_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemStatusIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column code
		///
		/// The specific value that represents the status of a specific solid surface.
        /// </summary>
        /// <value>
        /// Value of the column code
        /// </value>
        [AttrIx(100003)]
		[AttrName("solid-surface-status-code")]
		[AttrColumnName("code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000253)]
        [DataLength(6)]
        [DataDecimals(0)]
        SolidSurfaceStatusEnum SolidSurfaceStatusCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dmltn_stat_code
		///
		/// The specific value that represents the status of an object destined for demolition.
        /// </summary>
        /// <value>
        /// Value of the column dmltn_stat_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("solid-surface-status-demolition-status-code")]
		[AttrColumnName("dmltn_stat_code")]
        [AttrSeqnr(4)]
        [DomId(100000367)]
        [DataLength(6)]
        [DataDecimals(0)]
        DemolitionStatusEnum? DemolitionStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column surf_cond_code
		///
		/// The specific value that represents the physical status of a solid surface area.
        /// </summary>
        /// <value>
        /// Value of the column surf_cond_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("solid-surface-status-surface-condition-code")]
		[AttrColumnName("surf_cond_code")]
        [AttrSeqnr(5)]
        [DomId(100000254)]
        [DataLength(6)]
        [DataDecimals(0)]
        SolidSurfaceStatusSurfaceConditionEnum? SurfaceCondition { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column surf_firm_code
		///
		/// The specific value that represents the firmness of a surface area, in terms of its ability to support land vehicles or helicopters.
        /// </summary>
        /// <value>
        /// Value of the column surf_firm_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("solid-surface-status-surface-firmness-code")]
		[AttrColumnName("surf_firm_code")]
        [AttrSeqnr(6)]
        [DomId(100000308)]
        [DataLength(6)]
        [DataDecimals(0)]
        SolidSurfaceStatusSurfaceFirmnessEnum? SurfaceFirmness { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column veg_cat_code
		///
		/// The specific value that represents the general vegetation class of a specific SOLID-SURFACE-STATUS.
        /// </summary>
        /// <value>
        /// Value of the column veg_cat_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("solid-surface-status-vegetation-category-code")]
		[AttrColumnName("veg_cat_code")]
        [AttrSeqnr(7)]
        [DomId(100004208)]
        [DataLength(6)]
        [DataDecimals(0)]
        VegetationCategoryEnum? VegetationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column veg_subcat_code
		///
		/// The specific value that represents the detailed vegetation class of a specific SOLID-SURFACE-STATUS.
        /// </summary>
        /// <value>
        /// Value of the column veg_subcat_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("solid-surface-status-vegetation-subcategory-code")]
		[AttrColumnName("veg_subcat_code")]
        [AttrSeqnr(8)]
        [DomId(100004328)]
        [DataLength(6)]
        [DataDecimals(0)]
        VegetationSubcategoryEnum? VegetationSubcategory { get; set; }
		
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
