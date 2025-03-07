using C4Net.Core.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Expressions
{
    /// <summary>
    /// Expression class for query the entity BrEntAttrComp.
    /// </summary>
    public class BrEntAttrCompExpression : BaseEntityExpression<BrEntAttrCompExpression>
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
        /// Expression for the column br_ent_attr_comp_ix.
        /// </summary>
        /// <value>
        /// The value of the column br_ent_attr_comp_ix.
        /// </value>
        public ColumnExpression BrEntAttrCompIx 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the column null_ind_code.
        /// </summary>
        /// <value>
        /// The value of the column null_ind_code.
        /// </value>
        public ColumnExpression NullIndCode 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the column ent_id.
        /// </summary>
        /// <value>
        /// The value of the column ent_id.
        /// </value>
        public ColumnExpression EntId 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the column attr_ix.
        /// </summary>
        /// <value>
        /// The value of the column attr_ix.
        /// </value>
        public ColumnExpression AttrIx 
        { 
            get { return this.columns[5]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="BrEntAttrCompExpression"/> class.
        /// </summary>
        public BrEntAttrCompExpression()
            : base("[%LogicalName%%]", typeof(IBrEntAttrComp))
        {
        }

        #endregion
    }
}
