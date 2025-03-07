using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity AIRCRAFT-TYPE that represents the table ACFT_TYPE.
	///
	/// An EQUIPMENT-TYPE that is designed to fly.
    /// </summary>
    [Serializable]
    [DefinitionName("AircraftType", "C4Net.JC3IEDM.Definitions.AircraftType.definition.xml")]
    public class AircraftType : EquipmentType, IAircraftType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly AircraftTypeExpression _ = new AircraftTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of AIRCRAFT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public AircraftTypeCategoryEnum AircraftTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column airframe_design_code
		///
		/// The specific value that represents the design of the airframe of an AIRCRAFT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column airframe_design_code
        /// </value>
		public AircraftTypeAirframeDesignEnum? AirframeDesign { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column model_code
		///
		/// The specific value that represents the specific design of an AIRCRAFT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column model_code
        /// </value>
		public AircraftTypeModelEnum? Model { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column manning_code
		///
		/// The specific value that represents whether an aircraft is designed to be manned or unmanned.
        /// </summary>
        /// <value>
        /// Value of the column manning_code
        /// </value>
		public AircraftTypeManningEnum? Manning { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mil_civ_code
		///
		/// The specific value that represents whether an aircraft is primarily intended for military or civilian use.
        /// </summary>
        /// <value>
        /// Value of the column mil_civ_code
        /// </value>
		public AircraftTypeMilitaryCivilianEnum? MilitaryCivilian { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column main_purpose_code
		///
		/// The specific value that represents the main purpose of an AIRCRAFT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column main_purpose_code
        /// </value>
		public AircraftTypeMainPurposeEnum? MainPurpose { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column design_role_code
		///
		/// The specific value that represents the designed role of an AIRCRAFT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column design_role_code
        /// </value>
		public AircraftTypeDesignRoleEnum? DesignRole { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column design_range_code
		///
		/// The specific value that represents the designed range of an AIRCRAFT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column design_range_code
        /// </value>
		public AircraftTypeDesignRangeEnum? DesignRange { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column weather_qual_code
		///
		/// The specific value that represents the weather conditions in which an AIRCRAFT-TYPE can perform its mission.
        /// </summary>
        /// <value>
        /// Value of the column weather_qual_code
        /// </value>
		public AircraftTypeWeatherQualifierEnum? WeatherQualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column training_cat_code
		///
		/// The specific value that denotes whether an aircraft can be used for training purposes.
        /// </summary>
        /// <value>
        /// Value of the column training_cat_code
        /// </value>
		public AircraftTypeTrainingCategoryEnum? TrainingCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column load_cat_code
		///
		/// The specific value that represents a loading capability of an AIRCRAFT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column load_cat_code
        /// </value>
		public AircraftTypeLoadCategoryEnum? LoadCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column takeoff_and_lndg_code
		///
		/// The specific value that represents the takeoff and landing designation of an AIRCRAFT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column takeoff_and_lndg_code
        /// </value>
		public AircraftTypeTakeoffAndLandingEnum? TakeoffAndLanding { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column wing_span_dim
		///
		/// The one-dimensional linear distance representing the spread of the wings of a specific AIRCRAFT-TYPE measured from end to end.
        /// </summary>
        /// <value>
        /// Value of the column wing_span_dim
        /// </value>
		public double? WingSpanDimension { get; set; }
		
        #endregion
    }
}
