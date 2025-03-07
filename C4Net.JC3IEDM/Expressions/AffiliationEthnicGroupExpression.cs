using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity AffiliationEthnicGroup.
    /// </summary>
    public class AffiliationEthnicGroupExpression : BaseEntityExpression<AffiliationEthnicGroupExpression>
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
        /// Expression for the property AffiliationEthnicGroupCode that represents the column code.
        /// </summary>
        /// <value>
        /// The value of the property AffiliationEthnicGroupCode that represents the column code.
        /// </value>
        public ColumnExpression AffiliationEthnicGroupCode 
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
        /// Initializes a new instance of the <see cref="AffiliationEthnicGroupExpression"/> class.
        /// </summary>
        public AffiliationEthnicGroupExpression()
            : base("AffiliationEthnicGroup", typeof(IAffiliationEthnicGroup))
        {
        }

        #endregion
    }
}
