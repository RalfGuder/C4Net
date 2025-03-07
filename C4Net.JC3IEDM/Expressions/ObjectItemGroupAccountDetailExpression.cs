using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ObjectItemGroupAccountDetail.
    /// </summary>
    public class ObjectItemGroupAccountDetailExpression : BaseEntityExpression<ObjectItemGroupAccountDetailExpression>
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
        /// Expression for the property ObjectItemGroupAccountIndex that represents the column obj_item_group_acct_ix.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemGroupAccountIndex that represents the column obj_item_group_acct_ix.
        /// </value>
        public ColumnExpression ObjectItemGroupAccountIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column obj_item_group_acct_det_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column obj_item_group_acct_det_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Count that represents the column cnt.
        /// </summary>
        /// <value>
        /// The value of the property Count that represents the column cnt.
        /// </value>
        public ColumnExpression Count 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Qualifier that represents the column qual_code.
        /// </summary>
        /// <value>
        /// The value of the property Qualifier that represents the column qual_code.
        /// </value>
        public ColumnExpression Qualifier 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property GroupCharacteristicId that represents the column group_chrct_id.
        /// </summary>
        /// <value>
        /// The value of the property GroupCharacteristicId that represents the column group_chrct_id.
        /// </value>
        public ColumnExpression GroupCharacteristicId 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property PersonTypeId that represents the column pers_type_id.
        /// </summary>
        /// <value>
        /// The value of the property PersonTypeId that represents the column pers_type_id.
        /// </value>
        public ColumnExpression PersonTypeId 
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
        /// Initializes a new instance of the <see cref="ObjectItemGroupAccountDetailExpression"/> class.
        /// </summary>
        public ObjectItemGroupAccountDetailExpression()
            : base("ObjectItemGroupAccountDetail", typeof(IObjectItemGroupAccountDetail))
        {
        }

        #endregion
    }
}
