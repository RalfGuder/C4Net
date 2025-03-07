using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity GeographicPoint.
    /// </summary>
    public class GeographicPointExpression : BaseEntityExpression<GeographicPointExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column geo_point_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column geo_point_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property LatitudeCoordinate that represents the column lat_coord.
        /// </summary>
        /// <value>
        /// The value of the property LatitudeCoordinate that represents the column lat_coord.
        /// </value>
        public ColumnExpression LatitudeCoordinate 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property LongitudeCoordinate that represents the column long_coord.
        /// </summary>
        /// <value>
        /// The value of the property LongitudeCoordinate that represents the column long_coord.
        /// </value>
        public ColumnExpression LongitudeCoordinate 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property LatitudePrecision that represents the column lat_precision_code.
        /// </summary>
        /// <value>
        /// The value of the property LatitudePrecision that represents the column lat_precision_code.
        /// </value>
        public ColumnExpression LatitudePrecision 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property LongitudePrecision that represents the column long_precision_code.
        /// </summary>
        /// <value>
        /// The value of the property LongitudePrecision that represents the column long_precision_code.
        /// </value>
        public ColumnExpression LongitudePrecision 
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
        /// Initializes a new instance of the <see cref="GeographicPointExpression"/> class.
        /// </summary>
        public GeographicPointExpression()
            : base("GeographicPoint", typeof(IGeographicPoint))
        {
        }

        #endregion
    }
}
