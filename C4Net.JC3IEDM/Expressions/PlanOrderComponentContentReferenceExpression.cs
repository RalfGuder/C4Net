using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity PlanOrderComponentContentReference.
    /// </summary>
    public class PlanOrderComponentContentReferenceExpression : BaseEntityExpression<PlanOrderComponentContentReferenceExpression>
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
        /// Expression for the property PlanOrderComponentIndex that represents the column poc_ix.
        /// </summary>
        /// <value>
        /// The value of the property PlanOrderComponentIndex that represents the column poc_ix.
        /// </value>
        public ColumnExpression PlanOrderComponentIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property PlanOrderComponentContentIndex that represents the column poc_cntnt_ix.
        /// </summary>
        /// <value>
        /// The value of the property PlanOrderComponentContentIndex that represents the column poc_cntnt_ix.
        /// </value>
        public ColumnExpression PlanOrderComponentContentIndex 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column poc_cntnt_ref_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column poc_cntnt_ref_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property Datetime that represents the column dttm.
        /// </summary>
        /// <value>
        /// The value of the property Datetime that represents the column dttm.
        /// </value>
        public ColumnExpression Datetime 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property ReferenceId that represents the column ref_id.
        /// </summary>
        /// <value>
        /// The value of the property ReferenceId that represents the column ref_id.
        /// </value>
        public ColumnExpression ReferenceId 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[8]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanOrderComponentContentReferenceExpression"/> class.
        /// </summary>
        public PlanOrderComponentContentReferenceExpression()
            : base("PlanOrderComponentContentReference", typeof(IPlanOrderComponentContentReference))
        {
        }

        #endregion
    }
}
