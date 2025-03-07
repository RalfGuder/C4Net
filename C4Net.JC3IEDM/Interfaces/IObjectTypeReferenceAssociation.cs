using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ObjectTypeReferenceAssociation that represents the table OBJ_TYPE_REF_ASSOC
	/// 
	/// A relationship between a specific OBJECT-TYPE and a specific REFERENCE.
    /// </summary>
	[EntId(10000289)]
    [EntName("OBJECT-TYPE-REFERENCE-ASSOCIATION")]
    [EntTableName("OBJ_TYPE_REF_ASSOC")]
    [EntDepth(2)]
    public interface IObjectTypeReferenceAssociation
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column obj_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column obj_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("object-type-id")]
		[AttrColumnName("obj_type_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectTypeId { get; set; }
		
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
		/// The specific value that represents the class of a specific OBJECT-TYPE-REFERENCE-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("object-type-reference-association-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(3)]
        [DomId(100004229)]
        [DataLength(6)]
        [DataDecimals(0)]
        ObjectTypeReferenceAssociationCategoryEnum? ObjectTypeReferenceAssociationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100004)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(4)]
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
        [AttrIx(100005)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
