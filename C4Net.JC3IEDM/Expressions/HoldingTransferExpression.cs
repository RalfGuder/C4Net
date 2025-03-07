using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity HoldingTransfer.
    /// </summary>
    public class HoldingTransferExpression : BaseEntityExpression<HoldingTransferExpression>
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
        /// Expression for the property HoldingIndex that represents the column holding_ix.
        /// </summary>
        /// <value>
        /// The value of the property HoldingIndex that represents the column holding_ix.
        /// </value>
        public ColumnExpression HoldingIndex 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column holding_trnsf_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column holding_trnsf_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Reason that represents the column reason_code.
        /// </summary>
        /// <value>
        /// The value of the property Reason that represents the column reason_code.
        /// </value>
        public ColumnExpression Reason 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property Quantity that represents the column qty.
        /// </summary>
        /// <value>
        /// The value of the property Quantity that represents the column qty.
        /// </value>
        public ColumnExpression Quantity 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property CorrespondingObjectItemId that represents the column holding_trnsf_crsp_obj_item_id.
        /// </summary>
        /// <value>
        /// The value of the property CorrespondingObjectItemId that represents the column holding_trnsf_crsp_obj_item_id.
        /// </value>
        public ColumnExpression CorrespondingObjectItemId 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property ReportingDataId that represents the column rptd_id.
        /// </summary>
        /// <value>
        /// The value of the property ReportingDataId that represents the column rptd_id.
        /// </value>
        public ColumnExpression ReportingDataId 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[9]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="HoldingTransferExpression"/> class.
        /// </summary>
        public HoldingTransferExpression()
            : base("HoldingTransfer", typeof(IHoldingTransfer))
        {
        }

        #endregion
    }
}
