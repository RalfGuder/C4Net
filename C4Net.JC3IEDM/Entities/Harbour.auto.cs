using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity HARBOUR that represents the table HRBR.
	///
	/// A FACILITY that is a restricted body of water, an anchorage, or other limited coastal water area and its water approaches from which and in which shipping operations are projected or supported.
    /// </summary>
    [Serializable]
    [DefinitionName("Harbour", "C4Net.JC3IEDM.Definitions.Harbour.definition.xml")]
    public class Harbour : Facility, IHarbour
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly HarbourExpression _ = new HarbourExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column airport_near_ind_code
		///
		/// The specific value that represents whether an airport is near the HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column airport_near_ind_code
        /// </value>
		public HarbourAirportNearIndicatorEnum? AirportNearIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column appr_chnl_depth_dim
		///
		/// The one-dimensional linear distance representing the depth maintained by dredging and guaranteed by the harbour authority of the specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column appr_chnl_depth_dim
        /// </value>
		public double? ApproachChannelDepthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column biolg_secure_avlbty_ind_code
		///
		/// The specific value that represents whether the HARBOUR is capable of supplying biologically secure facilities, to include quarantine facilities.
        /// </summary>
        /// <value>
        /// Value of the column biolg_secure_avlbty_ind_code
        /// </value>
		public HarbourBiologicallySecureAvailabilityIndicatorEnum? BiologicallySecureAvailabilityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column convoy_mrshl_ind_code
		///
		/// The specific value that represents whether the HARBOUR is capable of supplying convoy-marshalling facilities.
        /// </summary>
        /// <value>
        /// Value of the column convoy_mrshl_ind_code
        /// </value>
		public HarbourConvoyMarshallingIndicatorEnum? ConvoyMarshallingIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column day_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the HARBOUR during the day. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column day_limit_net_expl_qty
        /// </value>
		public int? DayLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column night_limit_net_expl_qty
		///
		/// The numeric value that represents the maximum net explosive quantity that can be handled at the HARBOUR during the night. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column night_limit_net_expl_qty
        /// </value>
		public int? NightLimitNetExplosiveQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column degaussing_ind_code
		///
		/// The specific value that represents whether degaussing facilities are available.
        /// </summary>
        /// <value>
        /// Value of the column degaussing_ind_code
        /// </value>
		public HarbourDegaussingIndicatorEnum? DegaussingIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dirty_ballast_ind_code
		///
		/// The specific value that represents whether the port has sufficient facilities for receiving oily or chemically contaminated dirty ballast.
        /// </summary>
        /// <value>
        /// Value of the column dirty_ballast_ind_code
        /// </value>
		public HarbourDirtyBallastIndicatorEnum? DirtyBallastIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column entr_restr_ice_ind_code
		///
		/// The specific value that represents whether ice is a natural factor restricting the entrance of vessels into the port.
        /// </summary>
        /// <value>
        /// Value of the column entr_restr_ice_ind_code
        /// </value>
		public HarbourEntranceRestrictionsIceIndicatorEnum? EntranceRestrictionsIceIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column entr_restr_swell_ind_code
		///
		/// The specific value that represents whether heavy swell is a natural factor restricting the entrance of vessels into the port.
        /// </summary>
        /// <value>
        /// Value of the column entr_restr_swell_ind_code
        /// </value>
		public HarbourEntranceRestrictionsSwellIndicatorEnum? EntranceRestrictionsSwellIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column entr_restr_txt
		///
		/// The character string assigned to represent the factors other than tide, heavy swell, and ice restricting entrance into the port.
        /// </summary>
        /// <value>
        /// Value of the column entr_restr_txt
        /// </value>
		public string EntranceRestrictionsText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column eta_ind_code
		///
		/// The specific value that represents whether an estimated time of arrival message is required.
        /// </summary>
        /// <value>
        /// Value of the column eta_ind_code
        /// </value>
		public HarbourEstimatedTimeOfArrivalIndicatorEnum? EstimatedTimeOfArrivalIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fire_fighting_capab_code
		///
		/// The specific value that represents the class of fire fighting capability available at a specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column fire_fighting_capab_code
        /// </value>
		public HarbourFireFightingCapabilityEnum? FireFightingCapability { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fire_fighting_ind_code
		///
		/// The specific value that represents whether the HARBOUR is capable of supplying fire-fighting facilities.
        /// </summary>
        /// <value>
        /// Value of the column fire_fighting_ind_code
        /// </value>
		public HarbourFireFightingIndicatorEnum? FireFightingIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column first_port_of_entry_ind_code
		///
		/// The specific value that represents whether the port may be used by a vessel that needs to clear foreign goods and personnel through Customs and Immigration.
        /// </summary>
        /// <value>
        /// Value of the column first_port_of_entry_ind_code
        /// </value>
		public HarbourFirstPortOfEntryIndicatorEnum? FirstPortOfEntryIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fresh_water_avlbty_ind_code
		///
		/// The specific value that represents whether the HARBOUR is capable of providing fresh water.
        /// </summary>
        /// <value>
        /// Value of the column fresh_water_avlbty_ind_code
        /// </value>
		public HarbourFreshWaterAvailabilityIndicatorEnum? FreshWaterAvailabilityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lash_ind_code
		///
		/// The specific value that represents whether the HARBOUR can support the Lighter Aboard Ship (LASH) transportation system.
        /// </summary>
        /// <value>
        /// Value of the column lash_ind_code
        /// </value>
		public HarbourLashIndicatorEnum? LashIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lighterage_avlbty_ind_code
		///
		/// The specific value that represents the possibility for transferring goods from a ship to a wharf or another ship using a boat, usu. flat-bottomed at a specific maritime port.
        /// </summary>
        /// <value>
        /// Value of the column lighterage_avlbty_ind_code
        /// </value>
		public HarbourLighterageAvailabilityIndicatorEnum? LighterageAvailabilityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_vessel_draught_dim
		///
		/// The one-dimensional linear distance representing the maximum draught of vessel that the specific HARBOUR can accommodate.
        /// </summary>
        /// <value>
        /// Value of the column max_vessel_draught_dim
        /// </value>
		public double? MaximumVesselDraughtDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_vessel_length_dim
		///
		/// The one-dimensional linear distance representing the maximum length of vessel that the specific HARBOUR can accommodate.
        /// </summary>
        /// <value>
        /// Value of the column max_vessel_length_dim
        /// </value>
		public double? MaximumVesselLengthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_vessel_width_dim
		///
		/// The one-dimensional linear distance representing the maximum width of vessel that the specific HARBOUR can accommodate.
        /// </summary>
        /// <value>
        /// Value of the column max_vessel_width_dim
        /// </value>
		public double? MaximumVesselWidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mean_tidal_curr_rate
		///
		/// The numeric value that denotes the average velocity of the tidal flow at the specific HARBOUR. The unit of measure is kilometres per hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column mean_tidal_curr_rate
        /// </value>
		public double? MeanTidalCurrentRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column psgr_hndl_ind_code
		///
		/// The specific value that represents whether the HARBOUR is capable of handling passengers.
        /// </summary>
        /// <value>
        /// Value of the column psgr_hndl_ind_code
        /// </value>
		public HarbourPassengerHandlingIndicatorEnum? PassengerHandlingIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column persistence_code
		///
		/// The specific value that represents whether the HARBOUR is permanent or temporary.
        /// </summary>
        /// <value>
        /// Value of the column persistence_code
        /// </value>
		public HarbourPersistenceEnum? Persistence { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column overhead_limits_ind_code
		///
		/// The specific value that represents whether bridge and/or overhead power cables exist.
        /// </summary>
        /// <value>
        /// Value of the column overhead_limits_ind_code
        /// </value>
		public HarbourOverheadLimitsIndicatorEnum? OverheadLimitsIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pilotage_avlbty_ind_code
		///
		/// The specific value that represents whether a pilot is available at the port.
        /// </summary>
        /// <value>
        /// Value of the column pilotage_avlbty_ind_code
        /// </value>
		public HarbourPilotageAvailabilityIndicatorEnum? PilotageAvailabilityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pilotage_reqmnt_ind_code
		///
		/// The specific value that represents whether the HARBOUR requires vessels to have a pilot.
        /// </summary>
        /// <value>
        /// Value of the column pilotage_reqmnt_ind_code
        /// </value>
		public HarbourPilotageRequirementIndicatorEnum? PilotageRequirementIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prvl_wind_dir_code
		///
		/// The specific value that represents the direction of the wind that most frequently occurs for the specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column prvl_wind_dir_code
        /// </value>
		public DirectionEnum? PrevailingWindDirection { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prvl_wind_max_speed_code
		///
		/// The specific value that represents the maximum degree of discrimination or resolution for which the prevailing wind speed is stated.
        /// </summary>
        /// <value>
        /// Value of the column prvl_wind_max_speed_code
        /// </value>
		public SpeedPrecisionEnum? PrevailingWindMaximumSpeed { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prvl_wind_max_speed_rate
		///
		/// The numeric value that denotes the maximum recorded strength of wind at the specific HARBOUR. The unit of measure is kilometres/hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column prvl_wind_max_speed_rate
        /// </value>
		public double? PrevailingWindMaximumSpeedRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column refl_avlbty_ind_code
		///
		/// The specific value that represents whether the HARBOUR has refuelling facilities.
        /// </summary>
        /// <value>
        /// Value of the column refl_avlbty_ind_code
        /// </value>
		public HarbourRefuellingAvailabilityIndicatorEnum? RefuellingAvailabilityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column refl_loc_txt
		///
		/// The character string assigned to represent a statement of the specific refuelling details that relate to the specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column refl_loc_txt
        /// </value>
		public string RefuellingLocationText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column refl_type_code
		///
		/// The specific value that represents the refuelling means available at the specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column refl_type_code
        /// </value>
		public HarbourRefuellingTypeEnum? RefuellingType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column seasonal_det_txt
		///
		/// The character string assigned to represent a statement of the specific seasonal details that relate to the specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column seasonal_det_txt
        /// </value>
		public string SeasonalDetailText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column shelter_qual_code
		///
		/// The protection provided from wind, sea, and swell in the area where normal port operations are conducted.
        /// </summary>
        /// <value>
        /// Value of the column shelter_qual_code
        /// </value>
		public HarbourShelterQualityEnum? ShelterQuality { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column tanker_facilities_ind_code
		///
		/// The specific value that represents the availability of facilities to process tankers at a specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column tanker_facilities_ind_code
        /// </value>
		public HarbourTankerFacilitiesIndicatorEnum? TankerFacilitiesIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column tidal_mean_neap_range_dim
		///
		/// The one-dimensional linear distance representing the average range just after the first and third quarters of the moon when there is the least difference between high and low water for a specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column tidal_mean_neap_range_dim
        /// </value>
		public double? TidalMeanNeapRangeDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column tidal_mean_spring_range_dim
		///
		/// The one-dimensional linear distance representing the average range just after the new and full moon when there is the greatest difference between high and low water for a specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column tidal_mean_spring_range_dim
        /// </value>
		public double? TidalMeanSpringRangeDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column tidal_txt
		///
		/// The character string assigned to represent a statement of the specific tidal details that relate to the specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column tidal_txt
        /// </value>
		public string TidalText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column trnst_acom_ind_code
		///
		/// The specific value that represents whether the HARBOUR is capable of supplying transit accommodation facilities.
        /// </summary>
        /// <value>
        /// Value of the column trnst_acom_ind_code
        /// </value>
		public HarbourTransitAccommodationIndicatorEnum? TransitAccommodationIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column tug_avlbty_ind_code
		///
		/// The specific value that represents the availability of tugs at a specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column tug_avlbty_ind_code
        /// </value>
		public HarbourTugAvailabilityIndicatorEnum? TugAvailabilityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column turning_area_ind_code
		///
		/// The specific value that represents whether there is a turning basin or other water area available in a specific HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column turning_area_ind_code
        /// </value>
		public HarbourTurningAreaIndicatorEnum? TurningAreaIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vehicle_hndl_type_code
		///
		/// The specific types of facilities available at a specified HARBOUR.
        /// </summary>
        /// <value>
        /// Value of the column vehicle_hndl_type_code
        /// </value>
		public HarbourVehicleHandlingTypeEnum? VehicleHandlingType { get; set; }
		
        #endregion
    }
}
