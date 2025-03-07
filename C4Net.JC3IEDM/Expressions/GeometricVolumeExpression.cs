using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity GeometricVolume.
    /// </summary>
    public class GeometricVolumeExpression : BaseEntityExpression<GeometricVolumeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column geom_vol_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column geom_vol_id.
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
        /// Expression for the property LowerVerticalDistanceId that represents the column geom_vol_lower_ver_dist_id.
        /// </summary>
        /// <value>
        /// The value of the property LowerVerticalDistanceId that represents the column geom_vol_lower_ver_dist_id.
        /// </value>
        public ColumnExpression LowerVerticalDistanceId 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property UpperVerticalDistanceId that represents the column geom_vol_upper_ver_dist_id.
        /// </summary>
        /// <value>
        /// The value of the property UpperVerticalDistanceId that represents the column geom_vol_upper_ver_dist_id.
        /// </value>
        public ColumnExpression UpperVerticalDistanceId 
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
        /// Initializes a new instance of the <see cref="GeometricVolumeExpression"/> class.
        /// </summary>
        public GeometricVolumeExpression()
            : base("GeometricVolume", typeof(IGeometricVolume))
        {
        }

        #endregion
    }
}
