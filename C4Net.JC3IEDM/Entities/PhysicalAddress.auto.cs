using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity PHYSICAL-ADDRESS that represents the table PHYSCL_ADDR.
	///
	/// An ADDRESS that represents a physical location that is reachable by use of transportation, to include the use of postal services.
    /// </summary>
    [Serializable]
    [DefinitionName("PhysicalAddress", "C4Net.JC3IEDM.Definitions.PhysicalAddress.definition.xml")]
    public class PhysicalAddress : Address, IPhysicalAddress
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly PhysicalAddressExpression _ = new PhysicalAddressExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column addr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ADDRESS and to distinguish it from all other ADDRESSs.
        /// </summary>
        /// <value>
        /// Value of the column addr_id
        /// </value>
		public decimal AddressId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of the PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public PhysicalAddressCategoryEnum PhysicalAddressCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rsdnc_txt
		///
		/// The character string assigned to represent the residence name of the PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column rsdnc_txt
        /// </value>
		public string ResidenceText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column street_txt
		///
		/// The character string assigned to represent the street name for a specific PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column street_txt
        /// </value>
		public string StreetText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column street_addtnl_txt
		///
		/// The character string assigned to represent specific additional information such as the house number, the apartment number, rural route number, building number, room number, office or equivalent number to complete the physical address for a specific PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column street_addtnl_txt
        /// </value>
		public string StreetAdditionalText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column postal_box_txt
		///
		/// The character string assigned to represent a specific post office box of the PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column postal_box_txt
        /// </value>
		public string PostalBoxText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column postbox_id_txt
		///
		/// The character string assigned to represent a specific letter box number of the PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column postbox_id_txt
        /// </value>
		public string PostboxIdentifierText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column city_txt
		///
		/// The character string assigned to represent the city name of the PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column city_txt
        /// </value>
		public string CityText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column geo_txt
		///
		/// The character string assigned to represent the geographic region of the PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column geo_txt
        /// </value>
		public string GeographicText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column postal_code_txt
		///
		/// The character string assigned to represent the postal code of the PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column postal_code_txt
        /// </value>
		public string PostalCodeText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column province_txt
		///
		/// The character string assigned to represent the province of the PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column province_txt
        /// </value>
		public string ProvinceText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column district_txt
		///
		/// The character string assigned to represent the district of the PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column district_txt
        /// </value>
		public string DistrictText { get; set; }
		
        #endregion
    }
}
