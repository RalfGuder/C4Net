using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity FireCapability that represents the table FIRE_CAPAB
	/// 
	/// A CAPABILITY, required for planning, of those FACILITYs, MATERIELs, ORGANISATIONs and PERSONs, or FACILITY-TYPEs, EQUIPMENT-TYPEs, ORGANISATION-TYPEs and PERSON-TYPEs that are deemed as having the ability to discharge or launch a projectile or missile.
    /// </summary>
	[EntId(10000052)]
    [EntName("FIRE-CAPABILITY")]
    [EntTableName("FIRE_CAPAB")]
    [EntDepth(4)]
    public interface IFireCapability
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column fire_capab_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CAPABILITY and to distinguish it from all other CAPABILITYs.
        /// </summary>
        /// <value>
        /// Value of the column fire_capab_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("fire-capability-id")]
		[AttrColumnName("fire_capab_id")]
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
		/// The specific value that represents the class of FIRE-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("fire-capability-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004356)]
        [DataLength(6)]
        [DataDecimals(0)]
        FireCapabilityCategoryEnum FireCapabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dscpt_code
		///
		/// The specific value that represents the FIRE-CAPABILITY that is being quantified.
        /// </summary>
        /// <value>
        /// Value of the column dscpt_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("fire-capability-descriptor-code")]
		[AttrColumnName("dscpt_code")]
        [AttrSeqnr(3)]
        [DomId(100004357)]
        [DataLength(6)]
        [DataDecimals(0)]
        FireCapabilityDescriptorEnum? Descriptor { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column weapon_type_code
		///
		/// The specific value that represents the general type of weapon that an EQUIPMENT-TYPE is qualified to employ.
        /// </summary>
        /// <value>
        /// Value of the column weapon_type_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("fire-capability-weapon-type-code")]
		[AttrColumnName("weapon_type_code")]
        [AttrSeqnr(4)]
        [DomId(100004373)]
        [DataLength(6)]
        [DataDecimals(0)]
        FireCapabilityWeaponTypeEnum? WeaponType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ammo_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column ammo_type_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("ammunition-type-id")]
		[AttrColumnName("ammo_type_id")]
        [AttrSeqnr(5)]
        [ForeignKey]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? AmmunitionTypeId { get; set; }
		
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
