using C4Net.Core.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Expressions
{
    /// <summary>
    /// Expression class for query the entity AltKey.
    /// </summary>
    public class AltKeyExpression : BaseEntityExpression<AltKeyExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the column ent_id.
        /// </summary>
        /// <value>
        /// The value of the column ent_id.
        /// </value>
        public ColumnExpression EntId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the column ak_ix.
        /// </summary>
        /// <value>
        /// The value of the column ak_ix.
        /// </value>
        public ColumnExpression AkIx 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the column ak_no_qty.
        /// </summary>
        /// <value>
        /// The value of the column ak_no_qty.
        /// </value>
        public ColumnExpression AkNoQty 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the column uniq_ind_code.
        /// </summary>
        /// <value>
        /// The value of the column uniq_ind_code.
        /// </value>
        public ColumnExpression UniqIndCode 
        { 
            get { return this.columns[3]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="AltKeyExpression"/> class.
        /// </summary>
        public AltKeyExpression()
            : base("[%LogicalName%%]", typeof(IAltKey))
        {
        }

        #endregion
    }
}
