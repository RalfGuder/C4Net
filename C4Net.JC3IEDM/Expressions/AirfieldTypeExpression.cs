using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity AirfieldType.
    /// </summary>
    public class AirfieldTypeExpression : BaseEntityExpression<AirfieldTypeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column airfield_type_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column airfield_type_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property UseCategory that represents the column use_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property UseCategory that represents the column use_cat_code.
        /// </value>
        public ColumnExpression UseCategory 
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
        /// Initializes a new instance of the <see cref="AirfieldTypeExpression"/> class.
        /// </summary>
        public AirfieldTypeExpression()
            : base("AirfieldType", typeof(IAirfieldType))
        {
        }

        #endregion
    }
}
