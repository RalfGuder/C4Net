using C4Net.Core.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Expressions
{
    /// <summary>
    /// Expression class for query the entity CreatorUpdateIdentific.
    /// </summary>
    public class CreatorUpdateIdentificExpression : BaseEntityExpression<CreatorUpdateIdentificExpression>
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
        /// Expression for the column creator_attr_ix.
        /// </summary>
        /// <value>
        /// The value of the column creator_attr_ix.
        /// </value>
        public ColumnExpression CreatorAttrIx 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the column update_attr_ix.
        /// </summary>
        /// <value>
        /// The value of the column update_attr_ix.
        /// </value>
        public ColumnExpression UpdateAttrIx 
        { 
            get { return this.columns[2]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatorUpdateIdentificExpression"/> class.
        /// </summary>
        public CreatorUpdateIdentificExpression()
            : base("[%LogicalName%%]", typeof(ICreatorUpdateIdentific))
        {
        }

        #endregion
    }
}
