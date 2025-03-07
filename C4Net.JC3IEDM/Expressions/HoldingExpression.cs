using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Holding.
    /// </summary>
    public class HoldingExpression : BaseEntityExpression<HoldingExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property ObjectItemId that represents the column obj_item_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemId that represents the column obj_item_id.
        /// </value>
        public ColumnExpression ObjectItemId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectTypeId that represents the column obj_type_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectTypeId that represents the column obj_type_id.
        /// </value>
        public ColumnExpression ObjectTypeId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column holding_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column holding_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property OperationalCount that represents the column operat_cnt.
        /// </summary>
        /// <value>
        /// The value of the property OperationalCount that represents the column operat_cnt.
        /// </value>
        public ColumnExpression OperationalCount 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property TotalQuantity that represents the column total_qty.
        /// </summary>
        /// <value>
        /// The value of the property TotalQuantity that represents the column total_qty.
        /// </value>
        public ColumnExpression TotalQuantity 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property OnHandQuantity that represents the column on_hand_qty.
        /// </summary>
        /// <value>
        /// The value of the property OnHandQuantity that represents the column on_hand_qty.
        /// </value>
        public ColumnExpression OnHandQuantity 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property RequiredTotalQuantity that represents the column req_total_qty.
        /// </summary>
        /// <value>
        /// The value of the property RequiredTotalQuantity that represents the column req_total_qty.
        /// </value>
        public ColumnExpression RequiredTotalQuantity 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property RequiredOnHandQuantity that represents the column req_on_hand_qty.
        /// </summary>
        /// <value>
        /// The value of the property RequiredOnHandQuantity that represents the column req_on_hand_qty.
        /// </value>
        public ColumnExpression RequiredOnHandQuantity 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property RequiredCalculationMethod that represents the column req_mthd_calc_code.
        /// </summary>
        /// <value>
        /// The value of the property RequiredCalculationMethod that represents the column req_mthd_calc_code.
        /// </value>
        public ColumnExpression RequiredCalculationMethod 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property ReportingDataId that represents the column rptd_id.
        /// </summary>
        /// <value>
        /// The value of the property ReportingDataId that represents the column rptd_id.
        /// </value>
        public ColumnExpression ReportingDataId 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[11]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="HoldingExpression"/> class.
        /// </summary>
        public HoldingExpression()
            : base("Holding", typeof(IHolding))
        {
        }

        #endregion
    }
}
