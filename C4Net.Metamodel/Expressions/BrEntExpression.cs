using C4Net.Core.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Expressions
{
    /// <summary>
    /// Expression class for query the entity BrEnt.
    /// </summary>
    public class BrEntExpression : BaseEntityExpression<BrEntExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the column br_id.
        /// </summary>
        /// <value>
        /// The value of the column br_id.
        /// </value>
        public ColumnExpression BrId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the column br_ent_ix.
        /// </summary>
        /// <value>
        /// The value of the column br_ent_ix.
        /// </value>
        public ColumnExpression BrEntIx 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the column ent_of_interest_id.
        /// </summary>
        /// <value>
        /// The value of the column ent_of_interest_id.
        /// </value>
        public ColumnExpression EntOfInterestId 
        { 
            get { return this.columns[2]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="BrEntExpression"/> class.
        /// </summary>
        public BrEntExpression()
            : base("[%LogicalName%%]", typeof(IBrEnt))
        {
        }

        #endregion
    }
}
