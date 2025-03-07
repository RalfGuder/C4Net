using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ReportingDataAbsoluteTiming that represents the table RPTD_ABS_TIMING
	/// 
	/// A REPORTING-DATA that specifies effective datetime that is referenced to Universal Time.
    /// </summary>
	[EntId(10000154)]
    [EntName("REPORTING-DATA-ABSOLUTE-TIMING")]
    [EntTableName("RPTD_ABS_TIMING")]
    [EntDepth(3)]
    public interface IReportingDataAbsoluteTiming
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column rptd_abs_timing_rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_abs_timing_rptd_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("reporting-data-absolute-timing-reporting-data-id")]
		[AttrColumnName("rptd_abs_timing_rptd_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000912)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ReportingDataId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_start_dttm
		///
		/// The character string representing a point in time that designates the beginning of the period of effectiveness for the data referenced by a specific REPORTING-DATA-ABSOLUTE-TIMING.
        /// </summary>
        /// <value>
        /// Value of the column effctv_start_dttm
        /// </value>
        [AttrIx(100002)]
		[AttrName("reporting-data-absolute-timing-effective-start-datetime")]
		[AttrColumnName("effctv_start_dttm")]
        [AttrSeqnr(2)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string EffectiveStartDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_end_dttm
		///
		/// The character string representing a point in time that designates the ending of the period of effectiveness for the data referenced by a specific REPORTING-DATA-ABSOLUTE-TIMING.
        /// </summary>
        /// <value>
        /// Value of the column effctv_end_dttm
        /// </value>
        [AttrIx(100003)]
		[AttrName("reporting-data-absolute-timing-effective-end-datetime")]
		[AttrColumnName("effctv_end_dttm")]
        [AttrSeqnr(3)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string EffectiveEndDatetime { get; set; }
		
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
