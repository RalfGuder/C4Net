using C4Net.Core.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Expressions
{
    /// <summary>
    /// Expression class for query the entity BaseAttr.
    /// </summary>
    public class BaseAttrExpression : BaseEntityExpression<BaseAttrExpression>
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
        /// Expression for the column def_txt.
        /// </summary>
        /// <value>
        /// The value of the column def_txt.
        /// </value>
        public ColumnExpression DefTxt 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the column data_type_code.
        /// </summary>
        /// <value>
        /// The value of the column data_type_code.
        /// </value>
        public ColumnExpression DataTypeCode 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the column data_len_cnt.
        /// </summary>
        /// <value>
        /// The value of the column data_len_cnt.
        /// </value>
        public ColumnExpression DataLenCnt 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the column data_dec_cnt.
        /// </summary>
        /// <value>
        /// The value of the column data_dec_cnt.
        /// </value>
        public ColumnExpression DataDecCnt 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the column dom_id.
        /// </summary>
        /// <value>
        /// The value of the column dom_id.
        /// </value>
        public ColumnExpression DomId 
        { 
            get { return this.columns[6]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseAttrExpression"/> class.
        /// </summary>
        public BaseAttrExpression()
            : base("[%LogicalName%%]", typeof(IBaseAttr))
        {
        }

        #endregion
    }
}
