using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity AircraftType that represents the table ACFT_TYPE
	/// 
	/// An EQUIPMENT-TYPE that is designed to fly.
    /// </summary>
	[EntId(10000184)]
    [EntName("AIRCRAFT-TYPE")]
    [EntTableName("ACFT_TYPE")]
    [EntDepth(3)]
    public interface IAircraftType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column acft_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column acft_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("aircraft-type-id")]
		[AttrColumnName("acft_type_id")]
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
		/// The specific value that represents the class of AIRCRAFT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("aircraft-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000336)]
        [DataLength(6)]
        [DataDecimals(0)]
        AircraftTypeCategoryEnum AircraftTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column airframe_design_code
		///
		/// The specific value that represents the design of the airframe of an AIRCRAFT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column airframe_design_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("aircraft-type-airframe-design-code")]
		[AttrColumnName("airframe_design_code")]
        [AttrSeqnr(3)]
        [DomId(100004365)]
        [DataLength(6)]
        [DataDecimals(0)]
        AircraftTypeAirframeDesignEnum? AirframeDesign { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column model_code
		///
		/// The specific value that represents the specific design of an AIRCRAFT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column model_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("aircraft-type-model-code")]
		[AttrColumnName("model_code")]
        [AttrSeqnr(4)]
        [DomId(100004202)]
        [DataLength(6)]
        [DataDecimals(0)]
        AircraftTypeModelEnum? Model { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column manning_code
		///
		/// The specific value that represents whether an aircraft is designed to be manned or unmanned.
        /// </summary>
        /// <value>
        /// Value of the column manning_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("aircraft-type-manning-code")]
		[AttrColumnName("manning_code")]
        [AttrSeqnr(5)]
        [DomId(100004366)]
        [DataLength(6)]
        [DataDecimals(0)]
        AircraftTypeManningEnum? Manning { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mil_civ_code
		///
		/// The specific value that represents whether an aircraft is primarily intended for military or civilian use.
        /// </summary>
        /// <value>
        /// Value of the column mil_civ_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("aircraft-type-military-civilian-code")]
		[AttrColumnName("mil_civ_code")]
        [AttrSeqnr(6)]
        [DomId(100004367)]
        [DataLength(6)]
        [DataDecimals(0)]
        AircraftTypeMilitaryCivilianEnum? MilitaryCivilian { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column main_purpose_code
		///
		/// The specific value that represents the main purpose of an AIRCRAFT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column main_purpose_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("aircraft-type-main-purpose-code")]
		[AttrColumnName("main_purpose_code")]
        [AttrSeqnr(7)]
        [DomId(100004368)]
        [DataLength(6)]
        [DataDecimals(0)]
        AircraftTypeMainPurposeEnum? MainPurpose { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column design_role_code
		///
		/// The specific value that represents the designed role of an AIRCRAFT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column design_role_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("aircraft-type-design-role-code")]
		[AttrColumnName("design_role_code")]
        [AttrSeqnr(8)]
        [DomId(100004369)]
        [DataLength(6)]
        [DataDecimals(0)]
        AircraftTypeDesignRoleEnum? DesignRole { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column design_range_code
		///
		/// The specific value that represents the designed range of an AIRCRAFT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column design_range_code
        /// </value>
        [AttrIx(100009)]
		[AttrName("aircraft-type-design-range-code")]
		[AttrColumnName("design_range_code")]
        [AttrSeqnr(9)]
        [DomId(100004370)]
        [DataLength(6)]
        [DataDecimals(0)]
        AircraftTypeDesignRangeEnum? DesignRange { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column weather_qual_code
		///
		/// The specific value that represents the weather conditions in which an AIRCRAFT-TYPE can perform its mission.
        /// </summary>
        /// <value>
        /// Value of the column weather_qual_code
        /// </value>
        [AttrIx(100010)]
		[AttrName("aircraft-type-weather-qualifier-code")]
		[AttrColumnName("weather_qual_code")]
        [AttrSeqnr(10)]
        [DomId(100004371)]
        [DataLength(6)]
        [DataDecimals(0)]
        AircraftTypeWeatherQualifierEnum? WeatherQualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column training_cat_code
		///
		/// The specific value that denotes whether an aircraft can be used for training purposes.
        /// </summary>
        /// <value>
        /// Value of the column training_cat_code
        /// </value>
        [AttrIx(100011)]
		[AttrName("aircraft-type-training-category-code")]
		[AttrColumnName("training_cat_code")]
        [AttrSeqnr(11)]
        [DomId(100004372)]
        [DataLength(6)]
        [DataDecimals(0)]
        AircraftTypeTrainingCategoryEnum? TrainingCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column load_cat_code
		///
		/// The specific value that represents a loading capability of an AIRCRAFT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column load_cat_code
        /// </value>
        [AttrIx(100012)]
		[AttrName("aircraft-type-load-category-code")]
		[AttrColumnName("load_cat_code")]
        [AttrSeqnr(12)]
        [DomId(100004203)]
        [DataLength(6)]
        [DataDecimals(0)]
        AircraftTypeLoadCategoryEnum? LoadCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column takeoff_and_lndg_code
		///
		/// The specific value that represents the takeoff and landing designation of an AIRCRAFT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column takeoff_and_lndg_code
        /// </value>
        [AttrIx(100013)]
		[AttrName("aircraft-type-takeoff-and-landing-code")]
		[AttrColumnName("takeoff_and_lndg_code")]
        [AttrSeqnr(13)]
        [DomId(100004204)]
        [DataLength(6)]
        [DataDecimals(0)]
        AircraftTypeTakeoffAndLandingEnum? TakeoffAndLanding { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column wing_span_dim
		///
		/// The one-dimensional linear distance representing the spread of the wings of a specific AIRCRAFT-TYPE measured from end to end.
        /// </summary>
        /// <value>
        /// Value of the column wing_span_dim
        /// </value>
        [AttrIx(100014)]
		[AttrName("aircraft-type-wing-span-dimension")]
		[AttrColumnName("wing_span_dim")]
        [AttrSeqnr(14)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? WingSpanDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100015)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(15)]
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
        [AttrIx(100016)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(16)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
