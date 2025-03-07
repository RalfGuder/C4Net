using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity PolyarcArea.
    /// </summary>
    public class PolyarcAreaExpression : BaseEntityExpression<PolyarcAreaExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column plyrc_area_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column plyrc_area_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property BeginBearingAngle that represents the column begin_brng_angle.
        /// </summary>
        /// <value>
        /// The value of the property BeginBearingAngle that represents the column begin_brng_angle.
        /// </value>
        public ColumnExpression BeginBearingAngle 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property EndBearingAngle that represents the column end_brng_angle.
        /// </summary>
        /// <value>
        /// The value of the property EndBearingAngle that represents the column end_brng_angle.
        /// </value>
        public ColumnExpression EndBearingAngle 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property ArcRadiusDimension that represents the column arc_radius_dim.
        /// </summary>
        /// <value>
        /// The value of the property ArcRadiusDimension that represents the column arc_radius_dim.
        /// </value>
        public ColumnExpression ArcRadiusDimension 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property DefiningLineId that represents the column plyrc_area_dfng_line_id.
        /// </summary>
        /// <value>
        /// The value of the property DefiningLineId that represents the column plyrc_area_dfng_line_id.
        /// </value>
        public ColumnExpression DefiningLineId 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property BearingOriginPointId that represents the column plyrc_area_brng_orgn_point_id.
        /// </summary>
        /// <value>
        /// The value of the property BearingOriginPointId that represents the column plyrc_area_brng_orgn_point_id.
        /// </value>
        public ColumnExpression BearingOriginPointId 
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
        /// Initializes a new instance of the <see cref="PolyarcAreaExpression"/> class.
        /// </summary>
        public PolyarcAreaExpression()
            : base("PolyarcArea", typeof(IPolyarcArea))
        {
        }

        #endregion
    }
}
