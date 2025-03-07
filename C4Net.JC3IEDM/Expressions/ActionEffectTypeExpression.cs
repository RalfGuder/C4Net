using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionEffectType.
    /// </summary>
    public class ActionEffectTypeExpression : BaseEntityExpression<ActionEffectTypeExpression>
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
        /// Expression for the property ActionEffectIndex that represents the column act_effect_ix.
        /// </summary>
        /// <value>
        /// The value of the property ActionEffectIndex that represents the column act_effect_ix.
        /// </value>
        public ColumnExpression ActionEffectIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Count that represents the column cnt.
        /// </summary>
        /// <value>
        /// The value of the property Count that represents the column cnt.
        /// </value>
        public ColumnExpression Count 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectTypeId that represents the column obj_type_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectTypeId that represents the column obj_type_id.
        /// </value>
        public ColumnExpression ObjectTypeId 
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
        /// Initializes a new instance of the <see cref="ActionEffectTypeExpression"/> class.
        /// </summary>
        public ActionEffectTypeExpression()
            : base("ActionEffectType", typeof(IActionEffectType))
        {
        }

        #endregion
    }
}
