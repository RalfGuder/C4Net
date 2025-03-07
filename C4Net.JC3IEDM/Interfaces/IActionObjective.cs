using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionObjective that represents the table ACT_OBJVE
	/// 
	/// The focus, in terms of an OBJECT-ITEM, OBJECT-TYPE, or ACTION-TASK, in conducting a specific ACTION.
    /// </summary>
	[EntId(10000008)]
    [EntName("ACTION-OBJECTIVE")]
    [EntTableName("ACT_OBJVE")]
    [EntDepth(2)]
    public interface IActionObjective
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
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ACTION-OBJECTIVE with respect to item or type. It serves as a discriminator that partitions ACTION-OBJECTIVE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-objective-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000115)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionObjectiveCategoryEnum ActionObjectiveCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qual_code
		///
		/// The specific value that represents a restriction or other qualification applicable to a specific ACTION-OBJECTIVE for a specific ACTION.
        /// </summary>
        /// <value>
        /// Value of the column qual_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-objective-qualifier-code")]
		[AttrColumnName("qual_code")]
        [AttrSeqnr(4)]
        [DomId(100000116)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionObjectiveQualifierEnum? Qualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column authorising_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column authorising_org_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("action-objective-authorising-organisation-id")]
		[AttrColumnName("authorising_org_id")]
        [AttrSeqnr(5)]
        [ForeignKey]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? AuthorisingOrganisationId { get; set; }
		
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
