using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionRequiredCapability.
    /// </summary>
    public class ActionRequiredCapabilityExpression : BaseEntityExpression<ActionRequiredCapabilityExpression>
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
        /// Expression for the property CapabilityId that represents the column capab_id.
        /// </summary>
        /// <value>
        /// The value of the property CapabilityId that represents the column capab_id.
        /// </value>
        public ColumnExpression CapabilityId 
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
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[4]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionRequiredCapabilityExpression"/> class.
        /// </summary>
        public ActionRequiredCapabilityExpression()
            : base("ActionRequiredCapability", typeof(IActionRequiredCapability))
        {
        }

        #endregion
    }
}
