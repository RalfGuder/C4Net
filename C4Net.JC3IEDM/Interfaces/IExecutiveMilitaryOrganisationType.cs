using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ExecutiveMilitaryOrganisationType that represents the table EXCTV_MIL_ORG_TYPE
	/// 
	/// A MILITARY-ORGANISATION-TYPE whose function is to manage and direct the military establishment.
    /// </summary>
	[EntId(10000200)]
    [EntName("EXECUTIVE-MILITARY-ORGANISATION-TYPE")]
    [EntTableName("EXCTV_MIL_ORG_TYPE")]
    [EntDepth(4)]
    public interface IExecutiveMilitaryOrganisationType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column exctv_mil_org_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column exctv_mil_org_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("executive-military-organisation-type-id")]
		[AttrColumnName("exctv_mil_org_type_id")]
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
		/// The specific value that represents the class of EXECUTIVE-MILITARY-ORGANISATION-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("executive-military-organisation-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000370)]
        [DataLength(6)]
        [DataDecimals(0)]
        ExecutiveMilitaryOrganisationTypeCategoryEnum ExecutiveMilitaryOrganisationTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(3)]
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
        [AttrIx(100004)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
