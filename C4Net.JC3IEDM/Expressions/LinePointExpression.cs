using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity LinePoint.
    /// </summary>
    public class LinePointExpression : BaseEntityExpression<LinePointExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property LineId that represents the column line_id.
        /// </summary>
        /// <value>
        /// The value of the property LineId that represents the column line_id.
        /// </value>
        public ColumnExpression LineId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column line_point_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column line_point_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property SequenceOrdinal that represents the column seq_ord.
        /// </summary>
        /// <value>
        /// The value of the property SequenceOrdinal that represents the column seq_ord.
        /// </value>
        public ColumnExpression SequenceOrdinal 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property PointId that represents the column point_id.
        /// </summary>
        /// <value>
        /// The value of the property PointId that represents the column point_id.
        /// </value>
        public ColumnExpression PointId 
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
        /// Initializes a new instance of the <see cref="LinePointExpression"/> class.
        /// </summary>
        public LinePointExpression()
            : base("LinePoint", typeof(ILinePoint))
        {
        }

        #endregion
    }
}
