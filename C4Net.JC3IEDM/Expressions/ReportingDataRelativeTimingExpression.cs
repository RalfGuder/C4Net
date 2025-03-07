using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ReportingDataRelativeTiming.
    /// </summary>
    public class ReportingDataRelativeTimingExpression : BaseEntityExpression<ReportingDataRelativeTimingExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property ReportingDataId that represents the column rptd_rel_timing_rptd_id.
        /// </summary>
        /// <value>
        /// The value of the property ReportingDataId that represents the column rptd_rel_timing_rptd_id.
        /// </value>
        public ColumnExpression ReportingDataId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property OffsetDuration that represents the column offset_dur.
        /// </summary>
        /// <value>
        /// The value of the property OffsetDuration that represents the column offset_dur.
        /// </value>
        public ColumnExpression OffsetDuration 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property ReferenceActionTaskId that represents the column ref_act_task_id.
        /// </summary>
        /// <value>
        /// The value of the property ReferenceActionTaskId that represents the column ref_act_task_id.
        /// </value>
        public ColumnExpression ReferenceActionTaskId 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[4]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingDataRelativeTimingExpression"/> class.
        /// </summary>
        public ReportingDataRelativeTimingExpression()
            : base("ReportingDataRelativeTiming", typeof(IReportingDataRelativeTiming))
        {
        }

        #endregion
    }
}
