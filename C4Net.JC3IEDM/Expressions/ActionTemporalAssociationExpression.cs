using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionTemporalAssociation.
    /// </summary>
    public class ActionTemporalAssociationExpression : BaseEntityExpression<ActionTemporalAssociationExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property SubjectActionId that represents the column subj_act_id.
        /// </summary>
        /// <value>
        /// The value of the property SubjectActionId that represents the column subj_act_id.
        /// </value>
        public ColumnExpression SubjectActionId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectActionId that represents the column obj_act_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectActionId that represents the column obj_act_id.
        /// </value>
        public ColumnExpression ObjectActionId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column act_tmprl_assoc_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column act_tmprl_assoc_ix.
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
        /// Expression for the property ReferenceDuration that represents the column ref_dur.
        /// </summary>
        /// <value>
        /// The value of the property ReferenceDuration that represents the column ref_dur.
        /// </value>
        public ColumnExpression ReferenceDuration 
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
        /// Initializes a new instance of the <see cref="ActionTemporalAssociationExpression"/> class.
        /// </summary>
        public ActionTemporalAssociationExpression()
            : base("ActionTemporalAssociation", typeof(IActionTemporalAssociation))
        {
        }

        #endregion
    }
}
