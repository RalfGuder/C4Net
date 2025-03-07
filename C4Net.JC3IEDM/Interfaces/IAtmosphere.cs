using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Atmosphere that represents the table ATMOSPHERE
	/// 
	/// A METEOROLOGIC-FEATURE that specifies humidity, pressure, and temperature characteristics of Earth's atmosphere.
    /// </summary>
	[EntId(10000018)]
    [EntName("ATMOSPHERE")]
    [EntTableName("ATMOSPHERE")]
    [EntDepth(3)]
    public interface IAtmosphere
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column atmosphere_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column atmosphere_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("atmosphere-id")]
		[AttrColumnName("atmosphere_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column humidity_rat
		///
		/// The numeric quotient value that represents the proportion of water present in the air to the maximum amount of water (saturation point) possible at a given temperature and pressure. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column humidity_rat
        /// </value>
        [AttrIx(100002)]
		[AttrName("atmosphere-humidity-ratio")]
		[AttrColumnName("humidity_rat")]
        [AttrSeqnr(2)]
        [DomId(100001900)]
        [DataLength(6)]
        [DataDecimals(5)]
        double? HumidityRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column inversion_layer_code
		///
		/// The specific value that represents the height of the inversion layer in the atmosphere. The stability class describes the degree of mixing of released material in the atmosphere.
        /// </summary>
        /// <value>
        /// Value of the column inversion_layer_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("atmosphere-inversion-layer-code")]
		[AttrColumnName("inversion_layer_code")]
        [AttrSeqnr(3)]
        [DomId(100004308)]
        [DataLength(6)]
        [DataDecimals(0)]
        AtmosphereInversionLayerEnum? InversionLayer { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prs_qty
		///
		/// The numeric value that denotes the ambient air pressure in terms of force per unit area. The unit of measure is kPa (Kilopascals).
        /// </summary>
        /// <value>
        /// Value of the column prs_qty
        /// </value>
        [AttrIx(100004)]
		[AttrName("atmosphere-pressure-quantity")]
		[AttrColumnName("prs_qty")]
        [AttrSeqnr(4)]
        [DomId(100001200)]
        [DataLength(8)]
        [DataDecimals(4)]
        double? PressureQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prs_sys_cat_code
		///
		/// The specific value that represents the class of a pressure system in a particular ATMOSPHERE.
        /// </summary>
        /// <value>
        /// Value of the column prs_sys_cat_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("atmosphere-pressure-system-category-code")]
		[AttrColumnName("prs_sys_cat_code")]
        [AttrSeqnr(5)]
        [DomId(100000304)]
        [DataLength(6)]
        [DataDecimals(0)]
        AtmospherePressureSystemCategoryEnum? PressureSystemCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column tmpr
		///
		/// The numeric value that indicates the heat of the ambient air for a specific ATMOSPHERE.
        /// </summary>
        /// <value>
        /// Value of the column tmpr
        /// </value>
        [AttrIx(100006)]
		[AttrName("atmosphere-temperature")]
		[AttrColumnName("tmpr")]
        [AttrSeqnr(6)]
        [DomId(100001400)]
        [DataLength(5)]
        [DataDecimals(1)]
        double? Temperature { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column tmpr_gradient_code
		///
		/// The specific value that represents heat change with respect to the ground and 100 m in elevation in a certain area. Acts as an indication of vertical air movement between the ground and higher elevations.
        /// </summary>
        /// <value>
        /// Value of the column tmpr_gradient_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("atmosphere-temperature-gradient-code")]
		[AttrColumnName("tmpr_gradient_code")]
        [AttrSeqnr(7)]
        [DomId(100000171)]
        [DataLength(6)]
        [DataDecimals(0)]
        AtmosphereTemperatureGradientEnum? TemperatureGradient { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(8)]
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
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(9)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
