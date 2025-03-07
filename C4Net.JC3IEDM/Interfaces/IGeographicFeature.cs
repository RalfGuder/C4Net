using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity GeographicFeature that represents the table GEO_FEAT
	/// 
	/// A FEATURE describing terrain characteristics to which military significance is attached.
    /// </summary>
	[EntId(10000053)]
    [EntName("GEOGRAPHIC-FEATURE")]
    [EntTableName("GEO_FEAT")]
    [EntDepth(2)]
    public interface IGeographicFeature
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column geo_feat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column geo_feat_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("geographic-feature-id")]
		[AttrColumnName("geo_feat_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column btm_hardness_code
		///
		/// A specific value that represents the subjective indication obtained by a diver of the hardness of the liquid/solid surface interface and is the result of a single arm thrust.
        /// </summary>
        /// <value>
        /// Value of the column btm_hardness_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("geographic-feature-bottom-hardness-code")]
		[AttrColumnName("btm_hardness_code")]
        [AttrSeqnr(2)]
        [DomId(100004338)]
        [DataLength(6)]
        [DataDecimals(0)]
        GeographicFeatureBottomHardnessEnum? BottomHardness { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column btm_penetration_qty
		///
		/// The numeric value that represents the depth to which a diver is able to thrust his fist or fingers into the surface of the solid/liquid interface. The unit of measure is metres.
        /// </summary>
        /// <value>
        /// Value of the column btm_penetration_qty
        /// </value>
        [AttrIx(100003)]
		[AttrName("geographic-feature-bottom-penetration-quantity")]
		[AttrColumnName("btm_penetration_qty")]
        [AttrSeqnr(3)]
        [DomId(100001200)]
        [DataLength(3)]
        [DataDecimals(2)]
        double? BottomPenetrationQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column sld_surf_cmps_code
		///
		/// The specific value that represents the composition of the surface of the GEOGRAPHIC-FEATURE.
        /// </summary>
        /// <value>
        /// Value of the column sld_surf_cmps_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("geographic-feature-solid-surface-composition-code")]
		[AttrColumnName("sld_surf_cmps_code")]
        [AttrSeqnr(4)]
        [DomId(100004205)]
        [DataLength(6)]
        [DataDecimals(0)]
        GeographicFeatureSolidSurfaceCompositionEnum? SolidSurfaceComposition { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column surf_cat_code
		///
		/// The specific value that represents the type of surface of the GEOGRAPHIC-FEATURE.
        /// </summary>
        /// <value>
        /// Value of the column surf_cat_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("geographic-feature-surface-category-code")]
		[AttrColumnName("surf_cat_code")]
        [AttrSeqnr(5)]
        [DomId(100004206)]
        [DataLength(6)]
        [DataDecimals(0)]
        GeographicFeatureSurfaceCategoryEnum? SurfaceCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column trn_code
		///
		/// The specific value that represents a tract of land.
        /// </summary>
        /// <value>
        /// Value of the column trn_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("geographic-feature-terrain-code")]
		[AttrColumnName("trn_code")]
        [AttrSeqnr(6)]
        [DomId(100004207)]
        [DataLength(6)]
        [DataDecimals(0)]
        GeographicFeatureTerrainEnum? Terrain { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column veg_cat_code
		///
		/// The specific value that represents the general vegetation class on a specific GEOGRAPHIC-FEATURE.
        /// </summary>
        /// <value>
        /// Value of the column veg_cat_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("geographic-feature-vegetation-category-code")]
		[AttrColumnName("veg_cat_code")]
        [AttrSeqnr(7)]
        [DomId(100004208)]
        [DataLength(6)]
        [DataDecimals(0)]
        VegetationCategoryEnum? VegetationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column veg_subcat_code
		///
		/// The specific value that represents the detailed vegetation class on a specific GEOGRAPHIC-FEATURE.
        /// </summary>
        /// <value>
        /// Value of the column veg_subcat_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("geographic-feature-vegetation-subcategory-code")]
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
