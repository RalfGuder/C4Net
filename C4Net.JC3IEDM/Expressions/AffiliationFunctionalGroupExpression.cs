using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity AffiliationFunctionalGroup.
    /// </summary>
    public class AffiliationFunctionalGroupExpression : BaseEntityExpression<AffiliationFunctionalGroupExpression>
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
        /// Expression for the property AffiliationFunctionalGroupCode that represents the column code.
        /// </summary>
        /// <value>
        /// The value of the property AffiliationFunctionalGroupCode that represents the column code.
        /// </value>
        public ColumnExpression AffiliationFunctionalGroupCode 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property NameText that represents the column name_txt.
        /// </summary>
        /// <value>
        /// The value of the property NameText that represents the column name_txt.
        /// </value>
        public ColumnExpression NameText 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[4]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliationFunctionalGroupExpression"/> class.
        /// </summary>
        public AffiliationFunctionalGroupExpression()
            : base("AffiliationFunctionalGroup", typeof(IAffiliationFunctionalGroup))
        {
        }

        #endregion
    }
}
