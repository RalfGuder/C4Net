using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Target.
    /// </summary>
    public class TargetExpression : BaseEntityExpression<TargetExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property ActionId that represents the column act_id.
        /// </summary>
        /// <value>
        /// The value of the property ActionId that represents the column act_id.
        /// </value>
        public ColumnExpression ActionId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ActionObjectiveIndex that represents the column act_objve_ix.
        /// </summary>
        /// <value>
        /// The value of the property ActionObjectiveIndex that represents the column act_objve_ix.
        /// </value>
        public ColumnExpression ActionObjectiveIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property EngagementAuthority that represents the column engage_authy_code.
        /// </summary>
        /// <value>
        /// The value of the property EngagementAuthority that represents the column engage_authy_code.
        /// </value>
        public ColumnExpression EngagementAuthority 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property IdentifierText that represents the column id_txt.
        /// </summary>
        /// <value>
        /// The value of the property IdentifierText that represents the column id_txt.
        /// </value>
        public ColumnExpression IdentifierText 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property PersistenceDuration that represents the column persistence_dur.
        /// </summary>
        /// <value>
        /// The value of the property PersistenceDuration that represents the column persistence_dur.
        /// </value>
        public ColumnExpression PersistenceDuration 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property DescriptionText that represents the column descr_txt.
        /// </summary>
        /// <value>
        /// The value of the property DescriptionText that represents the column descr_txt.
        /// </value>
        public ColumnExpression DescriptionText 
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
        /// Initializes a new instance of the <see cref="TargetExpression"/> class.
        /// </summary>
        public TargetExpression()
            : base("Target", typeof(ITarget))
        {
        }

        #endregion
    }
}
