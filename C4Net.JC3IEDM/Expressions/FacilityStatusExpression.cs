using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity FacilityStatus.
    /// </summary>
    public class FacilityStatusExpression : BaseEntityExpression<FacilityStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column fac_stat_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column fac_stat_id.
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
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property DemolitionStatus that represents the column dmltn_stat_code.
        /// </summary>
        /// <value>
        /// The value of the property DemolitionStatus that represents the column dmltn_stat_code.
        /// </value>
        public ColumnExpression DemolitionStatus 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property EnemyActivityCondition that represents the column enemy_actv_cond_code.
        /// </summary>
        /// <value>
        /// The value of the property EnemyActivityCondition that represents the column enemy_actv_cond_code.
        /// </value>
        public ColumnExpression EnemyActivityCondition 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property MinePresence that represents the column mine_prsnc_code.
        /// </summary>
        /// <value>
        /// The value of the property MinePresence that represents the column mine_prsnc_code.
        /// </value>
        public ColumnExpression MinePresence 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property OccupationProgramIndicator that represents the column ocptn_prog_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property OccupationProgramIndicator that represents the column ocptn_prog_ind_code.
        /// </value>
        public ColumnExpression OccupationProgramIndicator 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property OperationalStatus that represents the column operat_stat_code.
        /// </summary>
        /// <value>
        /// The value of the property OperationalStatus that represents the column operat_stat_code.
        /// </value>
        public ColumnExpression OperationalStatus 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property OperationalStatusQualifier that represents the column operat_stat_qual_code.
        /// </summary>
        /// <value>
        /// The value of the property OperationalStatusQualifier that represents the column operat_stat_qual_code.
        /// </value>
        public ColumnExpression OperationalStatusQualifier 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property ReserveIndicator that represents the column reserve_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property ReserveIndicator that represents the column reserve_ind_code.
        /// </value>
        public ColumnExpression ReserveIndicator 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property SecurityStatus that represents the column security_stat_code.
        /// </summary>
        /// <value>
        /// The value of the property SecurityStatus that represents the column security_stat_code.
        /// </value>
        public ColumnExpression SecurityStatus 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property UsageStatus that represents the column usage_stat_code.
        /// </summary>
        /// <value>
        /// The value of the property UsageStatus that represents the column usage_stat_code.
        /// </value>
        public ColumnExpression UsageStatus 
        { 
            get { return this.columns[11]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[12]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[13]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="FacilityStatusExpression"/> class.
        /// </summary>
        public FacilityStatusExpression()
            : base("FacilityStatus", typeof(IFacilityStatus))
        {
        }

        #endregion
    }
}
