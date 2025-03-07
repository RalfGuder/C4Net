using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity PlanOrderDistribution.
    /// </summary>
    public class PlanOrderDistributionExpression : BaseEntityExpression<PlanOrderDistributionExpression>
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
        /// Expression for the property Index that represents the column pln_ordr_distr_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column pln_ordr_distr_ix.
        /// </value>
        public ColumnExpression Index 
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
        /// Expression for the property ReleaseDatetime that represents the column release_dttm.
        /// </summary>
        /// <value>
        /// The value of the property ReleaseDatetime that represents the column release_dttm.
        /// </value>
        public ColumnExpression ReleaseDatetime 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property RecipientOrganisationId that represents the column recipient_org_id.
        /// </summary>
        /// <value>
        /// The value of the property RecipientOrganisationId that represents the column recipient_org_id.
        /// </value>
        public ColumnExpression RecipientOrganisationId 
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
        /// Initializes a new instance of the <see cref="PlanOrderDistributionExpression"/> class.
        /// </summary>
        public PlanOrderDistributionExpression()
            : base("PlanOrderDistribution", typeof(IPlanOrderDistribution))
        {
        }

        #endregion
    }
}
