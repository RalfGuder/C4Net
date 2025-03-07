using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ObjectItemReferenceAssociation that represents the table OBJ_ITEM_REF_ASSOC
	/// 
	/// A relationship between a specific OBJECT-ITEM and a specific REFERENCE.
    /// </summary>
	[EntId(10000288)]
    [EntName("OBJECT-ITEM-REFERENCE-ASSOCIATION")]
    [EntTableName("OBJ_ITEM_REF_ASSOC")]
    [EntDepth(2)]
    public interface IObjectItemReferenceAssociation
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("object-item-id")]
		[AttrColumnName("obj_item_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemId { get; set; }
		
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
        /// Gets or sets the value of the column obj_item_ref_assoc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-REFERENCE-ASSOCIATION for a specific OBJECT-ITEM and a specific REFERENCE and to distinguish it from all other OBJECT-ITEM-REFERENCE-ASSOCIATIONs for that OBJECT-ITEM and that REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_ref_assoc_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("object-item-reference-association-index")]
		[AttrColumnName("obj_item_ref_assoc_ix")]
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
		/// The specific value that represents the class of a specific OBJECT-ITEM-REFERENCE-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("object-item-reference-association-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(4)]
        [DomId(100004228)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectItemReferenceAssociationCategoryEnum? ObjectItemReferenceAssociationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column specific_part_txt
		///
		/// The character string assigned to represent a specific part of the artefact that applies in a specific OBJECT-ITEM-REFERENCE-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column specific_part_txt
        /// </value>
        [AttrIx(100005)]
		[AttrName("object-item-reference-association-specific-part-text")]
		[AttrColumnName("specific_part_txt")]
        [AttrSeqnr(5)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string SpecificPartText { get; set; }
		
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
