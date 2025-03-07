using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Runway.
    /// </summary>
    public class RunwayExpression : BaseEntityExpression<RunwayExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column runway_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column runway_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property LightingPresenceIndicator that represents the column lgtng_prsnc_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property LightingPresenceIndicator that represents the column lgtng_prsnc_ind_code.
        /// </value>
        public ColumnExpression LightingPresenceIndicator 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property WeightBearingCapacityQuantity that represents the column wt_brng_cap_qty.
        /// </summary>
        /// <value>
        /// The value of the property WeightBearingCapacityQuantity that represents the column wt_brng_cap_qty.
        /// </value>
        public ColumnExpression WeightBearingCapacityQuantity 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property PavementClassificationNumberCount that represents the column pvm_clsfc_no_cnt.
        /// </summary>
        /// <value>
        /// The value of the property PavementClassificationNumberCount that represents the column pvm_clsfc_no_cnt.
        /// </value>
        public ColumnExpression PavementClassificationNumberCount 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property PavementType that represents the column pvm_type_code.
        /// </summary>
        /// <value>
        /// The value of the property PavementType that represents the column pvm_type_code.
        /// </value>
        public ColumnExpression PavementType 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property PavementSubgradeCategory that represents the column pvm_subgrade_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property PavementSubgradeCategory that represents the column pvm_subgrade_cat_code.
        /// </value>
        public ColumnExpression PavementSubgradeCategory 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property PavementMaximumTyrePressure that represents the column pvm_max_tyre_prs_code.
        /// </summary>
        /// <value>
        /// The value of the property PavementMaximumTyrePressure that represents the column pvm_max_tyre_prs_code.
        /// </value>
        public ColumnExpression PavementMaximumTyrePressure 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property PavementEvaluationMethod that represents the column pvm_eval_method_code.
        /// </summary>
        /// <value>
        /// The value of the property PavementEvaluationMethod that represents the column pvm_eval_method_code.
        /// </value>
        public ColumnExpression PavementEvaluationMethod 
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
        /// Initializes a new instance of the <see cref="RunwayExpression"/> class.
        /// </summary>
        public RunwayExpression()
            : base("Runway", typeof(IRunway))
        {
        }

        #endregion
    }
}
