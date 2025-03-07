using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity SubsurfaceVesselType that represents the table SUBSURF_VESSEL_TYPE
	/// 
	/// A vessel principally designed to operate under the water surface.
    /// </summary>
	[EntId(10000323)]
    [EntName("SUBSURFACE-VESSEL-TYPE")]
    [EntTableName("SUBSURF_VESSEL_TYPE")]
    [EntDepth(4)]
    public interface ISubsurfaceVesselType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column subsurf_vessel_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column subsurf_vessel_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("subsurface-vessel-type-id")]
		[AttrColumnName("subsurf_vessel_type_id")]
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
		/// The specific value that represents the class of subsurface vessel.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("subsurface-vessel-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004285)]
        [DataLength(6)]
        [DataDecimals(0)]
        SubsurfaceVesselTypeCategoryEnum SubsurfaceVesselTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dived_displ_qty
		///
		/// The numeric value that represents the volume of water that is moved by the subsurface vessel when it is entirely below the surface. The unit of measure is ton.
        /// </summary>
        /// <value>
        /// Value of the column dived_displ_qty
        /// </value>
        [AttrIx(100003)]
		[AttrName("subsurface-vessel-type-dived-displacement-quantity")]
		[AttrColumnName("dived_displ_qty")]
        [AttrSeqnr(3)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? DivedDisplacementQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column speed_cavitation_qty
		///
		/// The numeric value that represents the speed at which the subsurface vessel will form bubbles or a vacuum in the water. The unit of measure is knots.
        /// </summary>
        /// <value>
        /// Value of the column speed_cavitation_qty
        /// </value>
        [AttrIx(100004)]
		[AttrName("subsurface-vessel-type-speed-cavitation-quantity")]
		[AttrColumnName("speed_cavitation_qty")]
        [AttrSeqnr(4)]
        [DomId(100001200)]
        [DataLength(3)]
        [DataDecimals(0)]
        short? SpeedCavitationQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column torpedo_loading_gear_ind_code
		///
		/// The specific value that indicates whether a subsurface vessel has torpedo loading rails and lifting bands.
        /// </summary>
        /// <value>
        /// Value of the column torpedo_loading_gear_ind_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("subsurface-vessel-type-torpedo-loading-gear-indicator-code")]
		[AttrColumnName("torpedo_loading_gear_ind_code")]
        [AttrSeqnr(5)]
        [DomId(100004286)]
        [DataLength(6)]
        [DataDecimals(0)]
        SubsurfaceVesselTypeTorpedoLoadingGearIndicatorEnum? TorpedoLoadingGearIndicator { get; set; }
		
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
