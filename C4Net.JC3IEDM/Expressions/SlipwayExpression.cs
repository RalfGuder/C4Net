using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Slipway.
    /// </summary>
    public class SlipwayExpression : BaseEntityExpression<SlipwayExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column slpway_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column slpway_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property GradientAngle that represents the column gradient_angle.
        /// </summary>
        /// <value>
        /// The value of the property GradientAngle that represents the column gradient_angle.
        /// </value>
        public ColumnExpression GradientAngle 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property LocationText that represents the column loc_txt.
        /// </summary>
        /// <value>
        /// The value of the property LocationText that represents the column loc_txt.
        /// </value>
        public ColumnExpression LocationText 
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
        /// Initializes a new instance of the <see cref="SlipwayExpression"/> class.
        /// </summary>
        public SlipwayExpression()
            : base("Slipway", typeof(ISlipway))
        {
        }

        #endregion
    }
}
