using C4Net.Core.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Expressions
{
    /// <summary>
    /// Expression class for query the entity PkAttr.
    /// </summary>
    public class PkAttrExpression : BaseEntityExpression<PkAttrExpression>
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
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="PkAttrExpression"/> class.
        /// </summary>
        public PkAttrExpression()
            : base("[%LogicalName%%]", typeof(IPkAttr))
        {
        }

        #endregion
    }
}
