using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity PlanOrderDistributionAcknowledgement.
    /// </summary>
    public class PlanOrderDistributionAcknowledgementExpression : BaseEntityExpression<PlanOrderDistributionAcknowledgementExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property PlanOrderId that represents the column pln_ordr_id.
        /// </summary>
        /// <value>
        /// The value of the property PlanOrderId that represents the column pln_ordr_id.
        /// </value>
        public ColumnExpression PlanOrderId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property PlanOrderDistributionIndex that represents the column pln_ordr_distr_ix.
        /// </summary>
        /// <value>
        /// The value of the property PlanOrderDistributionIndex that represents the column pln_ordr_distr_ix.
        /// </value>
        public ColumnExpression PlanOrderDistributionIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column pln_ordr_distr_ack_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column pln_ordr_distr_ack_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property PlanOrderDistributionAcknowledgementCode that represents the column code.
        /// </summary>
        /// <value>
        /// The value of the property PlanOrderDistributionAcknowledgementCode that represents the column code.
        /// </value>
        public ColumnExpression PlanOrderDistributionAcknowledgementCode 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Datetime that represents the column dttm.
        /// </summary>
        /// <value>
        /// The value of the property Datetime that represents the column dttm.
        /// </value>
        public ColumnExpression Datetime 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[6]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanOrderDistributionAcknowledgementExpression"/> class.
        /// </summary>
        public PlanOrderDistributionAcknowledgementExpression()
            : base("PlanOrderDistributionAcknowledgement", typeof(IPlanOrderDistributionAcknowledgement))
        {
        }

        #endregion
    }
}
