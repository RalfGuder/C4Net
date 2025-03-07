using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionReferenceAssociation that represents the table ACT_REF_ASSOC
	/// 
	/// A relationship between a specific ACTION and a specific REFERENCE.
    /// </summary>
	[EntId(10000286)]
    [EntName("ACTION-REFERENCE-ASSOCIATION")]
    [EntTableName("ACT_REF_ASSOC")]
    [EntDepth(2)]
    public interface IActionReferenceAssociation
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
        /// Gets or sets the value of the column ref_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REFERENCE and to distinguish it from all other REFERENCEs.
        /// </summary>
        /// <value>
        /// Value of the column ref_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("reference-id")]
		[AttrColumnName("ref_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000911)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ReferenceId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of a specific ACTION-REFERENCE-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-reference-association-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(3)]
        [DomId(100004226)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionReferenceAssociationCategoryEnum? ActionReferenceAssociationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column part_txt
		///
		/// The character string assigned to represent a specific part of the artefact that applies in a specific ACTION-REFERENCE-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column part_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-reference-association-part-text")]
		[AttrColumnName("part_txt")]
        [AttrSeqnr(4)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string PartText { get; set; }
		
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
