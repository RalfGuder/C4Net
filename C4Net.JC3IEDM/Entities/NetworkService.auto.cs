using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity NETWORK-SERVICE that represents the table NETWRK_SERVICE.
	///
	/// An identification of the specific type of communications service provided by a specific NETWORK.
    /// </summary>
    [Serializable]
    [DefinitionName("NetworkService", "C4Net.JC3IEDM.Definitions.NetworkService.definition.xml")]
    public class NetworkService : IEntity, INetworkService
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly NetworkServiceExpression _ = new NetworkServiceExpression();

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
        /// Gets or sets the value of the column netwrk_service_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific NETWORK-SERVICE for a specific NETWORK and to distinguish it from all other NETWORK-SERVICEs for that NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_service_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents a general type of service that a specific NETWORK is intended to provide.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public NetworkServiceCategoryEnum NetworkServiceCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents a detailed type of service that a specific NETWORK is intended to provide.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
		public NetworkServiceSubcategoryEnum? Subcategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column crypto_ind_code
		///
		/// The specific value that represents whether a specific NETWORK-SERVICE is encrypted.
        /// </summary>
        /// <value>
        /// Value of the column crypto_ind_code
        /// </value>
		public NetworkServiceCryptographicIndicatorEnum? CryptographicIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column crypto_plan_short_title_txt
		///
		/// The character string assigned to represent a specific cryptographic plan.
        /// </summary>
        /// <value>
        /// Value of the column crypto_plan_short_title_txt
        /// </value>
		public string CryptographicPlanShortTitleText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column crypto_code_short_title_txt
		///
		/// The character string assigned to represent a specific cryptographic code.
        /// </summary>
        /// <value>
        /// Value of the column crypto_code_short_title_txt
        /// </value>
		public string CryptographicCodeShortTitleText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column iff_mode_code_txt
		///
		/// The character string assigned to represent a specific IFF mode code combination.
        /// </summary>
        /// <value>
        /// Value of the column iff_mode_code_txt
        /// </value>
		public string IffModeCodeText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column security_clsfc_id
		///
		/// The unique value, or set of characters, assigned to represent a specific SECURITY-CLASSIFICATION and to distinguish it from all other SECURITY-CLASSIFICATIONs.
        /// </summary>
        /// <value>
        /// Value of the column security_clsfc_id
        /// </value>
		public decimal SecurityClassificationId { get; set; }
		
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
