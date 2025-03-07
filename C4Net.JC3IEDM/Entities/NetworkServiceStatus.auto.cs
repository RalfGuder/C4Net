using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity NETWORK-SERVICE-STATUS that represents the table NETWRK_SERVICE_STAT.
	///
	/// A record of the perceived condition of a specific NETWORK-SERVICE as determined by the reporting organisation.
    /// </summary>
    [Serializable]
    [DefinitionName("NetworkServiceStatus", "C4Net.JC3IEDM.Definitions.NetworkServiceStatus.definition.xml")]
    public class NetworkServiceStatus : IEntity, INetworkServiceStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly NetworkServiceStatusExpression _ = new NetworkServiceStatusExpression();

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
		public decimal NetworkServiceIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column netwrk_service_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific NETWORK-SERVICE-STATUS for a specific NETWORK-SERVICE and to distinguish it from all other NETWORK-SERVICE-STATUSs for that NETWORK-SERVICE.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_service_stat_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ind_code
		///
		/// The specific value that denotes whether the specific NETWORK-SERVICE is active.
        /// </summary>
        /// <value>
        /// Value of the column ind_code
        /// </value>
		public NetworkServiceStatusIndicatorEnum? Indicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
		public decimal ReportingDataId { get; set; }
		
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
