using C4Net.Core.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Expressions
{
    /// <summary>
    /// Expression class for query the entity SubtRel.
    /// </summary>
    public class SubtRelExpression : BaseEntityExpression<SubtRelExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the column sup_ent_id.
        /// </summary>
        /// <value>
        /// The value of the column sup_ent_id.
        /// </value>
        public ColumnExpression SupEntId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the column sub_ent_id.
        /// </summary>
        /// <value>
        /// The value of the column sub_ent_id.
        /// </value>
        public ColumnExpression SubEntId 
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
        /// Expression for the column cat_ix.
        /// </summary>
        /// <value>
        /// The value of the column cat_ix.
        /// </value>
        public ColumnExpression CatIx 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the column dom_id.
        /// </summary>
        /// <value>
        /// The value of the column dom_id.
        /// </value>
        public ColumnExpression DomId 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the column dom_val_ix.
        /// </summary>
        /// <value>
        /// The value of the column dom_val_ix.
        /// </value>
        public ColumnExpression DomValIx 
        { 
            get { return this.columns[5]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="SubtRelExpression"/> class.
        /// </summary>
        public SubtRelExpression()
            : base("[%LogicalName%%]", typeof(ISubtRel))
        {
        }

        #endregion
    }
}
