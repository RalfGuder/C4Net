using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity HandlingCapability.
    /// </summary>
    public class HandlingCapabilityExpression : BaseEntityExpression<HandlingCapabilityExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column hndl_capab_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column hndl_capab_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property CargoCategory that represents the column cargo_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property CargoCategory that represents the column cargo_cat_code.
        /// </value>
        public ColumnExpression CargoCategory 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Descriptor that represents the column dscpt_code.
        /// </summary>
        /// <value>
        /// The value of the property Descriptor that represents the column dscpt_code.
        /// </value>
        public ColumnExpression Descriptor 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Action that represents the column act_code.
        /// </summary>
        /// <value>
        /// The value of the property Action that represents the column act_code.
        /// </value>
        public ColumnExpression Action 
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
        /// Initializes a new instance of the <see cref="HandlingCapabilityExpression"/> class.
        /// </summary>
        public HandlingCapabilityExpression()
            : base("HandlingCapability", typeof(IHandlingCapability))
        {
        }

        #endregion
    }
}
