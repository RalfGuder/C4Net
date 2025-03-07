using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity NetworkCapacity.
    /// </summary>
    public class NetworkCapacityExpression : BaseEntityExpression<NetworkCapacityExpression>
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
        /// Expression for the property Index that represents the column netwrk_cap_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column netwrk_cap_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Bandwidth that represents the column bandwidth_code.
        /// </summary>
        /// <value>
        /// The value of the property Bandwidth that represents the column bandwidth_code.
        /// </value>
        public ColumnExpression Bandwidth 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Protocol that represents the column protocol_code.
        /// </summary>
        /// <value>
        /// The value of the property Protocol that represents the column protocol_code.
        /// </value>
        public ColumnExpression Protocol 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[5]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkCapacityExpression"/> class.
        /// </summary>
        public NetworkCapacityExpression()
            : base("NetworkCapacity", typeof(INetworkCapacity))
        {
        }

        #endregion
    }
}
