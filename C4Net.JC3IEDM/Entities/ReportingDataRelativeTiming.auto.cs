using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity REPORTING-DATA-RELATIVE-TIMING that represents the table RPTD_REL_TIMING.
	///
	/// A REPORTING-DATA that specifies effective timing that is referenced to a specific ACTION-TASK.
    /// </summary>
    [Serializable]
    [DefinitionName("ReportingDataRelativeTiming", "C4Net.JC3IEDM.Definitions.ReportingDataRelativeTiming.definition.xml")]
    public class ReportingDataRelativeTiming : ReportingData, IReportingDataRelativeTiming
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ReportingDataRelativeTimingExpression _ = new ReportingDataRelativeTimingExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column rptd_rel_timing_rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_rel_timing_rptd_id
        /// </value>
		public decimal ReportingDataId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column offset_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds from a given reference for a specific REPORTING-DATA-RELATIVE-TIMING.
        /// </summary>
        /// <value>
        /// Value of the column offset_dur
        /// </value>
		public decimal OffsetDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ref_act_task_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column ref_act_task_id
        /// </value>
		public decimal ReferenceActionTaskId { get; set; }
		
        #endregion
    }
}
