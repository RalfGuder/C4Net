using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ReportingDataAbsoluteTiming.
    /// </summary>
    public class ReportingDataAbsoluteTimingExpression : BaseEntityExpression<ReportingDataAbsoluteTimingExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property ReportingDataId that represents the column rptd_abs_timing_rptd_id.
        /// </summary>
        /// <value>
        /// The value of the property ReportingDataId that represents the column rptd_abs_timing_rptd_id.
        /// </value>
        public ColumnExpression ReportingDataId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property EffectiveStartDatetime that represents the column effctv_start_dttm.
        /// </summary>
        /// <value>
        /// The value of the property EffectiveStartDatetime that represents the column effctv_start_dttm.
        /// </value>
        public ColumnExpression EffectiveStartDatetime 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property EffectiveEndDatetime that represents the column effctv_end_dttm.
        /// </summary>
        /// <value>
        /// The value of the property EffectiveEndDatetime that represents the column effctv_end_dttm.
        /// </value>
        public ColumnExpression EffectiveEndDatetime 
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
        /// Initializes a new instance of the <see cref="ReportingDataAbsoluteTimingExpression"/> class.
        /// </summary>
        public ReportingDataAbsoluteTimingExpression()
            : base("ReportingDataAbsoluteTiming", typeof(IReportingDataAbsoluteTiming))
        {
        }

        #endregion
    }
}
