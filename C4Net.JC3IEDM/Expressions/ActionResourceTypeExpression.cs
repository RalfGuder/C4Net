using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionResourceType.
    /// </summary>
    public class ActionResourceTypeExpression : BaseEntityExpression<ActionResourceTypeExpression>
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
        /// Expression for the property ActionResourceIndex that represents the column act_res_ix.
        /// </summary>
        /// <value>
        /// The value of the property ActionResourceIndex that represents the column act_res_ix.
        /// </value>
        public ColumnExpression ActionResourceIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Quantity that represents the column qty.
        /// </summary>
        /// <value>
        /// The value of the property Quantity that represents the column qty.
        /// </value>
        public ColumnExpression Quantity 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property ApportionmentRatio that represents the column aprtnmt_rat.
        /// </summary>
        /// <value>
        /// The value of the property ApportionmentRatio that represents the column aprtnmt_rat.
        /// </value>
        public ColumnExpression ApportionmentRatio 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectTypeId that represents the column obj_type_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectTypeId that represents the column obj_type_id.
        /// </value>
        public ColumnExpression ObjectTypeId 
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
        /// Initializes a new instance of the <see cref="ActionResourceTypeExpression"/> class.
        /// </summary>
        public ActionResourceTypeExpression()
            : base("ActionResourceType", typeof(IActionResourceType))
        {
        }

        #endregion
    }
}
