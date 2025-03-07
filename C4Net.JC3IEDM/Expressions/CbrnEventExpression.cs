using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity CbrnEvent.
    /// </summary>
    public class CbrnEventExpression : BaseEntityExpression<CbrnEventExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column cbrn_event_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column cbrn_event_id.
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
        /// Expression for the property AlarmResultIndicator that represents the column alarm_result_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property AlarmResultIndicator that represents the column alarm_result_ind_code.
        /// </value>
        public ColumnExpression AlarmResultIndicator 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property ConfirmationTestIndicator that represents the column conf_test_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property ConfirmationTestIndicator that represents the column conf_test_ind_code.
        /// </value>
        public ColumnExpression ConfirmationTestIndicator 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property MaterielContainerType that represents the column mat_cntr_type_code.
        /// </summary>
        /// <value>
        /// The value of the property MaterielContainerType that represents the column mat_cntr_type_code.
        /// </value>
        public ColumnExpression MaterielContainerType 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property MaterielContainerTotalCount that represents the column mat_cntr_total_cnt.
        /// </summary>
        /// <value>
        /// The value of the property MaterielContainerTotalCount that represents the column mat_cntr_total_cnt.
        /// </value>
        public ColumnExpression MaterielContainerTotalCount 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[8]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="CbrnEventExpression"/> class.
        /// </summary>
        public CbrnEventExpression()
            : base("CbrnEvent", typeof(ICbrnEvent))
        {
        }

        #endregion
    }
}
