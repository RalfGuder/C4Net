using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity NETWORK-FREQUENCY that represents the table NETWRK_FREQ.
	///
	/// The specification of a discrete frequency that is used on a specific NETWORK.
    /// </summary>
    [Serializable]
    [DefinitionName("NetworkFrequency", "C4Net.JC3IEDM.Definitions.NetworkFrequency.definition.xml")]
    public class NetworkFrequency : IEntity, INetworkFrequency
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly NetworkFrequencyExpression _ = new NetworkFrequencyExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column netwrk_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_id
        /// </value>
		public decimal NetworkId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column netwrk_freq_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific NETWORK-FREQUENCY for a specific NETWORK and to distinguish it from all other NETWORK-FREQUENCYs for that NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_freq_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column band_code
		///
		/// The specific value that represents the frequency band of a specific NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column band_code
        /// </value>
		public NetworkFrequencyBandEnum? Band { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column chnl_no_txt
		///
		/// The character string assigned to represent the channel number associated with a specific NETWORK-FREQUENCY.
        /// </summary>
        /// <value>
        /// Value of the column chnl_no_txt
        /// </value>
		public string ChannelNumberText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column discrete_freq_qty
		///
		/// The numeric value that represents the radio frequency that a specific NETWORK may use. The unit of measure is kilohertz.
        /// </summary>
        /// <value>
        /// Value of the column discrete_freq_qty
        /// </value>
		public int? DiscreteFrequencyQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column band_lower_freq_qty
		///
		/// The numeric value that represents the lowest radio frequency of a specific contiguous band that a NETWORK may use. The unit of measure is kilohertz.
        /// </summary>
        /// <value>
        /// Value of the column band_lower_freq_qty
        /// </value>
		public int? BandLowerFrequencyQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column band_upper_freq_qty
		///
		/// The numeric value that represents the highest radio frequency of a specific contiguous band that a NETWORK may use. The unit of measure is kilohertz.
        /// </summary>
        /// <value>
        /// Value of the column band_upper_freq_qty
        /// </value>
		public int? BandUpperFrequencyQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_start_dttm
		///
		/// The character string representing a point in time that designates the effective assignment of a specific OBJECT-TYPE-ESTABLISHMENT to a specific OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column effctv_start_dttm
        /// </value>
		public string EffectiveStartDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_end_dttm
		///
		/// The character string representing a point in time that designates the end of the authorised period of effectiveness for a specific NETWORK-FREQUENCY.
        /// </summary>
        /// <value>
        /// Value of the column effctv_end_dttm
        /// </value>
		public string EffectiveEndDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mdltn_code
		///
		/// The specific value that represents the modulation of a specific NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column mdltn_code
        /// </value>
		public NetworkFrequencyModulationEnum? Modulation { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column purpose_txt
		///
		/// The character string assigned to represent the specific purpose of a NETWORK-FREQUENCY.
        /// </summary>
        /// <value>
        /// Value of the column purpose_txt
        /// </value>
		public string PurposeText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
		public decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
		public long UpdateSeqnr { get; set; }
		
        #endregion
    }
}
