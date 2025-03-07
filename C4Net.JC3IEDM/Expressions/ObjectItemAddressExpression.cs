using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ObjectItemAddress.
    /// </summary>
    public class ObjectItemAddressExpression : BaseEntityExpression<ObjectItemAddressExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property ObjectItemId that represents the column obj_item_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemId that represents the column obj_item_id.
        /// </value>
        public ColumnExpression ObjectItemId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property AddressId that represents the column addr_id.
        /// </summary>
        /// <value>
        /// The value of the property AddressId that represents the column addr_id.
        /// </value>
        public ColumnExpression AddressId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column obj_item_addr_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column obj_item_addr_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property CallSignText that represents the column call_sign_txt.
        /// </summary>
        /// <value>
        /// The value of the property CallSignText that represents the column call_sign_txt.
        /// </value>
        public ColumnExpression CallSignText 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Primacy that represents the column primacy_code.
        /// </summary>
        /// <value>
        /// The value of the property Primacy that represents the column primacy_code.
        /// </value>
        public ColumnExpression Primacy 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property AuthorisationIndicator that represents the column auth_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property AuthorisationIndicator that represents the column auth_ind_code.
        /// </value>
        public ColumnExpression AuthorisationIndicator 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property TransmitReceive that represents the column trns_rcv_code.
        /// </summary>
        /// <value>
        /// The value of the property TransmitReceive that represents the column trns_rcv_code.
        /// </value>
        public ColumnExpression TransmitReceive 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property NetworkId that represents the column netwrk_id.
        /// </summary>
        /// <value>
        /// The value of the property NetworkId that represents the column netwrk_id.
        /// </value>
        public ColumnExpression NetworkId 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property NetworkFrequencyIndex that represents the column netwrk_freq_ix.
        /// </summary>
        /// <value>
        /// The value of the property NetworkFrequencyIndex that represents the column netwrk_freq_ix.
        /// </value>
        public ColumnExpression NetworkFrequencyIndex 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property ReportingDataId that represents the column rptd_id.
        /// </summary>
        /// <value>
        /// The value of the property ReportingDataId that represents the column rptd_id.
        /// </value>
        public ColumnExpression ReportingDataId 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[11]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectItemAddressExpression"/> class.
        /// </summary>
        public ObjectItemAddressExpression()
            : base("ObjectItemAddress", typeof(IObjectItemAddress))
        {
        }

        #endregion
    }
}
