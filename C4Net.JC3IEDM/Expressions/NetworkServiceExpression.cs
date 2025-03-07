using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity NetworkService.
    /// </summary>
    public class NetworkServiceExpression : BaseEntityExpression<NetworkServiceExpression>
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
        /// Expression for the property Index that represents the column netwrk_service_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column netwrk_service_ix.
        /// </value>
        public ColumnExpression Index 
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
        /// Expression for the property Subcategory that represents the column subcat_code.
        /// </summary>
        /// <value>
        /// The value of the property Subcategory that represents the column subcat_code.
        /// </value>
        public ColumnExpression Subcategory 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property CryptographicIndicator that represents the column crypto_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property CryptographicIndicator that represents the column crypto_ind_code.
        /// </value>
        public ColumnExpression CryptographicIndicator 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property CryptographicPlanShortTitleText that represents the column crypto_plan_short_title_txt.
        /// </summary>
        /// <value>
        /// The value of the property CryptographicPlanShortTitleText that represents the column crypto_plan_short_title_txt.
        /// </value>
        public ColumnExpression CryptographicPlanShortTitleText 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property CryptographicCodeShortTitleText that represents the column crypto_code_short_title_txt.
        /// </summary>
        /// <value>
        /// The value of the property CryptographicCodeShortTitleText that represents the column crypto_code_short_title_txt.
        /// </value>
        public ColumnExpression CryptographicCodeShortTitleText 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property IffModeCodeText that represents the column iff_mode_code_txt.
        /// </summary>
        /// <value>
        /// The value of the property IffModeCodeText that represents the column iff_mode_code_txt.
        /// </value>
        public ColumnExpression IffModeCodeText 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property SecurityClassificationId that represents the column security_clsfc_id.
        /// </summary>
        /// <value>
        /// The value of the property SecurityClassificationId that represents the column security_clsfc_id.
        /// </value>
        public ColumnExpression SecurityClassificationId 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[10]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkServiceExpression"/> class.
        /// </summary>
        public NetworkServiceExpression()
            : base("NetworkService", typeof(INetworkService))
        {
        }

        #endregion
    }
}
