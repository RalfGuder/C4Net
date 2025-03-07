using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity SolidSurfaceStatus.
    /// </summary>
    public class SolidSurfaceStatusExpression : BaseEntityExpression<SolidSurfaceStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column sld_surf_stat_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column sld_surf_stat_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectItemStatusIndex that represents the column obj_item_stat_ix.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemStatusIndex that represents the column obj_item_stat_ix.
        /// </value>
        public ColumnExpression ObjectItemStatusIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property SolidSurfaceStatusCode that represents the column code.
        /// </summary>
        /// <value>
        /// The value of the property SolidSurfaceStatusCode that represents the column code.
        /// </value>
        public ColumnExpression SolidSurfaceStatusCode 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property DemolitionStatus that represents the column dmltn_stat_code.
        /// </summary>
        /// <value>
        /// The value of the property DemolitionStatus that represents the column dmltn_stat_code.
        /// </value>
        public ColumnExpression DemolitionStatus 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property SurfaceCondition that represents the column surf_cond_code.
        /// </summary>
        /// <value>
        /// The value of the property SurfaceCondition that represents the column surf_cond_code.
        /// </value>
        public ColumnExpression SurfaceCondition 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property SurfaceFirmness that represents the column surf_firm_code.
        /// </summary>
        /// <value>
        /// The value of the property SurfaceFirmness that represents the column surf_firm_code.
        /// </value>
        public ColumnExpression SurfaceFirmness 
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
        /// Initializes a new instance of the <see cref="SolidSurfaceStatusExpression"/> class.
        /// </summary>
        public SolidSurfaceStatusExpression()
            : base("SolidSurfaceStatus", typeof(ISolidSurfaceStatus))
        {
        }

        #endregion
    }
}
