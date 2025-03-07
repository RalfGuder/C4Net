using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionReconnaissanceEmployment that represents the table ACT_RECCE_EMPLOY
	/// 
	/// The parameters that guide the use of an ACTION-RESOURCE that is employed in a reconnaissance role.
    /// </summary>
	[EntId(10000305)]
    [EntName("ACTION-RECONNAISSANCE-EMPLOYMENT")]
    [EntTableName("ACT_RECCE_EMPLOY")]
    [EntDepth(4)]
    public interface IActionReconnaissanceEmployment
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
        /// Gets or sets the value of the column act_res_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-RESOURCE for a specific ACTION and to distinguish it from all other ACTION-RESOURCEs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_res_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-resource-index")]
		[AttrColumnName("act_res_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionResourceIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_res_employ_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-RESOURCE-EMPLOYMENT for a specific ACTION-RESOURCE and to distinguish it from all other ACTION-RESOURCE-EMPLOYMENTs for that ACTION-RESOURCE.
        /// </summary>
        /// <value>
        /// Value of the column act_res_employ_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-resource-employment-index")]
		[AttrColumnName("act_res_employ_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionResourceEmploymentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column img_cvrg_mode_code
		///
		/// The specific value that represents the mode of image coverage required.
        /// </summary>
        /// <value>
        /// Value of the column img_cvrg_mode_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-reconnaissance-employment-image-coverage-mode-code")]
		[AttrColumnName("img_cvrg_mode_code")]
        [AttrSeqnr(4)]
        [DomId(100004249)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionReconnaissanceEmploymentImageCoverageModeEnum? ImageCoverageMode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column img_view_qual_code
		///
		/// The specific value that represents the recorded media based on the type of imagery the interpreter is viewing.
        /// </summary>
        /// <value>
        /// Value of the column img_view_qual_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("action-reconnaissance-employment-image-view-qualifier-code")]
		[AttrColumnName("img_view_qual_code")]
        [AttrSeqnr(5)]
        [DomId(100004250)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionReconnaissanceEmploymentImageViewQualifierEnum? ImageViewQualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column type_of_cvrg_code
		///
		/// The specific value that represents the type of coverage required.
        /// </summary>
        /// <value>
        /// Value of the column type_of_cvrg_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("action-reconnaissance-employment-type-of-coverage-code")]
		[AttrColumnName("type_of_cvrg_code")]
        [AttrSeqnr(6)]
        [DomId(100004335)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionReconnaissanceEmploymentTypeOfCoverageEnum? TypeOfCoverage { get; set; }
		
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
