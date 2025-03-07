using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity PlanOrderAssociation.
    /// </summary>
    public class PlanOrderAssociationExpression : BaseEntityExpression<PlanOrderAssociationExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property SubjectPlanOrderId that represents the column poa_subj_pln_ordr_id.
        /// </summary>
        /// <value>
        /// The value of the property SubjectPlanOrderId that represents the column poa_subj_pln_ordr_id.
        /// </value>
        public ColumnExpression SubjectPlanOrderId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectPlanOrderId that represents the column poa_obj_pln_ordr_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectPlanOrderId that represents the column poa_obj_pln_ordr_id.
        /// </value>
        public ColumnExpression ObjectPlanOrderId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column poa_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column poa_ix.
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
        /// Initializes a new instance of the <see cref="PlanOrderAssociationExpression"/> class.
        /// </summary>
        public PlanOrderAssociationExpression()
            : base("PlanOrderAssociation", typeof(IPlanOrderAssociation))
        {
        }

        #endregion
    }
}
