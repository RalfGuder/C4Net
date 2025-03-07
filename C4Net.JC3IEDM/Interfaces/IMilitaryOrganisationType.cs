using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity MilitaryOrganisationType that represents the table MIL_ORG_TYPE
	/// 
	/// A GOVERNMENT-ORGANISATION-TYPE that is officially sanctioned and is trained and equipped to exert force.
    /// </summary>
	[EntId(10000203)]
    [EntName("MILITARY-ORGANISATION-TYPE")]
    [EntTableName("MIL_ORG_TYPE")]
    [EntDepth(3)]
    public interface IMilitaryOrganisationType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mil_org_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column mil_org_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("military-organisation-type-id")]
		[AttrColumnName("mil_org_type_id")]
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
		/// The specific value that represents the class of MILITARY-ORGANISATION-TYPE. It serves as a discriminator that partitions MILITARY-ORGANISATION-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("military-organisation-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000373)]
        [DataLength(6)]
        [DataDecimals(0)]
        MilitaryOrganisationTypeCategoryEnum MilitaryOrganisationTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column service_code
		///
		/// The specific value that represents a military, paramilitary, irregular force, force or group, capable of functioning as an offensive or defensive combat or support organisation.
        /// </summary>
        /// <value>
        /// Value of the column service_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("military-organisation-type-service-code")]
		[AttrColumnName("service_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000374)]
        [DataLength(6)]
        [DataDecimals(0)]
        MilitaryOrganisationTypeServiceEnum Service { get; set; }
		
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
