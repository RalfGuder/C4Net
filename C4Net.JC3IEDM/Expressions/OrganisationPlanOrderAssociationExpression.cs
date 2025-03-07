using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity OrganisationPlanOrderAssociation.
    /// </summary>
    public class OrganisationPlanOrderAssociationExpression : BaseEntityExpression<OrganisationPlanOrderAssociationExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property OrganisationId that represents the column org_id.
        /// </summary>
        /// <value>
        /// The value of the property OrganisationId that represents the column org_id.
        /// </value>
        public ColumnExpression OrganisationId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property PlanOrderId that represents the column pln_ordr_id.
        /// </summary>
        /// <value>
        /// The value of the property PlanOrderId that represents the column pln_ordr_id.
        /// </value>
        public ColumnExpression PlanOrderId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column org_poa_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column org_poa_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[5]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganisationPlanOrderAssociationExpression"/> class.
        /// </summary>
        public OrganisationPlanOrderAssociationExpression()
            : base("OrganisationPlanOrderAssociation", typeof(IOrganisationPlanOrderAssociation))
        {
        }

        #endregion
    }
}
