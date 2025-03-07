using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity MobilityCapability that represents the table MOB_CAPAB
	/// 
	/// A CAPABILITY, required for planning, of those FACILITYs, MATERIELs, ORGANISATIONs and PERSONs or FACILITY-TYPEs, EQUIPMENT-TYPEs, ORGANISATION-TYPEs, and PERSON-TYPEs that are deemed as having the nominal ability to move in space, air, on water, under water, or over a specific type of terrain.
    /// </summary>
	[EntId(10000183)]
    [EntName("MOBILITY-CAPABILITY")]
    [EntTableName("MOB_CAPAB")]
    [EntDepth(1)]
    public interface IMobilityCapability
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mob_capab_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CAPABILITY and to distinguish it from all other CAPABILITYs.
        /// </summary>
        /// <value>
        /// Value of the column mob_capab_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("mobility-capability-id")]
		[AttrColumnName("mob_capab_id")]
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
		/// The specific value that represents the class of MOBILITY-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("mobility-capability-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000329)]
        [DataLength(6)]
        [DataDecimals(0)]
        MobilityCapabilityCategoryEnum MobilityCapabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dscpt_code
		///
		/// The specific value that represents the MOBILITY-CAPABILITY that is being quantified.
        /// </summary>
        /// <value>
        /// Value of the column dscpt_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("mobility-capability-descriptor-code")]
		[AttrColumnName("dscpt_code")]
        [AttrSeqnr(3)]
        [DomId(100004358)]
        [DataLength(6)]
        [DataDecimals(0)]
        MobilityCapabilityDescriptorEnum? Descriptor { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column terrain_type_code
		///
		/// The specific value that represents the class of terrain to which a particular MOBILITY-CAPABILITY pertains.
        /// </summary>
        /// <value>
        /// Value of the column terrain_type_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("mobility-capability-terrain-type-code")]
		[AttrColumnName("terrain_type_code")]
        [AttrSeqnr(4)]
        [DomId(100000330)]
        [DataLength(6)]
        [DataDecimals(0)]
        MobilityCapabilityTerrainTypeEnum? TerrainType { get; set; }
		
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
