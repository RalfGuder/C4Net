using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity OrganisationReferenceAssociation that represents the table ORG_REF_ASSOC
	/// 
	/// A relationship between a specific ORGANISATION and a specific REFERENCE.
    /// </summary>
	[EntId(10000290)]
    [EntName("ORGANISATION-REFERENCE-ASSOCIATION")]
    [EntTableName("ORG_REF_ASSOC")]
    [EntDepth(2)]
    public interface IOrganisationReferenceAssociation
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column org_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("organisation-id")]
		[AttrColumnName("org_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal OrganisationId { get; set; }
		
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
        /// Gets or sets the value of the column org_ref_assoc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ORGANISATION-REFERENCE-ASSOCIATION for a specific ORGANISATION and a specific REFERENCE and to distinguish it from all other ORGANISATION-REFERENCE-ASSOCIATIONs for that ORGANISATION and that REFERENCE.
        /// </summary>
        /// <value>
        /// Value of the column org_ref_assoc_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("organisation-reference-association-index")]
		[AttrColumnName("org_ref_assoc_ix")]
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
		/// The specific value that represents the class of a specific ORGANISATION-REFERENCE-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("organisation-reference-association-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(4)]
        [DomId(100004230)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationReferenceAssociationCategoryEnum? OrganisationReferenceAssociationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column start_dttm
		///
		/// The character string representing a point in time that designates the start of a specific ORGANISATION-REFERENCE-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column start_dttm
        /// </value>
        [AttrIx(100005)]
		[AttrName("organisation-reference-association-start-datetime")]
		[AttrColumnName("start_dttm")]
        [AttrSeqnr(5)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string StartDatetime { get; set; }
		
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
