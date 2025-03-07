using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity AirRouteSegment.
    /// </summary>
    public class AirRouteSegmentExpression : BaseEntityExpression<AirRouteSegmentExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column air_route_sgmnt_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column air_route_sgmnt_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property RequiredNavigationPerformance that represents the column req_nvgtn_perf_code.
        /// </summary>
        /// <value>
        /// The value of the property RequiredNavigationPerformance that represents the column req_nvgtn_perf_code.
        /// </value>
        public ColumnExpression RequiredNavigationPerformance 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property CivilMilitary that represents the column civil_mil_code.
        /// </summary>
        /// <value>
        /// The value of the property CivilMilitary that represents the column civil_mil_code.
        /// </value>
        public ColumnExpression CivilMilitary 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property InternationalRoute that represents the column intl_route_code.
        /// </summary>
        /// <value>
        /// The value of the property InternationalRoute that represents the column intl_route_code.
        /// </value>
        public ColumnExpression InternationalRoute 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property MaintainedSpeedRate that represents the column mntnd_speed_rate.
        /// </summary>
        /// <value>
        /// The value of the property MaintainedSpeedRate that represents the column mntnd_speed_rate.
        /// </value>
        public ColumnExpression MaintainedSpeedRate 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property DescriptionText that represents the column descr_txt.
        /// </summary>
        /// <value>
        /// The value of the property DescriptionText that represents the column descr_txt.
        /// </value>
        public ColumnExpression DescriptionText 
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
        /// Initializes a new instance of the <see cref="AirRouteSegmentExpression"/> class.
        /// </summary>
        public AirRouteSegmentExpression()
            : base("AirRouteSegment", typeof(IAirRouteSegment))
        {
        }

        #endregion
    }
}
