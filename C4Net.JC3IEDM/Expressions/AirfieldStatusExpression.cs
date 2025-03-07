using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity AirfieldStatus.
    /// </summary>
    public class AirfieldStatusExpression : BaseEntityExpression<AirfieldStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column airfield_stat_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column airfield_stat_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectItemStatusIndex that represents the column obj_item_stat_ix.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemStatusIndex that represents the column obj_item_stat_ix.
        /// </value>
        public ColumnExpression ObjectItemStatusIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property DayOperations that represents the column day_opers_code.
        /// </summary>
        /// <value>
        /// The value of the property DayOperations that represents the column day_opers_code.
        /// </value>
        public ColumnExpression DayOperations 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property FlightSupportCategory that represents the column flight_supp_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property FlightSupportCategory that represents the column flight_supp_cat_code.
        /// </value>
        public ColumnExpression FlightSupportCategory 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property EvaluationIndicator that represents the column eval_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property EvaluationIndicator that represents the column eval_ind_code.
        /// </value>
        public ColumnExpression EvaluationIndicator 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumNbacThroughputCount that represents the column max_nbac_thpt_cnt.
        /// </summary>
        /// <value>
        /// The value of the property MaximumNbacThroughputCount that represents the column max_nbac_thpt_cnt.
        /// </value>
        public ColumnExpression MaximumNbacThroughputCount 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumNbacParkCount that represents the column max_nbac_park_cnt.
        /// </summary>
        /// <value>
        /// The value of the property MaximumNbacParkCount that represents the column max_nbac_park_cnt.
        /// </value>
        public ColumnExpression MaximumNbacParkCount 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumWbacThroughputCount that represents the column max_wbac_thpt_cnt.
        /// </summary>
        /// <value>
        /// The value of the property MaximumWbacThroughputCount that represents the column max_wbac_thpt_cnt.
        /// </value>
        public ColumnExpression MaximumWbacThroughputCount 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumWbacParkCount that represents the column max_wbac_park_cnt.
        /// </summary>
        /// <value>
        /// The value of the property MaximumWbacParkCount that represents the column max_wbac_park_cnt.
        /// </value>
        public ColumnExpression MaximumWbacParkCount 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[10]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="AirfieldStatusExpression"/> class.
        /// </summary>
        public AirfieldStatusExpression()
            : base("AirfieldStatus", typeof(IAirfieldStatus))
        {
        }

        #endregion
    }
}
