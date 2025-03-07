using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity OrganisationStructure that represents the table ORG_STRUCT
	/// 
	/// The hierarchical configuration of a specific root ORGANISATION where the configuration is specified by reference to a set of associations between instances of OBJECT-ITEM.
    /// </summary>
	[EntId(10000245)]
    [EntName("ORGANISATION-STRUCTURE")]
    [EntTableName("ORG_STRUCT")]
    [EntDepth(3)]
    public interface IOrganisationStructure
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
        decimal RootOrganisationId { get; set; }
		
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
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column name_txt
		///
		/// The character string assigned to represent a specific ORGANISATION-STRUCTURE.
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
        [AttrIx(100003)]
		[AttrName("organisation-structure-name-text")]
		[AttrColumnName("name_txt")]
        [AttrSeqnr(3)]
        [DomId(100001500)]
        [DataLength(100)]
        [DataDecimals(0)]
        string NameText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
        [AttrIx(100004)]
		[AttrName("reporting-data-id")]
		[AttrColumnName("rptd_id")]
        [AttrSeqnr(4)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000912)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ReportingDataId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type of the ORGANISATION-STRUCTURE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("organisation-structure-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100004429)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationStructureCategoryEnum OrganisationStructureCategory { get; set; }
		
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
        [AttrIx(100006)]
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
