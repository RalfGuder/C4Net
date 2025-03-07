using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity CloudCover that represents the table CLOUD_COVER
	/// 
	/// A METEOROLOGIC-FEATURE that specifies the characteristics of clouds above Earth's surface.
    /// </summary>
	[EntId(10000023)]
    [EntName("CLOUD-COVER")]
    [EntTableName("CLOUD_COVER")]
    [EntDepth(3)]
    public interface ICloudCover
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cloud_cover_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column cloud_cover_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("cloud-cover-id")]
		[AttrColumnName("cloud_cover_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the prevailing class of a specific CLOUD-COVER.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("cloud-cover-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000168)]
        [DataLength(6)]
        [DataDecimals(0)]
        CloudCoverCategoryEnum CloudCoverCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column base_dim
		///
		/// The one-dimensional linear distance representing the elevation of the lowest cloud base for a specific CLOUD-COVER.
        /// </summary>
        /// <value>
        /// Value of the column base_dim
        /// </value>
        [AttrIx(100003)]
		[AttrName("cloud-cover-base-dimension")]
		[AttrColumnName("base_dim")]
        [AttrSeqnr(3)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? BaseDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column top_dim
		///
		/// The one-dimensional linear distance representing the elevation of the highest cloud ceiling for a specific CLOUD-COVER.
        /// </summary>
        /// <value>
        /// Value of the column top_dim
        /// </value>
        [AttrIx(100004)]
		[AttrName("cloud-cover-top-dimension")]
		[AttrColumnName("top_dim")]
        [AttrSeqnr(4)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? TopDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column avg_cvrg_code
		///
		/// The specific value that represents the average density of a specific CLOUD-COVER as fractional coverage.
        /// </summary>
        /// <value>
        /// Value of the column avg_cvrg_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("cloud-cover-average-coverage-code")]
		[AttrColumnName("avg_cvrg_code")]
        [AttrSeqnr(5)]
        [DomId(100000213)]
        [DataLength(6)]
        [DataDecimals(0)]
        CloudCoverAverageCoverageEnum? AverageCoverage { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column light_refraction_rat
		///
		/// The numeric quotient value that represents the velocity of light in a specific CLOUD-COVER as a fraction of the velocity of light in a vacuum, based on cloud height. This represents the inverse of the index of refraction. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column light_refraction_rat
        /// </value>
        [AttrIx(100006)]
		[AttrName("cloud-cover-light-refraction-ratio")]
		[AttrColumnName("light_refraction_rat")]
        [AttrSeqnr(6)]
        [DomId(100001900)]
        [DataLength(7)]
        [DataDecimals(6)]
        double? LightRefractionRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(7)]
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
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(8)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
