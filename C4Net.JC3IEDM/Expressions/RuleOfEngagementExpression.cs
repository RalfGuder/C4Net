using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity RuleOfEngagement.
    /// </summary>
    public class RuleOfEngagementExpression : BaseEntityExpression<RuleOfEngagementExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column roe_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column roe_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property NameText that represents the column name_txt.
        /// </summary>
        /// <value>
        /// The value of the property NameText that represents the column name_txt.
        /// </value>
        public ColumnExpression NameText 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property DescriptionText that represents the column descr_txt.
        /// </summary>
        /// <value>
        /// The value of the property DescriptionText that represents the column descr_txt.
        /// </value>
        public ColumnExpression DescriptionText 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property OwningOrganisationId that represents the column owning_org_id.
        /// </summary>
        /// <value>
        /// The value of the property OwningOrganisationId that represents the column owning_org_id.
        /// </value>
        public ColumnExpression OwningOrganisationId 
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
        /// Initializes a new instance of the <see cref="RuleOfEngagementExpression"/> class.
        /// </summary>
        public RuleOfEngagementExpression()
            : base("RuleOfEngagement", typeof(IRuleOfEngagement))
        {
        }

        #endregion
    }
}
