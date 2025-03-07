using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity PhysicalAddress that represents the table PHYSCL_ADDR
	/// 
	/// An ADDRESS that represents a physical location that is reachable by use of transportation, to include the use of postal services.
    /// </summary>
	[EntId(10000242)]
    [EntName("PHYSICAL-ADDRESS")]
    [EntTableName("PHYSCL_ADDR")]
    [EntDepth(1)]
    public interface IPhysicalAddress
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column addr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ADDRESS and to distinguish it from all other ADDRESSs.
        /// </summary>
        /// <value>
        /// Value of the column addr_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("address-id")]
		[AttrColumnName("addr_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000917)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal AddressId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of the PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("physical-address-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000383)]
        [DataLength(6)]
        [DataDecimals(0)]
        PhysicalAddressCategoryEnum PhysicalAddressCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rsdnc_txt
		///
		/// The character string assigned to represent the residence name of the PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column rsdnc_txt
        /// </value>
        [AttrIx(100003)]
		[AttrName("physical-address-residence-text")]
		[AttrColumnName("rsdnc_txt")]
        [AttrSeqnr(3)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string ResidenceText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column street_txt
		///
		/// The character string assigned to represent the street name for a specific PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column street_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("physical-address-street-text")]
		[AttrColumnName("street_txt")]
        [AttrSeqnr(4)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string StreetText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column street_addtnl_txt
		///
		/// The character string assigned to represent specific additional information such as the house number, the apartment number, rural route number, building number, room number, office or equivalent number to complete the physical address for a specific PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column street_addtnl_txt
        /// </value>
        [AttrIx(100005)]
		[AttrName("physical-address-street-additional-text")]
		[AttrColumnName("street_addtnl_txt")]
        [AttrSeqnr(5)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string StreetAdditionalText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column postal_box_txt
		///
		/// The character string assigned to represent a specific post office box of the PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column postal_box_txt
        /// </value>
        [AttrIx(100006)]
		[AttrName("physical-address-postal-box-text")]
		[AttrColumnName("postal_box_txt")]
        [AttrSeqnr(6)]
        [DomId(100001500)]
        [DataLength(15)]
        [DataDecimals(0)]
        string PostalBoxText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column postbox_id_txt
		///
		/// The character string assigned to represent a specific letter box number of the PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column postbox_id_txt
        /// </value>
        [AttrIx(100007)]
		[AttrName("physical-address-postbox-identifier-text")]
		[AttrColumnName("postbox_id_txt")]
        [AttrSeqnr(7)]
        [DomId(100001500)]
        [DataLength(15)]
        [DataDecimals(0)]
        string PostboxIdentifierText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column city_txt
		///
		/// The character string assigned to represent the city name of the PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column city_txt
        /// </value>
        [AttrIx(100008)]
		[AttrName("physical-address-city-text")]
		[AttrColumnName("city_txt")]
        [AttrSeqnr(8)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string CityText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column geo_txt
		///
		/// The character string assigned to represent the geographic region of the PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column geo_txt
        /// </value>
        [AttrIx(100009)]
		[AttrName("physical-address-geographic-text")]
		[AttrColumnName("geo_txt")]
        [AttrSeqnr(9)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string GeographicText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column postal_code_txt
		///
		/// The character string assigned to represent the postal code of the PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column postal_code_txt
        /// </value>
        [AttrIx(100010)]
		[AttrName("physical-address-postal-code-text")]
		[AttrColumnName("postal_code_txt")]
        [AttrSeqnr(10)]
        [DomId(100001500)]
        [DataLength(15)]
        [DataDecimals(0)]
        string PostalCodeText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column province_txt
		///
		/// The character string assigned to represent the province of the PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column province_txt
        /// </value>
        [AttrIx(100013)]
		[AttrName("physical-address-province-text")]
		[AttrColumnName("province_txt")]
        [AttrSeqnr(11)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string ProvinceText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column district_txt
		///
		/// The character string assigned to represent the district of the PHYSICAL-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column district_txt
        /// </value>
        [AttrIx(100014)]
		[AttrName("physical-address-district-text")]
		[AttrColumnName("district_txt")]
        [AttrSeqnr(12)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string DistrictText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100011)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(13)]
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
        [AttrIx(100012)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(14)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
