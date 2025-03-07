using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity SurfaceVesselType.
    /// </summary>
    public class SurfaceVesselTypeExpression : BaseEntityExpression<SurfaceVesselTypeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column surf_vessel_type_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column surf_vessel_type_id.
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
        /// Expression for the property DisplacementQuantity that represents the column displ_qty.
        /// </summary>
        /// <value>
        /// The value of the property DisplacementQuantity that represents the column displ_qty.
        /// </value>
        public ColumnExpression DisplacementQuantity 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumDeckLoadQuantity that represents the column max_deck_load_qty.
        /// </summary>
        /// <value>
        /// The value of the property MaximumDeckLoadQuantity that represents the column max_deck_load_qty.
        /// </value>
        public ColumnExpression MaximumDeckLoadQuantity 
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
        /// Initializes a new instance of the <see cref="SurfaceVesselTypeExpression"/> class.
        /// </summary>
        public SurfaceVesselTypeExpression()
            : base("SurfaceVesselType", typeof(ISurfaceVesselType))
        {
        }

        #endregion
    }
}
