using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ReportingDataRelativeTiming that represents the table RPTD_REL_TIMING
	/// 
	/// A REPORTING-DATA that specifies effective timing that is referenced to a specific ACTION-TASK.
    /// </summary>
	[EntId(10000155)]
    [EntName("REPORTING-DATA-RELATIVE-TIMING")]
    [EntTableName("RPTD_REL_TIMING")]
    [EntDepth(5)]
    public interface IReportingDataRelativeTiming
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column rptd_rel_timing_rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_rel_timing_rptd_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("reporting-data-relative-timing-reporting-data-id")]
		[AttrColumnName("rptd_rel_timing_rptd_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000912)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ReportingDataId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column offset_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds from a given reference for a specific REPORTING-DATA-RELATIVE-TIMING.
        /// </summary>
        /// <value>
        /// Value of the column offset_dur
        /// </value>
        [AttrIx(100002)]
		[AttrName("reporting-data-relative-timing-offset-duration")]
		[AttrColumnName("offset_dur")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000700)]
        [DataLength(19)]
        [DataDecimals(0)]
        decimal OffsetDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ref_act_task_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column ref_act_task_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("reporting-data-relative-timing-reference-action-task-id")]
		[AttrColumnName("ref_act_task_id")]
        [AttrSeqnr(3)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ReferenceActionTaskId { get; set; }
		
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
