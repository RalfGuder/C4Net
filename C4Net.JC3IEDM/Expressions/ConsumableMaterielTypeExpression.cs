using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ConsumableMaterielType.
    /// </summary>
    public class ConsumableMaterielTypeExpression : BaseEntityExpression<ConsumableMaterielTypeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column cons_mat_type_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column cons_mat_type_id.
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
        /// Expression for the property Subcategory that represents the column subcat_code.
        /// </summary>
        /// <value>
        /// The value of the property Subcategory that represents the column subcat_code.
        /// </value>
        public ColumnExpression Subcategory 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Hazard that represents the column hazard_code.
        /// </summary>
        /// <value>
        /// The value of the property Hazard that represents the column hazard_code.
        /// </value>
        public ColumnExpression Hazard 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property IssuingElement that represents the column issuing_elmt_code.
        /// </summary>
        /// <value>
        /// The value of the property IssuingElement that represents the column issuing_elmt_code.
        /// </value>
        public ColumnExpression IssuingElement 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property IssuingCount that represents the column issuing_cnt.
        /// </summary>
        /// <value>
        /// The value of the property IssuingCount that represents the column issuing_cnt.
        /// </value>
        public ColumnExpression IssuingCount 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property IssuingUnitOfMeasure that represents the column issuing_uom_code.
        /// </summary>
        /// <value>
        /// The value of the property IssuingUnitOfMeasure that represents the column issuing_uom_code.
        /// </value>
        public ColumnExpression IssuingUnitOfMeasure 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property IssuingWeightQuantity that represents the column issuing_wt_qty.
        /// </summary>
        /// <value>
        /// The value of the property IssuingWeightQuantity that represents the column issuing_wt_qty.
        /// </value>
        public ColumnExpression IssuingWeightQuantity 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property PerishabilityIndicator that represents the column perishability_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property PerishabilityIndicator that represents the column perishability_ind_code.
        /// </value>
        public ColumnExpression PerishabilityIndicator 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property UnitedNationsNumber that represents the column united_nations_no_code.
        /// </summary>
        /// <value>
        /// The value of the property UnitedNationsNumber that represents the column united_nations_no_code.
        /// </value>
        public ColumnExpression UnitedNationsNumber 
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
        /// Initializes a new instance of the <see cref="ConsumableMaterielTypeExpression"/> class.
        /// </summary>
        public ConsumableMaterielTypeExpression()
            : base("ConsumableMaterielType", typeof(IConsumableMaterielType))
        {
        }

        #endregion
    }
}
