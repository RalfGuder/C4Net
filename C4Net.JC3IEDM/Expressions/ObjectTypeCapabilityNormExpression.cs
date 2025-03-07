using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ObjectTypeCapabilityNorm.
    /// </summary>
    public class ObjectTypeCapabilityNormExpression : BaseEntityExpression<ObjectTypeCapabilityNormExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property ObjectTypeId that represents the column obj_type_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectTypeId that represents the column obj_type_id.
        /// </value>
        public ColumnExpression ObjectTypeId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property CapabilityId that represents the column capab_id.
        /// </summary>
        /// <value>
        /// The value of the property CapabilityId that represents the column capab_id.
        /// </value>
        public ColumnExpression CapabilityId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property MissionPrimacy that represents the column msn_primacy_code.
        /// </summary>
        /// <value>
        /// The value of the property MissionPrimacy that represents the column msn_primacy_code.
        /// </value>
        public ColumnExpression MissionPrimacy 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Quantity that represents the column qty.
        /// </summary>
        /// <value>
        /// The value of the property Quantity that represents the column qty.
        /// </value>
        public ColumnExpression Quantity 
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
        /// Initializes a new instance of the <see cref="ObjectTypeCapabilityNormExpression"/> class.
        /// </summary>
        public ObjectTypeCapabilityNormExpression()
            : base("ObjectTypeCapabilityNorm", typeof(IObjectTypeCapabilityNorm))
        {
        }

        #endregion
    }
}
