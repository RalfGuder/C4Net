using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity PointReference.
    /// </summary>
    public class PointReferenceExpression : BaseEntityExpression<PointReferenceExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property RelativeCoordinateSystemId that represents the column rel_coord_sys_id.
        /// </summary>
        /// <value>
        /// The value of the property RelativeCoordinateSystemId that represents the column rel_coord_sys_id.
        /// </value>
        public ColumnExpression RelativeCoordinateSystemId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property OriginPointId that represents the column point_ref_orgn_point_id.
        /// </summary>
        /// <value>
        /// The value of the property OriginPointId that represents the column point_ref_orgn_point_id.
        /// </value>
        public ColumnExpression OriginPointId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property XVectorPointId that represents the column point_ref_x_vector_point_id.
        /// </summary>
        /// <value>
        /// The value of the property XVectorPointId that represents the column point_ref_x_vector_point_id.
        /// </value>
        public ColumnExpression XVectorPointId 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property YVectorPointId that represents the column point_ref_y_vector_point_id.
        /// </summary>
        /// <value>
        /// The value of the property YVectorPointId that represents the column point_ref_y_vector_point_id.
        /// </value>
        public ColumnExpression YVectorPointId 
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
        /// Initializes a new instance of the <see cref="PointReferenceExpression"/> class.
        /// </summary>
        public PointReferenceExpression()
            : base("PointReference", typeof(IPointReference))
        {
        }

        #endregion
    }
}
