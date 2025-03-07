using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity DryDock that represents the table DRY_DOCK
	/// 
	/// A FACILITY that provides an enclosure for maintenance, building or repairing ships, from which water can be pumped out.
    /// </summary>
	[EntId(10000266)]
    [EntName("DRY-DOCK")]
    [EntTableName("DRY_DOCK")]
    [EntDepth(3)]
    public interface IDryDock
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column dry_dock_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column dry_dock_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("dry-dock-id")]
		[AttrColumnName("dry_dock_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column boat_lift_cap_qty
		///
		/// The numeric value that represents the maximum tonnage of a boat-lift that can be utilised to remove a vessel from a specific DRY-DOCK. The unit of measure is metric ton.
        /// </summary>
        /// <value>
        /// Value of the column boat_lift_cap_qty
        /// </value>
        [AttrIx(100002)]
		[AttrName("dry-dock-boat-lift-capacity-quantity")]
		[AttrColumnName("boat_lift_cap_qty")]
        [AttrSeqnr(2)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? BoatLiftCapacityQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column depth_dim
		///
		/// The one-dimensional linear distance representing the depth of water available at the DRY-DOCK when the dock is full of water.
        /// </summary>
        /// <value>
        /// Value of the column depth_dim
        /// </value>
        [AttrIx(100003)]
		[AttrName("dry-dock-depth-dimension")]
		[AttrColumnName("depth_dim")]
        [AttrSeqnr(3)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? DepthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column loc_txt
		///
		/// The character string assigned to represent a statement of the details that relate to the specific DRY-DOCK.
        /// </summary>
        /// <value>
        /// Value of the column loc_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("dry-dock-location-text")]
		[AttrColumnName("loc_txt")]
        [AttrSeqnr(4)]
        [DomId(100001500)]
        [DataLength(255)]
        [DataDecimals(0)]
        string LocationText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column marine_railway_size_code
		///
		/// The specific value that represents the bearing capacity of the underwater railway in the DRY-DOCK.
        /// </summary>
        /// <value>
        /// Value of the column marine_railway_size_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("dry-dock-marine-railway-size-code")]
		[AttrColumnName("marine_railway_size_code")]
        [AttrSeqnr(5)]
        [DomId(100004291)]
        [DataLength(6)]
        [DataDecimals(0)]
        DryDockMarineRailwaySizeEnum? MarineRailwaySize { get; set; }
		
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
