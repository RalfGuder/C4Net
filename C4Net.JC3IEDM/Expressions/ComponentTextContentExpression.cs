using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ComponentTextContent.
    /// </summary>
    public class ComponentTextContentExpression : BaseEntityExpression<ComponentTextContentExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column cmpnt_txt_cntnt_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column cmpnt_txt_cntnt_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Text that represents the column txt.
        /// </summary>
        /// <value>
        /// The value of the property Text that represents the column txt.
        /// </value>
        public ColumnExpression Text 
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
        /// Initializes a new instance of the <see cref="ComponentTextContentExpression"/> class.
        /// </summary>
        public ComponentTextContentExpression()
            : base("ComponentTextContent", typeof(IComponentTextContent))
        {
        }

        #endregion
    }
}
