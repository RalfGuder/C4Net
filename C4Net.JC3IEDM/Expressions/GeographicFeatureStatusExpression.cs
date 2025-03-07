using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity GeographicFeatureStatus.
    /// </summary>
    public class GeographicFeatureStatusExpression : BaseEntityExpression<GeographicFeatureStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column gfeat_stat_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column gfeat_stat_id.
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
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property MinePresence that represents the column mine_prsnc_code.
        /// </summary>
        /// <value>
        /// The value of the property MinePresence that represents the column mine_prsnc_code.
        /// </value>
        public ColumnExpression MinePresence 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property SurfaceRecirculationIndicator that represents the column surf_recirc_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property SurfaceRecirculationIndicator that represents the column surf_recirc_ind_code.
        /// </value>
        public ColumnExpression SurfaceRecirculationIndicator 
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
        /// Initializes a new instance of the <see cref="GeographicFeatureStatusExpression"/> class.
        /// </summary>
        public GeographicFeatureStatusExpression()
            : base("GeographicFeatureStatus", typeof(IGeographicFeatureStatus))
        {
        }

        #endregion
    }
}
