using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity OrganisationType that represents the table ORG_TYPE
	/// 
	/// An OBJECT-TYPE that represents administrative or functional structures.
    /// </summary>
	[EntId(10000094)]
    [EntName("ORGANISATION-TYPE")]
    [EntTableName("ORG_TYPE")]
    [EntDepth(1)]
    public interface IOrganisationType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column org_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column org_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("organisation-type-id")]
		[AttrColumnName("org_type_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ORGANISATION-TYPE. It serves as a discriminator that partitions ORGANISATION-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("organisation-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000154)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationTypeCategoryEnum OrganisationTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cmd_func_ind_code
		///
		/// The specific value that denotes whether an ORGANISATION-TYPE has a command function.
        /// </summary>
        /// <value>
        /// Value of the column cmd_func_ind_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("organisation-type-command-function-indicator-code")]
		[AttrColumnName("cmd_func_ind_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100004194)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationTypeCommandFunctionIndicatorEnum CommandFunctionIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cmd_and_ctrl_cat_code
		///
		/// The specific value that denotes the command and control classification of an ORGANISATION-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cmd_and_ctrl_cat_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("organisation-type-command-and-control-category-code")]
		[AttrColumnName("cmd_and_ctrl_cat_code")]
        [AttrSeqnr(4)]
        [DomId(100004184)]
        [DataLength(6)]
        [DataDecimals(0)]
        OrganisationTypeCommandAndControlCategoryEnum? CommandAndControlCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column descr_txt
		///
		/// The character string assigned to represent the specific ORGANISATION-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column descr_txt
        /// </value>
        [AttrIx(100005)]
		[AttrName("organisation-type-description-text")]
		[AttrColumnName("descr_txt")]
        [AttrSeqnr(5)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string DescriptionText { get; set; }
		
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
