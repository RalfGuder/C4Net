using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ComponentHeaderContent.
    /// </summary>
    public class ComponentHeaderContentExpression : BaseEntityExpression<ComponentHeaderContentExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column cmpnt_hdr_cntnt_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column cmpnt_hdr_cntnt_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property TopicHeadingText that represents the column topic_heading_txt.
        /// </summary>
        /// <value>
        /// The value of the property TopicHeadingText that represents the column topic_heading_txt.
        /// </value>
        public ColumnExpression TopicHeadingText 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property SecurityClassificationId that represents the column security_clsfc_id.
        /// </summary>
        /// <value>
        /// The value of the property SecurityClassificationId that represents the column security_clsfc_id.
        /// </value>
        public ColumnExpression SecurityClassificationId 
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
        /// Initializes a new instance of the <see cref="ComponentHeaderContentExpression"/> class.
        /// </summary>
        public ComponentHeaderContentExpression()
            : base("ComponentHeaderContent", typeof(IComponentHeaderContent))
        {
        }

        #endregion
    }
}
