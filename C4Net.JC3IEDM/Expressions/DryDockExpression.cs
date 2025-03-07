using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity DryDock.
    /// </summary>
    public class DryDockExpression : BaseEntityExpression<DryDockExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column dry_dock_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column dry_dock_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property BoatLiftCapacityQuantity that represents the column boat_lift_cap_qty.
        /// </summary>
        /// <value>
        /// The value of the property BoatLiftCapacityQuantity that represents the column boat_lift_cap_qty.
        /// </value>
        public ColumnExpression BoatLiftCapacityQuantity 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property DepthDimension that represents the column depth_dim.
        /// </summary>
        /// <value>
        /// The value of the property DepthDimension that represents the column depth_dim.
        /// </value>
        public ColumnExpression DepthDimension 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property LocationText that represents the column loc_txt.
        /// </summary>
        /// <value>
        /// The value of the property LocationText that represents the column loc_txt.
        /// </value>
        public ColumnExpression LocationText 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property MarineRailwaySize that represents the column marine_railway_size_code.
        /// </summary>
        /// <value>
        /// The value of the property MarineRailwaySize that represents the column marine_railway_size_code.
        /// </value>
        public ColumnExpression MarineRailwaySize 
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
        /// Initializes a new instance of the <see cref="DryDockExpression"/> class.
        /// </summary>
        public DryDockExpression()
            : base("DryDock", typeof(IDryDock))
        {
        }

        #endregion
    }
}
