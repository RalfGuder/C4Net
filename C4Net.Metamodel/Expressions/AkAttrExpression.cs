using C4Net.Core.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Expressions
{
    /// <summary>
    /// Expression class for query the entity AkAttr.
    /// </summary>
    public class AkAttrExpression : BaseEntityExpression<AkAttrExpression>
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
        /// Expression for the column attr_ix.
        /// </summary>
        /// <value>
        /// The value of the column attr_ix.
        /// </value>
        public ColumnExpression AttrIx 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the column ak_ix.
        /// </summary>
        /// <value>
        /// The value of the column ak_ix.
        /// </value>
        public ColumnExpression AkIx 
        { 
            get { return this.columns[2]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="AkAttrExpression"/> class.
        /// </summary>
        public AkAttrExpression()
            : base("[%LogicalName%%]", typeof(IAkAttr))
        {
        }

        #endregion
    }
}
