using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Capability that represents the table CAPAB
	/// 
	/// The potential ability to do work, perform a function or mission, achieve an objective, or provide a service.
    /// </summary>
	[EntId(10000022)]
    [EntName("CAPABILITY")]
    [EntTableName("CAPAB")]
    [EntDepth(0)]
    public interface ICapability
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column capab_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CAPABILITY and to distinguish it from all other CAPABILITYs.
        /// </summary>
        /// <value>
        /// Value of the column capab_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("capability-id")]
		[AttrColumnName("capab_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100000902)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the general class of a CAPABILITY. It serves as a discriminator that partitions CAPABILITY into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("capability-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000180)]
        [DataLength(6)]
        [DataDecimals(0)]
        CapabilityCategoryEnum CapabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column day_night_code
		///
		/// The specific value that defines the light conditions that apply to a particular CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column day_night_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("capability-day-night-code")]
		[AttrColumnName("day_night_code")]
        [AttrSeqnr(3)]
        [DomId(100000181)]
        [DataLength(6)]
        [DataDecimals(0)]
        CapabilityDayNightEnum? DayNight { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column uom_code
		///
		/// The specific value that represents the quantities in terms of which the magnitude of a specific CAPABILITY descriptor is stated.
        /// </summary>
        /// <value>
        /// Value of the column uom_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("capability-unit-of-measure-code")]
		[AttrColumnName("uom_code")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000173)]
        [DataLength(6)]
        [DataDecimals(0)]
        CapabilityUnitOfMeasureEnum UnitOfMeasure { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(5)]
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
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
