using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity MinefieldLand.
    /// </summary>
    public class MinefieldLandExpression : BaseEntityExpression<MinefieldLandExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column mnfld_land_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column mnfld_land_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property DepthPlacement that represents the column depth_plcmnt_code.
        /// </summary>
        /// <value>
        /// The value of the property DepthPlacement that represents the column depth_plcmnt_code.
        /// </value>
        public ColumnExpression DepthPlacement 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Function that represents the column func_code.
        /// </summary>
        /// <value>
        /// The value of the property Function that represents the column func_code.
        /// </value>
        public ColumnExpression Function 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Pattern that represents the column pattern_code.
        /// </summary>
        /// <value>
        /// The value of the property Pattern that represents the column pattern_code.
        /// </value>
        public ColumnExpression Pattern 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Persistence that represents the column persistence_code.
        /// </summary>
        /// <value>
        /// The value of the property Persistence that represents the column persistence_code.
        /// </value>
        public ColumnExpression Persistence 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property StoppingPower that represents the column stopping_power_code.
        /// </summary>
        /// <value>
        /// The value of the property StoppingPower that represents the column stopping_power_code.
        /// </value>
        public ColumnExpression StoppingPower 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[7]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="MinefieldLandExpression"/> class.
        /// </summary>
        public MinefieldLandExpression()
            : base("MinefieldLand", typeof(IMinefieldLand))
        {
        }

        #endregion
    }
}
