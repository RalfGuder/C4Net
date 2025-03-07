using C4Net.Core.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Expressions
{
    /// <summary>
    /// Expression class for query the entity Rel.
    /// </summary>
    public class RelExpression : BaseEntityExpression<RelExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the column pa_ent_id.
        /// </summary>
        /// <value>
        /// The value of the column pa_ent_id.
        /// </value>
        public ColumnExpression PaEntId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the column ch_ent_id.
        /// </summary>
        /// <value>
        /// The value of the column ch_ent_id.
        /// </value>
        public ColumnExpression ChEntId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the column rel_ix.
        /// </summary>
        /// <value>
        /// The value of the column rel_ix.
        /// </value>
        public ColumnExpression RelIx 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the column type_code.
        /// </summary>
        /// <value>
        /// The value of the column type_code.
        /// </value>
        public ColumnExpression TypeCode 
        { 
            get { return this.columns[3]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="RelExpression"/> class.
        /// </summary>
        public RelExpression()
            : base("[%LogicalName%%]", typeof(IRel))
        {
        }

        #endregion
    }
}
