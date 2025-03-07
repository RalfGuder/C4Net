using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Harbour that represents the table HRBR
	/// 
	/// A FACILITY that is a restricted body of water, an anchorage, or other limited coastal water area and its water approaches from which and in which shipping operations are projected or supported.
    /// </summary>
	[EntId(10000262)]
    [EntName("HARBOUR")]
    [EntTableName("HRBR")]
    [EntDepth(3)]
    public interface IHarbour
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column hrbr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column hrbr_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("harbour-id")]
		[AttrColumnName("hrbr_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column airport_near_ind_code
		///
		/// The specific value that represents whether an airport is near the HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column airport_near_ind_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("harbour-airport-near-indicator-code")]
		[AttrColumnName("airport_near_ind_code")]
        [AttrSeqnr(2)]
        [DomId(100004293)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourAirportNearIndicatorEnum? AirportNearIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column appr_chnl_depth_dim
		///
		/// The one-dimensional linear distance representing the depth maintained by dredging and guaranteed by the harbour authority of the specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column appr_chnl_depth_dim
        /// </value>
        [AttrIx(100003)]
		[AttrName("harbour-approach-channel-depth-dimension")]
		[AttrColumnName("appr_chnl_depth_dim")]
        [AttrSeqnr(3)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? ApproachChannelDepthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column biolg_secure_avlbty_ind_code
		///
		/// The specific value that represents whether the HARBOUR is capable of supplying biologically secure facilities, to include quarantine facilities.
        /// </summary>
        /// <value>
        /// Value of the column biolg_secure_avlbty_ind_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("harbour-biologically-secure-availability-indicator-code")]
		[AttrColumnName("biolg_secure_avlbty_ind_code")]
        [AttrSeqnr(4)]
        [DomId(100004162)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourBiologicallySecureAvailabilityIndicatorEnum? BiologicallySecureAvailabilityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column convoy_mrshl_ind_code
		///
		/// The specific value that represents whether the HARBOUR is capable of supplying convoy-marshalling facilities.
        /// </summary>
        /// <value>
        /// Value of the column convoy_mrshl_ind_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("harbour-convoy-marshalling-indicator-code")]
		[AttrColumnName("convoy_mrshl_ind_code")]
        [AttrSeqnr(5)]
        [DomId(100004163)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourConvoyMarshallingIndicatorEnum? ConvoyMarshallingIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column day_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the HARBOUR during the day. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column day_limit_net_expl_qty
        /// </value>
        [AttrIx(100006)]
		[AttrName("harbour-day-limit-net-explosive-quantity")]
		[AttrColumnName("day_limit_net_expl_qty")]
        [AttrSeqnr(6)]
        [DomId(100001200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? DayLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column night_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the HARBOUR during the night. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column night_limit_net_expl_qty
        /// </value>
        [AttrIx(100007)]
		[AttrName("harbour-night-limit-net-explosive-quantity")]
		[AttrColumnName("night_limit_net_expl_qty")]
        [AttrSeqnr(7)]
        [DomId(100001200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? NightLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column degaussing_ind_code
		///
		/// The specific value that represents whether degaussing facilities are available.
        /// </summary>
        /// <value>
        /// Value of the column degaussing_ind_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("harbour-degaussing-indicator-code")]
		[AttrColumnName("degaussing_ind_code")]
        [AttrSeqnr(8)]
        [DomId(100004294)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourDegaussingIndicatorEnum? DegaussingIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dirty_ballast_ind_code
		///
		/// The specific value that represents whether the port has sufficient facilities for receiving oily or chemically contaminated dirty ballast.
        /// </summary>
        /// <value>
        /// Value of the column dirty_ballast_ind_code
        /// </value>
        [AttrIx(100009)]
		[AttrName("harbour-dirty-ballast-indicator-code")]
		[AttrColumnName("dirty_ballast_ind_code")]
        [AttrSeqnr(9)]
        [DomId(100004295)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourDirtyBallastIndicatorEnum? DirtyBallastIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column entr_restr_ice_ind_code
		///
		/// The specific value that represents whether ice is a natural factor restricting the entrance of vessels into the port.
        /// </summary>
        /// <value>
        /// Value of the column entr_restr_ice_ind_code
        /// </value>
        [AttrIx(100010)]
		[AttrName("harbour-entrance-restrictions-ice-indicator-code")]
		[AttrColumnName("entr_restr_ice_ind_code")]
        [AttrSeqnr(10)]
        [DomId(100004296)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourEntranceRestrictionsIceIndicatorEnum? EntranceRestrictionsIceIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column entr_restr_swell_ind_code
		///
		/// The specific value that represents whether heavy swell is a natural factor restricting the entrance of vessels into the port.
        /// </summary>
        /// <value>
        /// Value of the column entr_restr_swell_ind_code
        /// </value>
        [AttrIx(100011)]
		[AttrName("harbour-entrance-restrictions-swell-indicator-code")]
		[AttrColumnName("entr_restr_swell_ind_code")]
        [AttrSeqnr(11)]
        [DomId(100004297)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourEntranceRestrictionsSwellIndicatorEnum? EntranceRestrictionsSwellIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column entr_restr_txt
		///
		/// The character string assigned to represent the factors other than tide, heavy swell, and ice restricting entrance into the port.
        /// </summary>
        /// <value>
        /// Value of the column entr_restr_txt
        /// </value>
        [AttrIx(100012)]
		[AttrName("harbour-entrance-restrictions-text")]
		[AttrColumnName("entr_restr_txt")]
        [AttrSeqnr(12)]
        [DomId(100001500)]
        [DataLength(100)]
        [DataDecimals(0)]
        string EntranceRestrictionsText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column eta_ind_code
		///
		/// The specific value that represents whether an estimated time of arrival message is required.
        /// </summary>
        /// <value>
        /// Value of the column eta_ind_code
        /// </value>
        [AttrIx(100013)]
		[AttrName("harbour-estimated-time-of-arrival-indicator-code")]
		[AttrColumnName("eta_ind_code")]
        [AttrSeqnr(13)]
        [DomId(100004298)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourEstimatedTimeOfArrivalIndicatorEnum? EstimatedTimeOfArrivalIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fire_fighting_capab_code
		///
		/// The specific value that represents the class of fire fighting capability available at a specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column fire_fighting_capab_code
        /// </value>
        [AttrIx(100014)]
		[AttrName("harbour-fire-fighting-capability-code")]
		[AttrColumnName("fire_fighting_capab_code")]
        [AttrSeqnr(14)]
        [DomId(100004164)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourFireFightingCapabilityEnum? FireFightingCapability { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fire_fighting_ind_code
		///
		/// The specific value that represents whether the HARBOUR is capable of supplying fire-fighting facilities.
        /// </summary>
        /// <value>
        /// Value of the column fire_fighting_ind_code
        /// </value>
        [AttrIx(100015)]
		[AttrName("harbour-fire-fighting-indicator-code")]
		[AttrColumnName("fire_fighting_ind_code")]
        [AttrSeqnr(15)]
        [DomId(100004165)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourFireFightingIndicatorEnum? FireFightingIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column first_port_of_entry_ind_code
		///
		/// The specific value that represents whether the port may be used by a vessel that needs to clear foreign goods and personnel through Customs and Immigration.
        /// </summary>
        /// <value>
        /// Value of the column first_port_of_entry_ind_code
        /// </value>
        [AttrIx(100016)]
		[AttrName("harbour-first-port-of-entry-indicator-code")]
		[AttrColumnName("first_port_of_entry_ind_code")]
        [AttrSeqnr(16)]
        [DomId(100004299)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourFirstPortOfEntryIndicatorEnum? FirstPortOfEntryIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fresh_water_avlbty_ind_code
		///
		/// The specific value that represents whether the HARBOUR is capable of providing fresh water.
        /// </summary>
        /// <value>
        /// Value of the column fresh_water_avlbty_ind_code
        /// </value>
        [AttrIx(100017)]
		[AttrName("harbour-fresh-water-availability-indicator-code")]
		[AttrColumnName("fresh_water_avlbty_ind_code")]
        [AttrSeqnr(17)]
        [DomId(100004166)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourFreshWaterAvailabilityIndicatorEnum? FreshWaterAvailabilityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lash_ind_code
		///
		/// The specific value that represents whether the HARBOUR can support the Lighter Aboard Ship (LASH) transportation system.
        /// </summary>
        /// <value>
        /// Value of the column lash_ind_code
        /// </value>
        [AttrIx(100018)]
		[AttrName("harbour-lash-indicator-code")]
		[AttrColumnName("lash_ind_code")]
        [AttrSeqnr(18)]
        [DomId(100004300)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourLashIndicatorEnum? LashIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lighterage_avlbty_ind_code
		///
		/// The specific value that represents the possibility for transferring goods from a ship to a wharf or another ship using a boat, usu. flat-bottomed at a specific maritime port.
        /// </summary>
        /// <value>
        /// Value of the column lighterage_avlbty_ind_code
        /// </value>
        [AttrIx(100019)]
		[AttrName("harbour-lighterage-availability-indicator-code")]
		[AttrColumnName("lighterage_avlbty_ind_code")]
        [AttrSeqnr(19)]
        [DomId(100004301)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourLighterageAvailabilityIndicatorEnum? LighterageAvailabilityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_vessel_draught_dim
		///
		/// The one-dimensional linear distance representing the maximum draught of vessel that the specific HARBOUR can accommodate.
        /// </summary>
        /// <value>
        /// Value of the column max_vessel_draught_dim
        /// </value>
        [AttrIx(100020)]
		[AttrName("harbour-maximum-vessel-draught-dimension")]
		[AttrColumnName("max_vessel_draught_dim")]
        [AttrSeqnr(20)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? MaximumVesselDraughtDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_vessel_length_dim
		///
		/// The one-dimensional linear distance representing the maximum length of vessel that the specific HARBOUR can accommodate.
        /// </summary>
        /// <value>
        /// Value of the column max_vessel_length_dim
        /// </value>
        [AttrIx(100021)]
		[AttrName("harbour-maximum-vessel-length-dimension")]
		[AttrColumnName("max_vessel_length_dim")]
        [AttrSeqnr(21)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? MaximumVesselLengthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_vessel_width_dim
		///
		/// The one-dimensional linear distance representing the maximum width of vessel that the specific HARBOUR can accommodate.
        /// </summary>
        /// <value>
        /// Value of the column max_vessel_width_dim
        /// </value>
        [AttrIx(100022)]
		[AttrName("harbour-maximum-vessel-width-dimension")]
		[AttrColumnName("max_vessel_width_dim")]
        [AttrSeqnr(22)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? MaximumVesselWidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mean_tidal_curr_rate
		///
		/// The numeric value that denotes the average velocity of the tidal flow at the specific HARBOUR. The unit of measure is kilometres per hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column mean_tidal_curr_rate
        /// </value>
        [AttrIx(100023)]
		[AttrName("harbour-mean-tidal-current-rate")]
		[AttrColumnName("mean_tidal_curr_rate")]
        [AttrSeqnr(23)]
        [DomId(100001300)]
        [DataLength(7)]
        [DataDecimals(1)]
        double? MeanTidalCurrentRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column psgr_hndl_ind_code
		///
		/// The specific value that represents whether the HARBOUR is capable of handling passengers.
        /// </summary>
        /// <value>
        /// Value of the column psgr_hndl_ind_code
        /// </value>
        [AttrIx(100024)]
		[AttrName("harbour-passenger-handling-indicator-code")]
		[AttrColumnName("psgr_hndl_ind_code")]
        [AttrSeqnr(24)]
        [DomId(100004167)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourPassengerHandlingIndicatorEnum? PassengerHandlingIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column persistence_code
		///
		/// The specific value that represents whether the HARBOUR is permanent or temporary.
        /// </summary>
        /// <value>
        /// Value of the column persistence_code
        /// </value>
        [AttrIx(100025)]
		[AttrName("harbour-persistence-code")]
		[AttrColumnName("persistence_code")]
        [AttrSeqnr(25)]
        [DomId(100004168)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourPersistenceEnum? Persistence { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column overhead_limits_ind_code
		///
		/// The specific value that represents whether bridge and/or overhead power cables exist.
        /// </summary>
        /// <value>
        /// Value of the column overhead_limits_ind_code
        /// </value>
        [AttrIx(100026)]
		[AttrName("harbour-overhead-limits-indicator-code")]
		[AttrColumnName("overhead_limits_ind_code")]
        [AttrSeqnr(26)]
        [DomId(100004302)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourOverheadLimitsIndicatorEnum? OverheadLimitsIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pilotage_avlbty_ind_code
		///
		/// The specific value that represents whether a pilot is available at the port.
        /// </summary>
        /// <value>
        /// Value of the column pilotage_avlbty_ind_code
        /// </value>
        [AttrIx(100027)]
		[AttrName("harbour-pilotage-availability-indicator-code")]
		[AttrColumnName("pilotage_avlbty_ind_code")]
        [AttrSeqnr(27)]
        [DomId(100004303)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourPilotageAvailabilityIndicatorEnum? PilotageAvailabilityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pilotage_reqmnt_ind_code
		///
		/// The specific value that represents whether the HARBOUR requires vessels to have a pilot.
        /// </summary>
        /// <value>
        /// Value of the column pilotage_reqmnt_ind_code
        /// </value>
        [AttrIx(100028)]
		[AttrName("harbour-pilotage-requirement-indicator-code")]
		[AttrColumnName("pilotage_reqmnt_ind_code")]
        [AttrSeqnr(28)]
        [DomId(100004169)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourPilotageRequirementIndicatorEnum? PilotageRequirementIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prvl_wind_dir_code
		///
		/// The specific value that represents the direction of the wind that most frequently occurs for the specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column prvl_wind_dir_code
        /// </value>
        [AttrIx(100029)]
		[AttrName("harbour-prevailing-wind-direction-code")]
		[AttrColumnName("prvl_wind_dir_code")]
        [AttrSeqnr(29)]
        [DomId(100000222)]
        [DataLength(6)]
        [DataDecimals(0)]
        DirectionEnum? PrevailingWindDirection { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prvl_wind_max_speed_code
		///
		/// The specific value that represents the maximum degree of discrimination or resolution for which the prevailing wind speed is stated.
        /// </summary>
        /// <value>
        /// Value of the column prvl_wind_max_speed_code
        /// </value>
        [AttrIx(100030)]
		[AttrName("harbour-prevailing-wind-maximum-speed-code")]
		[AttrColumnName("prvl_wind_max_speed_code")]
        [AttrSeqnr(30)]
        [DomId(100004217)]
        [DataLength(6)]
        [DataDecimals(0)]
        SpeedPrecisionEnum? PrevailingWindMaximumSpeed { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prvl_wind_max_speed_rate
		///
		/// The numeric value that denotes the maximum recorded strength of wind at the specific HARBOUR. The unit of measure is kilometres/hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column prvl_wind_max_speed_rate
        /// </value>
        [AttrIx(100031)]
		[AttrName("harbour-prevailing-wind-maximum-speed-rate")]
		[AttrColumnName("prvl_wind_max_speed_rate")]
        [AttrSeqnr(31)]
        [DomId(100001300)]
        [DataLength(4)]
        [DataDecimals(1)]
        double? PrevailingWindMaximumSpeedRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column refl_avlbty_ind_code
		///
		/// The specific value that represents whether the HARBOUR has refuelling facilities.
        /// </summary>
        /// <value>
        /// Value of the column refl_avlbty_ind_code
        /// </value>
        [AttrIx(100032)]
		[AttrName("harbour-refuelling-availability-indicator-code")]
		[AttrColumnName("refl_avlbty_ind_code")]
        [AttrSeqnr(32)]
        [DomId(100004171)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourRefuellingAvailabilityIndicatorEnum? RefuellingAvailabilityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column refl_loc_txt
		///
		/// The character string assigned to represent a statement of the specific refuelling details that relate to the specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column refl_loc_txt
        /// </value>
        [AttrIx(100033)]
		[AttrName("harbour-refuelling-location-text")]
		[AttrColumnName("refl_loc_txt")]
        [AttrSeqnr(33)]
        [DomId(100001500)]
        [DataLength(255)]
        [DataDecimals(0)]
        string RefuellingLocationText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column refl_type_code
		///
		/// The specific value that represents the refuelling means available at the specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column refl_type_code
        /// </value>
        [AttrIx(100034)]
		[AttrName("harbour-refuelling-type-code")]
		[AttrColumnName("refl_type_code")]
        [AttrSeqnr(34)]
        [DomId(100004172)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourRefuellingTypeEnum? RefuellingType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column seasonal_det_txt
		///
		/// The character string assigned to represent a statement of the specific seasonal details that relate to the specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column seasonal_det_txt
        /// </value>
        [AttrIx(100035)]
		[AttrName("harbour-seasonal-detail-text")]
		[AttrColumnName("seasonal_det_txt")]
        [AttrSeqnr(35)]
        [DomId(100001500)]
        [DataLength(255)]
        [DataDecimals(0)]
        string SeasonalDetailText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column shelter_qual_code
		///
		/// The protection provided from wind, sea, and swell in the area where normal port operations are conducted.
        /// </summary>
        /// <value>
        /// Value of the column shelter_qual_code
        /// </value>
        [AttrIx(100036)]
		[AttrName("harbour-shelter-quality-code")]
		[AttrColumnName("shelter_qual_code")]
        [AttrSeqnr(36)]
        [DomId(100004304)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourShelterQualityEnum? ShelterQuality { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column tanker_facilities_ind_code
		///
		/// The specific value that represents the availability of facilities to process tankers at a specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column tanker_facilities_ind_code
        /// </value>
        [AttrIx(100037)]
		[AttrName("harbour-tanker-facilities-indicator-code")]
		[AttrColumnName("tanker_facilities_ind_code")]
        [AttrSeqnr(37)]
        [DomId(100004305)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourTankerFacilitiesIndicatorEnum? TankerFacilitiesIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column tidal_mean_neap_range_dim
		///
		/// The one-dimensional linear distance representing the average range just after the first and third quarters of the moon when there is the least difference between high and low water for a specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column tidal_mean_neap_range_dim
        /// </value>
        [AttrIx(100038)]
		[AttrName("harbour-tidal-mean-neap-range-dimension")]
		[AttrColumnName("tidal_mean_neap_range_dim")]
        [AttrSeqnr(38)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? TidalMeanNeapRangeDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column tidal_mean_spring_range_dim
		///
		/// The one-dimensional linear distance representing the average range just after the new and full moon when there is the greatest difference between high and low water for a specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column tidal_mean_spring_range_dim
        /// </value>
        [AttrIx(100039)]
		[AttrName("harbour-tidal-mean-spring-range-dimension")]
		[AttrColumnName("tidal_mean_spring_range_dim")]
        [AttrSeqnr(39)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? TidalMeanSpringRangeDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column tidal_txt
		///
		/// The character string assigned to represent a statement of the specific tidal details that relate to the specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column tidal_txt
        /// </value>
        [AttrIx(100040)]
		[AttrName("harbour-tidal-text")]
		[AttrColumnName("tidal_txt")]
        [AttrSeqnr(40)]
        [DomId(100001500)]
        [DataLength(255)]
        [DataDecimals(0)]
        string TidalText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column trnst_acom_ind_code
		///
		/// The specific value that represents whether the HARBOUR is capable of supplying transit accommodation facilities.
        /// </summary>
        /// <value>
        /// Value of the column trnst_acom_ind_code
        /// </value>
        [AttrIx(100041)]
		[AttrName("harbour-transit-accommodation-indicator-code")]
		[AttrColumnName("trnst_acom_ind_code")]
        [AttrSeqnr(41)]
        [DomId(100004173)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourTransitAccommodationIndicatorEnum? TransitAccommodationIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column tug_avlbty_ind_code
		///
		/// The specific value that represents the availability of tugs at a specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column tug_avlbty_ind_code
        /// </value>
        [AttrIx(100042)]
		[AttrName("harbour-tug-availability-indicator-code")]
		[AttrColumnName("tug_avlbty_ind_code")]
        [AttrSeqnr(42)]
        [DomId(100004306)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourTugAvailabilityIndicatorEnum? TugAvailabilityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column turning_area_ind_code
		///
		/// The specific value that represents whether there is a turning basin or other water area available in a specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column turning_area_ind_code
        /// </value>
        [AttrIx(100043)]
		[AttrName("harbour-turning-area-indicator-code")]
		[AttrColumnName("turning_area_ind_code")]
        [AttrSeqnr(43)]
        [DomId(100004307)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourTurningAreaIndicatorEnum? TurningAreaIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vehicle_hndl_type_code
		///
		/// The specific types of facilities available at a specified HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column vehicle_hndl_type_code
        /// </value>
        [AttrIx(100044)]
		[AttrName("harbour-vehicle-handling-type-code")]
		[AttrColumnName("vehicle_hndl_type_code")]
        [AttrSeqnr(44)]
        [DomId(100004174)]
        [DataLength(6)]
        [DataDecimals(0)]
        HarbourVehicleHandlingTypeEnum? VehicleHandlingType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100045)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(45)]
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
        [AttrIx(100046)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(46)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
