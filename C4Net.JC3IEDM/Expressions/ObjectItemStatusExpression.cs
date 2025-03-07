using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ObjectItemStatus.
    /// </summary>
    public class ObjectItemStatusExpression : BaseEntityExpression<ObjectItemStatusExpression>
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
        /// Expression for the property Index that represents the column obj_item_stat_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column obj_item_stat_ix.
        /// </value>
        public ColumnExpression Index 
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
        /// Expression for the property BoobyTrapPresence that represents the column booby_trap_prsnc_code.
        /// </summary>
        /// <value>
        /// The value of the property BoobyTrapPresence that represents the column booby_trap_prsnc_code.
        /// </value>
        public ColumnExpression BoobyTrapPresence 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property EmissionControl that represents the column emsn_ctrl_code.
        /// </summary>
        /// <value>
        /// The value of the property EmissionControl that represents the column emsn_ctrl_code.
        /// </value>
        public ColumnExpression EmissionControl 
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
        /// Initializes a new instance of the <see cref="ObjectItemStatusExpression"/> class.
        /// </summary>
        public ObjectItemStatusExpression()
            : base("ObjectItemStatus", typeof(IObjectItemStatus))
        {
        }

        #endregion
    }
}
