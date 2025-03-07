using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity VesselType that represents the table VESSEL_TYPE
	/// 
	/// An EQUIPMENT-TYPE that is designed to operate on or under the water surface.
    /// </summary>
	[EntId(10000192)]
    [EntName("VESSEL-TYPE")]
    [EntTableName("VESSEL_TYPE")]
    [EntDepth(3)]
    public interface IVesselType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column vessel_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column vessel_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("vessel-type-id")]
		[AttrColumnName("vessel_type_id")]
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
		/// The specific value that represents the class of VESSEL-TYPE. It serves as a discriminator that partitions VESSEL-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("vessel-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000349)]
        [DataLength(6)]
        [DataDecimals(0)]
        VesselTypeCategoryEnum VesselTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column magn_degaussing_code_no_qty
		///
		/// The numeric value that represents the peak vertical component of the magnetic field under a ship on the worst heading and at certain depth. The unit of measure is microtesla.
        /// </summary>
        /// <value>
        /// Value of the column magn_degaussing_code_no_qty
        /// </value>
        [AttrIx(100003)]
		[AttrName("vessel-type-magnetic-degaussing-code-number-quantity")]
		[AttrColumnName("magn_degaussing_code_no_qty")]
        [AttrSeqnr(3)]
        [DomId(100001200)]
        [DataLength(12)]
        [DataDecimals(0)]
        long? MagneticDegaussingCodeNumberQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prismatic_coefficient_rat
		///
		/// The numeric quotient value that represents a ratio of the volume displaced by the hull in relation to the volume of a prism or cylinder of cross section equal to the greatest cross-section of the submerged part of the hull and of length equal to the ships length between perpendiculars. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column prismatic_coefficient_rat
        /// </value>
        [AttrIx(100004)]
		[AttrName("vessel-type-prismatic-coefficient-ratio")]
		[AttrColumnName("prismatic_coefficient_rat")]
        [AttrSeqnr(4)]
        [DomId(100001900)]
        [DataLength(6)]
        [DataDecimals(5)]
        double? PrismaticCoefficientRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dead_wt_qty
		///
		/// The numeric value that represents the carrying capacity of a ship. Dead weight is the difference between the Full displacement (Gross weight) and the Light displacement (Net weight). The unit of measure is metric ton.
        /// </summary>
        /// <value>
        /// Value of the column dead_wt_qty
        /// </value>
        [AttrIx(100005)]
		[AttrName("vessel-type-dead-weight-quantity")]
		[AttrColumnName("dead_wt_qty")]
        [AttrSeqnr(5)]
        [DomId(100001200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? DeadWeightQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column draught_dim
		///
		/// The numeric value of the distance from the Deep Water Line (DWL) to the lowest permanent projection on the hull of a vessel type including sonar domes, propellers, rudders, or other projections.
        /// </summary>
        /// <value>
        /// Value of the column draught_dim
        /// </value>
        [AttrIx(100006)]
		[AttrName("vessel-type-draught-dimension")]
		[AttrColumnName("draught_dim")]
        [AttrSeqnr(6)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? DraughtDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column gross_rgstrd_tong_qty
		///
		/// The numeric value that represents a ship's internal cubic capacity or freight-carrying capacity. The unit of measure is Gross Registered Tonnage (GRT). A unit of Gross Registered Tonnage is equal to 2.83 cubic metres.
        /// </summary>
        /// <value>
        /// Value of the column gross_rgstrd_tong_qty
        /// </value>
        [AttrIx(100007)]
		[AttrName("vessel-type-gross-registered-tonnage-quantity")]
		[AttrColumnName("gross_rgstrd_tong_qty")]
        [AttrSeqnr(7)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? GrossRegisteredTonnageQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column height_above_the_wtrln_dim
		///
		/// The one-dimensional linear distance representing the distance from the waterline to the topmost point of an unloaded vessel.
        /// </summary>
        /// <value>
        /// Value of the column height_above_the_wtrln_dim
        /// </value>
        [AttrIx(100008)]
		[AttrName("vessel-type-height-above-the-waterline-dimension")]
		[AttrColumnName("height_above_the_wtrln_dim")]
        [AttrSeqnr(8)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? HeightAboveTheWaterlineDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column propeller_cnt
		///
		/// The integer value representing the number of propellers on the ship.
        /// </summary>
        /// <value>
        /// Value of the column propeller_cnt
        /// </value>
        [AttrIx(100009)]
		[AttrName("vessel-type-propeller-count")]
		[AttrColumnName("propeller_cnt")]
        [AttrSeqnr(9)]
        [DomId(100001800)]
        [DataLength(2)]
        [DataDecimals(0)]
        short? PropellerCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column propulsion_type_code
		///
		/// The specific value that represents the type of power used to move the vessel.
        /// </summary>
        /// <value>
        /// Value of the column propulsion_type_code
        /// </value>
        [AttrIx(100010)]
		[AttrName("vessel-type-propulsion-type-code")]
		[AttrColumnName("propulsion_type_code")]
        [AttrSeqnr(10)]
        [DomId(100004283)]
        [DataLength(6)]
        [DataDecimals(0)]
        VesselTypePropulsionTypeEnum? PropulsionType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_displ_qty
		///
		/// The numeric value that represents the weight or volume of water moved by the vessel on the surface of the water. The unit of measure is metric ton.
        /// </summary>
        /// <value>
        /// Value of the column operat_displ_qty
        /// </value>
        [AttrIx(100011)]
		[AttrName("vessel-type-operational-displacement-quantity")]
		[AttrColumnName("operat_displ_qty")]
        [AttrSeqnr(11)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? OperationalDisplacementQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_speed_rate
		///
		/// The numeric value of the maximum speed that a vessel type can maintain for one hour or less with a clean hull immediately out of dry docking or refit. The speed is measured in knots. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column max_speed_rate
        /// </value>
        [AttrIx(100012)]
		[AttrName("vessel-type-maximum-speed-rate")]
		[AttrColumnName("max_speed_rate")]
        [AttrSeqnr(12)]
        [DomId(100001300)]
        [DataLength(8)]
        [DataDecimals(4)]
        double? MaximumSpeedRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column acoustic_merit_ix_qty
		///
		/// The numeric value that indicates the total acoustic level.
        /// </summary>
        /// <value>
        /// Value of the column acoustic_merit_ix_qty
        /// </value>
        [AttrIx(100013)]
		[AttrName("vessel-type-acoustic-merit-index-quantity")]
		[AttrColumnName("acoustic_merit_ix_qty")]
        [AttrSeqnr(13)]
        [DomId(100001200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? AcousticMeritIndexQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100014)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(14)]
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
        [AttrIx(100015)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(15)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
