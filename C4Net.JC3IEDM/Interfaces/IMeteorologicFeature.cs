using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity MeteorologicFeature that represents the table MET_FEAT
	/// 
	/// A FEATURE that describes reported or forecast weather and light conditions.
    /// </summary>
	[EntId(10000073)]
    [EntName("METEOROLOGIC-FEATURE")]
    [EntTableName("MET_FEAT")]
    [EntDepth(2)]
    public interface IMeteorologicFeature
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column met_feat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column met_feat_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("meteorologic-feature-id")]
		[AttrColumnName("met_feat_id")]
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
		/// The specific value that represents the class of METEOROLOGIC-FEATURE. It serves as a discriminator that partitions METEOROLOGIC-FEATURE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("meteorologic-feature-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000195)]
        [DataLength(6)]
        [DataDecimals(0)]
        MeteorologicFeatureCategoryEnum MeteorologicFeatureCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column interpretation_code
		///
		/// The specific value that denotes the statistical meaning of a specified METEOROLOGIC-FEATURE.
        /// </summary>
        /// <value>
        /// Value of the column interpretation_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("meteorologic-feature-interpretation-code")]
		[AttrColumnName("interpretation_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000196)]
        [DataLength(6)]
        [DataDecimals(0)]
        MeteorologicFeatureInterpretationEnum Interpretation { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prob_rat
		///
		/// The numeric quotient value that represents the likelihood that a specific condition will occur for a specific METEOROLOGIC-FEATURE. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column prob_rat
        /// </value>
        [AttrIx(100004)]
		[AttrName("meteorologic-feature-probability-ratio")]
		[AttrColumnName("prob_rat")]
        [AttrSeqnr(4)]
        [DomId(100001900)]
        [DataLength(6)]
        [DataDecimals(5)]
        double? ProbabilityRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column source_code
		///
		/// The specific value that denotes the basis for the estimate of a condition for a specific METEOROLOGIC-FEATURE.
        /// </summary>
        /// <value>
        /// Value of the column source_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("meteorologic-feature-source-code")]
		[AttrColumnName("source_code")]
        [AttrSeqnr(5)]
        [DomId(100000169)]
        [DataLength(6)]
        [DataDecimals(0)]
        MeteorologicFeatureSourceEnum? Source { get; set; }
		
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
