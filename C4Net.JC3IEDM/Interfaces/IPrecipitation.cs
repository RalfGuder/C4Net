using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Precipitation that represents the table PRECIPITATION
	/// 
	/// A METEOROLOGIC-FEATURE that specifies the type of particulate matter in the Earth's atmosphere and the rate of its descent onto the Earth's surface.
    /// </summary>
	[EntId(10000108)]
    [EntName("PRECIPITATION")]
    [EntTableName("PRECIPITATION")]
    [EntDepth(3)]
    public interface IPrecipitation
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column precipitation_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column precipitation_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("precipitation-id")]
		[AttrColumnName("precipitation_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the prevailing class of a specific PRECIPITATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("precipitation-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000170)]
        [DataLength(6)]
        [DataDecimals(0)]
        PrecipitationCategoryEnum PrecipitationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rate
		///
		/// The numeric value that denotes the amount of PRECIPITATION deposited per unit time. The unit of measure is millimetres per hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column rate
        /// </value>
        [AttrIx(100003)]
		[AttrName("precipitation-rate")]
		[AttrColumnName("rate")]
        [AttrSeqnr(3)]
        [DomId(100001300)]
        [DataLength(4)]
        [DataDecimals(1)]
        double? Rate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100004)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(4)]
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
        [AttrIx(100005)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
