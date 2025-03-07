using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ObjectItemObjectTypeEstablishment.
    /// </summary>
    public class ObjectItemObjectTypeEstablishmentExpression : BaseEntityExpression<ObjectItemObjectTypeEstablishmentExpression>
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
        /// Expression for the property EstablishedObjectTypeId that represents the column estabd_obj_type_id.
        /// </summary>
        /// <value>
        /// The value of the property EstablishedObjectTypeId that represents the column estabd_obj_type_id.
        /// </value>
        public ColumnExpression EstablishedObjectTypeId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectTypeEstablishmentIndex that represents the column obj_type_estab_ix.
        /// </summary>
        /// <value>
        /// The value of the property ObjectTypeEstablishmentIndex that represents the column obj_type_estab_ix.
        /// </value>
        public ColumnExpression ObjectTypeEstablishmentIndex 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column obj_item_obj_type_estab_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column obj_item_obj_type_estab_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property EffectiveDatetime that represents the column effctv_dttm.
        /// </summary>
        /// <value>
        /// The value of the property EffectiveDatetime that represents the column effctv_dttm.
        /// </value>
        public ColumnExpression EffectiveDatetime 
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
        /// Initializes a new instance of the <see cref="ObjectItemObjectTypeEstablishmentExpression"/> class.
        /// </summary>
        public ObjectItemObjectTypeEstablishmentExpression()
            : base("ObjectItemObjectTypeEstablishment", typeof(IObjectItemObjectTypeEstablishment))
        {
        }

        #endregion
    }
}
