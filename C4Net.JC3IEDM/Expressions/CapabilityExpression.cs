using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Capability.
    /// </summary>
    public class CapabilityExpression : BaseEntityExpression<CapabilityExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column capab_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column capab_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property DayNight that represents the column day_night_code.
        /// </summary>
        /// <value>
        /// The value of the property DayNight that represents the column day_night_code.
        /// </value>
        public ColumnExpression DayNight 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property UnitOfMeasure that represents the column uom_code.
        /// </summary>
        /// <value>
        /// The value of the property UnitOfMeasure that represents the column uom_code.
        /// </value>
        public ColumnExpression UnitOfMeasure 
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
        /// Initializes a new instance of the <see cref="CapabilityExpression"/> class.
        /// </summary>
        public CapabilityExpression()
            : base("Capability", typeof(ICapability))
        {
        }

        #endregion
    }
}
