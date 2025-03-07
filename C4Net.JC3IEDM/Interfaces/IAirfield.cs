using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Airfield that represents the table AIRFIELD
	/// 
	/// A FACILITY that is an area prepared for the accommodation (including any buildings, installations, or equipment) of landing and take off of aircraft.
    /// </summary>
	[EntId(10000225)]
    [EntName("AIRFIELD")]
    [EntTableName("AIRFIELD")]
    [EntDepth(3)]
    public interface IAirfield
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column airfield_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column airfield_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("airfield-id")]
		[AttrColumnName("airfield_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column atc_prsnc_ind_code
		///
		/// The specific value that indicates whether a specific AIRFIELD provides air traffic control.
        /// </summary>
        /// <value>
        /// Value of the column atc_prsnc_ind_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("airfield-air-traffic-control-presence-indicator-code")]
		[AttrColumnName("atc_prsnc_ind_code")]
        [AttrSeqnr(2)]
        [DomId(100004111)]
        [DataLength(6)]
        [DataDecimals(0)]
        AirfieldAirTrafficControlPresenceIndicatorEnum? AirTrafficControlPresenceIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column hngr_area_qty
		///
		/// The numeric value that represents the total hangar area in a specific AIRFIELD. The unit of measure is square metre.
        /// </summary>
        /// <value>
        /// Value of the column hngr_area_qty
        /// </value>
        [AttrIx(100003)]
		[AttrName("airfield-hangar-area-quantity")]
		[AttrColumnName("hngr_area_qty")]
        [AttrSeqnr(3)]
        [DomId(100001200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? HangarAreaQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ils_prsnc_ind_code
		///
		/// The specific value that indicates whether a specific AIRFIELD has an instrument landing system.
        /// </summary>
        /// <value>
        /// Value of the column ils_prsnc_ind_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("airfield-instrument-landing-system-presence-indicator-code")]
		[AttrColumnName("ils_prsnc_ind_code")]
        [AttrSeqnr(4)]
        [DomId(100004112)]
        [DataLength(6)]
        [DataDecimals(0)]
        AirfieldInstrumentLandingSystemPresenceIndicatorEnum? InstrumentLandingSystemPresenceIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column intl_civil_avtn_org_txt
		///
		/// The character string assigned to represent the description the international civil aviation organization (ICAO) identifier commonly used throughout the world for reference to a known aviation facility.
        /// </summary>
        /// <value>
        /// Value of the column intl_civil_avtn_org_txt
        /// </value>
        [AttrIx(100005)]
		[AttrName("airfield-international-civil-aviation-organisation-text")]
		[AttrColumnName("intl_civil_avtn_org_txt")]
        [AttrSeqnr(5)]
        [DomId(100001500)]
        [DataLength(100)]
        [DataDecimals(0)]
        string InternationalCivilAviationOrganisationText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column visual_nvtgl_aid_ind_code
		///
		/// The specific value indicating whether or not the airport has a visual navigational aid displaying flashes of white or colored light to indicate the location of an airport.
        /// </summary>
        /// <value>
        /// Value of the column visual_nvtgl_aid_ind_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("airfield-visual-navigational-aid-indicator-code")]
		[AttrColumnName("visual_nvtgl_aid_ind_code")]
        [AttrSeqnr(6)]
        [DomId(100004257)]
        [DataLength(6)]
        [DataDecimals(0)]
        AirfieldVisualNavigationalAidIndicatorEnum? VisualNavigationalAidIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(7)]
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
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(8)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
