using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ControlFeatureStatus.
    /// </summary>
    public class ControlFeatureStatusExpression : BaseEntityExpression<ControlFeatureStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column cfeat_stat_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column cfeat_stat_id.
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
        /// Expression for the property InvestigationStatus that represents the column invstg_stat_code.
        /// </summary>
        /// <value>
        /// The value of the property InvestigationStatus that represents the column invstg_stat_code.
        /// </value>
        public ColumnExpression InvestigationStatus 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property CbrnThreatLevel that represents the column cbrn_thrt_lvl_code.
        /// </summary>
        /// <value>
        /// The value of the property CbrnThreatLevel that represents the column cbrn_thrt_lvl_code.
        /// </value>
        public ColumnExpression CbrnThreatLevel 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property SecurityStatus that represents the column security_stat_code.
        /// </summary>
        /// <value>
        /// The value of the property SecurityStatus that represents the column security_stat_code.
        /// </value>
        public ColumnExpression SecurityStatus 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property UsageStatus that represents the column usage_stat_code.
        /// </summary>
        /// <value>
        /// The value of the property UsageStatus that represents the column usage_stat_code.
        /// </value>
        public ColumnExpression UsageStatus 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[7]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlFeatureStatusExpression"/> class.
        /// </summary>
        public ControlFeatureStatusExpression()
            : base("ControlFeatureStatus", typeof(IControlFeatureStatus))
        {
        }

        #endregion
    }
}
