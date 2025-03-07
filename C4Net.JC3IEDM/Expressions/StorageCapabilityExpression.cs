using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity StorageCapability.
    /// </summary>
    public class StorageCapabilityExpression : BaseEntityExpression<StorageCapabilityExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column storage_capab_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column storage_capab_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property CargoCategory that represents the column cargo_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property CargoCategory that represents the column cargo_cat_code.
        /// </value>
        public ColumnExpression CargoCategory 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Descriptor that represents the column dscpt_code.
        /// </summary>
        /// <value>
        /// The value of the property Descriptor that represents the column dscpt_code.
        /// </value>
        public ColumnExpression Descriptor 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Condition that represents the column cond_code.
        /// </summary>
        /// <value>
        /// The value of the property Condition that represents the column cond_code.
        /// </value>
        public ColumnExpression Condition 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectTypeId that represents the column obj_type_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectTypeId that represents the column obj_type_id.
        /// </value>
        public ColumnExpression ObjectTypeId 
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
        /// Initializes a new instance of the <see cref="StorageCapabilityExpression"/> class.
        /// </summary>
        public StorageCapabilityExpression()
            : base("StorageCapability", typeof(IStorageCapability))
        {
        }

        #endregion
    }
}
