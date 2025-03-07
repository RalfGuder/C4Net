using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Address.
    /// </summary>
    public class AddressExpression : BaseEntityExpression<AddressExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column addr_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column addr_id.
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
        /// Expression for the property PlaceNameText that represents the column place_name_txt.
        /// </summary>
        /// <value>
        /// The value of the property PlaceNameText that represents the column place_name_txt.
        /// </value>
        public ColumnExpression PlaceNameText 
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
        /// Initializes a new instance of the <see cref="AddressExpression"/> class.
        /// </summary>
        public AddressExpression()
            : base("Address", typeof(IAddress))
        {
        }

        #endregion
    }
}
