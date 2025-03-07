using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity OperationalInformationGroupOrganisationAssociation that represents the table OIG_ORG_ASSOC
	/// 
	/// A relationship of a specific OPERATIONAL-INFORMATION-GROUP with a specific ORGANISATION for specifying the role of the ORGANISATION with respect to the OPERATIONAL-INFORMATION-GROUP.
    /// </summary>
	[EntId(10000300)]
    [EntName("OPERATIONAL-INFORMATION-GROUP-ORGANISATION-ASSOCIATION")]
    [EntTableName("OIG_ORG_ASSOC")]
    [EntDepth(3)]
    public interface IOperationalInformationGroupOrganisationAssociation
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column oig_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CONTEXT and to distinguish it from all other CONTEXTs.
        /// </summary>
        /// <value>
        /// Value of the column oig_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("operational-information-group-id")]
		[AttrColumnName("oig_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000901)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal OperationalInformationGroupId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column org_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("organisation-id")]
		[AttrColumnName("org_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal OrganisationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column oig_org_assoc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OPERATIONAL-INFORMATION-GROUP-ORGANISATION-ASSOCIATION for a specific OPERATIONAL-INFORMATION-GROUP and a specific ORGANISATION and to distinguish it from all other OPERATIONAL-INFORMATION-GROUP-ORGANISATION-ASSOCIATIONs for that OPERATIONAL-INFORMATION-GROUP and that ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column oig_org_assoc_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("operational-information-group-organisation-association-index")]
		[AttrColumnName("oig_org_assoc_ix")]
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
		/// The specific value that represents the type of relationship between a specific OPERATIONAL-INFORMATION-GROUP and a specific ORGANISATION in a specific OPERATIONAL-INFORMATION-GROUP-ORGANISATION-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("operational-information-group-organisation-association-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100004247)]
        [DataLength(6)]
        [DataDecimals(0)]
        OperationalInformationGroupOrganisationAssociationCategoryEnum OperationalInformationGroupOrganisationAssociationCategory { get; set; }
		
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
