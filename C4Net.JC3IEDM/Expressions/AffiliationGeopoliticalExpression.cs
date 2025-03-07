using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity AffiliationGeopolitical.
    /// </summary>
    public class AffiliationGeopoliticalExpression : BaseEntityExpression<AffiliationGeopoliticalExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property AffiliationId that represents the column affl_id.
        /// </summary>
        /// <value>
        /// The value of the property AffiliationId that represents the column affl_id.
        /// </value>
        public ColumnExpression AffiliationId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property AffiliationGeopoliticalCode that represents the column code.
        /// </summary>
        /// <value>
        /// The value of the property AffiliationGeopoliticalCode that represents the column code.
        /// </value>
        public ColumnExpression AffiliationGeopoliticalCode 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[3]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliationGeopoliticalExpression"/> class.
        /// </summary>
        public AffiliationGeopoliticalExpression()
            : base("AffiliationGeopolitical", typeof(IAffiliationGeopolitical))
        {
        }

        #endregion
    }
}
