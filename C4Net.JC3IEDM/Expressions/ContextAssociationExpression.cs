using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ContextAssociation.
    /// </summary>
    public class ContextAssociationExpression : BaseEntityExpression<ContextAssociationExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property SubjectContextId that represents the column subj_contxt_id.
        /// </summary>
        /// <value>
        /// The value of the property SubjectContextId that represents the column subj_contxt_id.
        /// </value>
        public ColumnExpression SubjectContextId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectContextId that represents the column obj_contxt_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectContextId that represents the column obj_contxt_id.
        /// </value>
        public ColumnExpression ObjectContextId 
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
        /// Initializes a new instance of the <see cref="ContextAssociationExpression"/> class.
        /// </summary>
        public ContextAssociationExpression()
            : base("ContextAssociation", typeof(IContextAssociation))
        {
        }

        #endregion
    }
}
