using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Harbour.
    /// </summary>
    public class HarbourExpression : BaseEntityExpression<HarbourExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column hrbr_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column hrbr_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property AirportNearIndicator that represents the column airport_near_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property AirportNearIndicator that represents the column airport_near_ind_code.
        /// </value>
        public ColumnExpression AirportNearIndicator 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property ApproachChannelDepthDimension that represents the column appr_chnl_depth_dim.
        /// </summary>
        /// <value>
        /// The value of the property ApproachChannelDepthDimension that represents the column appr_chnl_depth_dim.
        /// </value>
        public ColumnExpression ApproachChannelDepthDimension 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property BiologicallySecureAvailabilityIndicator that represents the column biolg_secure_avlbty_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property BiologicallySecureAvailabilityIndicator that represents the column biolg_secure_avlbty_ind_code.
        /// </value>
        public ColumnExpression BiologicallySecureAvailabilityIndicator 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property ConvoyMarshallingIndicator that represents the column convoy_mrshl_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property ConvoyMarshallingIndicator that represents the column convoy_mrshl_ind_code.
        /// </value>
        public ColumnExpression ConvoyMarshallingIndicator 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property DayLimitNetExplosiveQuantity that represents the column day_limit_net_expl_qty.
        /// </summary>
        /// <value>
        /// The value of the property DayLimitNetExplosiveQuantity that represents the column day_limit_net_expl_qty.
        /// </value>
        public ColumnExpression DayLimitNetExplosiveQuantity 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property NightLimitNetExplosiveQuantity that represents the column night_limit_net_expl_qty.
        /// </summary>
        /// <value>
        /// The value of the property NightLimitNetExplosiveQuantity that represents the column night_limit_net_expl_qty.
        /// </value>
        public ColumnExpression NightLimitNetExplosiveQuantity 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property DegaussingIndicator that represents the column degaussing_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property DegaussingIndicator that represents the column degaussing_ind_code.
        /// </value>
        public ColumnExpression DegaussingIndicator 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property DirtyBallastIndicator that represents the column dirty_ballast_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property DirtyBallastIndicator that represents the column dirty_ballast_ind_code.
        /// </value>
        public ColumnExpression DirtyBallastIndicator 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property EntranceRestrictionsIceIndicator that represents the column entr_restr_ice_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property EntranceRestrictionsIceIndicator that represents the column entr_restr_ice_ind_code.
        /// </value>
        public ColumnExpression EntranceRestrictionsIceIndicator 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property EntranceRestrictionsSwellIndicator that represents the column entr_restr_swell_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property EntranceRestrictionsSwellIndicator that represents the column entr_restr_swell_ind_code.
        /// </value>
        public ColumnExpression EntranceRestrictionsSwellIndicator 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property EntranceRestrictionsText that represents the column entr_restr_txt.
        /// </summary>
        /// <value>
        /// The value of the property EntranceRestrictionsText that represents the column entr_restr_txt.
        /// </value>
        public ColumnExpression EntranceRestrictionsText 
        { 
            get { return this.columns[11]; } 
        }
		
        /// <summary>
        /// Expression for the property EstimatedTimeOfArrivalIndicator that represents the column eta_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property EstimatedTimeOfArrivalIndicator that represents the column eta_ind_code.
        /// </value>
        public ColumnExpression EstimatedTimeOfArrivalIndicator 
        { 
            get { return this.columns[12]; } 
        }
		
        /// <summary>
        /// Expression for the property FireFightingCapability that represents the column fire_fighting_capab_code.
        /// </summary>
        /// <value>
        /// The value of the property FireFightingCapability that represents the column fire_fighting_capab_code.
        /// </value>
        public ColumnExpression FireFightingCapability 
        { 
            get { return this.columns[13]; } 
        }
		
        /// <summary>
        /// Expression for the property FireFightingIndicator that represents the column fire_fighting_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property FireFightingIndicator that represents the column fire_fighting_ind_code.
        /// </value>
        public ColumnExpression FireFightingIndicator 
        { 
            get { return this.columns[14]; } 
        }
		
        /// <summary>
        /// Expression for the property FirstPortOfEntryIndicator that represents the column first_port_of_entry_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property FirstPortOfEntryIndicator that represents the column first_port_of_entry_ind_code.
        /// </value>
        public ColumnExpression FirstPortOfEntryIndicator 
        { 
            get { return this.columns[15]; } 
        }
		
        /// <summary>
        /// Expression for the property FreshWaterAvailabilityIndicator that represents the column fresh_water_avlbty_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property FreshWaterAvailabilityIndicator that represents the column fresh_water_avlbty_ind_code.
        /// </value>
        public ColumnExpression FreshWaterAvailabilityIndicator 
        { 
            get { return this.columns[16]; } 
        }
		
        /// <summary>
        /// Expression for the property LashIndicator that represents the column lash_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property LashIndicator that represents the column lash_ind_code.
        /// </value>
        public ColumnExpression LashIndicator 
        { 
            get { return this.columns[17]; } 
        }
		
        /// <summary>
        /// Expression for the property LighterageAvailabilityIndicator that represents the column lighterage_avlbty_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property LighterageAvailabilityIndicator that represents the column lighterage_avlbty_ind_code.
        /// </value>
        public ColumnExpression LighterageAvailabilityIndicator 
        { 
            get { return this.columns[18]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumVesselDraughtDimension that represents the column max_vessel_draught_dim.
        /// </summary>
        /// <value>
        /// The value of the property MaximumVesselDraughtDimension that represents the column max_vessel_draught_dim.
        /// </value>
        public ColumnExpression MaximumVesselDraughtDimension 
        { 
            get { return this.columns[19]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumVesselLengthDimension that represents the column max_vessel_length_dim.
        /// </summary>
        /// <value>
        /// The value of the property MaximumVesselLengthDimension that represents the column max_vessel_length_dim.
        /// </value>
        public ColumnExpression MaximumVesselLengthDimension 
        { 
            get { return this.columns[20]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumVesselWidthDimension that represents the column max_vessel_width_dim.
        /// </summary>
        /// <value>
        /// The value of the property MaximumVesselWidthDimension that represents the column max_vessel_width_dim.
        /// </value>
        public ColumnExpression MaximumVesselWidthDimension 
        { 
            get { return this.columns[21]; } 
        }
		
        /// <summary>
        /// Expression for the property MeanTidalCurrentRate that represents the column mean_tidal_curr_rate.
        /// </summary>
        /// <value>
        /// The value of the property MeanTidalCurrentRate that represents the column mean_tidal_curr_rate.
        /// </value>
        public ColumnExpression MeanTidalCurrentRate 
        { 
            get { return this.columns[22]; } 
        }
		
        /// <summary>
        /// Expression for the property PassengerHandlingIndicator that represents the column psgr_hndl_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property PassengerHandlingIndicator that represents the column psgr_hndl_ind_code.
        /// </value>
        public ColumnExpression PassengerHandlingIndicator 
        { 
            get { return this.columns[23]; } 
        }
		
        /// <summary>
        /// Expression for the property Persistence that represents the column persistence_code.
        /// </summary>
        /// <value>
        /// The value of the property Persistence that represents the column persistence_code.
        /// </value>
        public ColumnExpression Persistence 
        { 
            get { return this.columns[24]; } 
        }
		
        /// <summary>
        /// Expression for the property OverheadLimitsIndicator that represents the column overhead_limits_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property OverheadLimitsIndicator that represents the column overhead_limits_ind_code.
        /// </value>
        public ColumnExpression OverheadLimitsIndicator 
        { 
            get { return this.columns[25]; } 
        }
		
        /// <summary>
        /// Expression for the property PilotageAvailabilityIndicator that represents the column pilotage_avlbty_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property PilotageAvailabilityIndicator that represents the column pilotage_avlbty_ind_code.
        /// </value>
        public ColumnExpression PilotageAvailabilityIndicator 
        { 
            get { return this.columns[26]; } 
        }
		
        /// <summary>
        /// Expression for the property PilotageRequirementIndicator that represents the column pilotage_reqmnt_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property PilotageRequirementIndicator that represents the column pilotage_reqmnt_ind_code.
        /// </value>
        public ColumnExpression PilotageRequirementIndicator 
        { 
            get { return this.columns[27]; } 
        }
		
        /// <summary>
        /// Expression for the property PrevailingWindDirection that represents the column prvl_wind_dir_code.
        /// </summary>
        /// <value>
        /// The value of the property PrevailingWindDirection that represents the column prvl_wind_dir_code.
        /// </value>
        public ColumnExpression PrevailingWindDirection 
        { 
            get { return this.columns[28]; } 
        }
		
        /// <summary>
        /// Expression for the property PrevailingWindMaximumSpeed that represents the column prvl_wind_max_speed_code.
        /// </summary>
        /// <value>
        /// The value of the property PrevailingWindMaximumSpeed that represents the column prvl_wind_max_speed_code.
        /// </value>
        public ColumnExpression PrevailingWindMaximumSpeed 
        { 
            get { return this.columns[29]; } 
        }
		
        /// <summary>
        /// Expression for the property PrevailingWindMaximumSpeedRate that represents the column prvl_wind_max_speed_rate.
        /// </summary>
        /// <value>
        /// The value of the property PrevailingWindMaximumSpeedRate that represents the column prvl_wind_max_speed_rate.
        /// </value>
        public ColumnExpression PrevailingWindMaximumSpeedRate 
        { 
            get { return this.columns[30]; } 
        }
		
        /// <summary>
        /// Expression for the property RefuellingAvailabilityIndicator that represents the column refl_avlbty_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property RefuellingAvailabilityIndicator that represents the column refl_avlbty_ind_code.
        /// </value>
        public ColumnExpression RefuellingAvailabilityIndicator 
        { 
            get { return this.columns[31]; } 
        }
		
        /// <summary>
        /// Expression for the property RefuellingLocationText that represents the column refl_loc_txt.
        /// </summary>
        /// <value>
        /// The value of the property RefuellingLocationText that represents the column refl_loc_txt.
        /// </value>
        public ColumnExpression RefuellingLocationText 
        { 
            get { return this.columns[32]; } 
        }
		
        /// <summary>
        /// Expression for the property RefuellingType that represents the column refl_type_code.
        /// </summary>
        /// <value>
        /// The value of the property RefuellingType that represents the column refl_type_code.
        /// </value>
        public ColumnExpression RefuellingType 
        { 
            get { return this.columns[33]; } 
        }
		
        /// <summary>
        /// Expression for the property SeasonalDetailText that represents the column seasonal_det_txt.
        /// </summary>
        /// <value>
        /// The value of the property SeasonalDetailText that represents the column seasonal_det_txt.
        /// </value>
        public ColumnExpression SeasonalDetailText 
        { 
            get { return this.columns[34]; } 
        }
		
        /// <summary>
        /// Expression for the property ShelterQuality that represents the column shelter_qual_code.
        /// </summary>
        /// <value>
        /// The value of the property ShelterQuality that represents the column shelter_qual_code.
        /// </value>
        public ColumnExpression ShelterQuality 
        { 
            get { return this.columns[35]; } 
        }
		
        /// <summary>
        /// Expression for the property TankerFacilitiesIndicator that represents the column tanker_facilities_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property TankerFacilitiesIndicator that represents the column tanker_facilities_ind_code.
        /// </value>
        public ColumnExpression TankerFacilitiesIndicator 
        { 
            get { return this.columns[36]; } 
        }
		
        /// <summary>
        /// Expression for the property TidalMeanNeapRangeDimension that represents the column tidal_mean_neap_range_dim.
        /// </summary>
        /// <value>
        /// The value of the property TidalMeanNeapRangeDimension that represents the column tidal_mean_neap_range_dim.
        /// </value>
        public ColumnExpression TidalMeanNeapRangeDimension 
        { 
            get { return this.columns[37]; } 
        }
		
        /// <summary>
        /// Expression for the property TidalMeanSpringRangeDimension that represents the column tidal_mean_spring_range_dim.
        /// </summary>
        /// <value>
        /// The value of the property TidalMeanSpringRangeDimension that represents the column tidal_mean_spring_range_dim.
        /// </value>
        public ColumnExpression TidalMeanSpringRangeDimension 
        { 
            get { return this.columns[38]; } 
        }
		
        /// <summary>
        /// Expression for the property TidalText that represents the column tidal_txt.
        /// </summary>
        /// <value>
        /// The value of the property TidalText that represents the column tidal_txt.
        /// </value>
        public ColumnExpression TidalText 
        { 
            get { return this.columns[39]; } 
        }
		
        /// <summary>
        /// Expression for the property TransitAccommodationIndicator that represents the column trnst_acom_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property TransitAccommodationIndicator that represents the column trnst_acom_ind_code.
        /// </value>
        public ColumnExpression TransitAccommodationIndicator 
        { 
            get { return this.columns[40]; } 
        }
		
        /// <summary>
        /// Expression for the property TugAvailabilityIndicator that represents the column tug_avlbty_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property TugAvailabilityIndicator that represents the column tug_avlbty_ind_code.
        /// </value>
        public ColumnExpression TugAvailabilityIndicator 
        { 
            get { return this.columns[41]; } 
        }
		
        /// <summary>
        /// Expression for the property TurningAreaIndicator that represents the column turning_area_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property TurningAreaIndicator that represents the column turning_area_ind_code.
        /// </value>
        public ColumnExpression TurningAreaIndicator 
        { 
            get { return this.columns[42]; } 
        }
		
        /// <summary>
        /// Expression for the property VehicleHandlingType that represents the column vehicle_hndl_type_code.
        /// </summary>
        /// <value>
        /// The value of the property VehicleHandlingType that represents the column vehicle_hndl_type_code.
        /// </value>
        public ColumnExpression VehicleHandlingType 
        { 
            get { return this.columns[43]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[44]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[45]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="HarbourExpression"/> class.
        /// </summary>
        public HarbourExpression()
            : base("Harbour", typeof(IHarbour))
        {
        }

        #endregion
    }
}
