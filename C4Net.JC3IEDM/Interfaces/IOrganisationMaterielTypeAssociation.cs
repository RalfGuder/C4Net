using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity OrganisationMaterielTypeAssociation that represents the table ORG_MAT_TYPE_ASSOC
	/// 
	/// A relationship of an ORGANISATION as a subject with a MATERIEL-TYPE as an object.
    /// </summary>
	[EntId(10000174)]
    [EntName("ORGANISATION-MATERIEL-TYPE-ASSOCIATION")]
    [EntTableName("ORG_MAT_TYPE_ASSOC")]
    [EntDepth(2)]
    public interface IOrganisationMaterielTypeAssociation
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
        /// Gets or sets the value of the column mat_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column mat_type_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("materiel-type-id")]
		[AttrColumnName("mat_type_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal MaterielTypeId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptbl_type_code
		///
		/// The specific value that represents the class of ORGANISATION-MATERIEL-TYPE-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column rptbl_type_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("organisation-materiel-type-association-reportable-type-code")]
		[AttrColumnName("rptbl_type_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100004239)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationMaterielTypeAssociationReportableTypeEnum ReportableType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptbl_type_txt
		///
		/// The character string assigned to represent the Reportable type code for a specific MATERIEL-TYPE, as assigned by a specific ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column rptbl_type_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("organisation-materiel-type-association-reportable-type-text")]
		[AttrColumnName("rptbl_type_txt")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100001500)]
        [DataLength(6)]
        [DataDecimals(0)]
        string ReportableTypeText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptbl_type_dttm
		///
		/// The character string representing a point in time that designates when the Reportable type code referenced by the ORGANISATION-MATERIEL-TYPE-ASSOCIATION is assigned.
        /// </summary>
        /// <value>
        /// Value of the column rptbl_type_dttm
        /// </value>
        [AttrIx(100005)]
		[AttrName("organisation-materiel-type-association-reportable-type-datetime")]
		[AttrColumnName("rptbl_type_dttm")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string ReportableTypeDatetime { get; set; }
		
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
