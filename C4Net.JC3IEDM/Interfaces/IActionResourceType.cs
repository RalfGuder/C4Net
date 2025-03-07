using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionResourceType that represents the table ACT_RES_TYPE
	/// 
	/// An OBJECT-TYPE (FACILITY-TYPE, FEATURE-TYPE, MATERIEL-TYPE, ORGANISATION-TYPE, or PERSON-TYPE) to be used, excluded from use, being used, or having been used, in conducting a specific ACTION.
    /// </summary>
	[EntId(10000015)]
    [EntName("ACTION-RESOURCE-TYPE")]
    [EntTableName("ACT_RES_TYPE")]
    [EntDepth(3)]
    public interface IActionResourceType
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
        /// Gets or sets the value of the column qty
		///
		/// The numeric value that represents the aggregated units of a specific ACTION-RESOURCE-TYPE. No unit of measure is required.
        /// </summary>
        /// <value>
        /// Value of the column qty
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-resource-type-quantity")]
		[AttrColumnName("qty")]
        [AttrSeqnr(3)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? Quantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column aprtnmt_rat
		///
		/// The numeric quotient value that represents a proportion of a specific ACTION-RESOURCE-TYPE devoted to an ACTION. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column aprtnmt_rat
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-resource-type-apportionment-ratio")]
		[AttrColumnName("aprtnmt_rat")]
        [AttrSeqnr(4)]
        [DomId(100001900)]
        [DataLength(6)]
        [DataDecimals(5)]
        double? ApportionmentRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column obj_type_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("object-type-id")]
		[AttrColumnName("obj_type_id")]
        [AttrSeqnr(5)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectTypeId { get; set; }
		
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
