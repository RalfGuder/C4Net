using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity MaintenanceCapability that represents the table MNT_CAPAB
	/// 
	/// A CAPABILITY, required for planning, of those FACILITYs, MATERIELs, ORGANISATIONs and PERSONs or FACILITY-TYPEs, EQUIPMENT-TYPEs, ORGANISATION-TYPEs, and PERSON-TYPEs that are deemed as having the ability to provide a range of activities required to restore or maintain operational usage.
    /// </summary>
	[EntId(10000332)]
    [EntName("MAINTENANCE-CAPABILITY")]
    [EntTableName("MNT_CAPAB")]
    [EntDepth(1)]
    public interface IMaintenanceCapability
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mnt_capab_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CAPABILITY and to distinguish it from all other CAPABILITYs.
        /// </summary>
        /// <value>
        /// Value of the column mnt_capab_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("maintenance-capability-id")]
		[AttrColumnName("mnt_capab_id")]
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
		/// The specific value that represents the class of MAINTENANCE-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("maintenance-capability-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004348)]
        [DataLength(6)]
        [DataDecimals(0)]
        MaintenanceCapabilityCategoryEnum MaintenanceCapabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column station_cnt
		///
		/// The integer value representing the number of operational maintenance stations, fully outfitted with the necessary equipment and maintenance personnel, available for the purpose of repairing and servicing materiel.
        /// </summary>
        /// <value>
        /// Value of the column station_cnt
        /// </value>
        [AttrIx(100003)]
		[AttrName("maintenance-capability-station-count")]
		[AttrColumnName("station_cnt")]
        [AttrSeqnr(3)]
        [DomId(100001800)]
        [DataLength(4)]
        [DataDecimals(0)]
        short? StationCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lvl_code
		///
		/// The specific value that represents the extent of repairs or servicing that can be accomplished.
        /// </summary>
        /// <value>
        /// Value of the column lvl_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("maintenance-capability-level-code")]
		[AttrColumnName("lvl_code")]
        [AttrSeqnr(4)]
        [DomId(100004349)]
        [DataLength(6)]
        [DataDecimals(0)]
        MaintenanceCapabilityLevelEnum? Level { get; set; }
		
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
