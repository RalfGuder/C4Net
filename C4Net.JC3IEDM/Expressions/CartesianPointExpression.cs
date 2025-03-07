using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity CartesianPoint.
    /// </summary>
    public class CartesianPointExpression : BaseEntityExpression<CartesianPointExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column crts_point_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column crts_point_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property XCoordinateDimension that represents the column x_coord_dim.
        /// </summary>
        /// <value>
        /// The value of the property XCoordinateDimension that represents the column x_coord_dim.
        /// </value>
        public ColumnExpression XCoordinateDimension 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property YCoordinateDimension that represents the column y_coord_dim.
        /// </summary>
        /// <value>
        /// The value of the property YCoordinateDimension that represents the column y_coord_dim.
        /// </value>
        public ColumnExpression YCoordinateDimension 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property ZCoordinateDimension that represents the column z_coord_dim.
        /// </summary>
        /// <value>
        /// The value of the property ZCoordinateDimension that represents the column z_coord_dim.
        /// </value>
        public ColumnExpression ZCoordinateDimension 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property XPrecision that represents the column x_precision_code.
        /// </summary>
        /// <value>
        /// The value of the property XPrecision that represents the column x_precision_code.
        /// </value>
        public ColumnExpression XPrecision 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property YPrecision that represents the column y_precision_code.
        /// </summary>
        /// <value>
        /// The value of the property YPrecision that represents the column y_precision_code.
        /// </value>
        public ColumnExpression YPrecision 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property ZPrecision that represents the column z_precision_code.
        /// </summary>
        /// <value>
        /// The value of the property ZPrecision that represents the column z_precision_code.
        /// </value>
        public ColumnExpression ZPrecision 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[8]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="CartesianPointExpression"/> class.
        /// </summary>
        public CartesianPointExpression()
            : base("CartesianPoint", typeof(ICartesianPoint))
        {
        }

        #endregion
    }
}
