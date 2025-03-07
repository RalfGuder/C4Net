using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity SecurityClassification.
    /// </summary>
    public class SecurityClassificationExpression : BaseEntityExpression<SecurityClassificationExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column security_clsfc_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column security_clsfc_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Level that represents the column lvl_code.
        /// </summary>
        /// <value>
        /// The value of the property Level that represents the column lvl_code.
        /// </value>
        public ColumnExpression Level 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property PolicyText that represents the column policy_txt.
        /// </summary>
        /// <value>
        /// The value of the property PolicyText that represents the column policy_txt.
        /// </value>
        public ColumnExpression PolicyText 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property CaveatText that represents the column caveat_txt.
        /// </summary>
        /// <value>
        /// The value of the property CaveatText that represents the column caveat_txt.
        /// </value>
        public ColumnExpression CaveatText 
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
        /// Initializes a new instance of the <see cref="SecurityClassificationExpression"/> class.
        /// </summary>
        public SecurityClassificationExpression()
            : base("SecurityClassification", typeof(ISecurityClassification))
        {
        }

        #endregion
    }
}
