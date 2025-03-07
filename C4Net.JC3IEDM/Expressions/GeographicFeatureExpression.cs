using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity GeographicFeature.
    /// </summary>
    public class GeographicFeatureExpression : BaseEntityExpression<GeographicFeatureExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column geo_feat_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column geo_feat_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property BottomHardness that represents the column btm_hardness_code.
        /// </summary>
        /// <value>
        /// The value of the property BottomHardness that represents the column btm_hardness_code.
        /// </value>
        public ColumnExpression BottomHardness 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property BottomPenetrationQuantity that represents the column btm_penetration_qty.
        /// </summary>
        /// <value>
        /// The value of the property BottomPenetrationQuantity that represents the column btm_penetration_qty.
        /// </value>
        public ColumnExpression BottomPenetrationQuantity 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property SolidSurfaceComposition that represents the column sld_surf_cmps_code.
        /// </summary>
        /// <value>
        /// The value of the property SolidSurfaceComposition that represents the column sld_surf_cmps_code.
        /// </value>
        public ColumnExpression SolidSurfaceComposition 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property SurfaceCategory that represents the column surf_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property SurfaceCategory that represents the column surf_cat_code.
        /// </value>
        public ColumnExpression SurfaceCategory 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property Terrain that represents the column trn_code.
        /// </summary>
        /// <value>
        /// The value of the property Terrain that represents the column trn_code.
        /// </value>
        public ColumnExpression Terrain 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property VegetationCategory that represents the column veg_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property VegetationCategory that represents the column veg_cat_code.
        /// </value>
        public ColumnExpression VegetationCategory 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property VegetationSubcategory that represents the column veg_subcat_code.
        /// </summary>
        /// <value>
        /// The value of the property VegetationSubcategory that represents the column veg_subcat_code.
        /// </value>
        public ColumnExpression VegetationSubcategory 
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
        /// Initializes a new instance of the <see cref="GeographicFeatureExpression"/> class.
        /// </summary>
        public GeographicFeatureExpression()
            : base("GeographicFeature", typeof(IGeographicFeature))
        {
        }

        #endregion
    }
}
