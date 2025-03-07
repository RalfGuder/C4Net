using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Wind.
    /// </summary>
    public class WindExpression : BaseEntityExpression<WindExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column wind_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column wind_id.
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
        /// Expression for the property AirStabilityCategory that represents the column air_stability_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property AirStabilityCategory that represents the column air_stability_cat_code.
        /// </value>
        public ColumnExpression AirStabilityCategory 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property AltitudeLayer that represents the column altitude_layer_code.
        /// </summary>
        /// <value>
        /// The value of the property AltitudeLayer that represents the column altitude_layer_code.
        /// </value>
        public ColumnExpression AltitudeLayer 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property DirectionAngle that represents the column dir_angle.
        /// </summary>
        /// <value>
        /// The value of the property DirectionAngle that represents the column dir_angle.
        /// </value>
        public ColumnExpression DirectionAngle 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property EffectiveDownwindDirectionAngle that represents the column effctv_downwind_dir_angle.
        /// </summary>
        /// <value>
        /// The value of the property EffectiveDownwindDirectionAngle that represents the column effctv_downwind_dir_angle.
        /// </value>
        public ColumnExpression EffectiveDownwindDirectionAngle 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property SpeedRate that represents the column speed_rate.
        /// </summary>
        /// <value>
        /// The value of the property SpeedRate that represents the column speed_rate.
        /// </value>
        public ColumnExpression SpeedRate 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property NuclearYieldQualifier that represents the column nuc_yield_qual_code.
        /// </summary>
        /// <value>
        /// The value of the property NuclearYieldQualifier that represents the column nuc_yield_qual_code.
        /// </value>
        public ColumnExpression NuclearYieldQualifier 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[9]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="WindExpression"/> class.
        /// </summary>
        public WindExpression()
            : base("Wind", typeof(IWind))
        {
        }

        #endregion
    }
}
