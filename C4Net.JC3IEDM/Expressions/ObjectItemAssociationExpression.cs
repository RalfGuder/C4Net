using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ObjectItemAssociation.
    /// </summary>
    public class ObjectItemAssociationExpression : BaseEntityExpression<ObjectItemAssociationExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property SubjectObjectItemId that represents the column subj_obj_item_id.
        /// </summary>
        /// <value>
        /// The value of the property SubjectObjectItemId that represents the column subj_obj_item_id.
        /// </value>
        public ColumnExpression SubjectObjectItemId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectObjectItemId that represents the column obj_obj_item_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectObjectItemId that represents the column obj_obj_item_id.
        /// </value>
        public ColumnExpression ObjectObjectItemId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column obj_item_assoc_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column obj_item_assoc_ix.
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
        /// Expression for the property Subcategory that represents the column subcat_code.
        /// </summary>
        /// <value>
        /// The value of the property Subcategory that represents the column subcat_code.
        /// </value>
        public ColumnExpression Subcategory 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property ActionTaskId that represents the column act_task_id.
        /// </summary>
        /// <value>
        /// The value of the property ActionTaskId that represents the column act_task_id.
        /// </value>
        public ColumnExpression ActionTaskId 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[7]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectItemAssociationExpression"/> class.
        /// </summary>
        public ObjectItemAssociationExpression()
            : base("ObjectItemAssociation", typeof(IObjectItemAssociation))
        {
        }

        #endregion
    }
}
