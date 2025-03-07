using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Atmosphere.
    /// </summary>
    public class AtmosphereExpression : BaseEntityExpression<AtmosphereExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column atmosphere_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column atmosphere_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property HumidityRatio that represents the column humidity_rat.
        /// </summary>
        /// <value>
        /// The value of the property HumidityRatio that represents the column humidity_rat.
        /// </value>
        public ColumnExpression HumidityRatio 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property InversionLayer that represents the column inversion_layer_code.
        /// </summary>
        /// <value>
        /// The value of the property InversionLayer that represents the column inversion_layer_code.
        /// </value>
        public ColumnExpression InversionLayer 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property PressureQuantity that represents the column prs_qty.
        /// </summary>
        /// <value>
        /// The value of the property PressureQuantity that represents the column prs_qty.
        /// </value>
        public ColumnExpression PressureQuantity 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property PressureSystemCategory that represents the column prs_sys_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property PressureSystemCategory that represents the column prs_sys_cat_code.
        /// </value>
        public ColumnExpression PressureSystemCategory 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property Temperature that represents the column tmpr.
        /// </summary>
        /// <value>
        /// The value of the property Temperature that represents the column tmpr.
        /// </value>
        public ColumnExpression Temperature 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property TemperatureGradient that represents the column tmpr_gradient_code.
        /// </summary>
        /// <value>
        /// The value of the property TemperatureGradient that represents the column tmpr_gradient_code.
        /// </value>
        public ColumnExpression TemperatureGradient 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[8]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="AtmosphereExpression"/> class.
        /// </summary>
        public AtmosphereExpression()
            : base("Atmosphere", typeof(IAtmosphere))
        {
        }

        #endregion
    }
}
