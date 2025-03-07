using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity CorridorArea.
    /// </summary>
    public class CorridorAreaExpression : BaseEntityExpression<CorridorAreaExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column corridor_area_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column corridor_area_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property WidthDimension that represents the column width_dim.
        /// </summary>
        /// <value>
        /// The value of the property WidthDimension that represents the column width_dim.
        /// </value>
        public ColumnExpression WidthDimension 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property CentreLineId that represents the column corridor_area_centre_line_id.
        /// </summary>
        /// <value>
        /// The value of the property CentreLineId that represents the column corridor_area_centre_line_id.
        /// </value>
        public ColumnExpression CentreLineId 
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
        /// Initializes a new instance of the <see cref="CorridorAreaExpression"/> class.
        /// </summary>
        public CorridorAreaExpression()
            : base("CorridorArea", typeof(ICorridorArea))
        {
        }

        #endregion
    }
}
