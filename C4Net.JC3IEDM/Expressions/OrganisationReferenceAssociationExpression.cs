using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity OrganisationReferenceAssociation.
    /// </summary>
    public class OrganisationReferenceAssociationExpression : BaseEntityExpression<OrganisationReferenceAssociationExpression>
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
        /// Expression for the property ReferenceId that represents the column ref_id.
        /// </summary>
        /// <value>
        /// The value of the property ReferenceId that represents the column ref_id.
        /// </value>
        public ColumnExpression ReferenceId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column org_ref_assoc_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column org_ref_assoc_ix.
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
        /// Expression for the property StartDatetime that represents the column start_dttm.
        /// </summary>
        /// <value>
        /// The value of the property StartDatetime that represents the column start_dttm.
        /// </value>
        public ColumnExpression StartDatetime 
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
        /// Initializes a new instance of the <see cref="OrganisationReferenceAssociationExpression"/> class.
        /// </summary>
        public OrganisationReferenceAssociationExpression()
            : base("OrganisationReferenceAssociation", typeof(IOrganisationReferenceAssociation))
        {
        }

        #endregion
    }
}
