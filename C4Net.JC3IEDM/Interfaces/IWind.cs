using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Wind that represents the table WIND
	/// 
	/// A METEOROLOGIC-FEATURE that specifies the velocity and directional characteristics of atmospheric movement.
    /// </summary>
	[EntId(10000131)]
    [EntName("WIND")]
    [EntTableName("WIND")]
    [EntDepth(3)]
    public interface IWind
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column wind_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column wind_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("wind-id")]
		[AttrColumnName("wind_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of WIND.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("wind-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [DomId(100000172)]
        [DataLength(6)]
        [DataDecimals(0)]
        WindCategoryEnum? WindCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column air_stability_cat_code
		///
		/// The specific value used to indicate the class of air stability.
        /// </summary>
        /// <value>
        /// Value of the column air_stability_cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("wind-air-stability-category-code")]
		[AttrColumnName("air_stability_cat_code")]
        [AttrSeqnr(3)]
        [DomId(100004309)]
        [DataLength(6)]
        [DataDecimals(0)]
        WindAirStabilityCategoryEnum? AirStabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column altitude_layer_code
		///
		/// The specific value used to indicate the class of the altitude for a specific set of reported wind data.
        /// </summary>
        /// <value>
        /// Value of the column altitude_layer_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("wind-altitude-layer-code")]
		[AttrColumnName("altitude_layer_code")]
        [AttrSeqnr(4)]
        [DomId(100004310)]
        [DataLength(6)]
        [DataDecimals(0)]
        WindAltitudeLayerEnum? AltitudeLayer { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dir_angle
		///
		/// The rotational measurement clockwise between the line of true North and the direction from which a specific WIND originates.
        /// </summary>
        /// <value>
        /// Value of the column dir_angle
        /// </value>
        [AttrIx(100005)]
		[AttrName("wind-direction-angle")]
		[AttrColumnName("dir_angle")]
        [AttrSeqnr(5)]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double? DirectionAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_downwind_dir_angle
		///
		/// The rotational measurement of the mean downwind direction at ground level in the hazard area towards which the cloud travels.
        /// </summary>
        /// <value>
        /// Value of the column effctv_downwind_dir_angle
        /// </value>
        [AttrIx(100006)]
		[AttrName("wind-effective-downwind-direction-angle")]
		[AttrColumnName("effctv_downwind_dir_angle")]
        [AttrSeqnr(6)]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double? EffectiveDownwindDirectionAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column speed_rate
		///
		/// The numeric value that denotes the distance per unit time of a specific WIND. The unit of measure is kilometres per hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column speed_rate
        /// </value>
        [AttrIx(100007)]
		[AttrName("wind-speed-rate")]
		[AttrColumnName("speed_rate")]
        [AttrSeqnr(7)]
        [DomId(100001300)]
        [DataLength(8)]
        [DataDecimals(4)]
        double? SpeedRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column nuc_yield_qual_code
		///
		/// The specific value used to identify predicted wind values associated with nuclear fallout prediction for a specific Nuclear yield group.
        /// </summary>
        /// <value>
        /// Value of the column nuc_yield_qual_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("wind-nuclear-yield-qualifier-code")]
		[AttrColumnName("nuc_yield_qual_code")]
        [AttrSeqnr(8)]
        [DomId(100004375)]
        [DataLength(6)]
        [DataDecimals(0)]
        NuclearYieldGroupEnum? NuclearYieldQualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(9)]
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
        [AttrIx(100010)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(10)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
