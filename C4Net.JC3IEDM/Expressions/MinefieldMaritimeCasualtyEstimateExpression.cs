using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity MinefieldMaritimeCasualtyEstimate.
    /// </summary>
    public class MinefieldMaritimeCasualtyEstimateExpression : BaseEntityExpression<MinefieldMaritimeCasualtyEstimateExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property MinefieldMaritimeId that represents the column mnfld_mrt_id.
        /// </summary>
        /// <value>
        /// The value of the property MinefieldMaritimeId that represents the column mnfld_mrt_id.
        /// </value>
        public ColumnExpression MinefieldMaritimeId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column mnfld_mrt_cas_est_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column mnfld_mrt_cas_est_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property AverageCount that represents the column avg_cnt.
        /// </summary>
        /// <value>
        /// The value of the property AverageCount that represents the column avg_cnt.
        /// </value>
        public ColumnExpression AverageCount 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property GivenTransitCount that represents the column given_transit_cnt.
        /// </summary>
        /// <value>
        /// The value of the property GivenTransitCount that represents the column given_transit_cnt.
        /// </value>
        public ColumnExpression GivenTransitCount 
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
        /// Initializes a new instance of the <see cref="MinefieldMaritimeCasualtyEstimateExpression"/> class.
        /// </summary>
        public MinefieldMaritimeCasualtyEstimateExpression()
            : base("MinefieldMaritimeCasualtyEstimate", typeof(IMinefieldMaritimeCasualtyEstimate))
        {
        }

        #endregion
    }
}
