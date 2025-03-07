using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Road.
    /// </summary>
    public class RoadExpression : BaseEntityExpression<RoadExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column road_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column road_id.
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
        /// Expression for the property ShoulderWidth that represents the column shoulder_width_code.
        /// </summary>
        /// <value>
        /// The value of the property ShoulderWidth that represents the column shoulder_width_code.
        /// </value>
        public ColumnExpression ShoulderWidth 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property TrafficDensityCount that represents the column traffic_density_cnt.
        /// </summary>
        /// <value>
        /// The value of the property TrafficDensityCount that represents the column traffic_density_cnt.
        /// </value>
        public ColumnExpression TrafficDensityCount 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property WeatherConditionCategory that represents the column weather_cond_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property WeatherConditionCategory that represents the column weather_cond_cat_code.
        /// </value>
        public ColumnExpression WeatherConditionCategory 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property Quality that represents the column quality_code.
        /// </summary>
        /// <value>
        /// The value of the property Quality that represents the column quality_code.
        /// </value>
        public ColumnExpression Quality 
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
        /// Initializes a new instance of the <see cref="RoadExpression"/> class.
        /// </summary>
        public RoadExpression()
            : base("Road", typeof(IRoad))
        {
        }

        #endregion
    }
}
