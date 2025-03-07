using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity MaterielType.
    /// </summary>
    public class MaterielTypeExpression : BaseEntityExpression<MaterielTypeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column mat_type_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column mat_type_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property ReportableItemText that represents the column rptbl_item_txt.
        /// </summary>
        /// <value>
        /// The value of the property ReportableItemText that represents the column rptbl_item_txt.
        /// </value>
        public ColumnExpression ReportableItemText 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property StockNumberText that represents the column stock_no_txt.
        /// </summary>
        /// <value>
        /// The value of the property StockNumberText that represents the column stock_no_txt.
        /// </value>
        public ColumnExpression StockNumberText 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property SupplyClass that represents the column supply_class_code.
        /// </summary>
        /// <value>
        /// The value of the property SupplyClass that represents the column supply_class_code.
        /// </value>
        public ColumnExpression SupplyClass 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property IssuingHeightDimension that represents the column issuing_height_dim.
        /// </summary>
        /// <value>
        /// The value of the property IssuingHeightDimension that represents the column issuing_height_dim.
        /// </value>
        public ColumnExpression IssuingHeightDimension 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property IssuingLengthDimension that represents the column issuing_length_dim.
        /// </summary>
        /// <value>
        /// The value of the property IssuingLengthDimension that represents the column issuing_length_dim.
        /// </value>
        public ColumnExpression IssuingLengthDimension 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property IssuingWidthDimension that represents the column issuing_width_dim.
        /// </summary>
        /// <value>
        /// The value of the property IssuingWidthDimension that represents the column issuing_width_dim.
        /// </value>
        public ColumnExpression IssuingWidthDimension 
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
        /// Initializes a new instance of the <see cref="MaterielTypeExpression"/> class.
        /// </summary>
        public MaterielTypeExpression()
            : base("MaterielType", typeof(IMaterielType))
        {
        }

        #endregion
    }
}
