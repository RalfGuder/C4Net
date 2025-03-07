using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity PlanOrderComponentStructure.
    /// </summary>
    public class PlanOrderComponentStructureExpression : BaseEntityExpression<PlanOrderComponentStructureExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property SubjectPlanOrderId that represents the column poc_struct_subj_pln_ordr_id.
        /// </summary>
        /// <value>
        /// The value of the property SubjectPlanOrderId that represents the column poc_struct_subj_pln_ordr_id.
        /// </value>
        public ColumnExpression SubjectPlanOrderId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property SubjectPlanOrderComponentIndex that represents the column poc_struct_subj_poc_ix.
        /// </summary>
        /// <value>
        /// The value of the property SubjectPlanOrderComponentIndex that represents the column poc_struct_subj_poc_ix.
        /// </value>
        public ColumnExpression SubjectPlanOrderComponentIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectPlanOrderId that represents the column poc_struct_obj_pln_ordr_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectPlanOrderId that represents the column poc_struct_obj_pln_ordr_id.
        /// </value>
        public ColumnExpression ObjectPlanOrderId 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectPlanOrderComponentIndex that represents the column poc_struct_obj_poc_ix.
        /// </summary>
        /// <value>
        /// The value of the property ObjectPlanOrderComponentIndex that represents the column poc_struct_obj_poc_ix.
        /// </value>
        public ColumnExpression ObjectPlanOrderComponentIndex 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column poc_struct_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column poc_struct_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property Datetime that represents the column dttm.
        /// </summary>
        /// <value>
        /// The value of the property Datetime that represents the column dttm.
        /// </value>
        public ColumnExpression Datetime 
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
        /// Initializes a new instance of the <see cref="PlanOrderComponentStructureExpression"/> class.
        /// </summary>
        public PlanOrderComponentStructureExpression()
            : base("PlanOrderComponentStructure", typeof(IPlanOrderComponentStructure))
        {
        }

        #endregion
    }
}
