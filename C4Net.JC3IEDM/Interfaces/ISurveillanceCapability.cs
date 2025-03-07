using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity SurveillanceCapability that represents the table SURV_CAPAB
	/// 
	/// A CAPABILITY, required for planning, of those FACILITYs, MATERIELs, ORGANISATIONs and PERSONs or FACILITY-TYPEs, EQUIPMENT-TYPEs, ORGANISATION-TYPEs and PERSON-TYPEs that are deemed as having the nominal ability to observe aerospace, surface or subsurface areas, places, persons, or things, by visual, aural, electronic, photographic or other means.
    /// </summary>
	[EntId(10000122)]
    [EntName("SURVEILLANCE-CAPABILITY")]
    [EntTableName("SURV_CAPAB")]
    [EntDepth(1)]
    public interface ISurveillanceCapability
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column surv_capab_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CAPABILITY and to distinguish it from all other CAPABILITYs.
        /// </summary>
        /// <value>
        /// Value of the column surv_capab_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("surveillance-capability-id")]
		[AttrColumnName("surv_capab_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000902)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of SURVEILLANCE-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("surveillance-capability-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000203)]
        [DataLength(6)]
        [DataDecimals(0)]
        SurveillanceCapabilityCategoryEnum SurveillanceCapabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dscpt_code
		///
		/// The specific value that represents the SURVEILLANCE-CAPABILITY that is being quantified.
        /// </summary>
        /// <value>
        /// Value of the column dscpt_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("surveillance-capability-descriptor-code")]
		[AttrColumnName("dscpt_code")]
        [AttrSeqnr(3)]
        [DomId(100004361)]
        [DataLength(6)]
        [DataDecimals(0)]
        SurveillanceCapabilityDescriptorEnum? Descriptor { get; set; }
		
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
