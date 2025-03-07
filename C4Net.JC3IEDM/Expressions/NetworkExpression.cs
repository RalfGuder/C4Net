using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Network.
    /// </summary>
    public class NetworkExpression : BaseEntityExpression<NetworkExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column netwrk_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column netwrk_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Subcategory that represents the column subcat_code.
        /// </summary>
        /// <value>
        /// The value of the property Subcategory that represents the column subcat_code.
        /// </value>
        public ColumnExpression Subcategory 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Architecture that represents the column arch_code.
        /// </summary>
        /// <value>
        /// The value of the property Architecture that represents the column arch_code.
        /// </value>
        public ColumnExpression Architecture 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property ChannelCount that represents the column chnl_cnt.
        /// </summary>
        /// <value>
        /// The value of the property ChannelCount that represents the column chnl_cnt.
        /// </value>
        public ColumnExpression ChannelCount 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumCapacityRate that represents the column max_cap_rate.
        /// </summary>
        /// <value>
        /// The value of the property MaximumCapacityRate that represents the column max_cap_rate.
        /// </value>
        public ColumnExpression MaximumCapacityRate 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property MinimumCapacityRate that represents the column mnm_cap_rate.
        /// </summary>
        /// <value>
        /// The value of the property MinimumCapacityRate that represents the column mnm_cap_rate.
        /// </value>
        public ColumnExpression MinimumCapacityRate 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property Means that represents the column means_code.
        /// </summary>
        /// <value>
        /// The value of the property Means that represents the column means_code.
        /// </value>
        public ColumnExpression Means 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property SetNumberCount that represents the column set_no_cnt.
        /// </summary>
        /// <value>
        /// The value of the property SetNumberCount that represents the column set_no_cnt.
        /// </value>
        public ColumnExpression SetNumberCount 
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
        /// Initializes a new instance of the <see cref="NetworkExpression"/> class.
        /// </summary>
        public NetworkExpression()
            : base("Network", typeof(INetwork))
        {
        }

        #endregion
    }
}
