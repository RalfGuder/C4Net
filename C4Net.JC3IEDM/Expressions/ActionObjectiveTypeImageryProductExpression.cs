using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionObjectiveTypeImageryProduct.
    /// </summary>
    public class ActionObjectiveTypeImageryProductExpression : BaseEntityExpression<ActionObjectiveTypeImageryProductExpression>
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
        /// Expression for the property ActionObjectiveIndex that represents the column act_objve_ix.
        /// </summary>
        /// <value>
        /// The value of the property ActionObjectiveIndex that represents the column act_objve_ix.
        /// </value>
        public ColumnExpression ActionObjectiveIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property ImageScaleCount that represents the column img_scale_cnt.
        /// </summary>
        /// <value>
        /// The value of the property ImageScaleCount that represents the column img_scale_cnt.
        /// </value>
        public ColumnExpression ImageScaleCount 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property ImageType that represents the column img_type_code.
        /// </summary>
        /// <value>
        /// The value of the property ImageType that represents the column img_type_code.
        /// </value>
        public ColumnExpression ImageType 
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
        /// Initializes a new instance of the <see cref="ActionObjectiveTypeImageryProductExpression"/> class.
        /// </summary>
        public ActionObjectiveTypeImageryProductExpression()
            : base("ActionObjectiveTypeImageryProduct", typeof(IActionObjectiveTypeImageryProduct))
        {
        }

        #endregion
    }
}
