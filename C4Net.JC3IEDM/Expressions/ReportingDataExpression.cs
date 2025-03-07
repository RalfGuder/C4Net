using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ReportingData.
    /// </summary>
    public class ReportingDataExpression : BaseEntityExpression<ReportingDataExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column rptd_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column rptd_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Accuracy that represents the column acc_code.
        /// </summary>
        /// <value>
        /// The value of the property Accuracy that represents the column acc_code.
        /// </value>
        public ColumnExpression Accuracy 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property CountingIndicator that represents the column cntg_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property CountingIndicator that represents the column cntg_ind_code.
        /// </value>
        public ColumnExpression CountingIndicator 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Credibility that represents the column credibility_code.
        /// </summary>
        /// <value>
        /// The value of the property Credibility that represents the column credibility_code.
        /// </value>
        public ColumnExpression Credibility 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property Reliability that represents the column reliability_code.
        /// </summary>
        /// <value>
        /// The value of the property Reliability that represents the column reliability_code.
        /// </value>
        public ColumnExpression Reliability 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property ReportingDatetime that represents the column rep_dttm.
        /// </summary>
        /// <value>
        /// The value of the property ReportingDatetime that represents the column rep_dttm.
        /// </value>
        public ColumnExpression ReportingDatetime 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property SourceType that represents the column source_type_code.
        /// </summary>
        /// <value>
        /// The value of the property SourceType that represents the column source_type_code.
        /// </value>
        public ColumnExpression SourceType 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property TimingCategory that represents the column timing_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property TimingCategory that represents the column timing_cat_code.
        /// </value>
        public ColumnExpression TimingCategory 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property RealDataExerciseUseOnly that represents the column real_data_exer_use_only_code.
        /// </summary>
        /// <value>
        /// The value of the property RealDataExerciseUseOnly that represents the column real_data_exer_use_only_code.
        /// </value>
        public ColumnExpression RealDataExerciseUseOnly 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property ReferenceId that represents the column ref_id.
        /// </summary>
        /// <value>
        /// The value of the property ReferenceId that represents the column ref_id.
        /// </value>
        public ColumnExpression ReferenceId 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property ReportingOrganisationId that represents the column rep_org_id.
        /// </summary>
        /// <value>
        /// The value of the property ReportingOrganisationId that represents the column rep_org_id.
        /// </value>
        public ColumnExpression ReportingOrganisationId 
        { 
            get { return this.columns[11]; } 
        }
		
        /// <summary>
        /// Expression for the property EntCatCode that represents the column ent_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property EntCatCode that represents the column ent_cat_code.
        /// </value>
        public ColumnExpression EntCatCode 
        { 
            get { return this.columns[12]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[13]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[14]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingDataExpression"/> class.
        /// </summary>
        public ReportingDataExpression()
            : base("ReportingData", typeof(IReportingData))
        {
        }

        #endregion
    }
}
