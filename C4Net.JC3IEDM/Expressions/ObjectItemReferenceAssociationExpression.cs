using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ObjectItemReferenceAssociation.
    /// </summary>
    public class ObjectItemReferenceAssociationExpression : BaseEntityExpression<ObjectItemReferenceAssociationExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property ObjectItemId that represents the column obj_item_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemId that represents the column obj_item_id.
        /// </value>
        public ColumnExpression ObjectItemId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ReferenceId that represents the column ref_id.
        /// </summary>
        /// <value>
        /// The value of the property ReferenceId that represents the column ref_id.
        /// </value>
        public ColumnExpression ReferenceId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column obj_item_ref_assoc_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column obj_item_ref_assoc_ix.
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
        /// Expression for the property SpecificPartText that represents the column specific_part_txt.
        /// </summary>
        /// <value>
        /// The value of the property SpecificPartText that represents the column specific_part_txt.
        /// </value>
        public ColumnExpression SpecificPartText 
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
        /// Initializes a new instance of the <see cref="ObjectItemReferenceAssociationExpression"/> class.
        /// </summary>
        public ObjectItemReferenceAssociationExpression()
            : base("ObjectItemReferenceAssociation", typeof(IObjectItemReferenceAssociation))
        {
        }

        #endregion
    }
}
