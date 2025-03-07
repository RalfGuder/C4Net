using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ContextReportingDataAssociation.
    /// </summary>
    public class ContextReportingDataAssociationExpression : BaseEntityExpression<ContextReportingDataAssociationExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property ContextId that represents the column contxt_id.
        /// </summary>
        /// <value>
        /// The value of the property ContextId that represents the column contxt_id.
        /// </value>
        public ColumnExpression ContextId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ReportingDataId that represents the column rptd_id.
        /// </summary>
        /// <value>
        /// The value of the property ReportingDataId that represents the column rptd_id.
        /// </value>
        public ColumnExpression ReportingDataId 
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
        /// Initializes a new instance of the <see cref="ContextReportingDataAssociationExpression"/> class.
        /// </summary>
        public ContextReportingDataAssociationExpression()
            : base("ContextReportingDataAssociation", typeof(IContextReportingDataAssociation))
        {
        }

        #endregion
    }
}
