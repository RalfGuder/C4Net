using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity OrganisationStructureDetail that represents the table ORG_STRUCT_DET
	/// 
	/// The identification of a specific OBJECT-ITEM-ASSOCIATION as an element in a specific ORGANISATION-STRUCTURE.
    /// </summary>
	[EntId(10000246)]
    [EntName("ORGANISATION-STRUCTURE-DETAIL")]
    [EntTableName("ORG_STRUCT_DET")]
    [EntDepth(6)]
    public interface IOrganisationStructureDetail
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column org_struct_root_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column org_struct_root_org_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("organisation-structure-root-organisation-id")]
		[AttrColumnName("org_struct_root_org_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal OrganisationStructureRootOrganisationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_struct_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ORGANISATION-STRUCTURE for a specific ORGANISATION and to distinguish it from all other ORGANISATION-STRUCTUREs for that ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column org_struct_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("organisation-structure-index")]
		[AttrColumnName("org_struct_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal OrganisationStructureIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_struct_det_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ORGANISATION-STRUCTURE-DETAIL for a specific ORGANISATION-STRUCTURE and to distinguish it from all other ORGANISATION-STRUCTURE-DETAILs for that ORGANISATION-STRUCTURE.
        /// </summary>
        /// <value>
        /// Value of the column org_struct_det_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("organisation-structure-detail-index")]
		[AttrColumnName("org_struct_det_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subj_obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column subj_obj_item_id
        /// </value>
        [AttrIx(100004)]
		[AttrName("object-item-association-subject-object-item-id")]
		[AttrColumnName("subj_obj_item_id")]
        [AttrSeqnr(4)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemAssociationSubjectObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_obj_item_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("object-item-association-object-object-item-id")]
		[AttrColumnName("obj_obj_item_id")]
        [AttrSeqnr(5)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemAssociationObjectObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_assoc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-ASSOCIATION for a subject OBJECT-ITEM and an object OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-ASSOCIATIONs for those OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_assoc_ix
        /// </value>
        [AttrIx(100006)]
		[AttrName("object-item-association-index")]
		[AttrColumnName("obj_item_assoc_ix")]
        [AttrSeqnr(6)]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemAssociationIndex { get; set; }
		
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
