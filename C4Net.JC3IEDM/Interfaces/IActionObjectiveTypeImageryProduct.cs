using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionObjectiveTypeImageryProduct that represents the table ACT_OBJVE_TYPE_IMGRY_PROD
	/// 
	/// The intended characteristics of a specific ACTION-OBJECTIVE-TYPE-IMAGERY-PRODUCT that is an instance of MATERIEL-TYPE.
    /// </summary>
	[EntId(10000306)]
    [EntName("ACTION-OBJECTIVE-TYPE-IMAGERY-PRODUCT")]
    [EntTableName("ACT_OBJVE_TYPE_IMGRY_PROD")]
    [EntDepth(7)]
    public interface IActionObjectiveTypeImageryProduct
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("action-id")]
		[AttrColumnName("act_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_objve_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-OBJECTIVE for a specific ACTION and to distinguish it from all other ACTION-OBJECTIVEs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_objve_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-objective-index")]
		[AttrColumnName("act_objve_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionObjectiveIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column img_scale_cnt
		///
		/// The integer value representing the scale of the imagery mapping required.
        /// </summary>
        /// <value>
        /// Value of the column img_scale_cnt
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-objective-type-imagery-product-image-scale-count")]
		[AttrColumnName("img_scale_cnt")]
        [AttrSeqnr(3)]
        [DomId(100001800)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? ImageScaleCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column img_type_code
		///
		/// The specific value that represents the media of transmission and the quality of the photographic product required.
        /// </summary>
        /// <value>
        /// Value of the column img_type_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-objective-type-imagery-product-image-type-code")]
		[AttrColumnName("img_type_code")]
        [AttrSeqnr(4)]
        [DomId(100004252)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionObjectiveTypeImageryProductImageTypeEnum? ImageType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(5)]
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
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
