using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity AIRFIELD that represents the table AIRFIELD.
	///
	/// A FACILITY that is an area prepared for the accommodation (including any buildings, installations, or equipment) of landing and take off of aircraft.
    /// </summary>
    [Serializable]
    [DefinitionName("Airfield", "C4Net.JC3IEDM.Definitions.Airfield.definition.xml")]
    public class Airfield : Facility, IAirfield
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly AirfieldExpression _ = new AirfieldExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column atc_prsnc_ind_code
		///
		/// The specific value that indicates whether a specific AIRFIELD provides air traffic control.
        /// </summary>
        /// <value>
        /// Value of the column atc_prsnc_ind_code
        /// </value>
		public AirfieldAirTrafficControlPresenceIndicatorEnum? AirTrafficControlPresenceIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column hngr_area_qty
		///
		/// The numeric value that represents the total hangar area in a specific AIRFIELD. The unit of measure is square metre.
        /// </summary>
        /// <value>
        /// Value of the column hngr_area_qty
        /// </value>
		public int? HangarAreaQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ils_prsnc_ind_code
		///
		/// The specific value that indicates whether a specific AIRFIELD has an instrument landing system.
        /// </summary>
        /// <value>
        /// Value of the column ils_prsnc_ind_code
        /// </value>
		public AirfieldInstrumentLandingSystemPresenceIndicatorEnum? InstrumentLandingSystemPresenceIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column intl_civil_avtn_org_txt
		///
		/// The character string assigned to represent the description the international civil aviation organization (ICAO) identifier commonly used throughout the world for reference to a known aviation facility.
        /// </summary>
        /// <value>
        /// Value of the column intl_civil_avtn_org_txt
        /// </value>
		public string InternationalCivilAviationOrganisationText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column visual_nvtgl_aid_ind_code
		///
		/// The specific value indicating whether or not the airport has a visual navigational aid displaying flashes of white or colored light to indicate the location of an airport.
        /// </summary>
        /// <value>
        /// Value of the column visual_nvtgl_aid_ind_code
        /// </value>
		public AirfieldVisualNavigationalAidIndicatorEnum? VisualNavigationalAidIndicator { get; set; }
		
        #endregion
    }
}
