using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ObjectItemCapability.
    /// </summary>
    public class ObjectItemCapabilityExpression : BaseEntityExpression<ObjectItemCapabilityExpression>
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
        /// Expression for the property Index that represents the column obj_item_capab_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column obj_item_capab_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property MissionPrimacy that represents the column msn_primacy_code.
        /// </summary>
        /// <value>
        /// The value of the property MissionPrimacy that represents the column msn_primacy_code.
        /// </value>
        public ColumnExpression MissionPrimacy 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Quantity that represents the column qty.
        /// </summary>
        /// <value>
        /// The value of the property Quantity that represents the column qty.
        /// </value>
        public ColumnExpression Quantity 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property ReportingDataId that represents the column rptd_id.
        /// </summary>
        /// <value>
        /// The value of the property ReportingDataId that represents the column rptd_id.
        /// </value>
        public ColumnExpression ReportingDataId 
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
        /// Initializes a new instance of the <see cref="ObjectItemCapabilityExpression"/> class.
        /// </summary>
        public ObjectItemCapabilityExpression()
            : base("ObjectItemCapability", typeof(IObjectItemCapability))
        {
        }

        #endregion
    }
}
