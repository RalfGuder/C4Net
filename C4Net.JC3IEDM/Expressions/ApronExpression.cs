using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Apron.
    /// </summary>
    public class ApronExpression : BaseEntityExpression<ApronExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column apron_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column apron_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property WeightBearingCapacityQuantity that represents the column wt_brng_cap_qty.
        /// </summary>
        /// <value>
        /// The value of the property WeightBearingCapacityQuantity that represents the column wt_brng_cap_qty.
        /// </value>
        public ColumnExpression WeightBearingCapacityQuantity 
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
        /// Initializes a new instance of the <see cref="ApronExpression"/> class.
        /// </summary>
        public ApronExpression()
            : base("Apron", typeof(IApron))
        {
        }

        #endregion
    }
}
