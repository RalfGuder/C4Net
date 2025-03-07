using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionResourceEmployment that represents the table ACT_RES_EMPLOY
	/// 
	/// The procedure for using a specific ACTION-RESOURCE with or without dependence upon a specific ACTION-OBJECTIVE.
    /// </summary>
	[EntId(10000013)]
    [EntName("ACTION-RESOURCE-EMPLOYMENT")]
    [EntTableName("ACT_RES_EMPLOY")]
    [EntDepth(3)]
    public interface IActionResourceEmployment
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
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ACTION-RESOURCE-EMPLOYMENT. It serves as a discriminator that partitions ACTION-RESOURCE-EMPLOYMENT into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-resource-employment-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000207)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionResourceEmploymentCategoryEnum ActionResourceEmploymentCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column azimuth_fire_angle
		///
		/// The rotational measurement clockwise from the line of true North specifying the direction of fire for the ACTION-RESOURCE.
        /// </summary>
        /// <value>
        /// Value of the column azimuth_fire_angle
        /// </value>
        [AttrIx(100005)]
		[AttrName("action-resource-employment-azimuth-fire-angle")]
		[AttrColumnName("azimuth_fire_angle")]
        [AttrSeqnr(5)]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double? AzimuthFireAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column method_of_ctrl_code
		///
		/// The specific value that represents the standard procedure to be used in controlling the employment of a specific ACTION-RESOURCE in support of a specific ACTION.
        /// </summary>
        /// <value>
        /// Value of the column method_of_ctrl_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("action-resource-employment-method-of-control-code")]
		[AttrColumnName("method_of_ctrl_code")]
        [AttrSeqnr(6)]
        [DomId(100000118)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionResourceEmploymentMethodOfControlEnum? MethodOfControl { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column trajectory_fire_code
		///
		/// The specific value that represents the type of trajectory to be used in firing of a specific ACTION-RESOURCE in support of a specific ACTION.
        /// </summary>
        /// <value>
        /// Value of the column trajectory_fire_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("action-resource-employment-trajectory-fire-code")]
		[AttrColumnName("trajectory_fire_code")]
        [AttrSeqnr(7)]
        [DomId(100004313)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionResourceEmploymentTrajectoryFireEnum? TrajectoryFire { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_objve_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-OBJECTIVE for a specific ACTION and to distinguish it from all other ACTION-OBJECTIVEs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_objve_ix
        /// </value>
        [AttrIx(100008)]
		[AttrName("action-objective-index")]
		[AttrColumnName("act_objve_ix")]
        [AttrSeqnr(8)]
        [ForeignKey]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? ActionObjectiveIndex { get; set; }
		
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
