using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ConeVolume.
    /// </summary>
    public class ConeVolumeExpression : BaseEntityExpression<ConeVolumeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column cone_vol_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column cone_vol_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property DefiningSurfaceId that represents the column cone_vol_dfng_surf_id.
        /// </summary>
        /// <value>
        /// The value of the property DefiningSurfaceId that represents the column cone_vol_dfng_surf_id.
        /// </value>
        public ColumnExpression DefiningSurfaceId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property VertexPointId that represents the column vertex_point_id.
        /// </summary>
        /// <value>
        /// The value of the property VertexPointId that represents the column vertex_point_id.
        /// </value>
        public ColumnExpression VertexPointId 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[4]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ConeVolumeExpression"/> class.
        /// </summary>
        public ConeVolumeExpression()
            : base("ConeVolume", typeof(IConeVolume))
        {
        }

        #endregion
    }
}
