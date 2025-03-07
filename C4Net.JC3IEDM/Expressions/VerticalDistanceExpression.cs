using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity VerticalDistance.
    /// </summary>
    public class VerticalDistanceExpression : BaseEntityExpression<VerticalDistanceExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column ver_dist_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column ver_dist_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Reference that represents the column ref_code.
        /// </summary>
        /// <value>
        /// The value of the property Reference that represents the column ref_code.
        /// </value>
        public ColumnExpression Reference 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Dimension that represents the column dim.
        /// </summary>
        /// <value>
        /// The value of the property Dimension that represents the column dim.
        /// </value>
        public ColumnExpression Dimension 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Precision that represents the column precision_code.
        /// </summary>
        /// <value>
        /// The value of the property Precision that represents the column precision_code.
        /// </value>
        public ColumnExpression Precision 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property DatumText that represents the column datum_txt.
        /// </summary>
        /// <value>
        /// The value of the property DatumText that represents the column datum_txt.
        /// </value>
        public ColumnExpression DatumText 
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
        /// Initializes a new instance of the <see cref="VerticalDistanceExpression"/> class.
        /// </summary>
        public VerticalDistanceExpression()
            : base("VerticalDistance", typeof(IVerticalDistance))
        {
        }

        #endregion
    }
}
