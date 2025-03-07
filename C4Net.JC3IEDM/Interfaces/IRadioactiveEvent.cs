using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity RadioactiveEvent that represents the table RADACT_EVENT
	/// 
	/// A CBRN-EVENT involving radioactive materiel(s).
    /// </summary>
	[EntId(10000316)]
    [EntName("RADIOACTIVE-EVENT")]
    [EntTableName("RADACT_EVENT")]
    [EntDepth(3)]
    public interface IRadioactiveEvent
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column radact_event_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column radact_event_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("radioactive-event-id")]
		[AttrColumnName("radact_event_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of RADIOACTIVE-EVENT. It serves as a discriminator that partitions RADIOACTIVE-EVENT into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("radioactive-event-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004271)]
        [DataLength(6)]
        [DataDecimals(0)]
        RadioactiveEventCategoryEnum RadioactiveEventCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dose_qty
		///
		/// The numeric value that represents the total radiation dose accumulated over the duration of the RADIOACTIVE-EVENT. The unit of measure is centiGray (cGy).
        /// </summary>
        /// <value>
        /// Value of the column dose_qty
        /// </value>
        [AttrIx(100003)]
		[AttrName("radioactive-event-dose-quantity")]
		[AttrColumnName("dose_qty")]
        [AttrSeqnr(3)]
        [DomId(100001200)]
        [DataLength(14)]
        [DataDecimals(6)]
        double? DoseQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dose_rate
		///
		/// The numeric value that denotes the radiation dose rate. The unit of measure is centiGray per Hour (cGy/h). The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column dose_rate
        /// </value>
        [AttrIx(100004)]
		[AttrName("radioactive-event-dose-rate")]
		[AttrColumnName("dose_rate")]
        [AttrSeqnr(4)]
        [DomId(100001300)]
        [DataLength(16)]
        [DataDecimals(7)]
        double? DoseRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dose_rate_trend_code
		///
		/// The specific value that represents the rate of change of the ionising radiation emitted by a radioactive materiel.
        /// </summary>
        /// <value>
        /// Value of the column dose_rate_trend_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("radioactive-event-dose-rate-trend-code")]
		[AttrColumnName("dose_rate_trend_code")]
        [AttrSeqnr(5)]
        [DomId(100000360)]
        [DataLength(6)]
        [DataDecimals(0)]
        RadioactiveEventDoseRateTrendEnum? DoseRateTrend { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vol_cncntr_qty
		///
		/// The numeric value that represents the level of radioactive contamination per unit volume in air or water. The unit of measure is Becquerels per cubic metre (BQM3).
        /// </summary>
        /// <value>
        /// Value of the column vol_cncntr_qty
        /// </value>
        [AttrIx(100006)]
		[AttrName("radioactive-event-volume-concentration-quantity")]
		[AttrColumnName("vol_cncntr_qty")]
        [AttrSeqnr(6)]
        [DomId(100001200)]
        [DataLength(14)]
        [DataDecimals(6)]
        double? VolumeConcentrationQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column surf_dep_qty
		///
		/// The numeric value that represents the level of radioactive contamination per unit area on a surface. The unit of measure is Becquerels per square metre (BQM2).
        /// </summary>
        /// <value>
        /// Value of the column surf_dep_qty
        /// </value>
        [AttrIx(100007)]
		[AttrName("radioactive-event-surface-deposition-quantity")]
		[AttrColumnName("surf_dep_qty")]
        [AttrSeqnr(7)]
        [DomId(100001200)]
        [DataLength(14)]
        [DataDecimals(6)]
        double? SurfaceDepositionQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rel_decay_rate_code
		///
		/// The specific value that represents the rate of decay of fallout relative to the assumed normal value of 1.2 in the Kaufmann equation.
        /// </summary>
        /// <value>
        /// Value of the column rel_decay_rate_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("radioactive-event-relative-decay-rate-code")]
		[AttrColumnName("rel_decay_rate_code")]
        [AttrSeqnr(8)]
        [DomId(100004380)]
        [DataLength(6)]
        [DataDecimals(0)]
        RadioactiveEventRelativeDecayRateEnum? RelativeDecayRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(9)]
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
        [AttrIx(100010)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(10)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
