using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionObjective.
    /// </summary>
    public class ActionObjectiveExpression : BaseEntityExpression<ActionObjectiveExpression>
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
        /// Expression for the property Index that represents the column act_objve_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column act_objve_ix.
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
        /// Expression for the property Qualifier that represents the column qual_code.
        /// </summary>
        /// <value>
        /// The value of the property Qualifier that represents the column qual_code.
        /// </value>
        public ColumnExpression Qualifier 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property AuthorisingOrganisationId that represents the column authorising_org_id.
        /// </summary>
        /// <value>
        /// The value of the property AuthorisingOrganisationId that represents the column authorising_org_id.
        /// </value>
        public ColumnExpression AuthorisingOrganisationId 
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
        /// Initializes a new instance of the <see cref="ActionObjectiveExpression"/> class.
        /// </summary>
        public ActionObjectiveExpression()
            : base("ActionObjective", typeof(IActionObjective))
        {
        }

        #endregion
    }
}
