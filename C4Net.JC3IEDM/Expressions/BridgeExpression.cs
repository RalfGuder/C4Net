using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Bridge.
    /// </summary>
    public class BridgeExpression : BaseEntityExpression<BridgeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column bridge_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column bridge_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property LongestSpanLengthDimension that represents the column longest_span_length_dim.
        /// </summary>
        /// <value>
        /// The value of the property LongestSpanLengthDimension that represents the column longest_span_length_dim.
        /// </value>
        public ColumnExpression LongestSpanLengthDimension 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property SpanCount that represents the column span_cnt.
        /// </summary>
        /// <value>
        /// The value of the property SpanCount that represents the column span_cnt.
        /// </value>
        public ColumnExpression SpanCount 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Usage that represents the column usage_code.
        /// </summary>
        /// <value>
        /// The value of the property Usage that represents the column usage_code.
        /// </value>
        public ColumnExpression Usage 
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
        /// Initializes a new instance of the <see cref="BridgeExpression"/> class.
        /// </summary>
        public BridgeExpression()
            : base("Bridge", typeof(IBridge))
        {
        }

        #endregion
    }
}
