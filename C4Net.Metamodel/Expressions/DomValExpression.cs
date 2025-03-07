using C4Net.Core.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Expressions
{
    /// <summary>
    /// Expression class for query the entity DomVal.
    /// </summary>
    public class DomValExpression : BaseEntityExpression<DomValExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the column dom_id.
        /// </summary>
        /// <value>
        /// The value of the column dom_id.
        /// </value>
        public ColumnExpression DomId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the column dom_val_ix.
        /// </summary>
        /// <value>
        /// The value of the column dom_val_ix.
        /// </value>
        public ColumnExpression DomValIx 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the column descr_txt.
        /// </summary>
        /// <value>
        /// The value of the column descr_txt.
        /// </value>
        public ColumnExpression DescrTxt 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the column name_txt.
        /// </summary>
        /// <value>
        /// The value of the column name_txt.
        /// </value>
        public ColumnExpression NameTxt 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the column def_txt.
        /// </summary>
        /// <value>
        /// The value of the column def_txt.
        /// </value>
        public ColumnExpression DefTxt 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the column type_code.
        /// </summary>
        /// <value>
        /// The value of the column type_code.
        /// </value>
        public ColumnExpression TypeCode 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the column stdn_lvl_code.
        /// </summary>
        /// <value>
        /// The value of the column stdn_lvl_code.
        /// </value>
        public ColumnExpression StdnLvlCode 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the column src_txt.
        /// </summary>
        /// <value>
        /// The value of the column src_txt.
        /// </value>
        public ColumnExpression SrcTxt 
        { 
            get { return this.columns[7]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="DomValExpression"/> class.
        /// </summary>
        public DomValExpression()
            : base("[%LogicalName%%]", typeof(IDomVal))
        {
        }

        #endregion
    }
}
