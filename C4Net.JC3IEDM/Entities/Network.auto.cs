using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity NETWORK that represents the table NETWRK.
	///
	/// A FACILITY that provides bearer services for communication and information services and is composed of one or more links and nodes.
    /// </summary>
    [Serializable]
    [DefinitionName("Network", "C4Net.JC3IEDM.Definitions.Network.definition.xml")]
    public class Network : Facility, INetwork
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly NetworkExpression _ = new NetworkExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public NetworkCategoryEnum NetworkCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the specific class of NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
		public NetworkSubcategoryEnum? Subcategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column arch_code
		///
		/// The specific value that represents the architecture of a specific NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column arch_code
        /// </value>
		public NetworkArchitectureEnum? Architecture { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column chnl_cnt
		///
		/// The integer value representing the number of channels that a specific NETWORK can provide.
        /// </summary>
        /// <value>
        /// Value of the column chnl_cnt
        /// </value>
		public int? ChannelCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_cap_rate
		///
		/// The numeric value that represents the maximum data rate that a specific NETWORK can process. The unit of measure is kilobits per second (KBS). The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column max_cap_rate
        /// </value>
		public double? MaximumCapacityRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mnm_cap_rate
		///
		/// The numeric value that represents the minimum data rate that a specific NETWORK is required to process. The unit of measure is kilobits per second (KBS). The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column mnm_cap_rate
        /// </value>
		public double? MinimumCapacityRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column means_code
		///
		/// The specific value that represents the physical linkage between the nodes of a specific NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column means_code
        /// </value>
		public NetworkMeansEnum? Means { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column set_no_cnt
		///
		/// The integer value representing the frequency hopping set number parameter for this specific NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column set_no_cnt
        /// </value>
		public int? SetNumberCount { get; set; }
		
        #endregion
    }
}
