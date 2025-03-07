using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ElectronicAddress.
    /// </summary>
    public class ElectronicAddressExpression : BaseEntityExpression<ElectronicAddressExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property AddressId that represents the column addr_id.
        /// </summary>
        /// <value>
        /// The value of the property AddressId that represents the column addr_id.
        /// </value>
        public ColumnExpression AddressId 
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
        /// Expression for the property NetworkId that represents the column netwrk_id.
        /// </summary>
        /// <value>
        /// The value of the property NetworkId that represents the column netwrk_id.
        /// </value>
        public ColumnExpression NetworkId 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property NetworkServiceIndex that represents the column netwrk_service_ix.
        /// </summary>
        /// <value>
        /// The value of the property NetworkServiceIndex that represents the column netwrk_service_ix.
        /// </value>
        public ColumnExpression NetworkServiceIndex 
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
        /// Initializes a new instance of the <see cref="ElectronicAddressExpression"/> class.
        /// </summary>
        public ElectronicAddressExpression()
            : base("ElectronicAddress", typeof(IElectronicAddress))
        {
        }

        #endregion
    }
}
