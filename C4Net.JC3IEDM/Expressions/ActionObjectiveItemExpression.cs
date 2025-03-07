using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionObjectiveItem.
    /// </summary>
    public class ActionObjectiveItemExpression : BaseEntityExpression<ActionObjectiveItemExpression>
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
        /// Expression for the property Primacy that represents the column primacy_code.
        /// </summary>
        /// <value>
        /// The value of the property Primacy that represents the column primacy_code.
        /// </value>
        public ColumnExpression Primacy 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property CandidateTargetListId that represents the column ctgtlst_id.
        /// </summary>
        /// <value>
        /// The value of the property CandidateTargetListId that represents the column ctgtlst_id.
        /// </value>
        public ColumnExpression CandidateTargetListId 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property CandidateTargetDetailItemIndex that represents the column ctgtdet_item_ix.
        /// </summary>
        /// <value>
        /// The value of the property CandidateTargetDetailItemIndex that represents the column ctgtdet_item_ix.
        /// </value>
        public ColumnExpression CandidateTargetDetailItemIndex 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectItemId that represents the column obj_item_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemId that represents the column obj_item_id.
        /// </value>
        public ColumnExpression ObjectItemId 
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
        /// Initializes a new instance of the <see cref="ActionObjectiveItemExpression"/> class.
        /// </summary>
        public ActionObjectiveItemExpression()
            : base("ActionObjectiveItem", typeof(IActionObjectiveItem))
        {
        }

        #endregion
    }
}
