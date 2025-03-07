using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity REPORTING-DATA-ABSOLUTE-TIMING that represents the table RPTD_ABS_TIMING.
	///
	/// A REPORTING-DATA that specifies effective datetime that is referenced to Universal Time.
    /// </summary>
    [Serializable]
    [DefinitionName("ReportingDataAbsoluteTiming", "C4Net.JC3IEDM.Definitions.ReportingDataAbsoluteTiming.definition.xml")]
    public class ReportingDataAbsoluteTiming : ReportingData, IReportingDataAbsoluteTiming
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ReportingDataAbsoluteTimingExpression _ = new ReportingDataAbsoluteTimingExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column rptd_abs_timing_rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_abs_timing_rptd_id
        /// </value>
		public decimal ReportingDataId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_start_dttm
		///
		/// The character string representing a point in time that designates the beginning of the period of effectiveness for the data referenced by a specific REPORTING-DATA-ABSOLUTE-TIMING.
        /// </summary>
        /// <value>
        /// Value of the column effctv_start_dttm
        /// </value>
		public string EffectiveStartDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_end_dttm
		///
		/// The character string representing a point in time that designates the ending of the period of effectiveness for the data referenced by a specific REPORTING-DATA-ABSOLUTE-TIMING.
        /// </summary>
        /// <value>
        /// Value of the column effctv_end_dttm
        /// </value>
		public string EffectiveEndDatetime { get; set; }
		
        #endregion
    }
}
