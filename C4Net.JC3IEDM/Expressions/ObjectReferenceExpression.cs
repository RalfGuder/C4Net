using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ObjectReference.
    /// </summary>
    public class ObjectReferenceExpression : BaseEntityExpression<ObjectReferenceExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property RelativeCoordinateSystemId that represents the column rel_coord_sys_id.
        /// </summary>
        /// <value>
        /// The value of the property RelativeCoordinateSystemId that represents the column rel_coord_sys_id.
        /// </value>
        public ColumnExpression RelativeCoordinateSystemId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectItemId that represents the column obj_ref_obj_item_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemId that represents the column obj_ref_obj_item_id.
        /// </value>
        public ColumnExpression ObjectItemId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property LocationId that represents the column obj_ref_loc_id.
        /// </summary>
        /// <value>
        /// The value of the property LocationId that represents the column obj_ref_loc_id.
        /// </value>
        public ColumnExpression LocationId 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectItemLocationIndex that represents the column obj_ref_obj_item_loc_ix.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemLocationIndex that represents the column obj_ref_obj_item_loc_ix.
        /// </value>
        public ColumnExpression ObjectItemLocationIndex 
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
        /// Initializes a new instance of the <see cref="ObjectReferenceExpression"/> class.
        /// </summary>
        public ObjectReferenceExpression()
            : base("ObjectReference", typeof(IObjectReference))
        {
        }

        #endregion
    }
}
