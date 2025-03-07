using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity FanArea.
    /// </summary>
    public class FanAreaExpression : BaseEntityExpression<FanAreaExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column fan_area_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column fan_area_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property MinimumRangeDimension that represents the column mnm_range_dim.
        /// </summary>
        /// <value>
        /// The value of the property MinimumRangeDimension that represents the column mnm_range_dim.
        /// </value>
        public ColumnExpression MinimumRangeDimension 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumRangeDimension that represents the column max_range_dim.
        /// </summary>
        /// <value>
        /// The value of the property MaximumRangeDimension that represents the column max_range_dim.
        /// </value>
        public ColumnExpression MaximumRangeDimension 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property OrientationAngle that represents the column orient_angle.
        /// </summary>
        /// <value>
        /// The value of the property OrientationAngle that represents the column orient_angle.
        /// </value>
        public ColumnExpression OrientationAngle 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property SectorSizeAngle that represents the column sctr_size_angle.
        /// </summary>
        /// <value>
        /// The value of the property SectorSizeAngle that represents the column sctr_size_angle.
        /// </value>
        public ColumnExpression SectorSizeAngle 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property VertexPointId that represents the column fan_area_vertex_point_id.
        /// </summary>
        /// <value>
        /// The value of the property VertexPointId that represents the column fan_area_vertex_point_id.
        /// </value>
        public ColumnExpression VertexPointId 
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
        /// Initializes a new instance of the <see cref="FanAreaExpression"/> class.
        /// </summary>
        public FanAreaExpression()
            : base("FanArea", typeof(IFanArea))
        {
        }

        #endregion
    }
}
