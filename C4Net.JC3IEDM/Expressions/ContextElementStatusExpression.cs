using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ContextElementStatus.
    /// </summary>
    public class ContextElementStatusExpression : BaseEntityExpression<ContextElementStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property ContextId that represents the column contxt_id.
        /// </summary>
        /// <value>
        /// The value of the property ContextId that represents the column contxt_id.
        /// </value>
        public ColumnExpression ContextId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ContextElementIndex that represents the column contxt_elmt_ix.
        /// </summary>
        /// <value>
        /// The value of the property ContextElementIndex that represents the column contxt_elmt_ix.
        /// </value>
        public ColumnExpression ContextElementIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column contxt_elmt_stat_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column contxt_elmt_stat_ix.
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
        /// Expression for the property EstablishingOrganisationId that represents the column estblng_org_id.
        /// </summary>
        /// <value>
        /// The value of the property EstablishingOrganisationId that represents the column estblng_org_id.
        /// </value>
        public ColumnExpression EstablishingOrganisationId 
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
        /// Initializes a new instance of the <see cref="ContextElementStatusExpression"/> class.
        /// </summary>
        public ContextElementStatusExpression()
            : base("ContextElementStatus", typeof(IContextElementStatus))
        {
        }

        #endregion
    }
}
