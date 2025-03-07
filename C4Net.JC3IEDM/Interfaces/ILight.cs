using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Light that represents the table LIGHT
	/// 
	/// A METEOROLOGIC-FEATURE that specifies the availability of natural illumination by type and time.
    /// </summary>
	[EntId(10000060)]
    [EntName("LIGHT")]
    [EntTableName("LIGHT")]
    [EntDepth(3)]
    public interface ILight
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column light_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column light_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("light-id")]
		[AttrColumnName("light_id")]
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
		/// The specific value that represents the class of LIGHT.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("light-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [DomId(100000215)]
        [DataLength(6)]
        [DataDecimals(0)]
        LightCategoryEnum? LightCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column up_dttm
		///
		/// The character string representing a point in time that designates the time of day that marks the beginning of the period of effectiveness of the specified type of LIGHT.
        /// </summary>
        /// <value>
        /// Value of the column up_dttm
        /// </value>
        [AttrIx(100003)]
		[AttrName("light-up-datetime")]
		[AttrColumnName("up_dttm")]
        [AttrSeqnr(3)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string UpDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column down_dttm
		///
		/// The character string representing a point in time that designates the time of day that marks the end of the period of effectiveness of the specified type of LIGHT.
        /// </summary>
        /// <value>
        /// Value of the column down_dttm
        /// </value>
        [AttrIx(100004)]
		[AttrName("light-down-datetime")]
		[AttrColumnName("down_dttm")]
        [AttrSeqnr(4)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string DownDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column moon_phase_code
		///
		/// The specific value that represents the phase of the moon for a specific LIGHT.
        /// </summary>
        /// <value>
        /// Value of the column moon_phase_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("light-moon-phase-code")]
		[AttrColumnName("moon_phase_code")]
        [AttrSeqnr(5)]
        [DomId(100000194)]
        [DataLength(6)]
        [DataDecimals(0)]
        LightMoonPhaseEnum? MoonPhase { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(6)]
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
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(7)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
