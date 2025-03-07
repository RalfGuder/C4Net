using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity NetworkServiceStatus.
    /// </summary>
    public class NetworkServiceStatusExpression : BaseEntityExpression<NetworkServiceStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property NetworkId that represents the column netwrk_id.
        /// </summary>
        /// <value>
        /// The value of the property NetworkId that represents the column netwrk_id.
        /// </value>
        public ColumnExpression NetworkId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property NetworkServiceIndex that represents the column netwrk_service_ix.
        /// </summary>
        /// <value>
        /// The value of the property NetworkServiceIndex that represents the column netwrk_service_ix.
        /// </value>
        public ColumnExpression NetworkServiceIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column netwrk_service_stat_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column netwrk_service_stat_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Indicator that represents the column ind_code.
        /// </summary>
        /// <value>
        /// The value of the property Indicator that represents the column ind_code.
        /// </value>
        public ColumnExpression Indicator 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property ReportingDataId that represents the column rptd_id.
        /// </summary>
        /// <value>
        /// The value of the property ReportingDataId that represents the column rptd_id.
        /// </value>
        public ColumnExpression ReportingDataId 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[6]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkServiceStatusExpression"/> class.
        /// </summary>
        public NetworkServiceStatusExpression()
            : base("NetworkServiceStatus", typeof(INetworkServiceStatus))
        {
        }

        #endregion
    }
}
