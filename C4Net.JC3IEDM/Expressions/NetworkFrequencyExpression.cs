using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity NetworkFrequency.
    /// </summary>
    public class NetworkFrequencyExpression : BaseEntityExpression<NetworkFrequencyExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property NetworkId that represents the column netwrk_id.
        /// </summary>
        /// <value>
        /// The value of the property NetworkId that represents the column netwrk_id.
        /// </value>
        public ColumnExpression NetworkId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column netwrk_freq_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column netwrk_freq_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Band that represents the column band_code.
        /// </summary>
        /// <value>
        /// The value of the property Band that represents the column band_code.
        /// </value>
        public ColumnExpression Band 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property ChannelNumberText that represents the column chnl_no_txt.
        /// </summary>
        /// <value>
        /// The value of the property ChannelNumberText that represents the column chnl_no_txt.
        /// </value>
        public ColumnExpression ChannelNumberText 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property DiscreteFrequencyQuantity that represents the column discrete_freq_qty.
        /// </summary>
        /// <value>
        /// The value of the property DiscreteFrequencyQuantity that represents the column discrete_freq_qty.
        /// </value>
        public ColumnExpression DiscreteFrequencyQuantity 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property BandLowerFrequencyQuantity that represents the column band_lower_freq_qty.
        /// </summary>
        /// <value>
        /// The value of the property BandLowerFrequencyQuantity that represents the column band_lower_freq_qty.
        /// </value>
        public ColumnExpression BandLowerFrequencyQuantity 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property BandUpperFrequencyQuantity that represents the column band_upper_freq_qty.
        /// </summary>
        /// <value>
        /// The value of the property BandUpperFrequencyQuantity that represents the column band_upper_freq_qty.
        /// </value>
        public ColumnExpression BandUpperFrequencyQuantity 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property EffectiveStartDatetime that represents the column effctv_start_dttm.
        /// </summary>
        /// <value>
        /// The value of the property EffectiveStartDatetime that represents the column effctv_start_dttm.
        /// </value>
        public ColumnExpression EffectiveStartDatetime 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property EffectiveEndDatetime that represents the column effctv_end_dttm.
        /// </summary>
        /// <value>
        /// The value of the property EffectiveEndDatetime that represents the column effctv_end_dttm.
        /// </value>
        public ColumnExpression EffectiveEndDatetime 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property Modulation that represents the column mdltn_code.
        /// </summary>
        /// <value>
        /// The value of the property Modulation that represents the column mdltn_code.
        /// </value>
        public ColumnExpression Modulation 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property PurposeText that represents the column purpose_txt.
        /// </summary>
        /// <value>
        /// The value of the property PurposeText that represents the column purpose_txt.
        /// </value>
        public ColumnExpression PurposeText 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[11]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[12]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkFrequencyExpression"/> class.
        /// </summary>
        public NetworkFrequencyExpression()
            : base("NetworkFrequency", typeof(INetworkFrequency))
        {
        }

        #endregion
    }
}
